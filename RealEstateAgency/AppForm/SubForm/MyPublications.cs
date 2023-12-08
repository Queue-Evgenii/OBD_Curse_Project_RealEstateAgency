using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateAgency.Models.db;
using RealEstateAgency.Models.MyDataTypes;
using RealEstateAgency.Statistic;
using RealEstateAgency.EditObjectForm;

namespace RealEstateAgency
{
    public partial class App
    {
        private MyPublicationsList myPublications;
        private void setMyPublicationsPage()
        {
            clearPublicationsList(myPublicationsListLayout);
            myPublications = new MyPublicationsList(conn, id);
            if (myPublicationsHeaderLayout.Controls.Count == 0)
            {
                setMyPublicationsHeader();
            }
            setMyPublicationsList(myPublications.get());
        }
        private void setMyPublicationsHeader()
        {
            Control[] controls = new Control[]
            {
                setAddPublicationControl(),
                setShowStatisticControl(),
            };

            myPublicationsHeaderLayout.Controls.AddRange(controls);
        }
        private void setMyPublicationsList(List<RealEstateObject> list)
        {
            if (list.Count == 0) return;
            myPublicationsListLayout.Visible = false;

            for (int i = 0; i < list.Count; ++i)
            {
                RealEstateObject item = list[i];

                RowStyle row = new RowStyle(SizeType.AutoSize);
                myPublicationsListLayout.RowStyles.Add(row);

                myPublicationsListLayout.Controls.Add(setImageToPublicationLayout(item), 0, i);
                myPublicationsListLayout.Controls.Add(setShortInfTooPublicationLayout(item), 1, i);
                myPublicationsListLayout.Controls.Add(setEditButtonPublicationLayout(item), 2, i);

            }

            myPublicationsListLayout.Visible = true;
            resizeMyPublicationsPage();
        }


        private Control setAddPublicationControl()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Button button = new Button();

            panel.AutoSize = true;

            button.Font = new Font("Arial", 12);
            button.Text = "Додати публікацію";
            button.Width = 200;
            button.Height = 40;

            AddObjectForm form = null;
            button.Click += (object sender, EventArgs e) => {
                if (form != null) form.Close();
                form = new AddObjectForm(conn, id, null);
                form.Show();
                form.FormClosed += (object sender2, FormClosedEventArgs e2) =>
                {
                    clearPublicationsList(myPublicationsListLayout);
                    myPublications = new MyPublicationsList(conn, id);
                    setMyPublicationsList(myPublications.get());
                };
            };

            panel.Controls.Add(button);

            return panel;
        }
        private  Control setShowStatisticControl()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Button button = new Button();

            panel.AutoSize = true;

            button.Font = new Font("Arial", 12);
            button.Text = "Статистика переглядів";
            button.Width = 200;
            button.Height = 40;

            button.Click += (object sender, EventArgs e) => {
                GeneralShowStatistic form = new GeneralShowStatistic(conn, myPublications.get());
                form.Show();
            };

            panel.Controls.Add(button);

            return panel;
        }

        private Control setEditButtonPublicationLayout(RealEstateObject item)
        {
            Panel panel = new Panel();
            ComboBox status = new ComboBox();
            Button edit = new Button();
            Button delete = new Button();

            panel.AutoSize = true;
            ///panel.Height = 80;
            panel.Margin = new Padding(16);

            edit.Font = delete.Font = status.Font = new Font("Arial", 12);
            edit.Width = delete.Width = status.Width = 120;
            edit.Height = delete.Height = 40;

            edit.Text = "Редагувати";
            delete.Text = "Видалити";

            status.Location = new Point(default, 0);
            edit.Location = new Point(default, 35);
            delete.Location = new Point(default, 75);

            status.Items.AddRange(myPublications.status.Select(el => el.StatusObject).ToArray());
            status.SelectedItem = item.StatusObject;

            if (item.StatusObject == "продано") 
            {
                status.Enabled = false;
                edit.Enabled = false;
                delete.Enabled = false;
            }

            status.SelectedValueChanged += (object sender, EventArgs e) =>
            {
                if (status.SelectedItem.ToString() == "продано")
                {
                    MessageBox.Show("Змінити статус на продано може лише релторська компанія", "Заборона", MessageBoxButtons.OK);
                    status.SelectedItem = item.StatusObject;
                    return;
                }
                try
                {
                    item.StatusObject = status.SelectedItem.ToString();
                    conn.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Щось пішло не так :(", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            EditForm form = null;
            edit.Click += (object sender, EventArgs e) =>
            {
                if (form != null) form.Close();
                form = new EditForm(conn, item);
                form.Show();
                form.FormClosed += (object sender2, FormClosedEventArgs e2) =>
                {
                    clearPublicationsList(myPublicationsListLayout);
                    myPublications = new MyPublicationsList(conn, id);
                    setMyPublicationsList(myPublications.get());
                };
            };

            delete.Click += (object sender, EventArgs e) =>
            {
                DialogResult res = MessageBox.Show("Ви впевнені, що хочете видаллити публікацію?", "", MessageBoxButtons.YesNo);
                if (res.GetHashCode() == 6)
                {
                    List<Show> list = conn.Show.Where(el => el.IdObject == item.IdObject).ToList();
                    foreach (Show show in list)
                    {
                        Deal deal = conn.Deal.Where(el => el.IdShow == show.IdShow).SingleOrDefault();
                        if (deal != null)
                        {
                            conn.Deal.Remove(deal);
                        }

                        conn.Show.Remove(show);
                    }
                    conn.RealEstateObject.Remove(item);
                    conn.SaveChanges();
                    clearPublicationsList(myPublicationsListLayout);
                    myPublications = new MyPublicationsList(conn, id);
                    setMyPublicationsList(myPublications.get());
                }
            };

            panel.Controls.AddRange(new Control[] {
                status,
                edit,
                delete
            });

            return panel;
        }


        private void resizeMyPublicationsPage()
        {
            setPublicationHeight(myPublicationsListWrapper);

            if (Size.Width < 800)
            {
                setPublicationWidth(myPublicationsListWrapper, myPublicationsListLayout, myPublicationsHeaderLayout, Size.Width - 50);

                myPublicationsHeaderLayout.Height = 200;

                if (myPublicationsWrapper.Location.X == 10) return;
                myPublicationsWrapper.Location = new Point(10, myPublicationsWrapper.Location.Y);

                setPublicationListImageSize(myPublicationsListLayout, 120);
                return;
            }

            setPublicationWidth(myPublicationsListWrapper, myPublicationsListLayout, myPublicationsHeaderLayout, Size.Width / 2 + Size.Width / 4);

            myPublicationsWrapper.Location = new Point(Size.Width / 2 - myPublicationsWrapper.Width / 2, myPublicationsWrapper.Location.Y);

            try
            {
                if (myPublicationsListLayout.Controls.Find("publicationListImage", false)?[0].Height == 250) return;
                setPublicationListImageSize(myPublicationsListLayout, 250);
            }
            catch
            {
                return;
            }
        }
    }
}
