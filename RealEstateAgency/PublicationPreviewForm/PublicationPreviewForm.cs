using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;

namespace RealEstateAgency
{
    public partial class PublicationPreviewForm : Form
    {
        private RealEstateAgencyContext conn;
        private int userId;
        private RealEstateObject obj;
        public PublicationPreviewForm(RealEstateAgencyContext _conn, int _userId, int _objId)
        {
            conn = _conn;
            userId = _userId;
            obj = conn.RealEstateObject.Where(el => el.IdObject == _objId).SingleOrDefault();

            createForm();
        }
        public PublicationPreviewForm(RealEstateAgencyContext _conn, int _userId, RealEstateObject _obj)
        {
            conn = _conn;
            userId = _userId;
            obj = _obj;

            createForm();
        }
        private void createForm()
        {
            if (conn == null)
            {
                MessageBox.Show("Проблема з підключенням!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (obj == null)
            {
                MessageBox.Show("Об'єкту нерухомості не існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            InitializeComponent();

            timePicker.MaxDate = timePicker.MinDate.AddDays(14);
            if (obj.IdPerson == userId)
            {
                timePicker.Enabled = false;
            }

            setObjectData();
        }

        private void setObjectData()
        {
            flowLayoutPanel1.MaximumSize = new Size(flowLayoutPanel1.Width, default);

            List<string> photoLink = conn.Photo.Where(el => el.IdObject == obj.IdObject).Select(el => el.PhotoLink).ToList();

            for (int i = 0; i < photoLink.Count; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "publicationListImage";
                if (photoLink[i] != null)
                {
                    try
                    {
                        byte[] data = App.getImageBytesFromWeb(photoLink[i]);
                        using (MemoryStream stream = new MemoryStream(data))
                        {
                            pictureBox.Image = Image.FromStream(stream);
                        }
                    } catch
                    {
                        MessageBox.Show("Щось пішло не так :(", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox.Width = flowLayoutPanel1.Width - 5;
                pictureBox.Height = (int)(flowLayoutPanel1.Width / 1.5);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;

                flowLayoutPanel1.Controls.Add(pictureBox);

            }
            mainTitle.Text = $"{obj.HouseBuilding.StreetNameNavigation.NameDistrict} район, {obj.StreetName}, дім {obj.HouseNumber}, {obj.Price}$";
            districtTitle.Text = obj.HouseBuilding.StreetNameNavigation.NameDistrict;
            streetTitle.Text = obj.StreetName;
            houseNumTitle.Text = obj.HouseNumber.ToString();
            floorAmountTitle.Text = obj.ObjectFloorsAmount.ToString();
            footageTitle.Text = obj.Footage.ToString();
            roomsAmountTitle.Text = obj.RoomsAmount.ToString();
            descriptionTitle.Text = obj.ObjectDescription;
            if (descriptionTitle.Text.Length == 0)
            {
                descriptionPanel.Visible = false;
                descriptionPanel.Enabled = false;
            }

            conn.Entry(obj).Reference(t => t.Apartament).Load();
            conn.Entry(obj).Reference(t => t.House).Load();

            if (obj.Apartament != null)
            {
                apartPanel.Visible = true;
                apartPanel.Enabled = true;
                floorTitle.Text = obj.Apartament.ApartFloor.HasValue ? obj.Apartament.ApartFloor.ToString() : "не вказано";
                serviceTitle.Text = obj.Apartament.ApartService != null ? obj.Apartament.ApartService : "не вказано";
            }

            if (obj.House != null)
            {
                housePanel.Visible = true;
                housePanel.Enabled = true;
                yardFootageTitle.Text = obj.House.YardFootage.HasValue ? obj.House.YardFootage.ToString() : "не вказано";
                garageTitle.Text = obj.House.GarageDescription.Length != 0 ? obj.House.GarageDescription : "не вказано";
                loftTitle.Text = obj.House.HouseLoft.Length != 0 ? obj.House.HouseLoft : "не вказано";
            }

            Person person = conn.Person.Where(el => el.IdPerson == obj.IdPerson).FirstOrDefault();
            sellerEmail.Text = person.Email;
        }


        private void bookButton_Click(object sender, EventArgs e)
        {
            if (obj.IdPerson == userId)
            {
                MessageBox.Show("Покупець не може купити об'єкт який йому належить!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime date = timePicker.Value;
            if (date == null)
            {
                MessageBox.Show("Потрібно спочатку обрати час!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (conn.Show.Where(el => el.IdPerson == userId && el.ShowDate == date).Any())
            {
                MessageBox.Show("На один день можна записатися лише один раз!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Show show = new Show()
            {
                ShowDate = date,
                IdObject = obj.IdObject,
                IdPerson = userId,
                IdEmployee = null,
            };


            try
            {
                conn.Show.Add(show);
                conn.SaveChanges();
            } catch
            {
                MessageBox.Show("Щось пішло нe так!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(
                "Щойно агент прийме заявку, вам вамповідомлять за номером телефону або електронною поштою!",
                "Успіх!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
