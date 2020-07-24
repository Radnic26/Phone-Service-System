using System.Windows.Forms;

namespace FinalProject
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelTelephone = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.TelephoneTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtraOption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceEO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.InfoSButton = new System.Windows.Forms.Button();
            this.InfoEButton = new System.Windows.Forms.Button();
            this.SubscriptionCombo = new System.Windows.Forms.ComboBox();
            this.ExtraCombo = new System.Windows.Forms.ComboBox();
            this.NameErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgeErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.CityErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.TelephoneErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscriptionChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraOptionChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NameErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneErr)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Location = new System.Drawing.Point(12, 56);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.BackColor = System.Drawing.Color.Transparent;
            this.LabelAge.Location = new System.Drawing.Point(12, 93);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(26, 13);
            this.LabelAge.TabIndex = 1;
            this.LabelAge.Text = "Age";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Location = new System.Drawing.Point(12, 130);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(32, 13);
            this.LabelEmail.TabIndex = 2;
            this.LabelEmail.Text = "Email";
            // 
            // LabelTelephone
            // 
            this.LabelTelephone.AutoSize = true;
            this.LabelTelephone.BackColor = System.Drawing.Color.Transparent;
            this.LabelTelephone.Location = new System.Drawing.Point(266, 93);
            this.LabelTelephone.Name = "LabelTelephone";
            this.LabelTelephone.Size = new System.Drawing.Size(58, 13);
            this.LabelTelephone.TabIndex = 3;
            this.LabelTelephone.Text = "Telephone";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.BackColor = System.Drawing.Color.Transparent;
            this.LabelCity.Location = new System.Drawing.Point(266, 56);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(24, 13);
            this.LabelCity.TabIndex = 4;
            this.LabelCity.Text = "City";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(67, 53);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(121, 20);
            this.NameTB.TabIndex = 5;
            this.NameTB.Validating += new System.ComponentModel.CancelEventHandler(this.NameTB_Validating_1);
            this.NameTB.Validated += new System.EventHandler(this.NameTB_Validated);
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(67, 127);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(121, 20);
            this.EmailTB.TabIndex = 6;
            this.EmailTB.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTB_Validating);
            this.EmailTB.Validated += new System.EventHandler(this.EmailTB_Validated);
            // 
            // CityTB
            // 
            this.CityTB.Location = new System.Drawing.Point(340, 53);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(121, 20);
            this.CityTB.TabIndex = 7;
            this.CityTB.Validating += new System.ComponentModel.CancelEventHandler(this.CityTB_Validating);
            this.CityTB.Validated += new System.EventHandler(this.CityTB_Validated);
            // 
            // TelephoneTB
            // 
            this.TelephoneTB.Location = new System.Drawing.Point(340, 90);
            this.TelephoneTB.Name = "TelephoneTB";
            this.TelephoneTB.Size = new System.Drawing.Size(121, 20);
            this.TelephoneTB.TabIndex = 8;
            this.TelephoneTB.Validating += new System.ComponentModel.CancelEventHandler(this.TelephoneTB_Validating);
            this.TelephoneTB.Validated += new System.EventHandler(this.TelephoneTB_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(522, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ExtraOption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(522, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Subscription";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.listView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView.BackgroundImage")));
            this.listView.BackgroundImageTiled = true;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Age,
            this.Email,
            this.City,
            this.Telephone,
            this.Subscription,
            this.PriceS,
            this.ExtraOption,
            this.PriceEO});
            this.listView.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(15, 211);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(769, 419);
            this.listView.TabIndex = 19;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 90;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Age.Width = 35;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 99;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.City.Width = 91;
            // 
            // Telephone
            // 
            this.Telephone.Text = "Telephone";
            this.Telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telephone.Width = 93;
            // 
            // Subscription
            // 
            this.Subscription.Text = "Subscription";
            this.Subscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Subscription.Width = 110;
            // 
            // PriceS
            // 
            this.PriceS.Text = "Price(EUR)";
            this.PriceS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceS.Width = 65;
            // 
            // ExtraOption
            // 
            this.ExtraOption.Text = "ExtraOption";
            this.ExtraOption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExtraOption.Width = 120;
            // 
            // PriceEO
            // 
            this.PriceEO.Text = "Price(EUR)";
            this.PriceEO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceEO.Width = 65;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(594, 150);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(190, 23);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add Client";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // InfoSButton
            // 
            this.InfoSButton.Location = new System.Drawing.Point(733, 53);
            this.InfoSButton.Name = "InfoSButton";
            this.InfoSButton.Size = new System.Drawing.Size(51, 21);
            this.InfoSButton.TabIndex = 23;
            this.InfoSButton.Text = "Info";
            this.InfoSButton.UseVisualStyleBackColor = true;
            this.InfoSButton.Click += new System.EventHandler(this.InfoSButton_Click);
            // 
            // InfoEButton
            // 
            this.InfoEButton.Location = new System.Drawing.Point(733, 92);
            this.InfoEButton.Name = "InfoEButton";
            this.InfoEButton.Size = new System.Drawing.Size(51, 22);
            this.InfoEButton.TabIndex = 24;
            this.InfoEButton.Text = "Info";
            this.InfoEButton.UseVisualStyleBackColor = true;
            this.InfoEButton.Click += new System.EventHandler(this.InfoEButton_Click);
            // 
            // SubscriptionCombo
            // 
            this.SubscriptionCombo.FormattingEnabled = true;
            this.SubscriptionCombo.Items.AddRange(new object[] {
            "Smart Student",
            "Busy BusinessMan",
            "Mega Extra Premium"});
            this.SubscriptionCombo.Location = new System.Drawing.Point(594, 53);
            this.SubscriptionCombo.Name = "SubscriptionCombo";
            this.SubscriptionCombo.Size = new System.Drawing.Size(121, 21);
            this.SubscriptionCombo.TabIndex = 25;
            // 
            // ExtraCombo
            // 
            this.ExtraCombo.FormattingEnabled = true;
            this.ExtraCombo.Items.AddRange(new object[] {
            "Internet pe Mobil",
            "Muzica si Video",
            "Minute si SMS Nationale",
            "-"});
            this.ExtraCombo.Location = new System.Drawing.Point(594, 94);
            this.ExtraCombo.Name = "ExtraCombo";
            this.ExtraCombo.Size = new System.Drawing.Size(121, 21);
            this.ExtraCombo.TabIndex = 26;
            // 
            // NameErr
            // 
            this.NameErr.ContainerControl = this;
            // 
            // AgeErr
            // 
            this.AgeErr.ContainerControl = this;
            // 
            // EmailErr
            // 
            this.EmailErr.ContainerControl = this;
            // 
            // CityErr
            // 
            this.CityErr.ContainerControl = this;
            // 
            // TelephoneErr
            // 
            this.TelephoneErr.ContainerControl = this;
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(67, 90);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(121, 20);
            this.AgeTB.TabIndex = 29;
            this.AgeTB.Validating += new System.ComponentModel.CancelEventHandler(this.AgeTB_Validating);
            this.AgeTB.Validated += new System.EventHandler(this.AgeTB_Validated);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "Final Project";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel2.Text = "Niculae Radu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.textToolStripMenuItem,
            this.printToolStripMenuItem,
            this.chartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click_1);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click_1);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click_1);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subscriptionChartToolStripMenuItem,
            this.extraOptionChartToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // subscriptionChartToolStripMenuItem
            // 
            this.subscriptionChartToolStripMenuItem.Name = "subscriptionChartToolStripMenuItem";
            this.subscriptionChartToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.subscriptionChartToolStripMenuItem.Text = "Subscription Chart";
            this.subscriptionChartToolStripMenuItem.Click += new System.EventHandler(this.subscriptionChartToolStripMenuItem_Click);
            // 
            // extraOptionChartToolStripMenuItem
            // 
            this.extraOptionChartToolStripMenuItem.Name = "extraOptionChartToolStripMenuItem";
            this.extraOptionChartToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.extraOptionChartToolStripMenuItem.Text = "ExtraOption Chart";
            this.extraOptionChartToolStripMenuItem.Click += new System.EventHandler(this.extraOptionChartToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(594, 179);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(190, 23);
            this.exportButton.TabIndex = 33;
            this.exportButton.Text = "Export From Database";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 655);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AgeTB);
            this.Controls.Add(this.ExtraCombo);
            this.Controls.Add(this.SubscriptionCombo);
            this.Controls.Add(this.InfoEButton);
            this.Controls.Add(this.InfoSButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelephoneTB);
            this.Controls.Add(this.CityTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.LabelTelephone);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.LabelName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Main";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.NameErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneErr)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelTelephone;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox TelephoneTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader Subscription;
        private System.Windows.Forms.ColumnHeader ExtraOption;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button InfoSButton;
        private System.Windows.Forms.Button InfoEButton;
        private System.Windows.Forms.ComboBox SubscriptionCombo;
        private System.Windows.Forms.ComboBox ExtraCombo;
        private System.Windows.Forms.ColumnHeader PriceS;
        private System.Windows.Forms.ColumnHeader PriceEO;
        private System.Windows.Forms.ErrorProvider NameErr;
        private System.Windows.Forms.ErrorProvider AgeErr;
        private System.Windows.Forms.ErrorProvider EmailErr;
        private System.Windows.Forms.ErrorProvider CityErr;
        private System.Windows.Forms.ErrorProvider TelephoneErr;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PageSetupDialog pageSetupDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private ToolStripMenuItem chartToolStripMenuItem;
        private ToolStripMenuItem subscriptionChartToolStripMenuItem;
        private ToolStripMenuItem extraOptionChartToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button exportButton;
    }
}

