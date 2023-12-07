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
    public partial class App
    {
        List<Show> clientStatements = null;

        private void setClientStatementPage()
        {
            clientStatements = conn.Show.Where(el => el.IdPerson == id).ToList();

            dealList = conn.Deal.ToList();

            setClientStatementList(clientStatements);
            setClientDealList(dealList);
            resizeClientStatementPage();
        }

        private void setClientStatementList(List<Show> list)
        {
            if (list.Count == 0) return;

            clientStatementListLayout.RowStyles.Clear();
            clientStatementListLayout.Controls.Clear();
            clientStatementListLayout.Height = 0;

            for (int i = 0; i < list.Count; ++i)
            {
                Show item = list[i];

                if (conn.Deal.Where(el => el.IdShow == item.IdShow).Any())
                {
                    continue;
                }

                RowStyle row = new RowStyle(SizeType.AutoSize);
                clientStatementListLayout.RowStyles.Add(row);


                clientStatementListLayout.Controls.Add(setClientStatementColumn(item), 0, i);
                clientStatementListLayout.Controls.Add(setAgentStatementColumn(item), 1, i);
                clientStatementListLayout.Controls.Add(setClientActionsColumn(item), 2, i);

            }


            clientStatementWrapper.Visible = true;
            clientStatementWrapper.Enabled = true;

            clientStatementListLayout.Visible = true;
            clientStatementListLayout.Enabled = true;
        }

        private void setClientDealList(List<Deal> list)
        {
            if (list.Count == 0) return;

            clientDealListLayout.RowStyles.Clear();
            clientDealListLayout.Controls.Clear();
            clientDealListLayout.Height = 0;

            for (int i = 0; i < list.Count; ++i)
            {
                Deal item = list[i];

                conn.Entry(item).Reference(t => t.IdShowNavigation).Load();
                conn.Entry(item).Reference(t => t.IdShowNavigation).Load();

                if (item.IdShowNavigation.IdPerson == id)
                {
                    RowStyle row = new RowStyle(SizeType.AutoSize);
                    clientDealListLayout.RowStyles.Add(row);

                    clientDealListLayout.Controls.Add(setClientDealColumn(item), 0, i);
                    clientDealListLayout.Controls.Add(setAgentDealColumn(item), 1, i);
                    clientDealListLayout.Controls.Add(setActionsDealColumn(item), 2, i);

                    clientDealListWrapper.Visible = true;
                    clientDealListWrapper.Enabled = true;

                    clientDealListLayout.Visible = true;
                    clientDealListLayout.Enabled = true;
                }
            }
        }



        private Control setClientStatementColumn(Show item)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label label = new Label();
            Label name = new Label();
            Label phone = new Label();
            Label email = new Label();

            panel.Width = 500;
            panel.Height = 110;
            panel.AutoScroll = true;

            Person person = conn.Person.Where(el => el.IdPerson == item.IdPerson).FirstOrDefault();
            RealEstateObject obj = conn.RealEstateObject.Where(el => el.IdObject == item.IdObject).FirstOrDefault();

            label.Text = $"{obj.StreetName}, {obj.HouseNumber}, {obj.Price}$";
            name.Text = $"Покупець: {person.Lname} {person.Fname} {person.Mname}";
            phone.Text = person.Phone != null ? person.Phone : "";
            email.Text = person.Email;

            int w = name.Text.Length > email.Text.Length ? name.Text.Length : email.Text.Length;

            label.Font = name.Font = phone.Font = email.Font = new Font("Arial", 12);
            label.Width = name.Width = phone.Width = email.Width = w * 9;
          

            panel.Controls.Add(label);
            panel.Controls.Add(name);
            if (phone.Text.Length > 0) panel.Controls.Add(phone);
            panel.Controls.Add(email);

            return panel;
        }
        private Control setAgentStatementColumn(Show item)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label label = new Label();

            panel.Width = 500;
            panel.Height = 110;
            panel.AutoScroll = true;

            if (item.IdEmployee == null)
            {
                label.Text = "Статус: очікується";
                panel.Controls.Add(label);
                return panel;
            } 

            Label name = new Label();
            Label phone = new Label();
            Label email = new Label();

            Employee empl = conn.Employee.Where(el => el.IdEmployee == item.IdEmployee).FirstOrDefault();
            Person person = conn.Person.Where(el => el.IdPerson == empl.IdPerson).FirstOrDefault();

            label.Text = "Дата огляду: " + item.ShowDate;
            name.Text = $"Агент: {person.Lname} {person.Fname} {person.Mname}";
            phone.Text = person.Phone != null ? person.Phone : "";
            email.Text = person.Email;

            int w = name.Text.Length > email.Text.Length ? name.Text.Length : email.Text.Length;

            label.Font = name.Font = phone.Font = email.Font = new Font("Arial", 12);
            label.Width = name.Width = phone.Width = email.Width = w * 9;

            panel.Controls.Add(label);
            panel.Controls.Add(name);
            if (phone.Text.Length > 0) panel.Controls.Add(phone);
            panel.Controls.Add(email);

            return panel;
        }
        private Control setClientActionsColumn(Show item)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();

            Button button = new Button();
            button.Text = "Переглянути";

            button.Font = new Font("Arial", 12);
            button.Width = 120;
            button.Height = 40;

            button.Click += (object sender, EventArgs e) =>
            {
                PublicationPreviewForm form = new PublicationPreviewForm(conn, id, item.IdObject);
                form.Show();
            };

            panel.Controls.Add(button);

            RealEstateObject obj = conn.RealEstateObject.Where(el => el.IdObject == item.IdObject).FirstOrDefault();
            if (obj == null)
            {
                MessageBox.Show("Щось пішло нe так!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return panel;
            }

            if (item.IdEmployee != null && DateTime.Now > item.ShowDate && id == item.IdPerson && obj.StatusObject == "у продажу") 
            {
                Button doDealButton = new Button();
                doDealButton.Text = "Укласти угоду";

                doDealButton.Font = new Font("Arial", 12);
                doDealButton.Width = 120;
                doDealButton.Height = 40;

                doDealButton.Click += (object sender, EventArgs e) =>
                {
                    if (id == item.IdEmployee)
                    {
                        MessageBox.Show("Не дозволено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Deal deal = new Deal()
                    {
                        DateDeal = DateTime.Now,
                        IdShow = item.IdShow,
                    };
                    conn.Deal.Add(deal);

                    obj.StatusObject = "продано";

                    try
                    {
                        conn.SaveChanges();
                    } catch
                    {
                        MessageBox.Show("Щось пішло нe так!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    setClientStatementPage();
                };

                panel.Controls.Add(doDealButton);
            }

            return panel;
        }

        private void resizeClientStatementPage()
        {
            clientShowStatementWrapper.MaximumSize = new Size(default, Height / 2 + Height / 4);

            clientDealListWrapper.Location = new Point(clientStatementWrapper.Location.X, clientStatementWrapper.Height);

            if (Size.Width < 800)
            {

                clientStatementListLayout.MaximumSize = new Size(Width - 70, default);
                clientDealListLayout.MaximumSize = new Size(Width - 70, default);


                if (clientShowStatementWrapper.Location.X == 10) return;
                clientShowStatementWrapper.Location = new Point(10, clientShowStatementWrapper.Location.Y);

                return;
            }


            clientStatementListLayout.MaximumSize = new Size(Width / 2 + Width / 4, default);
            clientDealListLayout.MaximumSize = new Size(Width / 2 + Width / 4, default);


            clientShowStatementWrapper.Location = new Point(Size.Width / 2 - clientShowStatementWrapper.Width / 2, clientShowStatementWrapper.Location.Y);
        }
    }
}
