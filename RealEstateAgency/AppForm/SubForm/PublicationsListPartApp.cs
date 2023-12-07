using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using RealEstateAgency.Models.db;
using RealEstateAgency.Models.MyDataTypes;
using System.Data.Entity;

namespace RealEstateAgency
{
    public partial class App
    {
        PublicationList publicationList = null;

        private bool isPriceSort = false;
        private bool isPriceDesc = false;
        private bool isDateDesc = false;


        /* PublicationList methods */
        private void clearPublicationsList(TableLayoutPanel container)
        {
            container.Controls.Clear();
            container.RowStyles.Clear();
            container.Height = 0;
        }

        private void setPublicationPage()
        {
            clearPublicationsList(publicationsListLayout);
            publicationList = new PublicationList(conn);

            if (publicationsListHeaderLayout.Controls.Count == 0)
            {
                setPublicationsHeader();
                publicationsListHeaderLayout.MaximumSize = new Size(default, 200);
            }

            setPublicationList(publicationList.get());
        }
        private void setPublicationsHeader()
        {
            Control[] filters = new Control[]
            {
                setSortByPricePublicationsHeader(),
                setSortByDatePublicationsHeader(),
                setFilterByRoomsPublicationsHeader(),
                setFiltersByAddressPublicationsHeader(),
                setFiltersByPricePublicationsHeader(),
                setFiltersResetPublicationsHeader(),
            };

            publicationsListHeaderLayout.Controls.AddRange(filters);
        }
        private void setPublicationList(List<RealEstateObject> list)
        {
            if (list.Count == 0) return;
            publicationsListLayout.Visible = false;

            for (int i = 0; i < list.Count; ++i)
            {
                RealEstateObject item = list[i];

                RowStyle row = new RowStyle(SizeType.AutoSize);
                publicationsListLayout.RowStyles.Add(row);

                
                publicationsListLayout.Controls.Add(setImageToPublicationLayout(item), 0, i);
                publicationsListLayout.Controls.Add(setShortInfTooPublicationLayout(item), 1, i);
                publicationsListLayout.Controls.Add(setShowButtonToPublicationLayout(item), 2, i);

            }

            publicationsListLayout.Visible = true;
            resizePublicationList();
        }


        /* ========= Method for setPublicationList() ========= */
        /// <summary>
        /// Method only for other method setPublicationList()
        /// In the point to code decomposition
        /// </summary>
        /// <param name="item"></param>
        private PictureBox setImageToPublicationLayout(RealEstateObject item)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "publicationListImage";
            
