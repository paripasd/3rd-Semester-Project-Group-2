namespace ClientApp.UILayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GameMenuBar = new System.Windows.Forms.TabPage();
            this.DeveloperMenuBar = new System.Windows.Forms.TabPage();
            this.panelCreateDeveloper = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelCreateDeveloper = new System.Windows.Forms.Button();
            this.buttonFinishDeveloperCreation = new System.Windows.Forms.Button();
            this.labelCreateDeveloperDescription = new System.Windows.Forms.Label();
            this.labelCreateDeveloperEmail = new System.Windows.Forms.Label();
            this.labelCreateDeveloperName = new System.Windows.Forms.Label();
            this.textBoxCreateDeveloperDescription = new System.Windows.Forms.TextBox();
            this.textBoxCreateDeveloperEmail = new System.Windows.Forms.TextBox();
            this.textBoxCreateDeveloperName = new System.Windows.Forms.TextBox();
            this.labelErrorDeveloperSearch = new System.Windows.Forms.Label();
            this.textBoxSearchDeveloper = new System.Windows.Forms.TextBox();
            this.buttonSearchDeveloperByID = new System.Windows.Forms.Button();
            this.buttonShowAllDeveloper = new System.Windows.Forms.Button();
            this.buttonDeleteDeveloper = new System.Windows.Forms.Button();
            this.buttonCreateDeveloper = new System.Windows.Forms.Button();
            this.buttonUpdateDeveloper = new System.Windows.Forms.Button();
            this.labelDeveloperList = new System.Windows.Forms.Label();
            this.labelDeveloperPanelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDeveloperGames = new System.Windows.Forms.Label();
            this.listBoxDeveloperGames = new System.Windows.Forms.ListBox();
            this.labelDeveloperNamePanel = new System.Windows.Forms.Label();
            this.labelDeveloperDescription = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDeveloperName = new System.Windows.Forms.Label();
            this.labelDeveloperID = new System.Windows.Forms.Label();
            this.textBoxDeveloperDescription = new System.Windows.Forms.TextBox();
            this.textBoxDeveloperName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDeveloperID = new System.Windows.Forms.TextBox();
            this.listBoxDeveloperList = new System.Windows.Forms.ListBox();
            this.EventMenuBar = new System.Windows.Forms.TabPage();
            this.SalesMenuBar = new System.Windows.Forms.TabPage();
            this.LoginMenuBar = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.DeveloperMenuBar.SuspendLayout();
            this.panelCreateDeveloper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.GameMenuBar);
            this.tabControl1.Controls.Add(this.DeveloperMenuBar);
            this.tabControl1.Controls.Add(this.EventMenuBar);
            this.tabControl1.Controls.Add(this.SalesMenuBar);
            this.tabControl1.Controls.Add(this.LoginMenuBar);
            this.tabControl1.ItemSize = new System.Drawing.Size(320, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1920, 1080);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // GameMenuBar
            // 
            this.GameMenuBar.Location = new System.Drawing.Point(4, 54);
            this.GameMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameMenuBar.Name = "GameMenuBar";
            this.GameMenuBar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameMenuBar.Size = new System.Drawing.Size(1912, 1022);
            this.GameMenuBar.TabIndex = 0;
            this.GameMenuBar.Text = "Game";
            this.GameMenuBar.UseVisualStyleBackColor = true;
            // 
            // DeveloperMenuBar
            // 
            this.DeveloperMenuBar.Controls.Add(this.panelCreateDeveloper);
            this.DeveloperMenuBar.Controls.Add(this.labelErrorDeveloperSearch);
            this.DeveloperMenuBar.Controls.Add(this.textBoxSearchDeveloper);
            this.DeveloperMenuBar.Controls.Add(this.buttonSearchDeveloperByID);
            this.DeveloperMenuBar.Controls.Add(this.buttonShowAllDeveloper);
            this.DeveloperMenuBar.Controls.Add(this.buttonDeleteDeveloper);
            this.DeveloperMenuBar.Controls.Add(this.buttonCreateDeveloper);
            this.DeveloperMenuBar.Controls.Add(this.buttonUpdateDeveloper);
            this.DeveloperMenuBar.Controls.Add(this.labelDeveloperList);
            this.DeveloperMenuBar.Controls.Add(this.labelDeveloperPanelName);
            this.DeveloperMenuBar.Controls.Add(this.panel1);
            this.DeveloperMenuBar.Controls.Add(this.listBoxDeveloperList);
            this.DeveloperMenuBar.Location = new System.Drawing.Point(4, 54);
            this.DeveloperMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeveloperMenuBar.Name = "DeveloperMenuBar";
            this.DeveloperMenuBar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeveloperMenuBar.Size = new System.Drawing.Size(1912, 1022);
            this.DeveloperMenuBar.TabIndex = 1;
            this.DeveloperMenuBar.Text = "Developer";
            this.DeveloperMenuBar.UseVisualStyleBackColor = true;
            // 
            // panelCreateDeveloper
            // 
            this.panelCreateDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCreateDeveloper.Controls.Add(this.label1);
            this.panelCreateDeveloper.Controls.Add(this.buttonCancelCreateDeveloper);
            this.panelCreateDeveloper.Controls.Add(this.buttonFinishDeveloperCreation);
            this.panelCreateDeveloper.Controls.Add(this.labelCreateDeveloperDescription);
            this.panelCreateDeveloper.Controls.Add(this.labelCreateDeveloperEmail);
            this.panelCreateDeveloper.Controls.Add(this.labelCreateDeveloperName);
            this.panelCreateDeveloper.Controls.Add(this.textBoxCreateDeveloperDescription);
            this.panelCreateDeveloper.Controls.Add(this.textBoxCreateDeveloperEmail);
            this.panelCreateDeveloper.Controls.Add(this.textBoxCreateDeveloperName);
            this.panelCreateDeveloper.Location = new System.Drawing.Point(1594, 115);
            this.panelCreateDeveloper.Name = "panelCreateDeveloper";
            this.panelCreateDeveloper.Size = new System.Drawing.Size(299, 439);
            this.panelCreateDeveloper.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create Developer Form";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonCancelCreateDeveloper
            // 
            this.buttonCancelCreateDeveloper.Location = new System.Drawing.Point(16, 397);
            this.buttonCancelCreateDeveloper.Name = "buttonCancelCreateDeveloper";
            this.buttonCancelCreateDeveloper.Size = new System.Drawing.Size(87, 23);
            this.buttonCancelCreateDeveloper.TabIndex = 7;
            this.buttonCancelCreateDeveloper.Text = "Cancel";
            this.buttonCancelCreateDeveloper.UseVisualStyleBackColor = true;
            this.buttonCancelCreateDeveloper.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFinishDeveloperCreation
            // 
            this.buttonFinishDeveloperCreation.Location = new System.Drawing.Point(197, 397);
            this.buttonFinishDeveloperCreation.Name = "buttonFinishDeveloperCreation";
            this.buttonFinishDeveloperCreation.Size = new System.Drawing.Size(87, 23);
            this.buttonFinishDeveloperCreation.TabIndex = 6;
            this.buttonFinishDeveloperCreation.Text = "Finish";
            this.buttonFinishDeveloperCreation.UseVisualStyleBackColor = true;
            this.buttonFinishDeveloperCreation.Click += new System.EventHandler(this.buttonFinishDeveloperCreation_Click);
            // 
            // labelCreateDeveloperDescription
            // 
            this.labelCreateDeveloperDescription.AutoSize = true;
            this.labelCreateDeveloperDescription.Location = new System.Drawing.Point(67, 186);
            this.labelCreateDeveloperDescription.Name = "labelCreateDeveloperDescription";
            this.labelCreateDeveloperDescription.Size = new System.Drawing.Size(67, 15);
            this.labelCreateDeveloperDescription.TabIndex = 5;
            this.labelCreateDeveloperDescription.Text = "Description";
            // 
            // labelCreateDeveloperEmail
            // 
            this.labelCreateDeveloperEmail.AutoSize = true;
            this.labelCreateDeveloperEmail.Location = new System.Drawing.Point(67, 136);
            this.labelCreateDeveloperEmail.Name = "labelCreateDeveloperEmail";
            this.labelCreateDeveloperEmail.Size = new System.Drawing.Size(36, 15);
            this.labelCreateDeveloperEmail.TabIndex = 4;
            this.labelCreateDeveloperEmail.Text = "Email";
            this.labelCreateDeveloperEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCreateDeveloperName
            // 
            this.labelCreateDeveloperName.AutoSize = true;
            this.labelCreateDeveloperName.Location = new System.Drawing.Point(67, 89);
            this.labelCreateDeveloperName.Name = "labelCreateDeveloperName";
            this.labelCreateDeveloperName.Size = new System.Drawing.Size(39, 15);
            this.labelCreateDeveloperName.TabIndex = 3;
            this.labelCreateDeveloperName.Text = "Name";
            // 
            // textBoxCreateDeveloperDescription
            // 
            this.textBoxCreateDeveloperDescription.Location = new System.Drawing.Point(68, 204);
            this.textBoxCreateDeveloperDescription.Multiline = true;
            this.textBoxCreateDeveloperDescription.Name = "textBoxCreateDeveloperDescription";
            this.textBoxCreateDeveloperDescription.Size = new System.Drawing.Size(171, 138);
            this.textBoxCreateDeveloperDescription.TabIndex = 2;
            // 
            // textBoxCreateDeveloperEmail
            // 
            this.textBoxCreateDeveloperEmail.Location = new System.Drawing.Point(68, 154);
            this.textBoxCreateDeveloperEmail.Name = "textBoxCreateDeveloperEmail";
            this.textBoxCreateDeveloperEmail.Size = new System.Drawing.Size(171, 23);
            this.textBoxCreateDeveloperEmail.TabIndex = 1;
            // 
            // textBoxCreateDeveloperName
            // 
            this.textBoxCreateDeveloperName.Location = new System.Drawing.Point(68, 107);
            this.textBoxCreateDeveloperName.Name = "textBoxCreateDeveloperName";
            this.textBoxCreateDeveloperName.Size = new System.Drawing.Size(171, 23);
            this.textBoxCreateDeveloperName.TabIndex = 0;
            // 
            // labelErrorDeveloperSearch
            // 
            this.labelErrorDeveloperSearch.AutoSize = true;
            this.labelErrorDeveloperSearch.Location = new System.Drawing.Point(52, 43);
            this.labelErrorDeveloperSearch.Name = "labelErrorDeveloperSearch";
            this.labelErrorDeveloperSearch.Size = new System.Drawing.Size(0, 15);
            this.labelErrorDeveloperSearch.TabIndex = 12;
            // 
            // textBoxSearchDeveloper
            // 
            this.textBoxSearchDeveloper.Location = new System.Drawing.Point(52, 60);
            this.textBoxSearchDeveloper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchDeveloper.Name = "textBoxSearchDeveloper";
            this.textBoxSearchDeveloper.PlaceholderText = "ID";
            this.textBoxSearchDeveloper.Size = new System.Drawing.Size(161, 23);
            this.textBoxSearchDeveloper.TabIndex = 9;
            this.textBoxSearchDeveloper.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSearchDeveloperByID
            // 
            this.buttonSearchDeveloperByID.Location = new System.Drawing.Point(264, 55);
            this.buttonSearchDeveloperByID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchDeveloperByID.Name = "buttonSearchDeveloperByID";
            this.buttonSearchDeveloperByID.Size = new System.Drawing.Size(175, 30);
            this.buttonSearchDeveloperByID.TabIndex = 8;
            this.buttonSearchDeveloperByID.Text = "Search";
            this.buttonSearchDeveloperByID.UseVisualStyleBackColor = true;
            this.buttonSearchDeveloperByID.Click += new System.EventHandler(this.buttonSearchDeveloperByID_Click);
            // 
            // buttonShowAllDeveloper
            // 
            this.buttonShowAllDeveloper.Location = new System.Drawing.Point(264, 14);
            this.buttonShowAllDeveloper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAllDeveloper.Name = "buttonShowAllDeveloper";
            this.buttonShowAllDeveloper.Size = new System.Drawing.Size(175, 30);
            this.buttonShowAllDeveloper.TabIndex = 7;
            this.buttonShowAllDeveloper.Text = "Show All";
            this.buttonShowAllDeveloper.UseVisualStyleBackColor = true;
            this.buttonShowAllDeveloper.Click += new System.EventHandler(this.buttonShowAllDeveloper_Click);
            // 
            // buttonDeleteDeveloper
            // 
            this.buttonDeleteDeveloper.Location = new System.Drawing.Point(264, 557);
            this.buttonDeleteDeveloper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteDeveloper.Name = "buttonDeleteDeveloper";
            this.buttonDeleteDeveloper.Size = new System.Drawing.Size(175, 30);
            this.buttonDeleteDeveloper.TabIndex = 6;
            this.buttonDeleteDeveloper.Text = "Delete";
            this.buttonDeleteDeveloper.UseVisualStyleBackColor = true;
            this.buttonDeleteDeveloper.Click += new System.EventHandler(this.buttonDeleteDeveloper_Click);
            // 
            // buttonCreateDeveloper
            // 
            this.buttonCreateDeveloper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateDeveloper.Location = new System.Drawing.Point(1792, 20);
            this.buttonCreateDeveloper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateDeveloper.Name = "buttonCreateDeveloper";
            this.buttonCreateDeveloper.Size = new System.Drawing.Size(87, 50);
            this.buttonCreateDeveloper.TabIndex = 5;
            this.buttonCreateDeveloper.Text = "Add New";
            this.buttonCreateDeveloper.UseVisualStyleBackColor = true;
            this.buttonCreateDeveloper.Click += new System.EventHandler(this.buttonCreateDeveloper_Click);
            // 
            // buttonUpdateDeveloper
            // 
            this.buttonUpdateDeveloper.Location = new System.Drawing.Point(1378, 557);
            this.buttonUpdateDeveloper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateDeveloper.Name = "buttonUpdateDeveloper";
            this.buttonUpdateDeveloper.Size = new System.Drawing.Size(175, 30);
            this.buttonUpdateDeveloper.TabIndex = 4;
            this.buttonUpdateDeveloper.Text = "Update";
            this.buttonUpdateDeveloper.UseVisualStyleBackColor = true;
            this.buttonUpdateDeveloper.Click += new System.EventHandler(this.buttonUpdateDeveloper_Click);
            // 
            // labelDeveloperList
            // 
            this.labelDeveloperList.AutoSize = true;
            this.labelDeveloperList.Location = new System.Drawing.Point(52, 98);
            this.labelDeveloperList.Name = "labelDeveloperList";
            this.labelDeveloperList.Size = new System.Drawing.Size(81, 15);
            this.labelDeveloperList.TabIndex = 3;
            this.labelDeveloperList.Text = "Developer List";
            // 
            // labelDeveloperPanelName
            // 
            this.labelDeveloperPanelName.AutoSize = true;
            this.labelDeveloperPanelName.Location = new System.Drawing.Point(557, 55);
            this.labelDeveloperPanelName.Name = "labelDeveloperPanelName";
            this.labelDeveloperPanelName.Size = new System.Drawing.Size(0, 15);
            this.labelDeveloperPanelName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelDeveloperGames);
            this.panel1.Controls.Add(this.listBoxDeveloperGames);
            this.panel1.Controls.Add(this.labelDeveloperNamePanel);
            this.panel1.Controls.Add(this.labelDeveloperDescription);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelDeveloperName);
            this.panel1.Controls.Add(this.labelDeveloperID);
            this.panel1.Controls.Add(this.textBoxDeveloperDescription);
            this.panel1.Controls.Add(this.textBoxDeveloperName);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxDeveloperID);
            this.panel1.Location = new System.Drawing.Point(535, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 438);
            this.panel1.TabIndex = 1;
            // 
            // labelDeveloperGames
            // 
            this.labelDeveloperGames.AutoSize = true;
            this.labelDeveloperGames.Location = new System.Drawing.Point(637, 106);
            this.labelDeveloperGames.Name = "labelDeveloperGames";
            this.labelDeveloperGames.Size = new System.Drawing.Size(43, 15);
            this.labelDeveloperGames.TabIndex = 9;
            this.labelDeveloperGames.Text = "Games";
            // 
            // listBoxDeveloperGames
            // 
            this.listBoxDeveloperGames.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxDeveloperGames.FormattingEnabled = true;
            this.listBoxDeveloperGames.ItemHeight = 25;
            this.listBoxDeveloperGames.Location = new System.Drawing.Point(637, 123);
            this.listBoxDeveloperGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDeveloperGames.Name = "listBoxDeveloperGames";
            this.listBoxDeveloperGames.Size = new System.Drawing.Size(329, 179);
            this.listBoxDeveloperGames.TabIndex = 8;
            this.listBoxDeveloperGames.SelectedIndexChanged += new System.EventHandler(this.listBoxDeveloperGames_SelectedIndexChanged);
            // 
            // labelDeveloperNamePanel
            // 
            this.labelDeveloperNamePanel.AutoSize = true;
            this.labelDeveloperNamePanel.Location = new System.Drawing.Point(502, 9);
            this.labelDeveloperNamePanel.Name = "labelDeveloperNamePanel";
            this.labelDeveloperNamePanel.Size = new System.Drawing.Size(39, 15);
            this.labelDeveloperNamePanel.TabIndex = 11;
            this.labelDeveloperNamePanel.Text = "Name";
            // 
            // labelDeveloperDescription
            // 
            this.labelDeveloperDescription.AutoSize = true;
            this.labelDeveloperDescription.Location = new System.Drawing.Point(134, 237);
            this.labelDeveloperDescription.Name = "labelDeveloperDescription";
            this.labelDeveloperDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDeveloperDescription.TabIndex = 7;
            this.labelDeveloperDescription.Text = "Description";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(134, 194);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelDeveloperName
            // 
            this.labelDeveloperName.AutoSize = true;
            this.labelDeveloperName.Location = new System.Drawing.Point(134, 153);
            this.labelDeveloperName.Name = "labelDeveloperName";
            this.labelDeveloperName.Size = new System.Drawing.Size(39, 15);
            this.labelDeveloperName.TabIndex = 5;
            this.labelDeveloperName.Text = "Name";
            // 
            // labelDeveloperID
            // 
            this.labelDeveloperID.AutoSize = true;
            this.labelDeveloperID.Location = new System.Drawing.Point(134, 106);
            this.labelDeveloperID.Name = "labelDeveloperID";
            this.labelDeveloperID.Size = new System.Drawing.Size(18, 15);
            this.labelDeveloperID.TabIndex = 4;
            this.labelDeveloperID.Text = "ID";
            this.labelDeveloperID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDeveloperDescription
            // 
            this.textBoxDeveloperDescription.Location = new System.Drawing.Point(134, 254);
            this.textBoxDeveloperDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeveloperDescription.Multiline = true;
            this.textBoxDeveloperDescription.Name = "textBoxDeveloperDescription";
            this.textBoxDeveloperDescription.Size = new System.Drawing.Size(350, 152);
            this.textBoxDeveloperDescription.TabIndex = 3;
            // 
            // textBoxDeveloperName
            // 
            this.textBoxDeveloperName.Location = new System.Drawing.Point(134, 170);
            this.textBoxDeveloperName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeveloperName.Name = "textBoxDeveloperName";
            this.textBoxDeveloperName.Size = new System.Drawing.Size(350, 23);
            this.textBoxDeveloperName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(134, 212);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(350, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxDeveloperID
            // 
            this.textBoxDeveloperID.Enabled = false;
            this.textBoxDeveloperID.Location = new System.Drawing.Point(134, 123);
            this.textBoxDeveloperID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeveloperID.Name = "textBoxDeveloperID";
            this.textBoxDeveloperID.Size = new System.Drawing.Size(350, 23);
            this.textBoxDeveloperID.TabIndex = 0;
            // 
            // listBoxDeveloperList
            // 
            this.listBoxDeveloperList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxDeveloperList.FormattingEnabled = true;
            this.listBoxDeveloperList.ItemHeight = 25;
            this.listBoxDeveloperList.Location = new System.Drawing.Point(52, 115);
            this.listBoxDeveloperList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDeveloperList.Name = "listBoxDeveloperList";
            this.listBoxDeveloperList.Size = new System.Drawing.Size(387, 429);
            this.listBoxDeveloperList.TabIndex = 0;
            this.listBoxDeveloperList.SelectedIndexChanged += new System.EventHandler(this.listBoxDeveloperList_SelectedIndexChanged);
            // 
            // EventMenuBar
            // 
            this.EventMenuBar.Location = new System.Drawing.Point(4, 54);
            this.EventMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventMenuBar.Name = "EventMenuBar";
            this.EventMenuBar.Size = new System.Drawing.Size(1912, 1022);
            this.EventMenuBar.TabIndex = 2;
            this.EventMenuBar.Text = "Event";
            this.EventMenuBar.UseVisualStyleBackColor = true;
            // 
            // SalesMenuBar
            // 
            this.SalesMenuBar.Location = new System.Drawing.Point(4, 54);
            this.SalesMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesMenuBar.Name = "SalesMenuBar";
            this.SalesMenuBar.Size = new System.Drawing.Size(1912, 1022);
            this.SalesMenuBar.TabIndex = 3;
            this.SalesMenuBar.Text = "Sales";
            this.SalesMenuBar.UseVisualStyleBackColor = true;
            // 
            // LoginMenuBar
            // 
            this.LoginMenuBar.Location = new System.Drawing.Point(4, 54);
            this.LoginMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginMenuBar.Name = "LoginMenuBar";
            this.LoginMenuBar.Size = new System.Drawing.Size(1912, 1022);
            this.LoginMenuBar.TabIndex = 4;
            this.LoginMenuBar.Text = "Login";
            this.LoginMenuBar.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.DeveloperMenuBar.ResumeLayout(false);
            this.DeveloperMenuBar.PerformLayout();
            this.panelCreateDeveloper.ResumeLayout(false);
            this.panelCreateDeveloper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private TabControl tabControl1;
        private TabPage GameMenuBar;
        private TabPage DeveloperMenuBar;
        private Panel panel1;
        private Label labelDeveloperName;
        private Label labelDeveloperID;
        private TextBox textBoxDeveloperDescription;
        private TextBox textBoxDeveloperName;
        private TextBox textBoxEmail;
        private TextBox textBoxDeveloperID;
        private ListBox listBoxDeveloperList;
        private Label labelDeveloperDescription;
        private Label labelEmail;
        private Label labelDeveloperPanelName;
        private Label labelDeveloperList;
        private Label labelDeveloperGames;
        private ListBox listBoxDeveloperGames;
        private Button buttonUpdateDeveloper;
        private Button buttonDeleteDeveloper;
        private Button buttonCreateDeveloper;
        private Button buttonShowAllDeveloper;
        private TextBox textBoxSearchDeveloper;
        private Button buttonSearchDeveloperByID;
        private Label labelDeveloperNamePanel;
        private TabPage EventMenuBar;
        private TabPage SalesMenuBar;
        private TabPage LoginMenuBar;
        private Label labelErrorDeveloperSearch;
        private Panel panelCreateDeveloper;
        private Button buttonFinishDeveloperCreation;
        private Label labelCreateDeveloperDescription;
        private Label labelCreateDeveloperEmail;
        private Label labelCreateDeveloperName;
        private TextBox textBoxCreateDeveloperDescription;
        private TextBox textBoxCreateDeveloperEmail;
        private TextBox textBoxCreateDeveloperName;
        private Button buttonCancelCreateDeveloper;
        private Label label1;
    }
}