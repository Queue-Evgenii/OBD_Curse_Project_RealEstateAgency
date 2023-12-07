using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;

namespace RealEstateAgency
{
    public partial class EditForm : Form
    {
        RealEstateAgencyContext conn = null;
        RealEstateObject obj = null;
        public EditForm(RealEstateAgencyContext _conn, RealEstateObject _obj)
        {
            obj = _obj;
            conn = _conn;

            if (obj == null && conn == null)
            {
                Close();
            }

            if (obj.Apartament == null && obj.House == null)
            {
                conn.Entry(obj).Reference(t =>   t.Apartament).Load();
                conn.Entry(obj).Reference(t =>   t.House).Load();
            }

            InitializeComponent();

            fillInputs();

            if (obj.Apartament != null)
            {
                setApartSubForm();
                typeLabel.Text = "Квартира";
            }
            if (obj.House != null) 
            {
                setHouseSubForm();
                typeLabel.Text = "Приватний будинок";
            }
        }

        private void fillInputs()
        {
            footageInput.Text = obj.Footage != null ? obj.Footage.ToString() : "";
            roomsAmountInput.Text = obj.RoomsAmount.ToString();
            floorsAmountInput.Text = obj.ObjectFloorsAmount != null ? obj.ObjectFloorsAmount.ToString() : "";
            descriptionInput.Text = obj.ObjectDescription;
            priceInput.Text = obj.Price.ToString();
        }

        private void setApartSubForm()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label floorLabel = new Label();
            TextBox floorsInput = new TextBox();
            Label apartServiceLabel = new Label();
            TextBox apartServiceInput = new TextBox();

            panel.AutoSize = true;

            floorLabel.Text = "Поверх";
            apartServiceLabel.Text = "Сервіс";
            floorLabel.Width = apartServiceLabel.Width = 70;
            floorLabel.Height = apartServiceLabel.Height = 40;

            floorLabel.Padding = new Padding(0, 8, 0, 0);
            apartServiceLabel.Padding = new Padding(8, 8, 0, 0);

            floorLabel.Font = floorsInput.Font = apartServiceInput.Font = apartServiceLabel.Font = new Font("Arial", 12);
            floorsInput.Width = floorsAmountInput.Width;
            floorsInput.Height = floorsAmountInput.Height;

            apartServiceInput.Multiline = true;
            apartServiceInput.Height = descriptionInput.Height;
            apartServiceInput.Width = descriptionInput.Width;
            apartServiceInput.MaxLength = 100;

            floorsInput.Text = obj.Apartament.ApartFloor != null ? obj.Apartament.ApartFloor.ToString() : "";
            apartServiceInput.Text = obj.Apartament.ApartService;


