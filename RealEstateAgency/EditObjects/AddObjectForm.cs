using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;
using RealEstateAgency.EditObjectForm;

namespace RealEstateAgency
{
    public partial class AddObjectForm : Form
    {
        private RealEstateAgencyContext conn = null;
        private int? userId = null;

        RealEstateObject editedItem = null;

        private List<District> districts = null;
        private List<Street> streets = null;

        private string street = null;
        private int? houseNumber = null;

        private int? footage= null;
        private int roomsAmount;
        private int? floorsAmount = null;
        private string description;
        private int? price = null;

        private Apartament apartament = null;
        private House house = null;

        private HouseBuilding houseBuilding = null;

        private List<string> images;

        public AddObjectForm(RealEstateAgencyContext _conn, int _userId, int? _objectId)
        {

            conn = _conn;
            userId = _userId;

            Text = "RealEstateAgency Add Publication";

            InitializeComponent();

            Width = 700;
            Height = 500;
            MinimumSize = MaximumSize = new Size(700, 500);

            districts = conn.District.ToList();
            streets = conn.Street.ToList();

            districtDropdown.Items.AddRange(districts.Select(el => el.NameDistrict).ToArray());

            if (_objectId != null) fillInputs((int)_objectId);
        }


        private void fillInputs(int _objectId)
        {
            editedItem = conn.RealEstateObject.Where(el => el.IdObject == _objectId).SingleOrDefault();
            conn.Entry(editedItem).Reference(t => t.HouseBuilding).Load();
            conn.Entry(editedItem.HouseBuilding).Reference(t => t.StreetNameNavigation).Load();
        }
        private bool isStreetExists(string param)
        {
            return streets.Where(el => el.StreetName == param).Any();
        }

        private void addRealEstateObject()
        {

            RealEstateObject newItem = new RealEstateObject();

            newItem.IdPerson = (int)userId;

            
            if (conn.HouseBuilding.Where(el => el.HouseNumber == houseNumber && el.StreetName == street).Any())
            {
                newItem.StreetName = street;
                newItem.HouseNumber = (int)houseNumber;
            } else
            {
                if (!conn.Street.Where(el => el.StreetName == street).Any())
                { 
                    Street newStreet = new Street();
                    newStreet.StreetName = street;
                    newStreet.NameDistrict = districtDropdown.SelectedItem.ToString();

                    houseBuilding.StreetNameNavigation = newStreet;
                    houseBuilding.HouseNumber = (int)houseNumber;
                } else
                {
                    houseBuilding.StreetName = street;
                    houseBuilding.HouseNumber = (int)houseNumber;
                }
                newItem.HouseBuilding = houseBuilding;
            }

            newItem.PublishDate = DateTime.Now;
            newItem.StatusObject = "не активно";

            newItem.ObjectFloorsAmount = floorsAmount;
            newItem.RoomsAmount = roomsAmount;
            newItem.Footage = footage;
            newItem.ObjectDescription = description;

            if (house == null && apartament != null)
            {
                newItem.Apartament = apartament;
            } else if (apartament == null && house != null)
            {
                newItem.House = house;
            }

            newItem.Price = (int)price;


            if (images == null) {

                conn.RealEstateObject.Add(newItem);
                return;
            }
            
            foreach (string path in images)
            {
                Photo photo = new Photo()
                {
                    PhotoLink = path,
                };
                newItem.Photo.Add(photo);
            }

            conn.RealEstateObject.Add(newItem);
        }

