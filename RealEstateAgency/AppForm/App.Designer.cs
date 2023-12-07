
namespace RealEstateAgency
{
    partial class App
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
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.publicationListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моїПублікаціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персональніДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicationsListWrapper = new System.Windows.Forms.Panel();
            this.publicationsListLayout = new System.Windows.Forms.TableLayoutPanel();
            this.personalWrapper = new System.Windows.Forms.Panel();
            this.personalLayoutBox = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fnameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mnameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.savePersonalButton = new System.Windows.Forms.Button();
            this.FormMainHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeShowStatementWrapper = new System.Windows.Forms.Panel();
            this.dealListWrapper = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dealListLayout = new System.Windows.Forms.TableLayoutPanel();
            this.plannedStatementWrapper = new System.Windows.Forms.Panel();
            this.futureCheckWrapper = new System.Windows.Forms.Label();
            this.plannedStatementLayout = new System.Windows.Forms.TableLayoutPanel();
            this.acceptStatementsWrapper = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.acceptStatementsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.clientShowStatementWrapper = new System.Windows.Forms.Panel();
            this.clientDealListWrapper = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.clientDealListLayout = new System.Windows.Forms.TableLayoutPanel();
            this.clientStatementWrapper = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.clientStatementListLayout = new System.Windows.Forms.TableLayoutPanel();
            this.myPublicationsWrapper = new System.Windows.Forms.Panel();
            this.myPublicationsHeaderLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.myPublicationsListWrapper = new System.Windows.Forms.Panel();
            this.myPublicationsListLayout = new System.Windows.Forms.TableLayoutPanel();
            this.publicationsWrapper = new System.Windows.Forms.Panel();
            this.publicationsListHeaderLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.statisticWrapper = new System.Windows.Forms.Panel();
            this.statisticLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.topMenu.SuspendLayout();
            this.publicationsListWrapper.SuspendLayout();
            this.personalWrapper.SuspendLayout();
            this.personalLayoutBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.employeeShowStatementWrapper.SuspendLayout();
            this.dealListWrapper.SuspendLayout();
            this.plannedStatementWrapper.SuspendLayout();
            this.acceptStatementsWrapper.SuspendLayout();
            this.clientShowStatementWrapper.SuspendLayout();
            this.clientDealListWrapper.SuspendLayout();
            this.clientStatementWrapper.SuspendLayout();
            this.myPublicationsWrapper.SuspendLayout();
            this.myPublicationsListWrapper.SuspendLayout();
            this.publicationsWrapper.SuspendLayout();
            this.statisticWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicationListMenuItem,
            this.моїПублікаціїToolStripMenuItem,
            this.персональніДаніToolStripMenuItem,
            this.заявиToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1458, 24);
            this.topMenu.TabIndex = 2;
            this.topMenu.Text = "menuStrip1";
            // 
            // publicationListMenuItem
            // 
            this.publicationListMenuItem.Name = "publicationListMenuItem";
            this.publicationListMenuItem.Size = new System.Drawing.Size(133, 20);
            this.publicationListMenuItem.Text = "Перегляд публікацій";
            this.publicationListMenuItem.Click += new System.EventHandler(this.publicationListMenuItem_click);
            // 
            // моїПублікаціїToolStripMenuItem
            // 
            this.моїПублікаціїToolStripMenuItem.Name = "моїПублікаціїToolStripMenuItem";
            this.моїПублікаціїToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.моїПублікаціїToolStripMenuItem.Text = "Мої публікації";
            this.моїПублікаціїToolStripMenuItem.Click += new System.EventHandler(this.myPublicationsMenuItem_click);
            // 
            // персональніДаніToolStripMenuItem
            // 
            this.персональніДаніToolStripMenuItem.Name = "персональніДаніToolStripMenuItem";
            this.персональніДаніToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.персональніДаніToolStripMenuItem.Text = "Персональні дані";
            this.персональніДаніToolStripMenuItem.Click += new System.EventHandler(this.personalMenuItem_click);
            // 
            // заявиToolStripMenuItem
            // 
            this.заявиToolStripMenuItem.Name = "заявиToolStripMenuItem";
            this.заявиToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.заявиToolStripMenuItem.Text = "Заяви та угоди";
            this.заявиToolStripMenuItem.Click += new System.EventHandler(this.showStatementMenuItem_click);
            // 
            // publicationsListWrapper
            // 
            this.publicationsListWrapper.AutoScroll = true;
            this.publicationsListWrapper.AutoSize = true;
            this.publicationsListWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.publicationsListWrapper.Controls.Add(this.publicationsListLayout);
            this.publicationsListWrapper.Location = new System.Drawing.Point(9, 197);
            this.publicationsListWrapper.MaximumSize = new System.Drawing.Size(0, 300);
            this.publicationsListWrapper.Name = "publicationsListWrapper";
            this.publicationsListWrapper.Size = new System.Drawing.Size(131, 131);
            this.publicationsListWrapper.TabIndex = 9;
            // 
            // publicationsListLayout
            // 
            this.publicationsListLayout.AutoSize = true;
            this.publicationsListLayout.BackColor = System.Drawing.SystemColors.Window;
            this.publicationsListLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.publicationsListLayout.ColumnCount = 3;
            this.publicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.publicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.publicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.publicationsListLayout.Location = new System.Drawing.Point(4, 3);
            this.publicationsListLayout.Name = "publicationsListLayout";
            this.publicationsListLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.publicationsListLayout.RowCount = 1;
            this.publicationsListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.publicationsListLayout.Size = new System.Drawing.Size(124, 125);
            this.publicationsListLayout.TabIndex = 5;
            this.publicationsListLayout.Visible = false;
            // 
            // personalWrapper
            // 
            this.personalWrapper.AutoSize = true;
            this.personalWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.personalWrapper.Controls.Add(this.personalLayoutBox);
            this.personalWrapper.Location = new System.Drawing.Point(2, 43);
            this.personalWrapper.Name = "personalWrapper";
            this.personalWrapper.Size = new System.Drawing.Size(291, 315);
            this.personalWrapper.TabIndex = 6;
            // 
            // personalLayoutBox
            // 
            this.personalLayoutBox.AllowDrop = true;
            this.personalLayoutBox.AutoSize = true;
            this.personalLayoutBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.personalLayoutBox.Controls.Add(this.label1);
            this.personalLayoutBox.Controls.Add(this.fnameInput);
            this.personalLayoutBox.Controls.Add(this.label2);
            this.personalLayoutBox.Controls.Add(this.lnameInput);
            this.personalLayoutBox.Controls.Add(this.label3);
            this.personalLayoutBox.Controls.Add(this.mnameInput);
            this.personalLayoutBox.Controls.Add(this.label5);
            this.personalLayoutBox.Controls.Add(this.phoneInput);
            this.personalLayoutBox.Controls.Add(this.label4);
            this.personalLayoutBox.Controls.Add(this.addressInput);
            this.personalLayoutBox.Controls.Add(this.savePersonalButton);
            this.personalLayoutBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.personalLayoutBox.Location = new System.Drawing.Point(3, 3);
            this.personalLayoutBox.Name = "personalLayoutBox";
            this.personalLayoutBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personalLayoutBox.Size = new System.Drawing.Size(285, 309);
            this.personalLayoutBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ім\'я";
            // 
            // fnameInput
            // 
            this.fnameInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameInput.Location = new System.Drawing.Point(3, 21);
            this.fnameInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.fnameInput.Name = "fnameInput";
            this.fnameInput.Size = new System.Drawing.Size(279, 22);
            this.fnameInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Прізвище";
            // 
            // lnameInput
            // 
            this.lnameInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameInput.Location = new System.Drawing.Point(3, 74);
            this.lnameInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.lnameInput.Name = "lnameInput";
            this.lnameInput.Size = new System.Drawing.Size(279, 22);
            this.lnameInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "По батькові";
            // 
            // mnameInput
            // 
            this.mnameInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnameInput.Location = new System.Drawing.Point(3, 127);
            this.mnameInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.mnameInput.Name = "mnameInput";
            this.mnameInput.Size = new System.Drawing.Size(279, 22);
            this.mnameInput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер телефона";
            // 
            // phoneInput
            // 
            this.phoneInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneInput.Location = new System.Drawing.Point(3, 180);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(279, 22);
            this.phoneInput.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адреса";
            // 
            // addressInput
            // 
            this.addressInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressInput.Location = new System.Drawing.Point(3, 233);
            this.addressInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(279, 22);
            this.addressInput.TabIndex = 9;
            // 
            // savePersonalButton
            // 
            this.savePersonalButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.savePersonalButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savePersonalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePersonalButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePersonalButton.Location = new System.Drawing.Point(67, 268);
            this.savePersonalButton.Name = "savePersonalButton";
            this.savePersonalButton.Size = new System.Drawing.Size(150, 38);
            this.savePersonalButton.TabIndex = 12;
            this.savePersonalButton.Text = "Зберегти";
            this.savePersonalButton.UseVisualStyleBackColor = true;
            this.savePersonalButton.Click += new System.EventHandler(this.savePersonalButton_click);
            // 
            // FormMainHeading
            // 
            this.FormMainHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormMainHeading.AutoSize = true;
            this.FormMainHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormMainHeading.Location = new System.Drawing.Point(623, 13);
            this.FormMainHeading.Name = "FormMainHeading";
            this.FormMainHeading.Size = new System.Drawing.Size(204, 27);
            this.FormMainHeading.TabIndex = 1;
            this.FormMainHeading.Text = "Персональні дані";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.statisticWrapper);
            this.groupBox1.Controls.Add(this.employeeShowStatementWrapper);
            this.groupBox1.Controls.Add(this.clientShowStatementWrapper);
            this.groupBox1.Controls.Add(this.myPublicationsWrapper);
            this.groupBox1.Controls.Add(this.publicationsWrapper);
            this.groupBox1.Controls.Add(this.personalWrapper);
            this.groupBox1.Controls.Add(this.FormMainHeading);
            this.groupBox1.Location = new System.Drawing.Point(0, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1461, 595);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // employeeShowStatementWrapper
            // 
            this.employeeShowStatementWrapper.AutoScroll = true;
            this.employeeShowStatementWrapper.AutoSize = true;
            this.employeeShowStatementWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.employeeShowStatementWrapper.Controls.Add(this.dealListWrapper);
            this.employeeShowStatementWrapper.Controls.Add(this.plannedStatementWrapper);
            this.employeeShowStatementWrapper.Controls.Add(this.acceptStatementsWrapper);
            this.employeeShowStatementWrapper.Location = new System.Drawing.Point(866, 49);
            this.employeeShowStatementWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.employeeShowStatementWrapper.Name = "employeeShowStatementWrapper";
            this.employeeShowStatementWrapper.Size = new System.Drawing.Size(290, 533);
            this.employeeShowStatementWrapper.TabIndex = 13;
            this.employeeShowStatementWrapper.Visible = false;
            // 
            // dealListWrapper
            // 
            this.dealListWrapper.AutoScroll = true;
            this.dealListWrapper.AutoSize = true;
            this.dealListWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dealListWrapper.Controls.Add(this.label9);
            this.dealListWrapper.Controls.Add(this.dealListLayout);
            this.dealListWrapper.Enabled = false;
            this.dealListWrapper.Location = new System.Drawing.Point(12, 347);
            this.dealListWrapper.MaximumSize = new System.Drawing.Size(0, 300);
            this.dealListWrapper.Name = "dealListWrapper";
            this.dealListWrapper.Size = new System.Drawing.Size(141, 183);
            this.dealListWrapper.TabIndex = 11;
            this.dealListWrapper.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Укладені угоди";
            // 
            // dealListLayout
            // 
            this.dealListLayout.AutoSize = true;
            this.dealListLayout.BackColor = System.Drawing.SystemColors.Window;
            this.dealListLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.dealListLayout.ColumnCount = 3;
            this.dealListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.36961F));
            this.dealListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.3696F));
            this.dealListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26079F));
            this.dealListLayout.Enabled = false;
            this.dealListLayout.Location = new System.Drawing.Point(3, 25);
            this.dealListLayout.Name = "dealListLayout";
            this.dealListLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.dealListLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dealListLayout.RowCount = 1;
            this.dealListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.dealListLayout.Size = new System.Drawing.Size(134, 155);
            this.dealListLayout.TabIndex = 5;
            this.dealListLayout.Visible = false;
            // 
            // plannedStatementWrapper
            // 
            this.plannedStatementWrapper.AutoScroll = true;
            this.plannedStatementWrapper.AutoSize = true;
            this.plannedStatementWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plannedStatementWrapper.Controls.Add(this.futureCheckWrapper);
            this.plannedStatementWrapper.Controls.Add(this.plannedStatementLayout);
            this.plannedStatementWrapper.Enabled = false;
            this.plannedStatementWrapper.Location = new System.Drawing.Point(0, 160);
            this.plannedStatementWrapper.MaximumSize = new System.Drawing.Size(0, 300);
            this.plannedStatementWrapper.Name = "plannedStatementWrapper";
            this.plannedStatementWrapper.Size = new System.Drawing.Size(182, 183);
            this.plannedStatementWrapper.TabIndex = 10;
            this.plannedStatementWrapper.Visible = false;
            // 
            // futureCheckWrapper
            // 
            this.futureCheckWrapper.AutoSize = true;
            this.futureCheckWrapper.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureCheckWrapper.Location = new System.Drawing.Point(0, 0);
            this.futureCheckWrapper.Name = "futureCheckWrapper";
            this.futureCheckWrapper.Size = new System.Drawing.Size(179, 22);
            this.futureCheckWrapper.TabIndex = 7;
            this.futureCheckWrapper.Text = "Заплановані огляди";
            // 
            // plannedStatementLayout
            // 
            this.plannedStatementLayout.AutoSize = true;
            this.plannedStatementLayout.BackColor = System.Drawing.SystemColors.Window;
            this.plannedStatementLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.plannedStatementLayout.ColumnCount = 3;
            this.plannedStatementLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.36961F));
            this.plannedStatementLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.3696F));
            this.plannedStatementLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26079F));
            this.plannedStatementLayout.Enabled = false;
            this.plannedStatementLayout.Location = new System.Drawing.Point(3, 25);
            this.plannedStatementLayout.Name = "plannedStatementLayout";
            this.plannedStatementLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.plannedStatementLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.plannedStatementLayout.RowCount = 1;
            this.plannedStatementLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.plannedStatementLayout.Size = new System.Drawing.Size(134, 155);
            this.plannedStatementLayout.TabIndex = 5;
            this.plannedStatementLayout.Visible = false;
            // 
            // acceptStatementsWrapper
            // 
            this.acceptStatementsWrapper.AutoScroll = true;
            this.acceptStatementsWrapper.AutoSize = true;
            this.acceptStatementsWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.acceptStatementsWrapper.Controls.Add(this.label11);
            this.acceptStatementsWrapper.Controls.Add(this.acceptStatementsLayout);
            this.acceptStatementsWrapper.Enabled = false;
            this.acceptStatementsWrapper.Location = new System.Drawing.Point(3, 7);
            this.acceptStatementsWrapper.MaximumSize = new System.Drawing.Size(0, 300);
            this.acceptStatementsWrapper.Name = "acceptStatementsWrapper";
            this.acceptStatementsWrapper.Size = new System.Drawing.Size(284, 183);
            this.acceptStatementsWrapper.TabIndex = 9;
            this.acceptStatementsWrapper.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-3, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 22);
            this.label11.TabIndex = 8;
            this.label11.Text = "Заяви на підтвердження огляду";
            // 
            // acceptStatementsLayout
            // 
            this.acceptStatementsLayout.AutoSize = true;
            this.acceptStatementsLayout.BackColor = System.Drawing.SystemColors.Window;
            this.acceptStatementsLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.acceptStatementsLayout.ColumnCount = 3;
            this.acceptStatementsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.26535F));
            this.acceptStatementsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.26535F));
            this.acceptStatementsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.4693F));
            this.acceptStatementsLayout.Enabled = false;
            this.acceptStatementsLayout.Location = new System.Drawing.Point(3, 25);
            this.acceptStatementsLayout.Name = "acceptStatementsLayout";
            this.acceptStatementsLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.acceptStatementsLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.acceptStatementsLayout.RowCount = 1;
            this.acceptStatementsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.acceptStatementsLayout.Size = new System.Drawing.Size(119, 155);
            this.acceptStatementsLayout.TabIndex = 5;
            this.acceptStatementsLayout.Visible = false;
            // 
            // clientShowStatementWrapper
            // 
            this.clientShowStatementWrapper.AutoScroll = true;
            this.clientShowStatementWrapper.AutoSize = true;
            this.clientShowStatementWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientShowStatementWrapper.Controls.Add(this.clientDealListWrapper);
            this.clientShowStatementWrapper.Controls.Add(this.clientStatementWrapper);
            this.clientShowStatementWrapper.Location = new System.Drawing.Point(642, 48);
            this.clientShowStatementWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.clientShowStatementWrapper.Name = "clientShowStatementWrapper";
            this.clientShowStatementWrapper.Size = new System.Drawing.Size(190, 377);
            this.clientShowStatementWrapper.TabIndex = 12;
            this.clientShowStatementWrapper.Visible = false;
            // 
            // clientDealListWrapper
            // 
            this.clientDealListWrapper.AutoScroll = true;
            this.clientDealListWrapper.AutoSize = true;
            this.clientDealListWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientDealListWrapper.Controls.Add(this.label6);
            this.clientDealListWrapper.Controls.Add(this.clientDealListLayout);
            this.clientDealListWrapper.Enabled = false;
            this.clientDealListWrapper.Location = new System.Drawing.Point(3, 191);
            this.clientDealListWrapper.MaximumSize = new System.Drawing.Size(0, 300);
            this.clientDealListWrapper.Name = "clientDealListWrapper";
            this.clientDealListWrapper.Size = new System.Drawing.Size(140, 183);
            this.clientDealListWrapper.TabIndex = 11;
            this.clientDealListWrapper.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ваші угоди";
            // 
            // clientDealListLayout
            // 
            this.clientDealListLayout.AutoSize = true;
            this.clientDealListLayout.BackColor = System.Drawing.SystemColors.Window;
            this.clientDealListLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.clientDealListLayout.ColumnCount = 3;
            this.clientDealListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.36961F));
            this.clientDealListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.3696F));
            this.clientDealListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26079F));
            this.clientDealListLayout.Enabled = false;
            this.clientDealListLayout.Location = new System.Drawing.Point(3, 25);
            this.clientDealListLayout.Name = "clientDealListLayout";
            this.clientDealListLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.clientDealListLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientDealListLayout.RowCount = 1;
            this.clientDealListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.clientDealListLayout.Size = new System.Drawing.Size(134, 155);
            this.clientDealListLayout.TabIndex = 5;
            this.clientDealListLayout.Visible = false;
            // 
            // clientStatementWrapper
            // 
            this.clientStatementWrapper.AutoScroll = true;
            this.clientStatementWrapper.AutoSize = true;
            this.clientStatementWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientStatementWrapper.Controls.Add(this.label7);
            this.clientStatementWrapper.Controls.Add(this.clientStatementListLayout);
            this.clientStatementWrapper.Enabled = false;
            this.clientStatementWrapper.Location = new System.Drawing.Point(0, 4);
            this.clientStatementWrapper.MaximumSize = new System.Drawing.Size(0, 300);
            this.clientStatementWrapper.Name = "clientStatementWrapper";
            this.clientStatementWrapper.Size = new System.Drawing.Size(187, 183);
            this.clientStatementWrapper.TabIndex = 10;
            this.clientStatementWrapper.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ваші заяви на огляд";
            // 
            // clientStatementListLayout
            // 
            this.clientStatementListLayout.AutoSize = true;
            this.clientStatementListLayout.BackColor = System.Drawing.SystemColors.Window;
            this.clientStatementListLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.clientStatementListLayout.ColumnCount = 3;
            this.clientStatementListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.36961F));
            this.clientStatementListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.3696F));
            this.clientStatementListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26079F));
            this.clientStatementListLayout.Enabled = false;
            this.clientStatementListLayout.Location = new System.Drawing.Point(3, 25);
            this.clientStatementListLayout.Name = "clientStatementListLayout";
            this.clientStatementListLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.clientStatementListLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientStatementListLayout.RowCount = 1;
            this.clientStatementListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.clientStatementListLayout.Size = new System.Drawing.Size(134, 155);
            this.clientStatementListLayout.TabIndex = 5;
            this.clientStatementListLayout.Visible = false;
            // 
            // myPublicationsWrapper
            // 
            this.myPublicationsWrapper.AutoSize = true;
            this.myPublicationsWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.myPublicationsWrapper.Controls.Add(this.myPublicationsHeaderLayout);
            this.myPublicationsWrapper.Controls.Add(this.myPublicationsListWrapper);
            this.myPublicationsWrapper.Location = new System.Drawing.Point(481, 49);
            this.myPublicationsWrapper.Name = "myPublicationsWrapper";
            this.myPublicationsWrapper.Size = new System.Drawing.Size(138, 331);
            this.myPublicationsWrapper.TabIndex = 11;
            this.myPublicationsWrapper.Visible = false;
            // 
            // myPublicationsHeaderLayout
            // 
            this.myPublicationsHeaderLayout.AutoSize = true;
            this.myPublicationsHeaderLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.myPublicationsHeaderLayout.BackColor = System.Drawing.SystemColors.Window;
            this.myPublicationsHeaderLayout.Location = new System.Drawing.Point(3, 3);
            this.myPublicationsHeaderLayout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.myPublicationsHeaderLayout.MinimumSize = new System.Drawing.Size(100, 50);
            this.myPublicationsHeaderLayout.Name = "myPublicationsHeaderLayout";
            this.myPublicationsHeaderLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myPublicationsHeaderLayout.Size = new System.Drawing.Size(100, 50);
            this.myPublicationsHeaderLayout.TabIndex = 6;
            // 
            // myPublicationsListWrapper
            // 
            this.myPublicationsListWrapper.AutoScroll = true;
            this.myPublicationsListWrapper.AutoSize = true;
            this.myPublicationsListWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.myPublicationsListWrapper.Controls.Add(this.myPublicationsListLayout);
            this.myPublicationsListWrapper.Location = new System.Drawing.Point(9, 197);
            this.myPublicationsListWrapper.MaximumSize = new System.Drawing.Size(0, 300);
            this.myPublicationsListWrapper.Name = "myPublicationsListWrapper";
            this.myPublicationsListWrapper.Size = new System.Drawing.Size(126, 131);
            this.myPublicationsListWrapper.TabIndex = 9;
            // 
            // myPublicationsListLayout
            // 
            this.myPublicationsListLayout.AutoSize = true;
            this.myPublicationsListLayout.BackColor = System.Drawing.SystemColors.Window;
            this.myPublicationsListLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.myPublicationsListLayout.ColumnCount = 3;
            this.myPublicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.myPublicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.myPublicationsListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.myPublicationsListLayout.Location = new System.Drawing.Point(4, 3);
            this.myPublicationsListLayout.Name = "myPublicationsListLayout";
            this.myPublicationsListLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myPublicationsListLayout.RowCount = 1;
            this.myPublicationsListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.myPublicationsListLayout.Size = new System.Drawing.Size(119, 125);
            this.myPublicationsListLayout.TabIndex = 5;
            this.myPublicationsListLayout.Visible = false;
            // 
            // publicationsWrapper
            // 
            this.publicationsWrapper.AutoSize = true;
            this.publicationsWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.publicationsWrapper.Controls.Add(this.publicationsListHeaderLayout);
            this.publicationsWrapper.Controls.Add(this.publicationsListWrapper);
            this.publicationsWrapper.Location = new System.Drawing.Point(299, 46);
            this.publicationsWrapper.Name = "publicationsWrapper";
            this.publicationsWrapper.Size = new System.Drawing.Size(143, 331);
            this.publicationsWrapper.TabIndex = 10;
            this.publicationsWrapper.Visible = false;
            // 
            // publicationsListHeaderLayout
            // 
            this.publicationsListHeaderLayout.AutoSize = true;
            this.publicationsListHeaderLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.publicationsListHeaderLayout.BackColor = System.Drawing.SystemColors.Window;
            this.publicationsListHeaderLayout.Location = new System.Drawing.Point(3, 3);
            this.publicationsListHeaderLayout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.publicationsListHeaderLayout.MinimumSize = new System.Drawing.Size(100, 50);
            this.publicationsListHeaderLayout.Name = "publicationsListHeaderLayout";
            this.publicationsListHeaderLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.publicationsListHeaderLayout.Size = new System.Drawing.Size(100, 50);
            this.publicationsListHeaderLayout.TabIndex = 6;
            // 
            // statisticWrapper
            // 
            this.statisticWrapper.AutoSize = true;
            this.statisticWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statisticWrapper.Controls.Add(this.statisticLayout);
            this.statisticWrapper.Location = new System.Drawing.Point(1198, 43);
            this.statisticWrapper.Name = "statisticWrapper";
            this.statisticWrapper.Size = new System.Drawing.Size(106, 63);
            this.statisticWrapper.TabIndex = 14;
            this.statisticWrapper.Visible = false;
            // 
            // statisticLayout
            // 
            this.statisticLayout.AutoSize = true;
            this.statisticLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statisticLayout.BackColor = System.Drawing.SystemColors.Window;
            this.statisticLayout.Location = new System.Drawing.Point(3, 3);
            this.statisticLayout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.statisticLayout.MinimumSize = new System.Drawing.Size(100, 50);
            this.statisticLayout.Name = "statisticLayout";
            this.statisticLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statisticLayout.Size = new System.Drawing.Size(100, 50);
            this.statisticLayout.TabIndex = 6;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 450);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.topMenu;
            this.Name = "App";
            this.Text = "Application";
            this.Resize += new System.EventHandler(this.app_resize);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.publicationsListWrapper.ResumeLayout(false);
            this.publicationsListWrapper.PerformLayout();
            this.personalWrapper.ResumeLayout(false);
            this.personalWrapper.PerformLayout();
            this.personalLayoutBox.ResumeLayout(false);
            this.personalLayoutBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.employeeShowStatementWrapper.ResumeLayout(false);
            this.employeeShowStatementWrapper.PerformLayout();
            this.dealListWrapper.ResumeLayout(false);
            this.dealListWrapper.PerformLayout();
            this.plannedStatementWrapper.ResumeLayout(false);
            this.plannedStatementWrapper.PerformLayout();
            this.acceptStatementsWrapper.ResumeLayout(false);
            this.acceptStatementsWrapper.PerformLayout();
            this.clientShowStatementWrapper.ResumeLayout(false);
            this.clientShowStatementWrapper.PerformLayout();
            this.clientDealListWrapper.ResumeLayout(false);
            this.clientDealListWrapper.PerformLayout();
            this.clientStatementWrapper.ResumeLayout(false);
            this.clientStatementWrapper.PerformLayout();
            this.myPublicationsWrapper.ResumeLayout(false);
            this.myPublicationsWrapper.PerformLayout();
            this.myPublicationsListWrapper.ResumeLayout(false);
            this.myPublicationsListWrapper.PerformLayout();
            this.publicationsWrapper.ResumeLayout(false);
            this.publicationsWrapper.PerformLayout();
            this.statisticWrapper.ResumeLayout(false);
            this.statisticWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem publicationListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моїПублікаціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персональніДаніToolStripMenuItem;
        private System.Windows.Forms.Label FormMainHeading;
        private System.Windows.Forms.Panel personalWrapper;
        private System.Windows.Forms.FlowLayoutPanel personalLayoutBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lnameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mnameInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Button savePersonalButton;
        private System.Windows.Forms.Panel publicationsListWrapper;
        private System.Windows.Forms.TableLayoutPanel publicationsListLayout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel publicationsListHeaderLayout;
        private System.Windows.Forms.Panel publicationsWrapper;
        private System.Windows.Forms.Panel myPublicationsWrapper;
        private System.Windows.Forms.FlowLayoutPanel myPublicationsHeaderLayout;
        private System.Windows.Forms.Panel myPublicationsListWrapper;
        private System.Windows.Forms.TableLayoutPanel myPublicationsListLayout;
        private System.Windows.Forms.Panel clientShowStatementWrapper;
        private System.Windows.Forms.ToolStripMenuItem заявиToolStripMenuItem;
        private System.Windows.Forms.Panel clientStatementWrapper;
        private System.Windows.Forms.TableLayoutPanel clientStatementListLayout;
        private System.Windows.Forms.Panel clientDealListWrapper;
        private System.Windows.Forms.TableLayoutPanel clientDealListLayout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel employeeShowStatementWrapper;
        private System.Windows.Forms.Panel dealListWrapper;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel dealListLayout;
        private System.Windows.Forms.Panel plannedStatementWrapper;
        private System.Windows.Forms.Label futureCheckWrapper;
        private System.Windows.Forms.TableLayoutPanel plannedStatementLayout;
        private System.Windows.Forms.Panel acceptStatementsWrapper;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel acceptStatementsLayout;
        private System.Windows.Forms.Panel statisticWrapper;
        private System.Windows.Forms.FlowLayoutPanel statisticLayout;
    }
}