            floorsInput.TextChanged += (object sender, EventArgs e) =>
            {
                if (floorsInput.Text.Length == 0) return;
                try
                {
                    int apartFloor = int.Parse(floorsInput.Text);
                    if (apartFloor <= 0) throw new Exception();
                    obj.Apartament.ApartFloor = apartFloor;
                }
                catch
                {
                    floorsInput.Text = obj.Apartament.ApartFloor.ToString();
                    MessageBox.Show("Неправильні дані у полі поверх!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            };
            apartServiceInput.TextChanged += (object sender, EventArgs e) =>
            {
                obj.Apartament.ApartService = apartServiceInput.Text;
            };

            panel.Controls.AddRange(new Control[] { floorLabel, floorsInput, apartServiceLabel, apartServiceInput });

            additionalPanel.Controls.Add(panel);
        }
        private void setHouseSubForm()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();

            FlowLayoutPanel panel1 = new FlowLayoutPanel();
            FlowLayoutPanel panel2 = new FlowLayoutPanel();
            FlowLayoutPanel panel3 = new FlowLayoutPanel();

            Label yardFootageLabel = new Label();
            TextBox yardFootageInput = new TextBox();
            Label garageLabel = new Label();
            TextBox garageInput = new TextBox();
            Label loftLabel = new Label();
            TextBox loftInput = new TextBox();

            panel.AutoSize = panel1.AutoSize = panel2.AutoSize = panel3.AutoSize = true;

            yardFootageLabel.Text = "Квадратура двору";
            garageLabel.Text = "Гараж (наявність, опис)";
            loftLabel.Text = "Лофт (наявність опис)";
            yardFootageLabel.Width = garageLabel.Width = loftLabel.Width = 200;
            yardFootageLabel.Height = garageLabel.Height = loftLabel.Height = 40;

            yardFootageLabel.Font = garageLabel.Font = loftLabel.Font = new Font("Arial", 12);
            yardFootageInput.Font = garageInput.Font = loftInput.Font = new Font("Arial", 12);

            yardFootageInput.Width = floorsAmountInput.Width;
            yardFootageInput.Height = floorsAmountInput.Height;

            garageInput.Multiline = loftInput.Multiline = true;
            garageInput.Height = loftInput.Height = descriptionInput.Height;
            garageInput.Width = loftInput.Width = descriptionInput.Width;
            garageInput.MaxLength = loftInput.MaxLength = 100;

            yardFootageInput.Text = obj.House.YardFootage != null ? obj.House.YardFootage.ToString() : "";
            garageInput.Text = obj.House.GarageDescription;
            loftInput.Text = obj.House.HouseLoft;


            yardFootageInput.TextChanged += (object sender, EventArgs e) =>
            {
                if (yardFootageInput.Text.Length == 0) return;
                try
                {
                    int yardFootage = int.Parse(yardFootageInput.Text);
                    if (yardFootage <= 0) throw new Exception();
                    obj.House.YardFootage = yardFootage;
                }
                catch
                {
                    yardFootageInput.Text = obj.House.YardFootage.ToString();
                    MessageBox.Show("Неправильні дані у полі квадратура двору!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            };
            loftInput.TextChanged += (object sender, EventArgs e) =>
            {
                obj.House.HouseLoft = loftInput.Text;
            };
            garageInput.TextChanged += (object sender, EventArgs e) =>
            {
                obj.House.GarageDescription = garageInput.Text;
            };


            panel1.Controls.AddRange(new Control[] {
                yardFootageLabel,
                yardFootageInput,
            });
            panel2.Controls.AddRange(new Control[] {
                garageLabel,
                garageInput,
            });
            panel3.Controls.AddRange(new Control[] {
                loftLabel,
                loftInput,
            });
            panel.Controls.AddRange(new Control[] {
                panel1,
                panel2,
                panel3,
            });

            additionalPanel.Controls.Add(panel);
        }


        private bool validate()
        {
            if (priceInput.Text.Length == 0)
            {
                MessageBox.Show("Поле ціна обов'язкове!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        /* ============= Events =============== */
        private void footageInput_TextChanged(object sender, EventArgs e)
        {
            if (footageInput.Text.Length == 0) return;

            try
            {
                int footage = int.Parse(footageInput.Text);
                if (footage <= 0) throw new Exception();
                obj.Footage = footage;
            }
            catch
            {
                footageInput.Text = obj.Footage.ToString();
                MessageBox.Show("Неправильні дані у полі квадратура!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void roomsAmountInput_TextChanged(object sender, EventArgs e)
        {
            if (roomsAmountInput.Text.Length == 0) return;

            try
            {
                int roomsAmount = int.Parse(roomsAmountInput.Text);
                if (roomsAmount <= 0) throw new Exception();
                obj.RoomsAmount = roomsAmount;
            }
            catch
            {
                roomsAmountInput.Text = obj.RoomsAmount.ToString();
                MessageBox.Show("Неправильні дані у полі кількість кімнат!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void floorsAmountInput_TextChanged(object sender, EventArgs e)
        {
            if (floorsAmountInput.Text.Length == 0) return;
            try
            {
                int floorsAmount = int.Parse(floorsAmountInput.Text);
                if (floorsAmount <= 0) throw new Exception();
                obj.ObjectFloorsAmount = floorsAmount;
            }
            catch
            {
                floorsAmountInput.Text = obj.ObjectFloorsAmount.ToString();
                MessageBox.Show("Неправильні дані у полі кількість поверхів!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void descriptionInput_TextChanged(object sender, EventArgs e)
        {
            obj.ObjectDescription = descriptionInput.Text;
        }

        private void priceInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int price = int.Parse(priceInput.Text);
                if (price <= 0) throw new Exception();
                obj.Price = price;
            }
            catch
            {
                priceInput.Text = obj.Price.ToString();
                MessageBox.Show("Неправильні дані у полі ціна!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validate()) return;
                conn.SaveChanges();
                Close();
            } catch
            {
                MessageBox.Show("Не вдалось зберегти дані!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
