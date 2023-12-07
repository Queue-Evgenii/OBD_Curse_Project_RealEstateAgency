
namespace RealEstateAgency
{
    partial class AddObjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.districtDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.houseNumberInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.footageInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomsAmountInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.floorsAmountInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.streetInput = new System.Windows.Forms.TextBox();
            this.streetDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.additionalPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialBuildinngInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.yearBuildingInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.floorsBuildingInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адреса";
            // 
            // districtDropdown
            // 
            this.districtDropdown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtDropdown.FormattingEnabled = true;
            this.districtDropdown.Location = new System.Drawing.Point(70, 36);
            this.districtDropdown.Name = "districtDropdown";
            this.districtDropdown.Size = new System.Drawing.Size(175, 26);
            this.districtDropdown.TabIndex = 1;
            this.districtDropdown.SelectedValueChanged += new System.EventHandler(this.districtDropdown_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Район";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер дому";
            // 
            // houseNumberInput
            // 
            this.houseNumberInput.Enabled = false;
            this.houseNumberInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseNumberInput.Location = new System.Drawing.Point(107, 98);
            this.houseNumberInput.Name = "houseNumberInput";
            this.houseNumberInput.Size = new System.Drawing.Size(138, 26);
            this.houseNumberInput.TabIndex = 8;
            this.houseNumberInput.TextChanged += new System.EventHandler(this.houseNumberInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Опис об\'єкту нерухомості";
            // 
            // footageInput
            // 
            this.footageInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footageInput.Location = new System.Drawing.Point(147, 42);
            this.footageInput.Name = "footageInput";
            this.footageInput.Size = new System.Drawing.Size(98, 26);
            this.footageInput.TabIndex = 11;
            this.footageInput.TextChanged += new System.EventHandler(this.footageInput_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Квадратура (м^2)";
            // 
            // roomsAmountInput
            // 
            this.roomsAmountInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsAmountInput.Location = new System.Drawing.Point(147, 74);
            this.roomsAmountInput.Name = "roomsAmountInput";
            this.roomsAmountInput.Size = new System.Drawing.Size(98, 26);
            this.roomsAmountInput.TabIndex = 13;
            this.roomsAmountInput.TextChanged += new System.EventHandler(this.roomsAmountInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Кількість кімнат";
            // 
            // floorsAmountInput
            // 
            this.floorsAmountInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorsAmountInput.Location = new System.Drawing.Point(147, 106);
            this.floorsAmountInput.Name = "floorsAmountInput";
            this.floorsAmountInput.Size = new System.Drawing.Size(98, 26);
            this.floorsAmountInput.TabIndex = 15;
            this.floorsAmountInput.TextChanged += new System.EventHandler(this.floorsAmountInput_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Кількість поверхів";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionInput.Location = new System.Drawing.Point(293, 75);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(226, 57);
            this.descriptionInput.TabIndex = 17;
            this.descriptionInput.TextChanged += new System.EventHandler(this.descriptionInput_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Короткий опис";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.descriptionInput);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.footageInput);
            this.panel1.Controls.Add(this.floorsAmountInput);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.roomsAmountInput);
            this.panel1.Location = new System.Drawing.Point(12, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 151);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.districtDropdown);
            this.panel2.Controls.Add(this.houseNumberInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.streetInput);
            this.panel2.Controls.Add(this.streetDropdown);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 136);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вулиця";
            // 
            // streetInput
            // 
            this.streetInput.Enabled = false;
            this.streetInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetInput.Location = new System.Drawing.Point(306, 66);
            this.streetInput.Name = "streetInput";
            this.streetInput.Size = new System.Drawing.Size(178, 26);
            this.streetInput.TabIndex = 6;
            this.streetInput.TextChanged += new System.EventHandler(this.streetInput_TextChanged);
            // 
            // streetDropdown
            // 
            this.streetDropdown.Enabled = false;
            this.streetDropdown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetDropdown.FormattingEnabled = true;
            this.streetDropdown.Location = new System.Drawing.Point(70, 66);
            this.streetDropdown.Name = "streetDropdown";
            this.streetDropdown.Size = new System.Drawing.Size(175, 26);
            this.streetDropdown.TabIndex = 4;
            this.streetDropdown.SelectedValueChanged += new System.EventHandler(this.streetDropdown_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "АБО";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Тип нерухомості";
            // 
            // typeDropdown
            // 
            this.typeDropdown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Items.AddRange(new object[] {
            "Квартира",
            "Приватний будинок"});
            this.typeDropdown.Location = new System.Drawing.Point(147, 434);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(135, 26);
            this.typeDropdown.TabIndex = 9;
            this.typeDropdown.SelectedIndexChanged += new System.EventHandler(this.typeDropdown_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(690, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(161, 51);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // additionalPanel
            // 
            this.additionalPanel.AutoSize = true;
            this.additionalPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.additionalPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.additionalPanel.Location = new System.Drawing.Point(12, 469);
            this.additionalPanel.MaximumSize = new System.Drawing.Size(523, 500);
            this.additionalPanel.MinimumSize = new System.Drawing.Size(200, 40);
            this.additionalPanel.Name = "additionalPanel";
            this.additionalPanel.Size = new System.Drawing.Size(200, 40);
            this.additionalPanel.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.materialBuildinngInput);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.yearBuildingInput);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.floorsBuildingInput);
            this.panel3.Location = new System.Drawing.Point(12, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 115);
            this.panel3.TabIndex = 20;
            // 
            // materialBuildinngInput
            // 
            this.materialBuildinngInput.Enabled = false;
            this.materialBuildinngInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialBuildinngInput.Location = new System.Drawing.Point(126, 71);
            this.materialBuildinngInput.Name = "materialBuildinngInput";
            this.materialBuildinngInput.Size = new System.Drawing.Size(141, 26);
            this.materialBuildinngInput.TabIndex = 9;
            this.materialBuildinngInput.TextChanged += new System.EventHandler(this.materialBuildinngInput_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Опис дому";
            // 
            // yearBuildingInput
            // 
            this.yearBuildingInput.Enabled = false;
            this.yearBuildingInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBuildingInput.Location = new System.Drawing.Point(404, 36);
            this.yearBuildingInput.Name = "yearBuildingInput";
            this.yearBuildingInput.Size = new System.Drawing.Size(46, 26);
            this.yearBuildingInput.TabIndex = 8;
            this.yearBuildingInput.TextChanged += new System.EventHandler(this.yearBuildingInput_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Поверховність";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "Матеріал дому";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(290, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Рік будування";
            // 
            // floorsBuildingInput
            // 
            this.floorsBuildingInput.Enabled = false;
            this.floorsBuildingInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorsBuildingInput.Location = new System.Drawing.Point(126, 36);
            this.floorsBuildingInput.Name = "floorsBuildingInput";
            this.floorsBuildingInput.Size = new System.Drawing.Size(141, 26);
            this.floorsBuildingInput.TabIndex = 6;
            this.floorsBuildingInput.TextChanged += new System.EventHandler(this.floorsBuildingInput_TextChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(749, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 22);
            this.label16.TabIndex = 9;
            this.label16.Text = "Ціна";
            // 
            // priceInput
            // 
            this.priceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInput.Location = new System.Drawing.Point(724, 148);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(98, 26);
            this.priceInput.TabIndex = 18;
            this.priceInput.TextChanged += new System.EventHandler(this.priceInput_TextChanged);
            // 
            // addImageButton
            // 
            this.addImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addImageButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageButton.Location = new System.Drawing.Point(690, 63);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(161, 54);
            this.addImageButton.TabIndex = 25;
            this.addImageButton.Text = "Додати зображення";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(879, 501);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.additionalPanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.typeDropdown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddObjectForm";
            this.Text = "AddObjectForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox districtDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox houseNumberInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox footageInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roomsAmountInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox floorsAmountInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox streetInput;
        private System.Windows.Forms.ComboBox streetDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel additionalPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox yearBuildingInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox floorsBuildingInput;
        private System.Windows.Forms.TextBox materialBuildinngInput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Button addImageButton;
    }
}