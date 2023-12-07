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
        List<Show> agentStatementsPlanned = null;
        List<Show> agentStatementsForAccept = null;
        List<Deal> dealList = null;

        private void setEmployeeStatementPage()
        {
            if (isAgent)
            {
                agentStatementsPlanned = conn.Show.Where(el => el.IdEmployee == id && DateTime.Now < el.ShowDate).ToList();
                agentStatementsForAccept = conn.Show.Where(el => el.IdEmployee == null).ToList();
                setAgentStatementsList(agentStatementsForAccept);
                setPlannedAgentStatementsList(agentStatementsPlanned);
            }

            dealList = conn.Deal.ToList();

            if (isManager) setDealList(dealList);
            resizeEmployeeStatementPage();
        }

        private void setAgentStatementsList(List<Show> list)
        {
            if (list.Count == 0) return;

            acceptStatementsLayout.RowStyles.Clear();
            acceptStatementsLayout.Controls.Clear();
            acceptStatementsLayout.Height = 0;

            for (int i = 0; i < list.Count; ++i)
            {
                Show item = list[i];

                RowStyle row = new RowStyle(SizeType.AutoSize);
                acceptStatementsLayout.RowStyles.Add(row);


                acceptStatementsLayout.Controls.Add(setClientStatementColumn(item), 0, i);
                acceptStatementsLayout.Controls.Add(setAgentStatementColumn(item), 1, i);
                acceptStatementsLayout.Controls.Add(setAgentActionsColumn(item, false), 2, i);

            }

            acceptStatementsLayout.Visible = true;
            acceptStatementsLayout.Enabled = true;

            acceptStatementsWrapper.Visible = true;
            acceptStatementsWrapper.Enabled = true;
        }

        private void setPlannedAgentStatementsList(List<Show> list)
        {
            if (list.Count == 0) return;

            plannedStatementLayout.RowStyles.Clear();
            plannedStatementLayout.Controls.Clear();
            plannedStatementLayout.Height = 0;

            for (int i = 0; i < list.Count; ++i)
            {
                Show item = list[i];

                RowStyle row = new RowStyle(SizeType.AutoSize);
                plannedStatementLayout.RowStyles.Add(row);


                plannedStatementLayout.Controls.Add(setClientStatementColumn(item), 0, i);
                plannedStatementLayout.Controls.Add(setAgentStatementColumn(item), 1, i);
                plannedStatementLayout.Controls.Add(setAgentActionsColumn(item, true), 2, i);

            }

            plannedStatementLayout.Visible = true;
            plannedStatementLayout.Enabled = true;

            plannedStatementWrapper.Visible = true;
            plannedStatementWrapper.Enabled = true;
        }

        private void setDealList(List<Deal> list)
        {
            if (list.Count == 0) return;

            dealListLayout.RowStyles.Clear();
            dealListLayout.Controls.Clear();
            dealListLayout.Height = 0;

            for (int i = 0; i < list.Count; ++i)
            {
                Deal item = list[i];

                conn.Entry(item).Reference(t => t.IdShowNavigation).Load();
                conn.Entry(item).Reference(t => t.IdShowNavigation).Load();

                RowStyle row = new RowStyle(SizeType.AutoSize);
                dealListLayout.RowStyles.Add(row);

                dealListLayout.Controls.Add(setClientDealColumn(item), 0, i);
                dealListLayout.Controls.Add(setAgentDealColumn(item), 1, i);
                dealListLayout.Controls.Add(setActionsDealColumn(item), 2, i);

                dealListWrapper.Visible = true;
                dealListWrapper.Enabled = true;

                dealListLayout.Visible = true;
                dealListLayout.Enabled = true;
                
            }
        }

        private Control setAgentActionsColumn(Show item, bool isPlanedList)
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

            if (isPlanedList) return panel;

            RealEstateObject obj = conn.RealEstateObject.Where(el => el.IdObject == item.IdObject).FirstOrDefault();
            if (obj == null)
            {
                MessageBox.Show("Щось пішло нe так!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return panel;
            }

            if (isAgent && item.IdEmployee == null && id != item.IdPerson && obj.StatusObject == "у продажу")
            {
                Button doDealButton = new Button();
                doDealButton.Text = "Прийняти";

                doDealButton.Font = new Font("Arial", 12);
                doDealButton.Width = 120;
                doDealButton.Height = 40;

                if (DateTime.Now > item.ShowDate)
                {
                    DateTimePicker timePicker = new DateTimePicker();
                    timePicker.Value.AddDays(7);
                    timePicker.Width = 120;
                    panel.AutoScroll = true;

                    doDealButton.Click += (object sender, EventArgs e) =>
                    {
                        item.IdEmployee = id;
                        item.ShowDate = timePicker.Value;

                        try
                        {
                            conn.SaveChanges();
                        } catch
                        {
                            MessageBox.Show("Щось пішло нe так!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        setEmployeeStatementPage();
                    };

                    panel.Controls.Add(timePicker);
                } else
                {
                    doDealButton.Click += (object sender, EventArgs e) =>
                    {
                        item.IdEmployee = id;

                        try
                        {
                            conn.SaveChanges();
                        } catch
                        {
                            MessageBox.Show("Щось пішло нe так!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        setEmployeeStatementPage();
                    };
                }

                panel.Controls.Add(doDealButton);
            }

            return panel;
        }

        private Control setClientDealColumn(Deal item)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label label = new Label();
            Label name = new Label();
            Label phone = new Label();
            Label email = new Label();

            panel.Width = 500;
            panel.Height = 110;
            panel.AutoScroll = true;

            Person person = conn.Person.Where(el => el.IdPerson == item.IdShowNavigation.IdPerson).FirstOrDefault();
            RealEstateObject obj = conn.RealEstateObject.Where(el => el.IdObject == item.IdShowNavigation.IdObject).FirstOrDefault();

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
        private Control setAgentDealColumn(Deal item)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();

            panel.Width = 500;
            panel.Height = 110;
            panel.AutoScroll = true;

            Label name = new Label();
            Label phone = new Label();
            Label email = new Label();



            Employee empl = conn.Employee.Where(el => el.IdEmployee == item.IdShowNavigation.IdEmployee).FirstOrDefault();
            Person person = conn.Person.Where(el => el.IdPerson == empl.IdPerson).FirstOrDefault();

            name.Text = $"Агент: {person.Lname} {person.Fname} {person.Mname}";
            phone.Text = person.Phone != null ? person.Phone : "";
            email.Text = person.Email;

            int w = name.Text.Length > email.Text.Length ? name.Text.Length : email.Text.Length;

            name.Font = phone.Font = email.Font = new Font("Arial", 12);
            name.Width = phone.Width = email.Width = w * 9;

            panel.Controls.Add(name);
            if (phone.Text.Length > 0) panel.Controls.Add(phone);
            panel.Controls.Add(email);

            return panel;
        }
        private Control setActionsDealColumn(Deal item)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Label date = new Label();
            Button button = new Button();

            button.Text = "Переглянути";
            date.Text = "Дата угоди" + item.DateDeal;

            button.Font = new Font("Arial", 12);
            button.Width = date.Width = 120;
            button.Height = date.Height = 40;

            button.Click += (object sender, EventArgs e) =>
            {
                PublicationPreviewForm form = new PublicationPreviewForm(conn, id, item.IdShowNavigation.IdObject);
                form.Show();
            };

            panel.Controls.Add(date);
            panel.Controls.Add(button);

            return panel;
        }

        private void resizeEmployeeStatementPage()
        {
            employeeShowStatementWrapper.MaximumSize = new Size(default, Height / 2 + Height / 4);

            plannedStatementWrapper.Location = new Point(acceptStatementsWrapper.Location.X, acceptStatementsWrapper.Height);
            dealListWrapper.Location = new Point(acceptStatementsWrapper.Location.X, acceptStatementsWrapper.Height + plannedStatementWrapper.Height);

            if (Size.Width < 800)
            {

                acceptStatementsLayout.MaximumSize = new Size(Width - 70, default);
                plannedStatementLayout.MaximumSize = new Size(Width - 70, default);
                dealListLayout.MaximumSize = new Size(Width - 70, default);

                if (employeeShowStatementWrapper.Location.X == 10) return;
                employeeShowStatementWrapper.Location = new Point(10, employeeShowStatementWrapper.Location.Y);

                return;
            }


            acceptStatementsLayout.MaximumSize = new Size(Width / 2 + Width / 4, default);
            plannedStatementLayout.MaximumSize = new Size(Width / 2 + Width / 4, default);
            dealListLayout.MaximumSize = new Size(Width / 2 + Width / 4, default);


            employeeShowStatementWrapper.Location = new Point(Size.Width / 2 - employeeShowStatementWrapper.Width / 2, employeeShowStatementWrapper.Location.Y);
        }
    }
}
