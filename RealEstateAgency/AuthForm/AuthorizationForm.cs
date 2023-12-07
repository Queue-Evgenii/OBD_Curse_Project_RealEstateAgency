using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;

namespace RealEstateAgency
{
    public partial class AuthorizationForm : Form
    {
        public bool isAuthorized =  false;
        public int userId;
        private RealEstateAgencyContext conn;
        private bool isRegistration = true;
        public AuthorizationForm(RealEstateAgencyContext _conn)
        {
            conn = _conn;
            InitializeComponent();
            setLabels();
        }

        private void setLabels()
        {
            string temp = (isRegistration ? "Створити акаунт" : "Увійти в акаунт");
            Text = "RealEstateAgency " + temp;
            FormMainHeading.Text = temp;

            FormSubtitle.Text = (isRegistration ? "Вже є акаунт?" : "Немає акаунту?");
            changeTypeButton.Text = (isRegistration ? "Увійти" : "Створити");
        }

        private bool validateEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool validatePassword(string password)
        {
            return password.Length > 3 ? true : false;
        }
        private byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
        private byte[] HashPassword(string password, byte[] salt)
        {
            byte[] saltedPassword = Encoding.UTF8.GetBytes(password).Concat(salt).ToArray();
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(saltedPassword);
            }
        }
        private void setPassword(int id, string password)
        {
            byte[] salt = GenerateSalt();
            byte[] hash = HashPassword(password, salt);

            conn.Passwords.Add(new Passwords()
            {
                IdPerson = id,
                PasswordHash = hash,
                PasswordSalt = salt
            });

            try
            {
                conn.SaveChanges();
            } catch
            {
                MessageBox.Show("Щось пішло не так :(", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void registrateUser(string email, string password)
        {
            conn.Person.Add(new Person
            {
                Email = email,
            });

            try
            {
                conn.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Person user = conn.Person.SingleOrDefault(el => el.Email == email);
            if (user != null)
            {
                setPassword(user.IdPerson, password);
                userId = user.IdPerson;
                isAuthorized = true;
                Close();
                return;
            }

            MessageBox.Show("Щось пішло не так :(", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void registration(string email, string password)
        {
            if (!validateEmail(email) || !validatePassword(password))
            {
                MessageBox.Show("Щось пішло не так :(\nВведені дані неправильні!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            try
            {
                if (conn.Person.Any(el => el.Email == email))
                {
                    MessageBox.Show("Щось пішло не так :(\nКористувач з такою електронною адресою вже існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(\nНемає підключення!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            registrateUser(email, password);
        }

        private void authorization(string email, string password)
        {
            Person user = null;
            try
            {
               user = conn.Person.SingleOrDefault(el => el.Email == email);
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(\nНемає підключення!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user != null)
            {
                Passwords storedPasswordData = conn.Passwords.FirstOrDefault(p => p.IdPerson == user.IdPerson);

                if (storedPasswordData != null)
                {
                    byte[] storedSalt = storedPasswordData.PasswordSalt;
                    byte[] storedHash = storedPasswordData.PasswordHash;

                    byte[] saltedPassword = Encoding.UTF8.GetBytes(password).Concat(storedSalt).ToArray();
                    byte[] hashedPassword;
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        hashedPassword = sha256.ComputeHash(saltedPassword);
                    }

                    if (hashedPassword.SequenceEqual(storedHash))
                    {
                        userId = user.IdPerson;
                        isAuthorized = true;
                        Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Щось пішло не так :(\nНе правильний пароль!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            
            MessageBox.Show("Щось пішло не так :(\nВведені дані неправильні!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void changeTypeButton_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isRegistration = !isRegistration;
            setLabels();
        }

        private void submitButton_click(object sender, EventArgs e)
        {
            string email = emailInput.Text;
            string password = passwordInput.Text;

            if (isRegistration)
            {
                registration(email, password);
                return;
            }

            authorization(email, password);
        }
    }
}
