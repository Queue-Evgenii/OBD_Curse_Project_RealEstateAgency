
namespace RealEstateAgency
{
    partial class AuthorizationForm
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
            this.FormMainHeading = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.FormSubtitle = new System.Windows.Forms.Label();
            this.changeTypeButton = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // FormMainHeading
            // 
            this.FormMainHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormMainHeading.AutoSize = true;
            this.FormMainHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormMainHeading.Location = new System.Drawing.Point(241, 20);
            this.FormMainHeading.Name = "FormMainHeading";
            this.FormMainHeading.Size = new System.Drawing.Size(198, 27);
            this.FormMainHeading.TabIndex = 0;
            this.FormMainHeading.Text = "Створити акаунт";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Введіть електронну пошту";
            // 
            // emailInput
            // 
            this.emailInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailInput.BackColor = System.Drawing.SystemColors.Window;
            this.emailInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.ForeColor = System.Drawing.SystemColors.MenuText;
            this.emailInput.Location = new System.Drawing.Point(206, 88);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(274, 29);
            this.emailInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(206, 154);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(274, 29);
            this.passwordInput.TabIndex = 4;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть пароль";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(206, 204);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(274, 44);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Далі";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_click);
            // 
            // FormSubtitle
            // 
            this.FormSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormSubtitle.AutoSize = true;
            this.FormSubtitle.Font = new System.Drawing.Font("Arial", 11F);
            this.FormSubtitle.Location = new System.Drawing.Point(259, 255);
            this.FormSubtitle.Name = "FormSubtitle";
            this.FormSubtitle.Size = new System.Drawing.Size(104, 17);
            this.FormSubtitle.TabIndex = 6;
            this.FormSubtitle.Text = "Вже є акаунт?";
            // 
            // changeTypeButton
            // 
            this.changeTypeButton.ActiveLinkColor = System.Drawing.Color.Black;
            this.changeTypeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeTypeButton.AutoSize = true;
            this.changeTypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeTypeButton.Font = new System.Drawing.Font("Arial", 10F);
            this.changeTypeButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeTypeButton.Location = new System.Drawing.Point(369, 255);
            this.changeTypeButton.Name = "changeTypeButton";
            this.changeTypeButton.Size = new System.Drawing.Size(49, 16);
            this.changeTypeButton.TabIndex = 7;
            this.changeTypeButton.TabStop = true;
            this.changeTypeButton.Text = "Увійти";
            this.changeTypeButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeTypeButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changeTypeButton_Click);
            // 
            // AuthorizationForm
            // 
            this.ClientSize = new System.Drawing.Size(684, 327);
            this.Controls.Add(this.changeTypeButton);
            this.Controls.Add(this.FormSubtitle);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FormMainHeading);
            this.Name = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FormMainHeading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label FormSubtitle;
        private System.Windows.Forms.LinkLabel changeTypeButton;
    }
}