            string photoLink = conn.Photo.Where(el => el.IdObject == item.IdObject).Select(el => el.PhotoLink).FirstOrDefault();
            if (photoLink != null)
            {
                try
                {
                    byte[] data = getImageBytesFromWeb(photoLink);
                    using (MemoryStream stream = new MemoryStream(data))
                    {
                        pictureBox.Image = Image.FromStream(stream);
                    }
                } catch
                {
                    MessageBox.Show("Щось пішло не так :(", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Height = pictureBox.Width = 120;

            return pictureBox;
        }

        /// <summary>
        /// Method only for other method setPublicationList()
        /// In the point to code decomposition
        /// </summary>
        /// <param name="item"></param>
        private FlowLayoutPanel setShortInfTooPublicationLayout(RealEstateObject item) {

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.TopDown;
            panel.AutoSize = true;
            panel.Padding = new Padding(10);

            Label price = new Label();
            price.Text = item.Price.ToString() + "$";
            price.Font = new Font("Arial", 18, FontStyle.Bold);

            Label street = new Label();
            street.Text = item.StreetName.ToString() + item.HouseNumber;


            Label district = new Label();
            district.Text = "район: " + item?.HouseBuilding.StreetNameNavigation.NameDistrict.ToString();

            Label rooms = new Label();
            rooms.Text = item.RoomsAmount.ToString() + " кімнати";
            rooms.Font = new Font("Arial", 12);

            Label date = new Label();
            date.Text = "Опубліковано: " + item.PublishDate.ToString();
            date.Font = new Font("Arial", 10);


            district.AutoEllipsis = street.AutoEllipsis = true;
            date.Width = rooms.Width = district.Width = street.Width = price.Width = 300;
            district.Font = street.Font = new Font("Arial", 14);
            price.Margin = rooms.Margin = district.Margin = new Padding(0, 0, 0, 16);


            panel.Controls.AddRange(new Control[] { street, district, rooms, price, date });

            return panel;

        }

        /// <summary>
        /// Method only for other method setPublicationList()
        /// In the point to code decomposition
        /// </summary>
        private Button setShowButtonToPublicationLayout(RealEstateObject item)
        {
            Button button = new Button();
            button.Text = "Переглянути";
            button.Font = new Font("Arial", 12);
            button.Width = 120;
            button.Height = 50;

            button.Margin = new Padding(16);

            button.Click += (object sender, EventArgs e) =>
            {
                PublicationPreviewForm form = new PublicationPreviewForm(conn, id, item);
                form.Show();
            };

            return button;
        }


        /* ========= Method for setPublicationsHeader() ========= */
        /// <summary>
        /// Method only for other method setPublicationsHeader()
        /// In the point to code decomposition
        /// </summary>
        /// <returns></returns>
        private Control setSortByPricePublicationsHeader()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label name = new Label();
            Button buttonAsc = new Button();
            Button buttonDesc = new Button();

            panel.AutoSize = true;

            name.Text = "Сортувати за ціною";
            buttonAsc.Text = "зростанням";
            buttonDesc.Text = "спаданням";

            setSortControlsStyles(name, buttonAsc, buttonDesc);

            buttonAsc.Click += buttonPriceASC_click;
            buttonDesc.Click += buttonPriceDESC_click;

            panel.Controls.AddRange(new Control[] { name, buttonAsc, buttonDesc });

            return panel;
        }

        /// <summary>
        /// Method only for other method setPublicationsHeader()
        /// In the point to code decomposition
        /// </summary>
        /// <returns></returns>
        private Control setSortByDatePublicationsHeader()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label name = new Label();
            Button buttonAsc = new Button();
            Button buttonDesc = new Button();

            panel.AutoSize = true;

            name.Text = "Сортувати за датою";
            buttonAsc.Text = "зростанням";
            buttonDesc.Text = "спаданням";

            setSortControlsStyles(name, buttonAsc, buttonDesc);

            buttonAsc.Click += buttonDateASC_click;
            buttonDesc.Click += buttonDateDESC_click;

            panel.Controls.AddRange(new Control[] { name, buttonAsc, buttonDesc });

            return panel;
        }

        /// <summary>
        /// Method only for other method setPublicationsHeader()
        /// In the point to code decomposition
        /// </summary>
        /// <returns></returns>
        private Control setFiltersByAddressPublicationsHeader()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            FlowLayoutPanel districtPanel = new FlowLayoutPanel();
            FlowLayoutPanel streetPanel = new FlowLayoutPanel();
            streetPanel.Visible = false;

            panel.AutoSize = districtPanel.AutoSize = streetPanel.AutoSize = true;

            Label districtLabelName = new Label();
            Label streetLabelName = new Label();
            ComboBox districtDropdown = new ComboBox();
            ComboBox streetDropdown = new ComboBox();

            districtLabelName.Text = "Район";
            streetLabelName.Text = "Вулиця";
            streetLabelName.TextAlign = districtLabelName.TextAlign = ContentAlignment.MiddleCenter;
            streetLabelName.Font = districtLabelName.Font = districtDropdown.Font = streetDropdown.Font = new Font("Arial", 12);
            streetLabelName.Width = districtLabelName.Width = 60;
            streetLabelName.Height = districtLabelName.Height = 40;

            districtDropdown.Items.Add("не обрано");
            districtDropdown.Items.AddRange(publicationList.districts.Select(el => el.NameDistrict).ToArray());
            streetDropdown.Width = districtDropdown.Width = 200;
            streetDropdown.Margin = districtDropdown.Margin = new Padding(0, 8, 0, 0);


