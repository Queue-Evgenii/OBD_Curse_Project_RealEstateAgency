using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgency.EditObjectForm
{
    public partial class AddImagesForm : Form
    {
        private List<string> images;
        public AddImagesForm(List<string> _images)
        {
            InitializeComponent();

            images = _images;
            if (images == null) images = new List<string>();

            for (int i = 0; i < images.Count; ++i)
            {
                TextBox input = new TextBox();
                input.Font = new Font("Arial", 12);
                input.Width = 312;
                input.ReadOnly = true;

                input.Text = images[i];

                flowLayoutPanel1.Controls.Add(input);
            }
        }
        public List<string> get()
        {
            return images;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Поле повинно бути заповнене!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (App.getImageBytesFromWeb(textBox1.Text) == null)
            {
                MessageBox.Show("Неправильне посилання!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            images.Add(textBox1.Text);
            Close();
        }
    }
}
