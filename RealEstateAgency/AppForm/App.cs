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
    public partial class App : Form
    {
        private int id;
        private RealEstateAgencyContext conn;

        private bool isManager = false;
        private bool isAgent = false;

        List<TextBox> inputsPersonal = new List<TextBox>();
        public App(int _id, RealEstateAgencyContext _conn)
        {
            id = _id;
            conn = _conn;

            Text = "RealEstateAgency";

            InitializeComponent();

            Width = 700;
            Height = 700;
            MinimumSize = new Size(700, 700);

            isManager = conn.Employee.Where(el => el.IdPerson == id && el.NamePosition == "Менеджер").Any();
            if (!isManager) isAgent = conn.Employee.Where(el => el.IdPerson == id && el.NamePosition == "Агент").Any();

            if (isAgent || isManager)
            {
                ToolStripButton menuEl = new ToolStripButton();
                menuEl.Text = "Угоди та заяви компанії";

                menuEl.Click += (object sender, EventArgs e) =>
                {
                    myPublicationsWrapper.Visible = false;
                    personalWrapper.Visible = false;
                    publicationsWrapper.Visible = false;
                    clientShowStatementWrapper.Visible = false;
                    employeeShowStatementWrapper.Visible = true;
                    statisticWrapper.Visible = false;

                    FormMainHeading.Text = "Угоди та заяви компанії";

                    setEmployeeStatementPage();
                    resizeEmployeeStatementPage();
                };

                topMenu.Items.Add(menuEl);
            }


            if (isManager)
            {
                ToolStripButton menuEl = new ToolStripButton();
                menuEl.Text = "Статистика";

                menuEl.Click += (object sender, EventArgs e) =>
                {
                    myPublicationsWrapper.Visible = false;
                    personalWrapper.Visible = false;
                    publicationsWrapper.Visible = false;
                    clientShowStatementWrapper.Visible = false;
                    employeeShowStatementWrapper.Visible = false;
                    statisticWrapper.Visible = true;

                    FormMainHeading.Text = "Статистика компанії";

                    setStatisticPage();
                    resizeStatisticPage();
                };

                topMenu.Items.Add(menuEl);
            }
            fillPersonalInputsVariable();
            setPersonalInputsWidth(Size.Width / 2);
            setDefaultPersonalLayoutWidth();
            fillPersonalInputs();
        }


        /* Events for design */
        private void app_resize(object sender, EventArgs e)
        {
            if (personalWrapper.Visible)
            {
                resizePersonal();
            } else  if (publicationsWrapper.Visible)
            {
                resizePublicationList();
            } else if (myPublicationsWrapper.Visible)
            {
                resizeMyPublicationsPage();
            } else if (clientShowStatementWrapper.Visible)
            {
                resizeClientStatementPage();
            } else if (employeeShowStatementWrapper.Visible)
            {
                resizeEmployeeStatementPage();
            } else if (statisticWrapper.Visible)
            {
                resizeStatisticPage();
            }
        }
        private void publicationListMenuItem_click(object sender, EventArgs e)
        {
            publicationsWrapper.Visible = true;
            personalWrapper.Visible = false;
            myPublicationsWrapper.Visible = false;
            clientShowStatementWrapper.Visible = false;
            employeeShowStatementWrapper.Visible = false;
            statisticWrapper.Visible = false;

            FormMainHeading.Text = "Пошук нерухомості";

            setPublicationPage();
            resizePublicationList();
        }
        private void personalMenuItem_click(object sender, EventArgs e)
        {
            personalWrapper.Visible = true;
            publicationsWrapper.Visible = false;
            myPublicationsWrapper.Visible = false;
            clientShowStatementWrapper.Visible = false;
            employeeShowStatementWrapper.Visible = false;
            statisticWrapper.Visible = false;

            FormMainHeading.Text = "Персональні дані";
            resizePersonal();
        }
        private void myPublicationsMenuItem_click(object sender, EventArgs e)
        {
            myPublicationsWrapper.Visible = true;
            personalWrapper.Visible = false;
            publicationsWrapper.Visible = false;
            clientShowStatementWrapper.Visible = false;
            employeeShowStatementWrapper.Visible = false;
            statisticWrapper.Visible = false;

            FormMainHeading.Text = "Мої публікації";

            setMyPublicationsPage();
            resizeMyPublicationsPage();
        }
        private void showStatementMenuItem_click(object sender, EventArgs e)
        {
            clientShowStatementWrapper.Visible = true;
            myPublicationsWrapper.Visible = false;
            personalWrapper.Visible = false;
            publicationsWrapper.Visible = false;
            employeeShowStatementWrapper.Visible = false;
            statisticWrapper.Visible = false;

            FormMainHeading.Text = "Мої заяви та угоди";

            setClientStatementPage();
            resizeClientStatementPage();
        }

        /* Events for work */
        private void savePersonalButton_click(object sender, EventArgs e)
        {
            Person person = getPerson();
            if (person == null) return;

            updatePerson(person);

        }
    }
}
