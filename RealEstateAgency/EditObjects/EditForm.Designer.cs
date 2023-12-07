
namespace RealEstateAgency
{
    partial class EditForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.footageInput = new System.Windows.Forms.TextBox();
            this.floorsAmountInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roomsAmountInput = new System.Windows.Forms.TextBox();
            this.additionalPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 151);
            this.panel1.TabIndex = 19;
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
            // footageInput
            // 
            this.footageInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footageInput.Location = new System.Drawing.Point(147, 42);
            this.footageInput.Name = "footageInput";
            this.footageInput.Size = new System.Drawing.Size(98, 26);
            this.footageInput.TabIndex = 11;
            this.footageInput.TextChanged += new System.EventHandler(this.footageInput_TextChanged);
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
            // roomsAmountInput
            // 
            this.roomsAmountInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsAmountInput.Location = new System.Drawing.Point(147, 74);
            this.roomsAmountInput.Name = "roomsAmountInput";
            this.roomsAmountInput.Size = new System.Drawing.Size(98, 26);
            this.roomsAmountInput.TabIndex = 13;
            this.roomsAmountInput.TextChanged += new System.EventHandler(this.roomsAmountInput_TextChanged);
            // 
            // additionalPanel
            // 
            this.additionalPanel.AutoSize = true;
            this.additionalPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.additionalPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.additionalPanel.Location = new System.Drawing.Point(10, 209);
            this.additionalPanel.MaximumSize = new System.Drawing.Size(523, 500);
            this.additionalPanel.MinimumSize = new System.Drawing.Size(200, 40);
            this.additionalPanel.Name = "additionalPanel";
            this.additionalPanel.Size = new System.Drawing.Size(200, 40);
            this.additionalPanel.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Тип нерухомості";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(146, 177);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(37, 18);
            this.typeLabel.TabIndex = 26;
            this.typeLabel.Text = "type";
            // 
            // priceInput
            // 
            this.priceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInput.Location = new System.Drawing.Point(627, 102);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(161, 26);
            this.priceInput.TabIndex = 28;
            this.priceInput.TextChanged += new System.EventHandler(this.priceInput_TextChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(686, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 22);
            this.label16.TabIndex = 27;
            this.label16.Text = "Ціна";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(627, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(161, 51);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.additionalPanel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Name = "EditForm";
            this.Text = "EditObjectForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox footageInput;
        private System.Windows.Forms.TextBox floorsAmountInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox roomsAmountInput;
        private System.Windows.Forms.FlowLayoutPanel additionalPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button saveButton;
    }
}