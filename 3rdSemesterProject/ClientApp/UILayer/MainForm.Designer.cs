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
            this.buttonUpdateEvent = new System.Windows.Forms.Button();
            this.panelCreateEvent = new System.Windows.Forms.Panel();
            this.numericUpDownCreateEventCapacity = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerCreateEventEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCreateEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelCreateEventGamId = new System.Windows.Forms.Label();
            this.textBoxCreateEventGameId = new System.Windows.Forms.TextBox();
            this.labelCreateEventEndDate = new System.Windows.Forms.Label();
            this.labelCreateEvent = new System.Windows.Forms.Label();
            this.labelCreateEventStartDate = new System.Windows.Forms.Label();
            this.labelCreateEventCapacity = new System.Windows.Forms.Label();
            this.buttonCreateEventCancel = new System.Windows.Forms.Button();
            this.buttonCreateEventFinish = new System.Windows.Forms.Button();
            this.labelCreateEventDescription = new System.Windows.Forms.Label();
            this.labelCreateEventName = new System.Windows.Forms.Label();
            this.textBoxCreateEventDescription = new System.Windows.Forms.TextBox();
            this.textBoxCreateEventName = new System.Windows.Forms.TextBox();
            this.buttonCreateNewEvent = new System.Windows.Forms.Button();
            this.buttonDeleteEvent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownEventPage = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerEventEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEventMemberList = new System.Windows.Forms.Label();
            this.labelEventNamePanel = new System.Windows.Forms.Label();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.listBoxEventMember = new System.Windows.Forms.ListBox();
            this.textBoxEventId = new System.Windows.Forms.TextBox();
            this.labelEventId = new System.Windows.Forms.Label();
            this.labelEventEndDate = new System.Windows.Forms.Label();
            this.labelEventStartDate = new System.Windows.Forms.Label();
            this.labelEventcapacity = new System.Windows.Forms.Label();
            this.textBoxEventGameId = new System.Windows.Forms.TextBox();
            this.labelEventGameId = new System.Windows.Forms.Label();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.textBoxEventIdSerach = new System.Windows.Forms.TextBox();
            this.buttonSearchEventById = new System.Windows.Forms.Button();
            this.buttonShowAllEvent = new System.Windows.Forms.Button();
            this.listBoxEvent = new System.Windows.Forms.ListBox();
            this.SalesMenuBar = new System.Windows.Forms.TabPage();
            this.LoginMenuBar = new System.Windows.Forms.TabPage();
            this.labelCapacityCounter = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DeveloperMenuBar.SuspendLayout();
            this.panelCreateDeveloper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EventMenuBar.SuspendLayout();
            this.panelCreateEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreateEventCapacity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventPage)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1930, 1050);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // GameMenuBar
            // 
            this.GameMenuBar.Location = new System.Drawing.Point(4, 54);
            this.GameMenuBar.Name = "GameMenuBar";
            this.GameMenuBar.Padding = new System.Windows.Forms.Padding(3);
            this.GameMenuBar.Size = new System.Drawing.Size(1922, 992);
            this.GameMenuBar.TabIndex = 0;
            this.GameMenuBar.Text = "Game";
            this.GameMenuBar.UseVisualStyleBackColor = true;
            // 
            // DeveloperMenuBar
            // 
            this.DeveloperMenuBar.AutoScroll = true;
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
            this.DeveloperMenuBar.Name = "DeveloperMenuBar";
            this.DeveloperMenuBar.Padding = new System.Windows.Forms.Padding(3);
            this.DeveloperMenuBar.Size = new System.Drawing.Size(1922, 992);
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
            this.panelCreateDeveloper.Location = new System.Drawing.Point(1555, 153);
            this.panelCreateDeveloper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCreateDeveloper.Name = "panelCreateDeveloper";
            this.panelCreateDeveloper.Size = new System.Drawing.Size(351, 548);
            this.panelCreateDeveloper.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create Developer Form";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonCancelCreateDeveloper
            // 
            this.buttonCancelCreateDeveloper.Location = new System.Drawing.Point(24, 511);
            this.buttonCancelCreateDeveloper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelCreateDeveloper.Name = "buttonCancelCreateDeveloper";
            this.buttonCancelCreateDeveloper.Size = new System.Drawing.Size(99, 31);
            this.buttonCancelCreateDeveloper.TabIndex = 7;
            this.buttonCancelCreateDeveloper.Text = "Cancel";
            this.buttonCancelCreateDeveloper.UseVisualStyleBackColor = true;
            this.buttonCancelCreateDeveloper.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFinishDeveloperCreation
            // 
            this.buttonFinishDeveloperCreation.Location = new System.Drawing.Point(230, 511);
            this.buttonFinishDeveloperCreation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFinishDeveloperCreation.Name = "buttonFinishDeveloperCreation";
            this.buttonFinishDeveloperCreation.Size = new System.Drawing.Size(99, 31);
            this.buttonFinishDeveloperCreation.TabIndex = 6;
            this.buttonFinishDeveloperCreation.Text = "Finish";
            this.buttonFinishDeveloperCreation.UseVisualStyleBackColor = true;
            this.buttonFinishDeveloperCreation.Click += new System.EventHandler(this.buttonFinishDeveloperCreation_Click);
            // 
            // labelCreateDeveloperDescription
            // 
            this.labelCreateDeveloperDescription.AutoSize = true;
            this.labelCreateDeveloperDescription.Location = new System.Drawing.Point(77, 248);
            this.labelCreateDeveloperDescription.Name = "labelCreateDeveloperDescription";
            this.labelCreateDeveloperDescription.Size = new System.Drawing.Size(85, 20);
            this.labelCreateDeveloperDescription.TabIndex = 5;
            this.labelCreateDeveloperDescription.Text = "Description";
            // 
            // labelCreateDeveloperEmail
            // 
            this.labelCreateDeveloperEmail.AutoSize = true;
            this.labelCreateDeveloperEmail.Location = new System.Drawing.Point(77, 181);
            this.labelCreateDeveloperEmail.Name = "labelCreateDeveloperEmail";
            this.labelCreateDeveloperEmail.Size = new System.Drawing.Size(46, 20);
            this.labelCreateDeveloperEmail.TabIndex = 4;
            this.labelCreateDeveloperEmail.Text = "Email";
            this.labelCreateDeveloperEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCreateDeveloperName
            // 
            this.labelCreateDeveloperName.AutoSize = true;
            this.labelCreateDeveloperName.Location = new System.Drawing.Point(77, 119);
            this.labelCreateDeveloperName.Name = "labelCreateDeveloperName";
            this.labelCreateDeveloperName.Size = new System.Drawing.Size(49, 20);
            this.labelCreateDeveloperName.TabIndex = 3;
            this.labelCreateDeveloperName.Text = "Name";
            // 
            // textBoxCreateDeveloperDescription
            // 
            this.textBoxCreateDeveloperDescription.Location = new System.Drawing.Point(78, 272);
            this.textBoxCreateDeveloperDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreateDeveloperDescription.Multiline = true;
            this.textBoxCreateDeveloperDescription.Name = "textBoxCreateDeveloperDescription";
            this.textBoxCreateDeveloperDescription.Size = new System.Drawing.Size(195, 183);
            this.textBoxCreateDeveloperDescription.TabIndex = 2;
            // 
            // textBoxCreateDeveloperEmail
            // 
            this.textBoxCreateDeveloperEmail.Location = new System.Drawing.Point(78, 205);
            this.textBoxCreateDeveloperEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreateDeveloperEmail.Name = "textBoxCreateDeveloperEmail";
            this.textBoxCreateDeveloperEmail.Size = new System.Drawing.Size(195, 27);
            this.textBoxCreateDeveloperEmail.TabIndex = 1;
            // 
            // textBoxCreateDeveloperName
            // 
            this.textBoxCreateDeveloperName.Location = new System.Drawing.Point(78, 143);
            this.textBoxCreateDeveloperName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreateDeveloperName.Name = "textBoxCreateDeveloperName";
            this.textBoxCreateDeveloperName.Size = new System.Drawing.Size(195, 27);
            this.textBoxCreateDeveloperName.TabIndex = 0;
            // 
            // labelErrorDeveloperSearch
            // 
            this.labelErrorDeveloperSearch.AutoSize = true;
            this.labelErrorDeveloperSearch.Location = new System.Drawing.Point(59, 57);
            this.labelErrorDeveloperSearch.Name = "labelErrorDeveloperSearch";
            this.labelErrorDeveloperSearch.Size = new System.Drawing.Size(0, 20);
            this.labelErrorDeveloperSearch.TabIndex = 12;
            // 
            // textBoxSearchDeveloper
            // 
            this.textBoxSearchDeveloper.Location = new System.Drawing.Point(59, 80);
            this.textBoxSearchDeveloper.Name = "textBoxSearchDeveloper";
            this.textBoxSearchDeveloper.PlaceholderText = "ID";
            this.textBoxSearchDeveloper.Size = new System.Drawing.Size(183, 27);
            this.textBoxSearchDeveloper.TabIndex = 9;
            this.textBoxSearchDeveloper.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSearchDeveloperByID
            // 
            this.buttonSearchDeveloperByID.Location = new System.Drawing.Point(302, 73);
            this.buttonSearchDeveloperByID.Name = "buttonSearchDeveloperByID";
            this.buttonSearchDeveloperByID.Size = new System.Drawing.Size(200, 40);
            this.buttonSearchDeveloperByID.TabIndex = 8;
            this.buttonSearchDeveloperByID.Text = "Search";
            this.buttonSearchDeveloperByID.UseVisualStyleBackColor = true;
            this.buttonSearchDeveloperByID.Click += new System.EventHandler(this.buttonSearchDeveloperByID_Click);
            // 
            // buttonShowAllDeveloper
            // 
            this.buttonShowAllDeveloper.Location = new System.Drawing.Point(302, 19);
            this.buttonShowAllDeveloper.Name = "buttonShowAllDeveloper";
            this.buttonShowAllDeveloper.Size = new System.Drawing.Size(200, 40);
            this.buttonShowAllDeveloper.TabIndex = 7;
            this.buttonShowAllDeveloper.Text = "Show All";
            this.buttonShowAllDeveloper.UseVisualStyleBackColor = true;
            this.buttonShowAllDeveloper.Click += new System.EventHandler(this.buttonShowAllDeveloper_Click);
            // 
            // buttonDeleteDeveloper
            // 
            this.buttonDeleteDeveloper.Location = new System.Drawing.Point(302, 743);
            this.buttonDeleteDeveloper.Name = "buttonDeleteDeveloper";
            this.buttonDeleteDeveloper.Size = new System.Drawing.Size(200, 40);
            this.buttonDeleteDeveloper.TabIndex = 6;
            this.buttonDeleteDeveloper.Text = "Delete";
            this.buttonDeleteDeveloper.UseVisualStyleBackColor = true;
            this.buttonDeleteDeveloper.Click += new System.EventHandler(this.buttonDeleteDeveloper_Click);
            // 
            // buttonCreateDeveloper
            // 
            this.buttonCreateDeveloper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateDeveloper.Location = new System.Drawing.Point(1797, 19);
            this.buttonCreateDeveloper.Name = "buttonCreateDeveloper";
            this.buttonCreateDeveloper.Size = new System.Drawing.Size(99, 67);
            this.buttonCreateDeveloper.TabIndex = 5;
            this.buttonCreateDeveloper.Text = "Add New";
            this.buttonCreateDeveloper.UseVisualStyleBackColor = true;
            this.buttonCreateDeveloper.Click += new System.EventHandler(this.buttonCreateDeveloper_Click);
            // 
            // buttonUpdateDeveloper
            // 
            this.buttonUpdateDeveloper.Location = new System.Drawing.Point(1326, 707);
            this.buttonUpdateDeveloper.Name = "buttonUpdateDeveloper";
            this.buttonUpdateDeveloper.Size = new System.Drawing.Size(200, 40);
            this.buttonUpdateDeveloper.TabIndex = 4;
            this.buttonUpdateDeveloper.Text = "Update";
            this.buttonUpdateDeveloper.UseVisualStyleBackColor = true;
            this.buttonUpdateDeveloper.Click += new System.EventHandler(this.buttonUpdateDeveloper_Click);
            // 
            // labelDeveloperList
            // 
            this.labelDeveloperList.AutoSize = true;
            this.labelDeveloperList.Location = new System.Drawing.Point(59, 131);
            this.labelDeveloperList.Name = "labelDeveloperList";
            this.labelDeveloperList.Size = new System.Drawing.Size(104, 20);
            this.labelDeveloperList.TabIndex = 3;
            this.labelDeveloperList.Text = "Developer List";
            // 
            // labelDeveloperPanelName
            // 
            this.labelDeveloperPanelName.AutoSize = true;
            this.labelDeveloperPanelName.Location = new System.Drawing.Point(637, 73);
            this.labelDeveloperPanelName.Name = "labelDeveloperPanelName";
            this.labelDeveloperPanelName.Size = new System.Drawing.Size(0, 20);
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
            this.panel1.Location = new System.Drawing.Point(532, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 548);
            this.panel1.TabIndex = 1;
            // 
            // labelDeveloperGames
            // 
            this.labelDeveloperGames.AutoSize = true;
            this.labelDeveloperGames.Location = new System.Drawing.Point(594, 81);
            this.labelDeveloperGames.Name = "labelDeveloperGames";
            this.labelDeveloperGames.Size = new System.Drawing.Size(54, 20);
            this.labelDeveloperGames.TabIndex = 9;
            this.labelDeveloperGames.Text = "Games";
            // 
            // listBoxDeveloperGames
            // 
            this.listBoxDeveloperGames.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxDeveloperGames.FormattingEnabled = true;
            this.listBoxDeveloperGames.ItemHeight = 32;
            this.listBoxDeveloperGames.Location = new System.Drawing.Point(594, 104);
            this.listBoxDeveloperGames.Name = "listBoxDeveloperGames";
            this.listBoxDeveloperGames.Size = new System.Drawing.Size(399, 228);
            this.listBoxDeveloperGames.TabIndex = 8;
            this.listBoxDeveloperGames.SelectedIndexChanged += new System.EventHandler(this.listBoxDeveloperGames_SelectedIndexChanged);
            // 
            // labelDeveloperNamePanel
            // 
            this.labelDeveloperNamePanel.AutoSize = true;
            this.labelDeveloperNamePanel.Location = new System.Drawing.Point(487, 21);
            this.labelDeveloperNamePanel.Name = "labelDeveloperNamePanel";
            this.labelDeveloperNamePanel.Size = new System.Drawing.Size(49, 20);
            this.labelDeveloperNamePanel.TabIndex = 11;
            this.labelDeveloperNamePanel.Text = "Name";
            // 
            // labelDeveloperDescription
            // 
            this.labelDeveloperDescription.AutoSize = true;
            this.labelDeveloperDescription.Location = new System.Drawing.Point(55, 234);
            this.labelDeveloperDescription.Name = "labelDeveloperDescription";
            this.labelDeveloperDescription.Size = new System.Drawing.Size(85, 20);
            this.labelDeveloperDescription.TabIndex = 7;
            this.labelDeveloperDescription.Text = "Description";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(55, 181);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 20);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelDeveloperName
            // 
            this.labelDeveloperName.AutoSize = true;
            this.labelDeveloperName.Location = new System.Drawing.Point(55, 119);
            this.labelDeveloperName.Name = "labelDeveloperName";
            this.labelDeveloperName.Size = new System.Drawing.Size(49, 20);
            this.labelDeveloperName.TabIndex = 5;
            this.labelDeveloperName.Text = "Name";
            // 
            // labelDeveloperID
            // 
            this.labelDeveloperID.AutoSize = true;
            this.labelDeveloperID.Location = new System.Drawing.Point(55, 58);
            this.labelDeveloperID.Name = "labelDeveloperID";
            this.labelDeveloperID.Size = new System.Drawing.Size(24, 20);
            this.labelDeveloperID.TabIndex = 4;
            this.labelDeveloperID.Text = "ID";
            this.labelDeveloperID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDeveloperDescription
            // 
            this.textBoxDeveloperDescription.Location = new System.Drawing.Point(55, 257);
            this.textBoxDeveloperDescription.Multiline = true;
            this.textBoxDeveloperDescription.Name = "textBoxDeveloperDescription";
            this.textBoxDeveloperDescription.Size = new System.Drawing.Size(399, 201);
            this.textBoxDeveloperDescription.TabIndex = 3;
            // 
            // textBoxDeveloperName
            // 
            this.textBoxDeveloperName.Location = new System.Drawing.Point(55, 143);
            this.textBoxDeveloperName.Name = "textBoxDeveloperName";
            this.textBoxDeveloperName.Size = new System.Drawing.Size(399, 27);
            this.textBoxDeveloperName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(55, 204);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(399, 27);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxDeveloperID
            // 
            this.textBoxDeveloperID.Enabled = false;
            this.textBoxDeveloperID.Location = new System.Drawing.Point(55, 81);
            this.textBoxDeveloperID.Name = "textBoxDeveloperID";
            this.textBoxDeveloperID.Size = new System.Drawing.Size(399, 27);
            this.textBoxDeveloperID.TabIndex = 0;
            // 
            // listBoxDeveloperList
            // 
            this.listBoxDeveloperList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxDeveloperList.FormattingEnabled = true;
            this.listBoxDeveloperList.ItemHeight = 32;
            this.listBoxDeveloperList.Location = new System.Drawing.Point(59, 153);
            this.listBoxDeveloperList.Name = "listBoxDeveloperList";
            this.listBoxDeveloperList.Size = new System.Drawing.Size(442, 548);
            this.listBoxDeveloperList.TabIndex = 0;
            this.listBoxDeveloperList.SelectedIndexChanged += new System.EventHandler(this.listBoxDeveloperList_SelectedIndexChanged);
            // 
            // EventMenuBar
            // 
            this.EventMenuBar.Controls.Add(this.buttonUpdateEvent);
            this.EventMenuBar.Controls.Add(this.panelCreateEvent);
            this.EventMenuBar.Controls.Add(this.buttonCreateNewEvent);
            this.EventMenuBar.Controls.Add(this.buttonDeleteEvent);
            this.EventMenuBar.Controls.Add(this.panel2);
            this.EventMenuBar.Controls.Add(this.textBoxEventIdSerach);
            this.EventMenuBar.Controls.Add(this.buttonSearchEventById);
            this.EventMenuBar.Controls.Add(this.buttonShowAllEvent);
            this.EventMenuBar.Controls.Add(this.listBoxEvent);
            this.EventMenuBar.Location = new System.Drawing.Point(4, 54);
            this.EventMenuBar.Name = "EventMenuBar";
            this.EventMenuBar.Size = new System.Drawing.Size(1922, 992);
            this.EventMenuBar.TabIndex = 2;
            this.EventMenuBar.Text = "Event";
            this.EventMenuBar.UseVisualStyleBackColor = true;
            this.EventMenuBar.Click += new System.EventHandler(this.EventMenuBar_Click);
            // 
            // buttonUpdateEvent
            // 
            this.buttonUpdateEvent.Location = new System.Drawing.Point(989, 716);
            this.buttonUpdateEvent.Name = "buttonUpdateEvent";
            this.buttonUpdateEvent.Size = new System.Drawing.Size(200, 40);
            this.buttonUpdateEvent.TabIndex = 15;
            this.buttonUpdateEvent.Text = "Update";
            this.buttonUpdateEvent.UseVisualStyleBackColor = true;
            this.buttonUpdateEvent.Click += new System.EventHandler(this.buttonUpdateEvent_Click);
            // 
            // panelCreateEvent
            // 
            this.panelCreateEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCreateEvent.Controls.Add(this.numericUpDownCreateEventCapacity);
            this.panelCreateEvent.Controls.Add(this.dateTimePickerCreateEventEndDate);
            this.panelCreateEvent.Controls.Add(this.dateTimePickerCreateEventStartDate);
            this.panelCreateEvent.Controls.Add(this.labelCreateEventGamId);
            this.panelCreateEvent.Controls.Add(this.textBoxCreateEventGameId);
            this.panelCreateEvent.Controls.Add(this.labelCreateEventEndDate);
            this.panelCreateEvent.Controls.Add(this.labelCreateEvent);
            this.panelCreateEvent.Controls.Add(this.labelCreateEventStartDate);
            this.panelCreateEvent.Controls.Add(this.labelCreateEventCapacity);
            this.panelCreateEvent.Controls.Add(this.buttonCreateEventCancel);
            this.panelCreateEvent.Controls.Add(this.buttonCreateEventFinish);
            this.panelCreateEvent.Controls.Add(this.labelCreateEventDescription);
            this.panelCreateEvent.Controls.Add(this.labelCreateEventName);
            this.panelCreateEvent.Controls.Add(this.textBoxCreateEventDescription);
            this.panelCreateEvent.Controls.Add(this.textBoxCreateEventName);
            this.panelCreateEvent.Location = new System.Drawing.Point(1195, 153);
            this.panelCreateEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCreateEvent.Name = "panelCreateEvent";
            this.panelCreateEvent.Size = new System.Drawing.Size(690, 544);
            this.panelCreateEvent.TabIndex = 14;
            // 
            // numericUpDownCreateEventCapacity
            // 
            this.numericUpDownCreateEventCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownCreateEventCapacity.Location = new System.Drawing.Point(77, 206);
            this.numericUpDownCreateEventCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCreateEventCapacity.Name = "numericUpDownCreateEventCapacity";
            this.numericUpDownCreateEventCapacity.Size = new System.Drawing.Size(249, 27);
            this.numericUpDownCreateEventCapacity.TabIndex = 17;
            this.numericUpDownCreateEventCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerCreateEventEndDate
            // 
            this.dateTimePickerCreateEventEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerCreateEventEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCreateEventEndDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerCreateEventEndDate.Location = new System.Drawing.Point(78, 333);
            this.dateTimePickerCreateEventEndDate.Name = "dateTimePickerCreateEventEndDate";
            this.dateTimePickerCreateEventEndDate.Size = new System.Drawing.Size(249, 27);
            this.dateTimePickerCreateEventEndDate.TabIndex = 28;
            this.dateTimePickerCreateEventEndDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerCreateEventStartDate
            // 
            this.dateTimePickerCreateEventStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerCreateEventStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCreateEventStartDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerCreateEventStartDate.Location = new System.Drawing.Point(78, 270);
            this.dateTimePickerCreateEventStartDate.Name = "dateTimePickerCreateEventStartDate";
            this.dateTimePickerCreateEventStartDate.Size = new System.Drawing.Size(248, 27);
            this.dateTimePickerCreateEventStartDate.TabIndex = 27;
            this.dateTimePickerCreateEventStartDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // labelCreateEventGamId
            // 
            this.labelCreateEventGamId.AutoSize = true;
            this.labelCreateEventGamId.Location = new System.Drawing.Point(371, 117);
            this.labelCreateEventGamId.Name = "labelCreateEventGamId";
            this.labelCreateEventGamId.Size = new System.Drawing.Size(67, 20);
            this.labelCreateEventGamId.TabIndex = 22;
            this.labelCreateEventGamId.Text = "Game ID";
            // 
            // textBoxCreateEventGameId
            // 
            this.textBoxCreateEventGameId.Location = new System.Drawing.Point(372, 141);
            this.textBoxCreateEventGameId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreateEventGameId.Name = "textBoxCreateEventGameId";
            this.textBoxCreateEventGameId.Size = new System.Drawing.Size(249, 27);
            this.textBoxCreateEventGameId.TabIndex = 21;
            // 
            // labelCreateEventEndDate
            // 
            this.labelCreateEventEndDate.AutoSize = true;
            this.labelCreateEventEndDate.Location = new System.Drawing.Point(77, 310);
            this.labelCreateEventEndDate.Name = "labelCreateEventEndDate";
            this.labelCreateEventEndDate.Size = new System.Drawing.Size(70, 20);
            this.labelCreateEventEndDate.TabIndex = 19;
            this.labelCreateEventEndDate.Text = "End Date";
            // 
            // labelCreateEvent
            // 
            this.labelCreateEvent.AutoSize = true;
            this.labelCreateEvent.Location = new System.Drawing.Point(281, 10);
            this.labelCreateEvent.Name = "labelCreateEvent";
            this.labelCreateEvent.Size = new System.Drawing.Size(130, 20);
            this.labelCreateEvent.TabIndex = 8;
            this.labelCreateEvent.Text = "Create Event Form";
            // 
            // labelCreateEventStartDate
            // 
            this.labelCreateEventStartDate.AutoSize = true;
            this.labelCreateEventStartDate.Location = new System.Drawing.Point(77, 246);
            this.labelCreateEventStartDate.Name = "labelCreateEventStartDate";
            this.labelCreateEventStartDate.Size = new System.Drawing.Size(76, 20);
            this.labelCreateEventStartDate.TabIndex = 17;
            this.labelCreateEventStartDate.Text = "Start Date";
            // 
            // labelCreateEventCapacity
            // 
            this.labelCreateEventCapacity.AutoSize = true;
            this.labelCreateEventCapacity.Location = new System.Drawing.Point(77, 182);
            this.labelCreateEventCapacity.Name = "labelCreateEventCapacity";
            this.labelCreateEventCapacity.Size = new System.Drawing.Size(66, 20);
            this.labelCreateEventCapacity.TabIndex = 17;
            this.labelCreateEventCapacity.Text = "Capacity";
            // 
            // buttonCreateEventCancel
            // 
            this.buttonCreateEventCancel.Location = new System.Drawing.Point(12, 502);
            this.buttonCreateEventCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateEventCancel.Name = "buttonCreateEventCancel";
            this.buttonCreateEventCancel.Size = new System.Drawing.Size(99, 31);
            this.buttonCreateEventCancel.TabIndex = 7;
            this.buttonCreateEventCancel.Text = "Cancel";
            this.buttonCreateEventCancel.UseVisualStyleBackColor = true;
            this.buttonCreateEventCancel.Click += new System.EventHandler(this.buttonCreateEventCancel_Click);
            // 
            // buttonCreateEventFinish
            // 
            this.buttonCreateEventFinish.Location = new System.Drawing.Point(574, 502);
            this.buttonCreateEventFinish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateEventFinish.Name = "buttonCreateEventFinish";
            this.buttonCreateEventFinish.Size = new System.Drawing.Size(99, 31);
            this.buttonCreateEventFinish.TabIndex = 6;
            this.buttonCreateEventFinish.Text = "Finish";
            this.buttonCreateEventFinish.UseVisualStyleBackColor = true;
            this.buttonCreateEventFinish.Click += new System.EventHandler(this.buttonCreateEventFinish_Click);
            // 
            // labelCreateEventDescription
            // 
            this.labelCreateEventDescription.AutoSize = true;
            this.labelCreateEventDescription.Location = new System.Drawing.Point(372, 181);
            this.labelCreateEventDescription.Name = "labelCreateEventDescription";
            this.labelCreateEventDescription.Size = new System.Drawing.Size(85, 20);
            this.labelCreateEventDescription.TabIndex = 5;
            this.labelCreateEventDescription.Text = "Description";
            // 
            // labelCreateEventName
            // 
            this.labelCreateEventName.AutoSize = true;
            this.labelCreateEventName.Location = new System.Drawing.Point(77, 119);
            this.labelCreateEventName.Name = "labelCreateEventName";
            this.labelCreateEventName.Size = new System.Drawing.Size(49, 20);
            this.labelCreateEventName.TabIndex = 3;
            this.labelCreateEventName.Text = "Name";
            // 
            // textBoxCreateEventDescription
            // 
            this.textBoxCreateEventDescription.Location = new System.Drawing.Point(372, 205);
            this.textBoxCreateEventDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreateEventDescription.Multiline = true;
            this.textBoxCreateEventDescription.Name = "textBoxCreateEventDescription";
            this.textBoxCreateEventDescription.Size = new System.Drawing.Size(249, 155);
            this.textBoxCreateEventDescription.TabIndex = 2;
            // 
            // textBoxCreateEventName
            // 
            this.textBoxCreateEventName.Location = new System.Drawing.Point(77, 143);
            this.textBoxCreateEventName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreateEventName.Name = "textBoxCreateEventName";
            this.textBoxCreateEventName.Size = new System.Drawing.Size(249, 27);
            this.textBoxCreateEventName.TabIndex = 0;
            // 
            // buttonCreateNewEvent
            // 
            this.buttonCreateNewEvent.Location = new System.Drawing.Point(1797, 19);
            this.buttonCreateNewEvent.Name = "buttonCreateNewEvent";
            this.buttonCreateNewEvent.Size = new System.Drawing.Size(99, 67);
            this.buttonCreateNewEvent.TabIndex = 6;
            this.buttonCreateNewEvent.Text = "Add New";
            this.buttonCreateNewEvent.UseVisualStyleBackColor = true;
            this.buttonCreateNewEvent.Click += new System.EventHandler(this.buttonCreateNewEvent_Click);
            // 
            // buttonDeleteEvent
            // 
            this.buttonDeleteEvent.Location = new System.Drawing.Point(302, 716);
            this.buttonDeleteEvent.Name = "buttonDeleteEvent";
            this.buttonDeleteEvent.Size = new System.Drawing.Size(200, 40);
            this.buttonDeleteEvent.TabIndex = 5;
            this.buttonDeleteEvent.Text = "Delete";
            this.buttonDeleteEvent.UseVisualStyleBackColor = true;
            this.buttonDeleteEvent.Click += new System.EventHandler(this.buttonDeleteEvent_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelCapacityCounter);
            this.panel2.Controls.Add(this.numericUpDownEventPage);
            this.panel2.Controls.Add(this.dateTimePickerEventEndDate);
            this.panel2.Controls.Add(this.dateTimePickerEventStartDate);
            this.panel2.Controls.Add(this.labelEventMemberList);
            this.panel2.Controls.Add(this.labelEventNamePanel);
            this.panel2.Controls.Add(this.buttonDeleteMember);
            this.panel2.Controls.Add(this.listBoxEventMember);
            this.panel2.Controls.Add(this.textBoxEventId);
            this.panel2.Controls.Add(this.labelEventId);
            this.panel2.Controls.Add(this.labelEventEndDate);
            this.panel2.Controls.Add(this.labelEventStartDate);
            this.panel2.Controls.Add(this.labelEventcapacity);
            this.panel2.Controls.Add(this.textBoxEventGameId);
            this.panel2.Controls.Add(this.labelEventGameId);
            this.panel2.Controls.Add(this.textBoxEventDescription);
            this.panel2.Controls.Add(this.labelEventDescription);
            this.panel2.Controls.Add(this.textBoxEventName);
            this.panel2.Controls.Add(this.labelEventName);
            this.panel2.Location = new System.Drawing.Point(532, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 544);
            this.panel2.TabIndex = 4;
            // 
            // numericUpDownEventPage
            // 
            this.numericUpDownEventPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownEventPage.Location = new System.Drawing.Point(46, 403);
            this.numericUpDownEventPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEventPage.Name = "numericUpDownEventPage";
            this.numericUpDownEventPage.ReadOnly = true;
            this.numericUpDownEventPage.Size = new System.Drawing.Size(250, 27);
            this.numericUpDownEventPage.TabIndex = 29;
            this.numericUpDownEventPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerEventEndDate
            // 
            this.dateTimePickerEventEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerEventEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEventEndDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerEventEndDate.Location = new System.Drawing.Point(332, 141);
            this.dateTimePickerEventEndDate.Name = "dateTimePickerEventEndDate";
            this.dateTimePickerEventEndDate.Size = new System.Drawing.Size(185, 27);
            this.dateTimePickerEventEndDate.TabIndex = 26;
            this.dateTimePickerEventEndDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerEventStartDate
            // 
            this.dateTimePickerEventStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerEventStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEventStartDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerEventStartDate.Location = new System.Drawing.Point(332, 77);
            this.dateTimePickerEventStartDate.Name = "dateTimePickerEventStartDate";
            this.dateTimePickerEventStartDate.Size = new System.Drawing.Size(185, 27);
            this.dateTimePickerEventStartDate.TabIndex = 23;
            this.dateTimePickerEventStartDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // labelEventMemberList
            // 
            this.labelEventMemberList.AutoSize = true;
            this.labelEventMemberList.Location = new System.Drawing.Point(332, 183);
            this.labelEventMemberList.Name = "labelEventMemberList";
            this.labelEventMemberList.Size = new System.Drawing.Size(71, 20);
            this.labelEventMemberList.TabIndex = 17;
            this.labelEventMemberList.Text = "Members";
            // 
            // labelEventNamePanel
            // 
            this.labelEventNamePanel.AutoSize = true;
            this.labelEventNamePanel.Location = new System.Drawing.Point(279, 10);
            this.labelEventNamePanel.Name = "labelEventNamePanel";
            this.labelEventNamePanel.Size = new System.Drawing.Size(49, 20);
            this.labelEventNamePanel.TabIndex = 16;
            this.labelEventNamePanel.Text = "Name";
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Location = new System.Drawing.Point(399, 436);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(200, 40);
            this.buttonDeleteMember.TabIndex = 15;
            this.buttonDeleteMember.Text = "Remove";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            this.buttonDeleteMember.Click += new System.EventHandler(this.buttonDeleteMember_Click);
            // 
            // listBoxEventMember
            // 
            this.listBoxEventMember.FormattingEnabled = true;
            this.listBoxEventMember.ItemHeight = 20;
            this.listBoxEventMember.Location = new System.Drawing.Point(332, 206);
            this.listBoxEventMember.Name = "listBoxEventMember";
            this.listBoxEventMember.Size = new System.Drawing.Size(267, 224);
            this.listBoxEventMember.TabIndex = 14;
            this.listBoxEventMember.SelectedIndexChanged += new System.EventHandler(this.listBoxEventMember_SelectedIndexChanged);
            // 
            // textBoxEventId
            // 
            this.textBoxEventId.Location = new System.Drawing.Point(46, 77);
            this.textBoxEventId.Name = "textBoxEventId";
            this.textBoxEventId.ReadOnly = true;
            this.textBoxEventId.Size = new System.Drawing.Size(250, 27);
            this.textBoxEventId.TabIndex = 13;
            // 
            // labelEventId
            // 
            this.labelEventId.AutoSize = true;
            this.labelEventId.Location = new System.Drawing.Point(46, 54);
            this.labelEventId.Name = "labelEventId";
            this.labelEventId.Size = new System.Drawing.Size(24, 20);
            this.labelEventId.TabIndex = 12;
            this.labelEventId.Text = "ID";
            // 
            // labelEventEndDate
            // 
            this.labelEventEndDate.AutoSize = true;
            this.labelEventEndDate.Location = new System.Drawing.Point(332, 118);
            this.labelEventEndDate.Name = "labelEventEndDate";
            this.labelEventEndDate.Size = new System.Drawing.Size(70, 20);
            this.labelEventEndDate.TabIndex = 10;
            this.labelEventEndDate.Text = "End Date";
            // 
            // labelEventStartDate
            // 
            this.labelEventStartDate.AutoSize = true;
            this.labelEventStartDate.Location = new System.Drawing.Point(332, 54);
            this.labelEventStartDate.Name = "labelEventStartDate";
            this.labelEventStartDate.Size = new System.Drawing.Size(76, 20);
            this.labelEventStartDate.TabIndex = 8;
            this.labelEventStartDate.Text = "Start Date";
            // 
            // labelEventcapacity
            // 
            this.labelEventcapacity.AutoSize = true;
            this.labelEventcapacity.Location = new System.Drawing.Point(46, 375);
            this.labelEventcapacity.Name = "labelEventcapacity";
            this.labelEventcapacity.Size = new System.Drawing.Size(66, 20);
            this.labelEventcapacity.TabIndex = 6;
            this.labelEventcapacity.Text = "Capacity";
            // 
            // textBoxEventGameId
            // 
            this.textBoxEventGameId.Location = new System.Drawing.Point(46, 334);
            this.textBoxEventGameId.Name = "textBoxEventGameId";
            this.textBoxEventGameId.ReadOnly = true;
            this.textBoxEventGameId.Size = new System.Drawing.Size(250, 27);
            this.textBoxEventGameId.TabIndex = 5;
            // 
            // labelEventGameId
            // 
            this.labelEventGameId.AutoSize = true;
            this.labelEventGameId.Location = new System.Drawing.Point(46, 311);
            this.labelEventGameId.Name = "labelEventGameId";
            this.labelEventGameId.Size = new System.Drawing.Size(67, 20);
            this.labelEventGameId.TabIndex = 4;
            this.labelEventGameId.Text = "Game ID";
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(46, 206);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(250, 91);
            this.textBoxEventDescription.TabIndex = 3;
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.AutoSize = true;
            this.labelEventDescription.Location = new System.Drawing.Point(46, 183);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(85, 20);
            this.labelEventDescription.TabIndex = 2;
            this.labelEventDescription.Text = "Description";
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(46, 141);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(250, 27);
            this.textBoxEventName.TabIndex = 1;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(46, 118);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(49, 20);
            this.labelEventName.TabIndex = 0;
            this.labelEventName.Text = "Name";
            // 
            // textBoxEventIdSerach
            // 
            this.textBoxEventIdSerach.Location = new System.Drawing.Point(59, 80);
            this.textBoxEventIdSerach.Name = "textBoxEventIdSerach";
            this.textBoxEventIdSerach.PlaceholderText = "ID";
            this.textBoxEventIdSerach.Size = new System.Drawing.Size(183, 27);
            this.textBoxEventIdSerach.TabIndex = 3;
            // 
            // buttonSearchEventById
            // 
            this.buttonSearchEventById.Location = new System.Drawing.Point(302, 73);
            this.buttonSearchEventById.Name = "buttonSearchEventById";
            this.buttonSearchEventById.Size = new System.Drawing.Size(200, 40);
            this.buttonSearchEventById.TabIndex = 2;
            this.buttonSearchEventById.Text = "Search";
            this.buttonSearchEventById.UseVisualStyleBackColor = true;
            this.buttonSearchEventById.Click += new System.EventHandler(this.buttonSearchEventById_Click);
            // 
            // buttonShowAllEvent
            // 
            this.buttonShowAllEvent.Location = new System.Drawing.Point(302, 19);
            this.buttonShowAllEvent.Name = "buttonShowAllEvent";
            this.buttonShowAllEvent.Size = new System.Drawing.Size(200, 40);
            this.buttonShowAllEvent.TabIndex = 1;
            this.buttonShowAllEvent.Text = "Show All";
            this.buttonShowAllEvent.UseVisualStyleBackColor = true;
            this.buttonShowAllEvent.Click += new System.EventHandler(this.buttonShowAllEvent_Click);
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.ItemHeight = 20;
            this.listBoxEvent.Location = new System.Drawing.Point(59, 153);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(442, 544);
            this.listBoxEvent.TabIndex = 0;
            this.listBoxEvent.SelectedIndexChanged += new System.EventHandler(this.listBoxEvent_SelectedIndexChanged);
            // 
            // SalesMenuBar
            // 
            this.SalesMenuBar.Location = new System.Drawing.Point(4, 54);
            this.SalesMenuBar.Name = "SalesMenuBar";
            this.SalesMenuBar.Size = new System.Drawing.Size(1922, 992);
            this.SalesMenuBar.TabIndex = 3;
            this.SalesMenuBar.Text = "Sales";
            this.SalesMenuBar.UseVisualStyleBackColor = true;
            // 
            // LoginMenuBar
            // 
            this.LoginMenuBar.Location = new System.Drawing.Point(4, 54);
            this.LoginMenuBar.Name = "LoginMenuBar";
            this.LoginMenuBar.Size = new System.Drawing.Size(1922, 992);
            this.LoginMenuBar.TabIndex = 4;
            this.LoginMenuBar.Text = "Login";
            this.LoginMenuBar.UseVisualStyleBackColor = true;
            // 
            // labelCapacityCounter
            // 
            this.labelCapacityCounter.AutoSize = true;
            this.labelCapacityCounter.Location = new System.Drawing.Point(549, 182);
            this.labelCapacityCounter.Name = "labelCapacityCounter";
            this.labelCapacityCounter.Size = new System.Drawing.Size(50, 20);
            this.labelCapacityCounter.TabIndex = 30;
            this.labelCapacityCounter.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.DeveloperMenuBar.ResumeLayout(false);
            this.DeveloperMenuBar.PerformLayout();
            this.panelCreateDeveloper.ResumeLayout(false);
            this.panelCreateDeveloper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EventMenuBar.ResumeLayout(false);
            this.EventMenuBar.PerformLayout();
            this.panelCreateEvent.ResumeLayout(false);
            this.panelCreateEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreateEventCapacity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private Panel panel2;
        private TextBox textBoxEventIdSerach;
        private Button buttonSearchEventById;
        private Button buttonShowAllEvent;
        private ListBox listBoxEvent;
        private ListBox listBoxEventMember;
        private TextBox textBoxEventId;
        private Label labelEventId;
        private Label labelEventEndDate;
        private Label labelEventStartDate;
        private TextBox textBoxEventGameId;
        private Label labelEventGameId;
        private TextBox textBoxEventDescription;
        private Label labelEventDescription;
        private TextBox textBoxEventName;
        private Label labelEventName;
        private Button buttonDeleteMember;
        private Button buttonUpdateEvent;
        private Panel panelCreateEvent;
        private Label labelCreateEventEndDate;
        private Label labelCreateEvent;
        private Label labelCreateEventStartDate;
        private Label labelCreateEventCapacity;
        private Button buttonCreateEventCancel;
        private Button buttonCreateEventFinish;
        private Label labelCreateEventDescription;
        private Label labelCreateEventName;
        private TextBox textBoxCreateEventDescription;
        private TextBox textBoxCreateEventName;
        private Button buttonCreateNewEvent;
        private Button buttonDeleteEvent;
        private Label labelEventMemberList;
        private Label labelEventNamePanel;
        private Label labelEventcapacity;
        private Label labelCreateEventGamId;
        private TextBox textBoxCreateEventGameId;
        private DateTimePicker dateTimePickerEventStartDate;
        private DateTimePicker dateTimePickerEventEndDate;
        private DateTimePicker dateTimePickerCreateEventEndDate;
        private DateTimePicker dateTimePickerCreateEventStartDate;
        private NumericUpDown numericUpDownCreateEventCapacity;
        private NumericUpDown numericUpDownEventPage;
        private Label labelCapacityCounter;
    }
}