            // address events
            districtDropdown.SelectedValueChanged += (object sender, EventArgs e) =>
            {
                string item = districtDropdown.SelectedItem.ToString();

                if (item.Length <= 0) return;

                if (item == "не обрано")
                {
                    publicationList.district = null;
                    streetPanel.Visible = false;
                } else
                {
                    publicationList.district = item;

                    streetDropdown.Items.Clear();
                    streetDropdown.Items.Add("не обрано");
                    streetDropdown.Items.AddRange(publicationList.streets.Select(el => el.StreetName).ToArray());

                    streetPanel.Visible = true;
                }

                clearPublicationsList(publicationsListLayout);
                setPublicationList(publicationList.get());
            };

            streetDropdown.SelectedValueChanged += (object sender, EventArgs e) =>
            {
                string item = streetDropdown.SelectedItem.ToString();

                if (item.Length <= 0) return;
                if (item == "не обрано")
                {
                    publicationList.street = null;
                } else
                {
                    publicationList.street = item;
                }

                clearPublicationsList(publicationsListLayout);
                setPublicationList(publicationList.get());
            };

            districtPanel.Controls.AddRange(new Control[] { districtLabelName, districtDropdown });
            streetPanel.Controls.AddRange(new Control[] { streetLabelName, streetDropdown });

            panel.Controls.Add(districtPanel);
            panel.Controls.Add(streetPanel);

            return panel;
        }

        /// <summary>
        /// Method only for other method setPublicationsHeader()
        /// In the point to code decomposition
        /// </summary>
        /// <returns></returns>
        private Control setFilterByRoomsPublicationsHeader()
        {
            int?[] arr = publicationList.roomsInList;

            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label name = new Label();
            Button[] buttons = new Button[arr.Length];

            panel.AutoSize = true;

            name.Text = "Кільксть кімнат";
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.Font = new Font("Arial", 12);
            name.Width = 120;
            name.Height = 40;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == null) continue;
                int index = i;

