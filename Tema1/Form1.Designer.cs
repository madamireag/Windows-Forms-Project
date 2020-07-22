namespace Tema1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCastigator = new System.Windows.Forms.TextBox();
            this.epSuma = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvMeciuri = new System.Windows.Forms.ListView();
            this.chSuma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCastigator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMeci = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCotaCastig = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbJucator = new System.Windows.Forms.TextBox();
            this.tbOponent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.epData = new System.Windows.Forms.ErrorProvider(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms__editeaza = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_sterge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.detaliiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epSport = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.epCastigator = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).BeginInit();
            this.cms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSport)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCastigator)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formular Pariu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suma pariu\r\n";
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(4, 78);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(201, 22);
            this.tbSuma.TabIndex = 2;
            this.tbSuma.Validating += new System.ComponentModel.CancelEventHandler(this.tbSuma_Validating);
            this.tbSuma.Validated += new System.EventHandler(this.tbSuma_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sport";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "FOTBAL",
            "TENIS",
            "SNOOKER",
            "BASCHET",
            "VOLEI"});
            this.cbTip.Location = new System.Drawing.Point(5, 123);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(201, 24);
            this.cbTip.TabIndex = 4;
            this.cbTip.Validating += new System.ComponentModel.CancelEventHandler(this.cbTip_Validating);
            this.cbTip.Validated += new System.EventHandler(this.cbTip_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Castigatorul meciului";
            // 
            // tbCastigator
            // 
            this.tbCastigator.Location = new System.Drawing.Point(5, 305);
            this.tbCastigator.Name = "tbCastigator";
            this.tbCastigator.Size = new System.Drawing.Size(200, 22);
            this.tbCastigator.TabIndex = 7;
            this.tbCastigator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCastigator_KeyDown);
            this.tbCastigator.Validating += new System.ComponentModel.CancelEventHandler(this.tbCastigator_Validating);
            this.tbCastigator.Validated += new System.EventHandler(this.tbCastigator_Validated);
            // 
            // epSuma
            // 
            this.epSuma.ContainerControl = this;
            // 
            // lvMeciuri
            // 
            this.lvMeciuri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvMeciuri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSuma,
            this.chSport,
            this.chData,
            this.chCastigator,
            this.chCota});
            this.lvMeciuri.FullRowSelect = true;
            this.lvMeciuri.GridLines = true;
            this.lvMeciuri.HideSelection = false;
            this.lvMeciuri.Location = new System.Drawing.Point(446, 69);
            this.lvMeciuri.Name = "lvMeciuri";
            this.lvMeciuri.Size = new System.Drawing.Size(560, 335);
            this.lvMeciuri.TabIndex = 8;
            this.lvMeciuri.UseCompatibleStateImageBehavior = false;
            this.lvMeciuri.View = System.Windows.Forms.View.Details;
            this.lvMeciuri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvMeciuri_KeyDown);
            this.lvMeciuri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMeciuri_MouseClick);
            this.lvMeciuri.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMeciuri_MouseDoubleClick);
            // 
            // chSuma
            // 
            this.chSuma.Text = "Suma";
            this.chSuma.Width = 58;
            // 
            // chSport
            // 
            this.chSport.Text = "Sport";
            this.chSport.Width = 53;
            // 
            // chData
            // 
            this.chData.Text = "Data game";
            this.chData.Width = 81;
            // 
            // chCastigator
            // 
            this.chCastigator.Text = "Castigator anticipat";
            this.chCastigator.Width = 131;
            // 
            // chCota
            // 
            this.chCota.Text = "Cota castigatorului";
            this.chCota.Width = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data meciului";
            // 
            // dtpMeci
            // 
            this.dtpMeci.Location = new System.Drawing.Point(5, 170);
            this.dtpMeci.Name = "dtpMeci";
            this.dtpMeci.Size = new System.Drawing.Size(200, 22);
            this.dtpMeci.TabIndex = 11;
            this.dtpMeci.Validating += new System.ComponentModel.CancelEventHandler(this.dtpMeci_Validating);
            this.dtpMeci.Validated += new System.EventHandler(this.dtpMeci_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cota aferenta";
            // 
            // tbCotaCastig
            // 
            this.tbCotaCastig.Location = new System.Drawing.Point(5, 350);
            this.tbCotaCastig.Name = "tbCotaCastig";
            this.tbCotaCastig.Size = new System.Drawing.Size(201, 22);
            this.tbCotaCastig.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Jucator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Oponent";
            // 
            // tbJucator
            // 
            this.tbJucator.Location = new System.Drawing.Point(6, 215);
            this.tbJucator.Name = "tbJucator";
            this.tbJucator.Size = new System.Drawing.Size(200, 22);
            this.tbJucator.TabIndex = 16;
            this.tbJucator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJucator_KeyDown);
            // 
            // tbOponent
            // 
            this.tbOponent.Location = new System.Drawing.Point(4, 260);
            this.tbOponent.Name = "tbOponent";
            this.tbOponent.Size = new System.Drawing.Size(201, 22);
            this.tbOponent.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.tbCotaCastig);
            this.groupBox1.Controls.Add(this.tbOponent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbJucator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSuma);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTip);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Controls.Add(this.dtpMeci);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCastigator);
            this.groupBox1.Controls.Add(this.btnCurata);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 488);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(206, 26);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.Name = "StripStatusLabel";
            this.StripStatusLabel.Size = new System.Drawing.Size(65, 20);
            this.StripStatusLabel.Text = "Pariuri: 0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(164, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Meciurile zilei in Snooker";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdauga.Image = global::Tema1.Properties.Resources.bet;
            this.btnAdauga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdauga.Location = new System.Drawing.Point(-1, 378);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(100, 55);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "Adauga Pariu";
            this.btnAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCurata.Image = global::Tema1.Properties.Resources.eraser;
            this.btnCurata.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurata.Location = new System.Drawing.Point(106, 378);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(100, 55);
            this.btnCurata.TabIndex = 9;
            this.btnCurata.Text = "Curata Formular";
            this.btnCurata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurata.UseVisualStyleBackColor = false;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // epData
            // 
            this.epData.ContainerControl = this;
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms__editeaza,
            this.cms_sterge});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(136, 52);
            // 
            // cms__editeaza
            // 
            this.cms__editeaza.Name = "cms__editeaza";
            this.cms__editeaza.Size = new System.Drawing.Size(135, 24);
            this.cms__editeaza.Text = "Editeaza";
            this.cms__editeaza.Click += new System.EventHandler(this.cms__editeaza_Click);
            // 
            // cms_sterge
            // 
            this.cms_sterge.Name = "cms_sterge";
            this.cms_sterge.Size = new System.Drawing.Size(135, 24);
            this.cms_sterge.Text = "Sterge";
            this.cms_sterge.Click += new System.EventHandler(this.cms_sterge_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaliiToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.serializareTxtToolStripMenuItem,
            this.salveazaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // detaliiToolStripMenuItem
            // 
            this.detaliiToolStripMenuItem.Name = "detaliiToolStripMenuItem";
            this.detaliiToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.detaliiToolStripMenuItem.Text = "Detalii";
            this.detaliiToolStripMenuItem.Click += new System.EventHandler(this.detaliiToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serializareTxtToolStripMenuItem
            // 
            this.serializareTxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerializareToolStripMenuItem,
            this.DeserializareToolStripMenuItem});
            this.serializareTxtToolStripMenuItem.Name = "serializareTxtToolStripMenuItem";
            this.serializareTxtToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.serializareTxtToolStripMenuItem.Text = "Fisier XML";
            // 
            // SerializareToolStripMenuItem
            // 
            this.SerializareToolStripMenuItem.Name = "SerializareToolStripMenuItem";
            this.SerializareToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.SerializareToolStripMenuItem.Text = "Serializare";
            this.SerializareToolStripMenuItem.Click += new System.EventHandler(this.SerializareToolStripMenuItem_Click);
            // 
            // DeserializareToolStripMenuItem
            // 
            this.DeserializareToolStripMenuItem.Name = "DeserializareToolStripMenuItem";
            this.DeserializareToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.DeserializareToolStripMenuItem.Text = "Deserializare";
            this.DeserializareToolStripMenuItem.Click += new System.EventHandler(this.DeserializareToolStripMenuItem_Click);
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // epSport
            // 
            this.epSport.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 27);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "Genereaza grafic";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save in txt(Ctrl+S)";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = global::Tema1.Properties.Resources.Actions_print_preview_icon;
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "&Print(Ctrl+P)";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(12, 38);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(174, 300);
            this.panel.TabIndex = 24;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Drop text file here";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(237, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 348);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // epCastigator
            // 
            this.epCastigator.ContainerControl = this;
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditeaza.Image = ((System.Drawing.Image)(resources.GetObject("btnEditeaza.Image")));
            this.btnEditeaza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditeaza.Location = new System.Drawing.Point(446, 410);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(100, 55);
            this.btnEditeaza.TabIndex = 20;
            this.btnEditeaza.Text = "Editeaza\r\nPariu\r\n";
            this.btnEditeaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditeaza.UseVisualStyleBackColor = false;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSterge.Image = global::Tema1.Properties.Resources.bin;
            this.btnSterge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSterge.Location = new System.Drawing.Point(906, 410);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(100, 55);
            this.btnSterge.TabIndex = 19;
            this.btnSterge.Text = "Sterge\r\nPariu\r\n";
            this.btnSterge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1021, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvMeciuri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Formular Pariuri";
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).EndInit();
            this.cms.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSport)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCastigator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCastigator;
        private System.Windows.Forms.ErrorProvider epSuma;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.ListView lvMeciuri;
        private System.Windows.Forms.DateTimePicker dtpMeci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCotaCastig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOponent;
        private System.Windows.Forms.TextBox tbJucator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader chSuma;
        private System.Windows.Forms.ColumnHeader chSport;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ColumnHeader chCastigator;
        private System.Windows.Forms.ColumnHeader chCota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider epData;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cms__editeaza;
        private System.Windows.Forms.ToolStripMenuItem cms_sterge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detaliiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider epSport;
        private System.Windows.Forms.ToolStripMenuItem serializareTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SerializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeserializareToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider epCastigator;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
    }
}

