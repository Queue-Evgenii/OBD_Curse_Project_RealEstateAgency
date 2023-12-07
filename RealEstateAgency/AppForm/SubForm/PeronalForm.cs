using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;

namespace RealEstateAgency
{
    public partial class App
    {
        /* Inits methods personal */
        private void fillPersonalInputsVariable()
        {
            foreach (Control el in personalLayoutBox.Controls)
            {
                if (el is TextBox)
                {
                    inputsPersonal.Add((TextBox)el);
                }
            }
        }
        private void setPersonalInputsWidth(int w)
        {
            foreach (TextBox el in inputsPersonal)
            {
                el.Width = w;
            }

        }
        private void setDefaultPersonalLayoutWidth()
        {
            personalLayoutBox.Location = new Point(Size.Width / 2 - personalLayoutBox.Size.Width / 2, personalLayoutBox.Location.Y);
        }
        private void fillPersonalInputs()
        {
            Person person = getPerson();
            if (person == null) return;
            setDefaultPeronalInputValues(person);
        }


        /* Personal methods */
        private Person getPerson()
        {
            return conn.Person.SingleOrDefault(el => el.IdPerson == id);
        }
        private void setDefaultPeronalInputValues(Person person)
        {
            fnameInput.Text = person.Fname != null ? person.Fname : "";
            mnameInput.Text = person.Mname != null ? person.Mname : "";
            lnameInput.Text = person.Lname != null ? person.Lname : "";
            phoneInput.Text = person.Phone != null ? person.Phone : "";
            addressInput.Text = person.AddressPerson != null ? person.AddressPerson : "";
        }
        private void updatePerson(Person person)
        {
            try
            {
                person.IdPerson = id;
                person.Fname = fnameInput.Text.Length > 0 ? fnameInput.Text : null;
                person.Mname = mnameInput.Text.Length > 0 ? mnameInput.Text : null;
                person.Lname = lnameInput.Text.Length > 0 ? lnameInput.Text : null;
                person.Phone = phoneInput.Text.Length > 0 ? phoneInput.Text : null;
                person.AddressPerson = addressInput.Text.Length > 0 ? addressInput.Text : null;

                conn.SaveChanges();
                MessageBox.Show("Дані успішно оновлені!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Щось пішло не так :(\nВведені дані не вдалось зберегти!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void resizePersonal()
        {
            if (Size.Width < 400)
            {
                setPersonalInputsWidth(Size.Width - 50);

                if (personalLayoutBox.Location.X == 10) return;
                personalLayoutBox.Location = new Point(10, personalLayoutBox.Location.Y);
                return;
            };
            setPersonalInputsWidth(Size.Width / 2);
            setDefaultPersonalLayoutWidth();
        }
    }
}