                buttons[i] = new Button();
                buttons[i].Width = 50;
                buttons[i].Height = 40;
                buttons[i].Text = arr[i].ToString();
                buttons[i].Click += (object sender, EventArgs e) =>
                {
                    publicationList.rooms = arr[index];

                    clearPublicationsList(publicationsListLayout);
                    setPublicationList(publicationList.get());
                };
            }

            panel.Controls.Add(name);
            panel.Controls.AddRange(buttons);

            return panel;
        }

        /// <summary>
        /// Method only for other method setPublicationsHeader()
        /// In the point to code decomposition
        /// </summary>
        /// <returns></returns>
        private Control setFiltersByPricePublicationsHeader()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label name = new Label();
            Label minLabel = new Label();
            Label maxLabel = new Label();
            TextBox min = new TextBox();
            TextBox max = new TextBox();
            Button button = new Button();

            panel.AutoSize = true;

            name.Text = "Діапазон цін";
            minLabel.Text = "від";
            maxLabel.Text = "до";
            name.TextAlign = minLabel.TextAlign = maxLabel.TextAlign = ContentAlignment.MiddleCenter;
            name.Font = button.Font = minLabel.Font = maxLabel.Font = new Font("Arial", 12);
            min.Font = max.Font = new Font("Arial", 14);
            name.Width = 100;
            button.Width = 120;
            min.Width = max.Width = 80;
            minLabel.Height = maxLabel.Height = name.Height = button.Height = 40;
            minLabel.Width = maxLabel.Width = 30;
            button.Text = "Застосувати";

            min.Margin = max.Margin = new Padding(0, 10, 5, 10);

            button.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    publicationList.min = min.Text.Length > 0 ? int.Parse(min.Text) : 0;
                    publicationList.max = max.Text.Length > 0 ? int.Parse(max.Text) : int.MaxValue;
                    publicationList.applyPriceFilter();

                    clearPublicationsList(publicationsListLayout);
                    setPublicationList(publicationList.get());
                } catch(Exception)
                {
                    MessageBox.Show("Неправильно введені дані!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            panel.Controls.AddRange(new Control[] { name, minLabel, min, maxLabel, max, button });

            return panel;
        }
        
        /// <summary>
        /// Method only for other method setPublicationsHeader()
        /// In the point to code decomposition
        /// </summary>
        /// <returns></returns>
        private Control setFiltersResetPublicationsHeader()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Button button = new Button();

            panel.AutoSize = true;

            button.Text = "Очистити";
            button.Width = 120;
            button.Height = 40;
            button.Font = new Font("Arial", 12);

            button.Click += (object sender, EventArgs e) =>
            {
                publicationList.clearFilters();

                clearPublicationsList(publicationsListLayout);
                setPublicationList(publicationList.get());
            };

            panel.Controls.Add(button);

            return panel;
        }



        /// <summary>
        /// Method set styles for label and buttons in sort controol filter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="buttonAsc"></param>
        /// <param name="buttonDesc"></param>
        private void setSortControlsStyles(Label name, Button buttonAsc, Button buttonDesc)
        {
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.Font = buttonAsc.Font = buttonDesc.Font = new Font("Arial", 12);
            name.Width = 160;
            buttonAsc.Width = buttonDesc.Width = 120;
            name.Height = buttonAsc.Height = buttonDesc.Height = 40;
        }


        /* Sort event handlers */
        private void buttonPriceASC_click(object sender, EventArgs e)
        {
            if (!isPriceDesc && isPriceSort) return;

            publicationList.sort = Sort.PriceAsc;

            clearPublicationsList(publicationsListLayout);
            setPublicationList(publicationList.get());

            isPriceDesc = false;
            isPriceSort = true;
        }
        private void buttonPriceDESC_click(object sender, EventArgs e)
        {
            if (isPriceDesc && isPriceSort) return;

            publicationList.sort = Sort.PriceDesc;

            clearPublicationsList(publicationsListLayout);
            setPublicationList(publicationList.get());

            isPriceDesc = true;
            isPriceSort = true;
        }
        private void buttonDateASC_click(object sender, EventArgs e)
        {
            if (!isDateDesc && !isPriceSort) return;

            publicationList.sort = Sort.DateAsc;

            clearPublicationsList(publicationsListLayout);
            setPublicationList(publicationList.get());

            isDateDesc = false;
            isPriceSort = false;
        }
        private void buttonDateDESC_click(object sender, EventArgs e)
        {
            if (isDateDesc && !isPriceSort) return;

            publicationList.sort = Sort.DateDesc;

            clearPublicationsList(publicationsListLayout);
            setPublicationList(publicationList.get());

            isDateDesc = true;
            isPriceSort = false;
        }



        /* ============= Methods for adaptive view =============== */

        private void setPublicationWidth(Control container, Control listContainer, Control headerContainer, int w)
        {
            listContainer.Width = w;
            headerContainer.Width = w;
            headerContainer.MaximumSize = new Size(w, 250);
            container.Location = new Point(0, headerContainer.Height + 20);
        }
        private void setPublicationHeight(Control container)
        {
            container.MaximumSize = new Size(default, Height / 2);
        }
        private void setPublicationListImageSize(Control container, int h)
        {
            foreach (Control item in container.Controls.Find("publicationListImage", false))
            {
                if (item.Height == h) return;
                container.Height = h;
                item.Height = h;
                item.Width = h;
            }
        }
       
        private void resizePublicationList()
        {
            setPublicationHeight(publicationsListWrapper);

            if (Size.Width < 800)
            {
                setPublicationWidth(publicationsListWrapper, publicationsListLayout, publicationsListHeaderLayout, Size.Width - 50);

                publicationsListHeaderLayout.Height = 200;

                if (publicationsWrapper.Location.X == 10) return;
                publicationsWrapper.Location = new Point(10, publicationsWrapper.Location.Y);

                setPublicationListImageSize(publicationsListLayout, 120);
                return;
            }

            setPublicationWidth(publicationsListWrapper, publicationsListLayout, publicationsListHeaderLayout, Size.Width / 2 + Size.Width / 4);

            publicationsWrapper.Location = new Point(Size.Width / 2 - publicationsWrapper.Width / 2, publicationsWrapper.Location.Y);

            if (publicationsListLayout.Controls.Find("publicationListImage", false)?[0].Height == 250) return;
            setPublicationListImageSize(publicationsListLayout, 250);
        }
    }
}