        private bool validate()
        {
            if (userId == null)
            {
                MessageBox.Show("Не авторизовано!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (street == null)
            {
                MessageBox.Show("Поле вулиця обов'язкове!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (houseNumber == null)
            {
                MessageBox.Show("Поле номер дому обов'язкове!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (apartament == null && house == null)
            {
                MessageBox.Show("Не всі поля заповнені!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (roomsAmountInput.Text.Length == 0)
            {
                MessageBox.Show("Поле кількість кімнат обов'язкове!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (price == null)
            {
                MessageBox.Show("Поле ціна обов'язкове!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        /* ====================== Event handlers ====================== */
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validate()) return;
                if (editedItem == null) addRealEstateObject();
                conn.SaveChanges();
                Close();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void districtDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            clearStreetForm();
            if (districts.Where(el => el.NameDistrict == districtDropdown.SelectedItem.ToString()).Any())
            {
                streetDropdown.Enabled = streetInput.Enabled = true;
                streetDropdown.Items.Clear();
                streetDropdown.Items.Add("не обрано");
                streetDropdown.SelectedItem = "не обрано";
                streetInput.Text = "";
                streetDropdown.Items
                    .AddRange(
                        streets
                            .Where(el => el.NameDistrict == districtDropdown.SelectedItem.ToString())
                            .Select(el => el.StreetName)
                            .ToArray()
                        );
                return;
            }
            streetDropdown.Enabled = streetInput.Enabled = false;
        }

        private void streetDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (streetDropdown.SelectedItem.ToString() == "не обрано")
            {
                streetInput.Enabled = true;
                return;
            }

            houseNumberInput.Enabled = false;
            streetInput.Enabled = false;
            clearStreetForm();

            if (isStreetExists(streetDropdown.SelectedItem.ToString())) {
                houseNumberInput.Enabled = true;
                street = streetDropdown.SelectedItem.ToString();
                return;
            }

        }
        private void streetInput_TextChanged(object sender, EventArgs e)
        {
            streetDropdown.Enabled = false;
            clearStreetForm();

            if (streetInput.Text.Length == 0)
            {
                streetDropdown.Enabled = true;
                return;
            }

            street = streetInput.Text;

            houseNumberInput.Enabled = true;
        }
        private void houseNumberInput_TextChanged(object sender, EventArgs e)
        {
            clearhouseBuildingForm();

            if (houseNumberInput.Text.Length == 0) return;

            try
            {
                houseNumber = int.Parse(houseNumberInput.Text);
                if (houseNumber <= 0) throw new Exception();
            } catch
            {
                MessageBox.Show("Неправильні дані у полі номер дому!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            houseBuilding = conn.HouseBuilding.Where(el => el.HouseNumber == houseNumber && el.StreetName == street).SingleOrDefault();
            if (houseBuilding != null)
            {
                floorsBuildingInput.Text = houseBuilding.BuildingFloorsAmount != null ? houseBuilding.BuildingFloorsAmount.ToString() : "";
                yearBuildingInput.Text = houseBuilding.BuildingYear != null ? houseBuilding.BuildingYear.ToString() : "";
                materialBuildinngInput.Text = houseBuilding.WallMaterial != null ? houseBuilding.WallMaterial.ToString() : "";
            } else
            {
                houseBuilding = new HouseBuilding();
            }

            floorsBuildingInput.Enabled = true;
            yearBuildingInput.Enabled = true;
            materialBuildinngInput.Enabled = true;
        }

        private void floorsBuildingInput_TextChanged(object sender, EventArgs e)
        {
            if (floorsBuildingInput.Text.Length == 0) return;

            try
            {
                houseBuilding.BuildingFloorsAmount = int.Parse(floorsBuildingInput.Text);
                if (houseBuilding.BuildingFloorsAmount <= 0) throw new Exception();
            } catch
            {
                floorsBuildingInput.Text = "";
                MessageBox.Show("Неправильні дані у полі номер поверховнсть дому!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void yearBuildingInput_TextChanged(object sender, EventArgs e)
        {
            if (yearBuildingInput.Text.Length == 0) return;

            try
            {
                houseBuilding.BuildingYear = int.Parse(yearBuildingInput.Text);
                if (houseBuilding.BuildingYear <= 0) throw new Exception();
            }
            catch
            {
                yearBuildingInput.Text = "";
                MessageBox.Show("Неправильні дані у полі номер рік поьудови!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void materialBuildinngInput_TextChanged(object sender, EventArgs e)
        {
            houseBuilding.WallMaterial = materialBuildinngInput.Text;
        }

        private void footageInput_TextChanged(object sender, EventArgs e)
        {
            if (footageInput.Text.Length == 0) return;

            try
            {
                footage = int.Parse(footageInput.Text);
                if (footage <= 0) throw new Exception();
            } catch
            {
                footageInput.Text = "";
                MessageBox.Show("Неправильні дані у полі квадратура!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void roomsAmountInput_TextChanged(object sender, EventArgs e)
        {
            if (roomsAmountInput.Text.Length == 0) return;
            try
            {
                roomsAmount = int.Parse(roomsAmountInput.Text);
                if (roomsAmount <= 0) throw new Exception();
            }
            catch
            {
                roomsAmountInput.Text = "";
                MessageBox.Show("Неправильні дані у полі кількість кімнат!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void floorsAmountInput_TextChanged(object sender, EventArgs e)
        {
            if (floorsAmountInput.Text.Length == 0) return;
            try
            {
                floorsAmount = int.Parse(floorsAmountInput.Text);
                if (floorsAmount <= 0) throw new Exception();
            }
            catch
            {
                floorsAmountInput.Text = "";
                MessageBox.Show("Неправильні дані у полі кількість поверхів!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void descriptionInput_TextChanged(object sender, EventArgs e)
        {
            description = descriptionInput.Text;
        }
        private void priceInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                price = int.Parse(priceInput.Text);
                if (price <= 0) throw new Exception();
            }
            catch
            {
                priceInput.Text = "";
                price = null;
                MessageBox.Show("Неправильні дані у полі ціна!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void typeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeDropdown.SelectedItem.ToString())
            {
                case "Квартира":
                    house = null;
                    if (apartament == null) apartament = new Apartament();
                    clearSubForm();
                    setApartSubForm();
                    break;
                case "Приватний будинок":
                    apartament = null;
                    if (house == null) house = new House();
                    clearSubForm();
                    setHouseSubForm();
                    break;
                default: break;
            }
                
        }



        private void clearhouseBuildingForm()
        {
            floorsBuildingInput.Text = "";
            yearBuildingInput.Text = "";
            materialBuildinngInput.Text = "";

            floorsBuildingInput.Enabled = false;
            yearBuildingInput.Enabled = false;
            materialBuildinngInput.Enabled = false;
        }
        private void clearStreetForm()
        {
            houseNumberInput.Text = "";
            houseNumber = null;
            clearhouseBuildingForm();
        }

        private void clearSubForm() 
        {
            additionalPanel.Controls.Clear();
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


            floorsInput.TextChanged += (object sender, EventArgs e) =>
            {
                if (floorsInput.Text.Length == 0) return;
                try
                {
                    apartament.ApartFloor = int.Parse(floorsInput.Text);
                    if (apartament.ApartFloor <= 0) throw new Exception();
                } catch
                {
                    floorsInput.Text = "";
                    MessageBox.Show("Неправильні дані у полі поверх!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            };
            apartServiceInput.TextChanged += (object sender, EventArgs e) =>
            {
                apartament.ApartService = apartServiceInput.Text;
            };

            panel.Controls.AddRange(new Control[] { floorLabel, floorsInput, apartServiceLabel, apartServiceInput } );

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

            yardFootageInput.TextChanged += (object sender, EventArgs e) =>
            {
                if (yardFootageInput.Text.Length == 0) return;
                try
                {
                    house.YardFootage = int.Parse(yardFootageInput.Text);
                    if (house.YardFootage <= 0) throw new Exception();
                } catch
                {
                    yardFootageInput.Text = "";
                    MessageBox.Show("Неправильні дані у полі квадратура двору!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            };
            loftInput.TextChanged += (object sender, EventArgs e) =>
            {
                house.HouseLoft = loftInput.Text;
            };
            garageInput.TextChanged += (object sender, EventArgs e) =>
            {
                house.GarageDescription = garageInput.Text;
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

        private void addImageButton_Click(object sender, EventArgs e)
        {
            AddImagesForm imagesForm = new AddImagesForm(images);
            imagesForm.Show();
            images = imagesForm.get();
        }
    }
}
