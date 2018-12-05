namespace GUI
{
    partial class UnifiedGuiForm
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
            this.DynamicTabControl = new System.Windows.Forms.TabControl();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Opret_sag = new System.Windows.Forms.TabPage();
            this.Sag_drop_YdelseTypeNr = new System.Windows.Forms.ComboBox();
            this.lbl_Slut = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.lbl_Sags = new System.Windows.Forms.Label();
            this.lbl_YdelseNr = new System.Windows.Forms.Label();
            this.lbl_Noter = new System.Windows.Forms.Label();
            this.lbl_Sagsbeskrivelse = new System.Windows.Forms.Label();
            this.txt_Sag_InterneNoter = new System.Windows.Forms.TextBox();
            this.txt_Sag_SagsBeskrivelse = new System.Windows.Forms.TextBox();
            this.txt_Sag_StartDato = new System.Windows.Forms.TextBox();
            this.Sag_drop_MedarbejderNr = new System.Windows.Forms.ComboBox();
            this.txt_Sag_KlientNr = new System.Windows.Forms.TextBox();
            this.lbl_Medarbejder = new System.Windows.Forms.Label();
            this.lbl_Klientnr = new System.Windows.Forms.Label();
            this.Datetimepicker_Sag_slutdato = new System.Windows.Forms.DateTimePicker();
            this.txt_Sag_time = new System.Windows.Forms.TextBox();
            this.txt_Sag_titel = new System.Windows.Forms.TextBox();
            this.txt_Sag_kørsel = new System.Windows.Forms.TextBox();
            this.txt_Sag_Sagsnr = new System.Windows.Forms.TextBox();
            this.lbl_TimeEstimat = new System.Windows.Forms.Label();
            this.lbl_Kørselstimer = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_Titel = new System.Windows.Forms.Label();
            this.Opret_advokat = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Advokat_SpecialeNavn = new System.Windows.Forms.TextBox();
            this.txt_Advokat_AdvokatId = new System.Windows.Forms.TextBox();
            this.lbl_SpecialeNavn = new System.Windows.Forms.Label();
            this.lbl_AdvokatId = new System.Windows.Forms.Label();
            this.lbl_AdvokatNavn = new System.Windows.Forms.Label();
            this.txt_Advokat_AdvokatNavn = new System.Windows.Forms.TextBox();
            this.btn_AddSpecialToAdvokat = new System.Windows.Forms.Button();
            this.btn_CreateAdvokat = new System.Windows.Forms.Button();
            this.Opret_klient = new System.Windows.Forms.TabPage();
            this.bnt_Klient_Opret = new System.Windows.Forms.Button();
            this.lbl_TelefonNr = new System.Windows.Forms.Label();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.lbl_navn = new System.Windows.Forms.Label();
            this.Txt_Klient_TelefonNr = new System.Windows.Forms.TextBox();
            this.Txt_Klient_Adresse = new System.Windows.Forms.TextBox();
            this.Txt_Klient_navn = new System.Windows.Forms.TextBox();
            this.Opret_ydelse = new System.Windows.Forms.TabPage();
            this.bnt_Ydelse_tilføj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sagsnr = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_pris = new System.Windows.Forms.Label();
            this.lbl_Beskrivelse = new System.Windows.Forms.Label();
            this.lbl_startdato = new System.Windows.Forms.Label();
            this.lbl_Nr = new System.Windows.Forms.Label();
            this.txt_ydelse_AdvokatID = new System.Windows.Forms.TextBox();
            this.txt_ydelse_sagsNr = new System.Windows.Forms.TextBox();
            this.txt_ydelse_timer = new System.Windows.Forms.TextBox();
            this.txt_ydelse_Pris = new System.Windows.Forms.TextBox();
            this.txt_ydelse_beskrivelse = new System.Windows.Forms.TextBox();
            this.txt_ydelse_startdato = new System.Windows.Forms.TextBox();
            this.txt_ydelse_ydelsesNr = new System.Windows.Forms.TextBox();
            this.Se_oversigt = new System.Windows.Forms.TabPage();
            this.combobox_hvad_type = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SagsNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Arbejdstitel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.StartDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Slutdate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Kørselstimer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TimeEstimat = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SagsBeskrivelse = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InterneNoter = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.KlientNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.MedarbejderNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.YdelsesTypeNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Navn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Adresse = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TelefonNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Advokat_navn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.YdelsesNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.YdelseBeskrivelse = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Pris = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Timer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AdvokatID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btn_GoToFormCreateAdvokat = new System.Windows.Forms.Button();
            this.Btn_CreateKlient = new System.Windows.Forms.Button();
            this.btn_GåtilYdelse = new System.Windows.Forms.Button();
            this.Btn_Oversigt = new System.Windows.Forms.Button();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.btn_opretsag = new System.Windows.Forms.Button();
            this.DynamicTabControl.SuspendLayout();
            this.tabStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Opret_sag.SuspendLayout();
            this.Opret_advokat.SuspendLayout();
            this.Opret_klient.SuspendLayout();
            this.Opret_ydelse.SuspendLayout();
            this.Se_oversigt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DynamicTabControl
            // 
            this.DynamicTabControl.Controls.Add(this.tabStart);
            this.DynamicTabControl.Controls.Add(this.Opret_sag);
            this.DynamicTabControl.Controls.Add(this.Opret_advokat);
            this.DynamicTabControl.Controls.Add(this.Opret_klient);
            this.DynamicTabControl.Controls.Add(this.Opret_ydelse);
            this.DynamicTabControl.Controls.Add(this.Se_oversigt);
            this.DynamicTabControl.ItemSize = new System.Drawing.Size(170, 20);
            this.DynamicTabControl.Location = new System.Drawing.Point(157, 1);
            this.DynamicTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DynamicTabControl.Name = "DynamicTabControl";
            this.DynamicTabControl.SelectedIndex = 0;
            this.DynamicTabControl.Size = new System.Drawing.Size(684, 521);
            this.DynamicTabControl.TabIndex = 0;
            // 
            // tabStart
            // 
            this.tabStart.Controls.Add(this.pictureBox1);
            this.tabStart.Location = new System.Drawing.Point(4, 24);
            this.tabStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStart.Name = "tabStart";
            this.tabStart.Size = new System.Drawing.Size(676, 493);
            this.tabStart.TabIndex = 5;
            this.tabStart.Text = "Startside";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images_første_forsøg_Tydeligt_500x500;
            this.pictureBox1.Location = new System.Drawing.Point(62, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 467);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Opret_sag
            // 
            this.Opret_sag.Controls.Add(this.Sag_drop_YdelseTypeNr);
            this.Opret_sag.Controls.Add(this.lbl_Slut);
            this.Opret_sag.Controls.Add(this.btn_Create);
            this.Opret_sag.Controls.Add(this.lbl_Sags);
            this.Opret_sag.Controls.Add(this.lbl_YdelseNr);
            this.Opret_sag.Controls.Add(this.lbl_Noter);
            this.Opret_sag.Controls.Add(this.lbl_Sagsbeskrivelse);
            this.Opret_sag.Controls.Add(this.txt_Sag_InterneNoter);
            this.Opret_sag.Controls.Add(this.txt_Sag_SagsBeskrivelse);
            this.Opret_sag.Controls.Add(this.txt_Sag_StartDato);
            this.Opret_sag.Controls.Add(this.Sag_drop_MedarbejderNr);
            this.Opret_sag.Controls.Add(this.txt_Sag_KlientNr);
            this.Opret_sag.Controls.Add(this.lbl_Medarbejder);
            this.Opret_sag.Controls.Add(this.lbl_Klientnr);
            this.Opret_sag.Controls.Add(this.Datetimepicker_Sag_slutdato);
            this.Opret_sag.Controls.Add(this.txt_Sag_time);
            this.Opret_sag.Controls.Add(this.txt_Sag_titel);
            this.Opret_sag.Controls.Add(this.txt_Sag_kørsel);
            this.Opret_sag.Controls.Add(this.txt_Sag_Sagsnr);
            this.Opret_sag.Controls.Add(this.lbl_TimeEstimat);
            this.Opret_sag.Controls.Add(this.lbl_Kørselstimer);
            this.Opret_sag.Controls.Add(this.lbl_Start);
            this.Opret_sag.Controls.Add(this.lbl_Titel);
            this.Opret_sag.Location = new System.Drawing.Point(4, 24);
            this.Opret_sag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opret_sag.Name = "Opret_sag";
            this.Opret_sag.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opret_sag.Size = new System.Drawing.Size(676, 493);
            this.Opret_sag.TabIndex = 0;
            this.Opret_sag.Text = "Sag";
            this.Opret_sag.UseVisualStyleBackColor = true;
            // 
            // Sag_drop_YdelseTypeNr
            // 
            this.Sag_drop_YdelseTypeNr.FormattingEnabled = true;
            this.Sag_drop_YdelseTypeNr.Location = new System.Drawing.Point(293, 20);
            this.Sag_drop_YdelseTypeNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sag_drop_YdelseTypeNr.Name = "Sag_drop_YdelseTypeNr";
            this.Sag_drop_YdelseTypeNr.Size = new System.Drawing.Size(128, 21);
            this.Sag_drop_YdelseTypeNr.TabIndex = 31;
            // 
            // lbl_Slut
            // 
            this.lbl_Slut.AutoSize = true;
            this.lbl_Slut.Location = new System.Drawing.Point(196, 187);
            this.lbl_Slut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Slut.Name = "lbl_Slut";
            this.lbl_Slut.Size = new System.Drawing.Size(49, 13);
            this.lbl_Slut.TabIndex = 58;
            this.lbl_Slut.Text = "Slut dato";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(512, 422);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(121, 23);
            this.btn_Create.TabIndex = 57;
            this.btn_Create.Text = "Opret Sag";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // lbl_Sags
            // 
            this.lbl_Sags.AutoSize = true;
            this.lbl_Sags.Location = new System.Drawing.Point(196, 65);
            this.lbl_Sags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Sags.Name = "lbl_Sags";
            this.lbl_Sags.Size = new System.Drawing.Size(43, 13);
            this.lbl_Sags.TabIndex = 57;
            this.lbl_Sags.Text = "Sags nr";
            // 
            // lbl_YdelseNr
            // 
            this.lbl_YdelseNr.AutoSize = true;
            this.lbl_YdelseNr.Location = new System.Drawing.Point(196, 26);
            this.lbl_YdelseNr.Name = "lbl_YdelseNr";
            this.lbl_YdelseNr.Size = new System.Drawing.Size(54, 13);
            this.lbl_YdelseNr.TabIndex = 56;
            this.lbl_YdelseNr.Text = "Sags type";
            // 
            // lbl_Noter
            // 
            this.lbl_Noter.AutoSize = true;
            this.lbl_Noter.Location = new System.Drawing.Point(196, 344);
            this.lbl_Noter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Noter.Name = "lbl_Noter";
            this.lbl_Noter.Size = new System.Drawing.Size(67, 13);
            this.lbl_Noter.TabIndex = 54;
            this.lbl_Noter.Text = "Interne noter";
            // 
            // lbl_Sagsbeskrivelse
            // 
            this.lbl_Sagsbeskrivelse.AutoSize = true;
            this.lbl_Sagsbeskrivelse.Location = new System.Drawing.Point(196, 309);
            this.lbl_Sagsbeskrivelse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Sagsbeskrivelse.Name = "lbl_Sagsbeskrivelse";
            this.lbl_Sagsbeskrivelse.Size = new System.Drawing.Size(84, 13);
            this.lbl_Sagsbeskrivelse.TabIndex = 53;
            this.lbl_Sagsbeskrivelse.Text = "Sagsbeskrivelse";
            // 
            // txt_Sag_InterneNoter
            // 
            this.txt_Sag_InterneNoter.Location = new System.Drawing.Point(293, 345);
            this.txt_Sag_InterneNoter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Sag_InterneNoter.Name = "txt_Sag_InterneNoter";
            this.txt_Sag_InterneNoter.Size = new System.Drawing.Size(128, 20);
            this.txt_Sag_InterneNoter.TabIndex = 43;
            // 
            // txt_Sag_SagsBeskrivelse
            // 
            this.txt_Sag_SagsBeskrivelse.Location = new System.Drawing.Point(293, 305);
            this.txt_Sag_SagsBeskrivelse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sag_SagsBeskrivelse.Name = "txt_Sag_SagsBeskrivelse";
            this.txt_Sag_SagsBeskrivelse.Size = new System.Drawing.Size(128, 20);
            this.txt_Sag_SagsBeskrivelse.TabIndex = 42;
            // 
            // txt_Sag_StartDato
            // 
            this.txt_Sag_StartDato.Enabled = false;
            this.txt_Sag_StartDato.Location = new System.Drawing.Point(293, 145);
            this.txt_Sag_StartDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Sag_StartDato.Name = "txt_Sag_StartDato";
            this.txt_Sag_StartDato.Size = new System.Drawing.Size(128, 20);
            this.txt_Sag_StartDato.TabIndex = 36;
            // 
            // Sag_drop_MedarbejderNr
            // 
            this.Sag_drop_MedarbejderNr.Location = new System.Drawing.Point(293, 386);
            this.Sag_drop_MedarbejderNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sag_drop_MedarbejderNr.Name = "Sag_drop_MedarbejderNr";
            this.Sag_drop_MedarbejderNr.Size = new System.Drawing.Size(128, 21);
            this.Sag_drop_MedarbejderNr.TabIndex = 44;
            // 
            // txt_Sag_KlientNr
            // 
            this.txt_Sag_KlientNr.Location = new System.Drawing.Point(293, 427);
            this.txt_Sag_KlientNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Sag_KlientNr.Name = "txt_Sag_KlientNr";
            this.txt_Sag_KlientNr.Size = new System.Drawing.Size(128, 20);
            this.txt_Sag_KlientNr.TabIndex = 45;
            // 
            // lbl_Medarbejder
            // 
            this.lbl_Medarbejder.AutoSize = true;
            this.lbl_Medarbejder.Location = new System.Drawing.Point(196, 392);
            this.lbl_Medarbejder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Medarbejder.Name = "lbl_Medarbejder";
            this.lbl_Medarbejder.Size = new System.Drawing.Size(66, 13);
            this.lbl_Medarbejder.TabIndex = 49;
            this.lbl_Medarbejder.Text = "Medarbejder";
            // 
            // lbl_Klientnr
            // 
            this.lbl_Klientnr.AutoSize = true;
            this.lbl_Klientnr.Location = new System.Drawing.Point(196, 431);
            this.lbl_Klientnr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Klientnr.Name = "lbl_Klientnr";
            this.lbl_Klientnr.Size = new System.Drawing.Size(42, 13);
            this.lbl_Klientnr.TabIndex = 47;
            this.lbl_Klientnr.Text = "Klientnr";
            // 
            // Datetimepicker_Sag_slutdato
            // 
            this.Datetimepicker_Sag_slutdato.Location = new System.Drawing.Point(293, 183);
            this.Datetimepicker_Sag_slutdato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Datetimepicker_Sag_slutdato.Name = "Datetimepicker_Sag_slutdato";
            this.Datetimepicker_Sag_slutdato.Size = new System.Drawing.Size(128, 20);
            this.Datetimepicker_Sag_slutdato.TabIndex = 38;
            // 
            // txt_Sag_time
            // 
            this.txt_Sag_time.Location = new System.Drawing.Point(293, 264);
            this.txt_Sag_time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Sag_time.Name = "txt_Sag_time";
            this.txt_Sag_time.Size = new System.Drawing.Size(128, 20);
            this.txt_Sag_time.TabIndex = 41;
            // 
            // txt_Sag_titel
            // 
            this.txt_Sag_titel.Location = new System.Drawing.Point(293, 102);
            this.txt_Sag_titel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Sag_titel.Name = "txt_Sag_titel";
            this.txt_Sag_titel.Size = new System.Drawing.Size(128, 20);
            this.txt_Sag_titel.TabIndex = 35;
            // 
            // txt_Sag_kørsel
            // 
            this.txt_Sag_kørsel.Location = new System.Drawing.Point(293, 223);
            this.txt_Sag_kørsel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Sag_kørsel.Name = "txt_Sag_kørsel";
            this.txt_Sag_kørsel.Size = new System.Drawing.Size(128, 20);
            this.txt_Sag_kørsel.TabIndex = 40;
            // 
            // txt_Sag_Sagsnr
            // 
            this.txt_Sag_Sagsnr.Enabled = false;
            this.txt_Sag_Sagsnr.Location = new System.Drawing.Point(293, 61);
            this.txt_Sag_Sagsnr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Sag_Sagsnr.Name = "txt_Sag_Sagsnr";
            this.txt_Sag_Sagsnr.Size = new System.Drawing.Size(128, 20);
            this.txt_Sag_Sagsnr.TabIndex = 32;
            // 
            // lbl_TimeEstimat
            // 
            this.lbl_TimeEstimat.AutoSize = true;
            this.lbl_TimeEstimat.Location = new System.Drawing.Point(196, 268);
            this.lbl_TimeEstimat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TimeEstimat.Name = "lbl_TimeEstimat";
            this.lbl_TimeEstimat.Size = new System.Drawing.Size(66, 13);
            this.lbl_TimeEstimat.TabIndex = 39;
            this.lbl_TimeEstimat.Text = "Time estimat";
            // 
            // lbl_Kørselstimer
            // 
            this.lbl_Kørselstimer.AutoSize = true;
            this.lbl_Kørselstimer.Location = new System.Drawing.Point(196, 228);
            this.lbl_Kørselstimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Kørselstimer.Name = "lbl_Kørselstimer";
            this.lbl_Kørselstimer.Size = new System.Drawing.Size(63, 13);
            this.lbl_Kørselstimer.TabIndex = 37;
            this.lbl_Kørselstimer.Text = "Kørselstimer";
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Location = new System.Drawing.Point(196, 149);
            this.lbl_Start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(53, 13);
            this.lbl_Start.TabIndex = 34;
            this.lbl_Start.Text = "Start dato";
            // 
            // lbl_Titel
            // 
            this.lbl_Titel.AutoSize = true;
            this.lbl_Titel.Location = new System.Drawing.Point(196, 106);
            this.lbl_Titel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Titel.Name = "lbl_Titel";
            this.lbl_Titel.Size = new System.Drawing.Size(58, 13);
            this.lbl_Titel.TabIndex = 33;
            this.lbl_Titel.Text = "Arbejdstitel";
            // 
            // Opret_advokat
            // 
            this.Opret_advokat.BackColor = System.Drawing.Color.White;
            this.Opret_advokat.Controls.Add(this.button1);
            this.Opret_advokat.Controls.Add(this.txt_Advokat_SpecialeNavn);
            this.Opret_advokat.Controls.Add(this.txt_Advokat_AdvokatId);
            this.Opret_advokat.Controls.Add(this.lbl_SpecialeNavn);
            this.Opret_advokat.Controls.Add(this.lbl_AdvokatId);
            this.Opret_advokat.Controls.Add(this.lbl_AdvokatNavn);
            this.Opret_advokat.Controls.Add(this.txt_Advokat_AdvokatNavn);
            this.Opret_advokat.Controls.Add(this.btn_AddSpecialToAdvokat);
            this.Opret_advokat.Controls.Add(this.btn_CreateAdvokat);
            this.Opret_advokat.Location = new System.Drawing.Point(4, 24);
            this.Opret_advokat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opret_advokat.Name = "Opret_advokat";
            this.Opret_advokat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opret_advokat.Size = new System.Drawing.Size(676, 493);
            this.Opret_advokat.TabIndex = 1;
            this.Opret_advokat.Text = "Advokat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_Advokat_SpecialeNavn
            // 
            this.txt_Advokat_SpecialeNavn.Location = new System.Drawing.Point(284, 271);
            this.txt_Advokat_SpecialeNavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Advokat_SpecialeNavn.Name = "txt_Advokat_SpecialeNavn";
            this.txt_Advokat_SpecialeNavn.Size = new System.Drawing.Size(76, 20);
            this.txt_Advokat_SpecialeNavn.TabIndex = 16;
            // 
            // txt_Advokat_AdvokatId
            // 
            this.txt_Advokat_AdvokatId.Location = new System.Drawing.Point(284, 237);
            this.txt_Advokat_AdvokatId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Advokat_AdvokatId.Name = "txt_Advokat_AdvokatId";
            this.txt_Advokat_AdvokatId.Size = new System.Drawing.Size(76, 20);
            this.txt_Advokat_AdvokatId.TabIndex = 15;
            // 
            // lbl_SpecialeNavn
            // 
            this.lbl_SpecialeNavn.AutoSize = true;
            this.lbl_SpecialeNavn.Location = new System.Drawing.Point(193, 274);
            this.lbl_SpecialeNavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SpecialeNavn.Name = "lbl_SpecialeNavn";
            this.lbl_SpecialeNavn.Size = new System.Drawing.Size(87, 13);
            this.lbl_SpecialeNavn.TabIndex = 14;
            this.lbl_SpecialeNavn.Text = "Efteruddannelse:";
            // 
            // lbl_AdvokatId
            // 
            this.lbl_AdvokatId.AutoSize = true;
            this.lbl_AdvokatId.Location = new System.Drawing.Point(221, 237);
            this.lbl_AdvokatId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AdvokatId.Name = "lbl_AdvokatId";
            this.lbl_AdvokatId.Size = new System.Drawing.Size(62, 13);
            this.lbl_AdvokatId.TabIndex = 13;
            this.lbl_AdvokatId.Text = "Advokat Id:";
            // 
            // lbl_AdvokatNavn
            // 
            this.lbl_AdvokatNavn.AutoSize = true;
            this.lbl_AdvokatNavn.Location = new System.Drawing.Point(200, 119);
            this.lbl_AdvokatNavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AdvokatNavn.Name = "lbl_AdvokatNavn";
            this.lbl_AdvokatNavn.Size = new System.Drawing.Size(79, 13);
            this.lbl_AdvokatNavn.TabIndex = 12;
            this.lbl_AdvokatNavn.Text = "Advokat Navn:";
            // 
            // txt_Advokat_AdvokatNavn
            // 
            this.txt_Advokat_AdvokatNavn.Location = new System.Drawing.Point(280, 117);
            this.txt_Advokat_AdvokatNavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Advokat_AdvokatNavn.Name = "txt_Advokat_AdvokatNavn";
            this.txt_Advokat_AdvokatNavn.Size = new System.Drawing.Size(76, 20);
            this.txt_Advokat_AdvokatNavn.TabIndex = 11;
            // 
            // btn_AddSpecialToAdvokat
            // 
            this.btn_AddSpecialToAdvokat.Location = new System.Drawing.Point(81, 237);
            this.btn_AddSpecialToAdvokat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddSpecialToAdvokat.Name = "btn_AddSpecialToAdvokat";
            this.btn_AddSpecialToAdvokat.Size = new System.Drawing.Size(100, 62);
            this.btn_AddSpecialToAdvokat.TabIndex = 10;
            this.btn_AddSpecialToAdvokat.Text = "Tilføj Efteruddannelse";
            this.btn_AddSpecialToAdvokat.UseVisualStyleBackColor = true;
            this.btn_AddSpecialToAdvokat.Click += new System.EventHandler(this.btn_AddSpecialToAdvokat_Click);
            // 
            // btn_CreateAdvokat
            // 
            this.btn_CreateAdvokat.Location = new System.Drawing.Point(81, 97);
            this.btn_CreateAdvokat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateAdvokat.Name = "btn_CreateAdvokat";
            this.btn_CreateAdvokat.Size = new System.Drawing.Size(104, 58);
            this.btn_CreateAdvokat.TabIndex = 9;
            this.btn_CreateAdvokat.Text = "Opret Advokat";
            this.btn_CreateAdvokat.UseVisualStyleBackColor = true;
            this.btn_CreateAdvokat.Click += new System.EventHandler(this.btn_CreateAdvokat_Click);
            // 
            // Opret_klient
            // 
            this.Opret_klient.Controls.Add(this.bnt_Klient_Opret);
            this.Opret_klient.Controls.Add(this.lbl_TelefonNr);
            this.Opret_klient.Controls.Add(this.lbl_Adresse);
            this.Opret_klient.Controls.Add(this.lbl_navn);
            this.Opret_klient.Controls.Add(this.Txt_Klient_TelefonNr);
            this.Opret_klient.Controls.Add(this.Txt_Klient_Adresse);
            this.Opret_klient.Controls.Add(this.Txt_Klient_navn);
            this.Opret_klient.Location = new System.Drawing.Point(4, 24);
            this.Opret_klient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opret_klient.Name = "Opret_klient";
            this.Opret_klient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opret_klient.Size = new System.Drawing.Size(676, 493);
            this.Opret_klient.TabIndex = 2;
            this.Opret_klient.Text = "Klient";
            this.Opret_klient.UseVisualStyleBackColor = true;
            // 
            // bnt_Klient_Opret
            // 
            this.bnt_Klient_Opret.Location = new System.Drawing.Point(121, 289);
            this.bnt_Klient_Opret.Name = "bnt_Klient_Opret";
            this.bnt_Klient_Opret.Size = new System.Drawing.Size(166, 23);
            this.bnt_Klient_Opret.TabIndex = 13;
            this.bnt_Klient_Opret.Text = "Opret Klient";
            this.bnt_Klient_Opret.UseVisualStyleBackColor = true;
            this.bnt_Klient_Opret.Click += new System.EventHandler(this.btn_OpretKlient);
            // 
            // lbl_TelefonNr
            // 
            this.lbl_TelefonNr.AutoSize = true;
            this.lbl_TelefonNr.Location = new System.Drawing.Point(257, 241);
            this.lbl_TelefonNr.Name = "lbl_TelefonNr";
            this.lbl_TelefonNr.Size = new System.Drawing.Size(54, 13);
            this.lbl_TelefonNr.TabIndex = 12;
            this.lbl_TelefonNr.Text = "TelefonNr";
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Location = new System.Drawing.Point(257, 197);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(45, 13);
            this.lbl_Adresse.TabIndex = 11;
            this.lbl_Adresse.Text = "Adresse";
            // 
            // lbl_navn
            // 
            this.lbl_navn.AutoSize = true;
            this.lbl_navn.Location = new System.Drawing.Point(257, 154);
            this.lbl_navn.Name = "lbl_navn";
            this.lbl_navn.Size = new System.Drawing.Size(33, 13);
            this.lbl_navn.TabIndex = 10;
            this.lbl_navn.Text = "Navn";
            // 
            // Txt_Klient_TelefonNr
            // 
            this.Txt_Klient_TelefonNr.Location = new System.Drawing.Point(121, 241);
            this.Txt_Klient_TelefonNr.Name = "Txt_Klient_TelefonNr";
            this.Txt_Klient_TelefonNr.Size = new System.Drawing.Size(100, 20);
            this.Txt_Klient_TelefonNr.TabIndex = 9;
            // 
            // Txt_Klient_Adresse
            // 
            this.Txt_Klient_Adresse.Location = new System.Drawing.Point(121, 197);
            this.Txt_Klient_Adresse.Name = "Txt_Klient_Adresse";
            this.Txt_Klient_Adresse.Size = new System.Drawing.Size(100, 20);
            this.Txt_Klient_Adresse.TabIndex = 8;
            // 
            // Txt_Klient_navn
            // 
            this.Txt_Klient_navn.Location = new System.Drawing.Point(121, 154);
            this.Txt_Klient_navn.Name = "Txt_Klient_navn";
            this.Txt_Klient_navn.Size = new System.Drawing.Size(100, 20);
            this.Txt_Klient_navn.TabIndex = 7;
            // 
            // Opret_ydelse
            // 
            this.Opret_ydelse.Controls.Add(this.bnt_Ydelse_tilføj);
            this.Opret_ydelse.Controls.Add(this.label1);
            this.Opret_ydelse.Controls.Add(this.lbl_sagsnr);
            this.Opret_ydelse.Controls.Add(this.lbl_timer);
            this.Opret_ydelse.Controls.Add(this.lbl_pris);
            this.Opret_ydelse.Controls.Add(this.lbl_Beskrivelse);
            this.Opret_ydelse.Controls.Add(this.lbl_startdato);
            this.Opret_ydelse.Controls.Add(this.lbl_Nr);
            this.Opret_ydelse.Controls.Add(this.txt_ydelse_AdvokatID);
            this.Opret_ydelse.Controls.Add(this.txt_ydelse_sagsNr);
            this.Opret_ydelse.Controls.Add(this.txt_ydelse_timer);
            this.Opret_ydelse.Controls.Add(this.txt_ydelse_Pris);
            this.Opret_ydelse.Controls.Add(this.txt_ydelse_beskrivelse);
            this.Opret_ydelse.Controls.Add(this.txt_ydelse_startdato);
            this.Opret_ydelse.Controls.Add(this.txt_ydelse_ydelsesNr);
            this.Opret_ydelse.Location = new System.Drawing.Point(4, 24);
            this.Opret_ydelse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opret_ydelse.Name = "Opret_ydelse";
            this.Opret_ydelse.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opret_ydelse.Size = new System.Drawing.Size(676, 493);
            this.Opret_ydelse.TabIndex = 3;
            this.Opret_ydelse.Text = "Ydelse";
            this.Opret_ydelse.UseVisualStyleBackColor = true;
            // 
            // bnt_Ydelse_tilføj
            // 
            this.bnt_Ydelse_tilføj.Location = new System.Drawing.Point(54, 280);
            this.bnt_Ydelse_tilføj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnt_Ydelse_tilføj.Name = "bnt_Ydelse_tilføj";
            this.bnt_Ydelse_tilføj.Size = new System.Drawing.Size(98, 28);
            this.bnt_Ydelse_tilføj.TabIndex = 29;
            this.bnt_Ydelse_tilføj.Text = "Tilføj ydelse";
            this.bnt_Ydelse_tilføj.UseVisualStyleBackColor = true;
            this.bnt_Ydelse_tilføj.Click += new System.EventHandler(this.btn_opret_ydelse);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Advokat";
            // 
            // lbl_sagsnr
            // 
            this.lbl_sagsnr.AutoSize = true;
            this.lbl_sagsnr.Location = new System.Drawing.Point(52, 206);
            this.lbl_sagsnr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sagsnr.Name = "lbl_sagsnr";
            this.lbl_sagsnr.Size = new System.Drawing.Size(43, 13);
            this.lbl_sagsnr.TabIndex = 27;
            this.lbl_sagsnr.Text = "Sags nr";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(52, 167);
            this.lbl_timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(33, 13);
            this.lbl_timer.TabIndex = 26;
            this.lbl_timer.Text = "Timer";
            // 
            // lbl_pris
            // 
            this.lbl_pris.AutoSize = true;
            this.lbl_pris.Location = new System.Drawing.Point(52, 128);
            this.lbl_pris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pris.Name = "lbl_pris";
            this.lbl_pris.Size = new System.Drawing.Size(24, 13);
            this.lbl_pris.TabIndex = 25;
            this.lbl_pris.Text = "Pris";
            // 
            // lbl_Beskrivelse
            // 
            this.lbl_Beskrivelse.AutoSize = true;
            this.lbl_Beskrivelse.Location = new System.Drawing.Point(52, 96);
            this.lbl_Beskrivelse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Beskrivelse.Name = "lbl_Beskrivelse";
            this.lbl_Beskrivelse.Size = new System.Drawing.Size(61, 13);
            this.lbl_Beskrivelse.TabIndex = 24;
            this.lbl_Beskrivelse.Text = "Beskrivelse";
            // 
            // lbl_startdato
            // 
            this.lbl_startdato.AutoSize = true;
            this.lbl_startdato.Location = new System.Drawing.Point(52, 60);
            this.lbl_startdato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_startdato.Name = "lbl_startdato";
            this.lbl_startdato.Size = new System.Drawing.Size(53, 13);
            this.lbl_startdato.TabIndex = 23;
            this.lbl_startdato.Text = "Start dato";
            // 
            // lbl_Nr
            // 
            this.lbl_Nr.AutoSize = true;
            this.lbl_Nr.Location = new System.Drawing.Point(52, 23);
            this.lbl_Nr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nr.Name = "lbl_Nr";
            this.lbl_Nr.Size = new System.Drawing.Size(56, 13);
            this.lbl_Nr.TabIndex = 22;
            this.lbl_Nr.Text = "Ydelses nr";
            // 
            // txt_ydelse_AdvokatID
            // 
            this.txt_ydelse_AdvokatID.Location = new System.Drawing.Point(127, 237);
            this.txt_ydelse_AdvokatID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ydelse_AdvokatID.Name = "txt_ydelse_AdvokatID";
            this.txt_ydelse_AdvokatID.Size = new System.Drawing.Size(74, 20);
            this.txt_ydelse_AdvokatID.TabIndex = 21;
            // 
            // txt_ydelse_sagsNr
            // 
            this.txt_ydelse_sagsNr.Location = new System.Drawing.Point(127, 202);
            this.txt_ydelse_sagsNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ydelse_sagsNr.Name = "txt_ydelse_sagsNr";
            this.txt_ydelse_sagsNr.Size = new System.Drawing.Size(74, 20);
            this.txt_ydelse_sagsNr.TabIndex = 20;
            // 
            // txt_ydelse_timer
            // 
            this.txt_ydelse_timer.Location = new System.Drawing.Point(127, 163);
            this.txt_ydelse_timer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ydelse_timer.Name = "txt_ydelse_timer";
            this.txt_ydelse_timer.Size = new System.Drawing.Size(74, 20);
            this.txt_ydelse_timer.TabIndex = 19;
            // 
            // txt_ydelse_Pris
            // 
            this.txt_ydelse_Pris.Location = new System.Drawing.Point(127, 124);
            this.txt_ydelse_Pris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ydelse_Pris.Name = "txt_ydelse_Pris";
            this.txt_ydelse_Pris.Size = new System.Drawing.Size(74, 20);
            this.txt_ydelse_Pris.TabIndex = 18;
            // 
            // txt_ydelse_beskrivelse
            // 
            this.txt_ydelse_beskrivelse.Location = new System.Drawing.Point(127, 92);
            this.txt_ydelse_beskrivelse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ydelse_beskrivelse.Name = "txt_ydelse_beskrivelse";
            this.txt_ydelse_beskrivelse.Size = new System.Drawing.Size(74, 20);
            this.txt_ydelse_beskrivelse.TabIndex = 17;
            // 
            // txt_ydelse_startdato
            // 
            this.txt_ydelse_startdato.Location = new System.Drawing.Point(127, 56);
            this.txt_ydelse_startdato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ydelse_startdato.Name = "txt_ydelse_startdato";
            this.txt_ydelse_startdato.Size = new System.Drawing.Size(74, 20);
            this.txt_ydelse_startdato.TabIndex = 16;
            // 
            // txt_ydelse_ydelsesNr
            // 
            this.txt_ydelse_ydelsesNr.Enabled = false;
            this.txt_ydelse_ydelsesNr.Location = new System.Drawing.Point(127, 19);
            this.txt_ydelse_ydelsesNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ydelse_ydelsesNr.Name = "txt_ydelse_ydelsesNr";
            this.txt_ydelse_ydelsesNr.Size = new System.Drawing.Size(74, 20);
            this.txt_ydelse_ydelsesNr.TabIndex = 15;
            // 
            // Se_oversigt
            // 
            this.Se_oversigt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Se_oversigt.Controls.Add(this.combobox_hvad_type);
            this.Se_oversigt.Controls.Add(this.btn_Update);
            this.Se_oversigt.Controls.Add(this.objectListView1);
            this.Se_oversigt.Location = new System.Drawing.Point(4, 24);
            this.Se_oversigt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Se_oversigt.Name = "Se_oversigt";
            this.Se_oversigt.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Se_oversigt.Size = new System.Drawing.Size(676, 493);
            this.Se_oversigt.TabIndex = 4;
            this.Se_oversigt.Text = "Oversigt";
            this.Se_oversigt.UseVisualStyleBackColor = true;
            // 
            // combobox_hvad_type
            // 
            this.combobox_hvad_type.FormattingEnabled = true;
            this.combobox_hvad_type.Location = new System.Drawing.Point(4, 32);
            this.combobox_hvad_type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combobox_hvad_type.Name = "combobox_hvad_type";
            this.combobox_hvad_type.Size = new System.Drawing.Size(83, 21);
            this.combobox_hvad_type.TabIndex = 12;
            this.combobox_hvad_type.SelectedIndexChanged += new System.EventHandler(this.combobox_hvad_type_SelectedIndexChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(4, 6);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(93, 20);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Gem ændring";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.SagsNr);
            this.objectListView1.AllColumns.Add(this.Arbejdstitel);
            this.objectListView1.AllColumns.Add(this.StartDate);
            this.objectListView1.AllColumns.Add(this.Slutdate);
            this.objectListView1.AllColumns.Add(this.Kørselstimer);
            this.objectListView1.AllColumns.Add(this.TimeEstimat);
            this.objectListView1.AllColumns.Add(this.SagsBeskrivelse);
            this.objectListView1.AllColumns.Add(this.InterneNoter);
            this.objectListView1.AllColumns.Add(this.KlientNr);
            this.objectListView1.AllColumns.Add(this.MedarbejderNr);
            this.objectListView1.AllColumns.Add(this.YdelsesTypeNr);
            this.objectListView1.AllColumns.Add(this.Navn);
            this.objectListView1.AllColumns.Add(this.Adresse);
            this.objectListView1.AllColumns.Add(this.TelefonNr);
            this.objectListView1.AllColumns.Add(this.Advokat_navn);
            this.objectListView1.AllColumns.Add(this.YdelsesNr);
            this.objectListView1.AllColumns.Add(this.YdelseBeskrivelse);
            this.objectListView1.AllColumns.Add(this.Pris);
            this.objectListView1.AllColumns.Add(this.Timer);
            this.objectListView1.AllColumns.Add(this.AdvokatID);
            this.objectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.SagsNr,
            this.Arbejdstitel,
            this.StartDate,
            this.Slutdate,
            this.Kørselstimer,
            this.TimeEstimat,
            this.SagsBeskrivelse,
            this.InterneNoter,
            this.KlientNr,
            this.MedarbejderNr,
            this.YdelsesTypeNr,
            this.Navn,
            this.Adresse,
            this.TelefonNr,
            this.Advokat_navn,
            this.YdelsesNr,
            this.YdelseBeskrivelse,
            this.Pris,
            this.Timer,
            this.AdvokatID});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.HasCollapsibleGroups = false;
            this.objectListView1.Location = new System.Drawing.Point(4, 95);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.ShowImagesOnSubItems = true;
            this.objectListView1.Size = new System.Drawing.Size(644, 348);
            this.objectListView1.TabIndex = 9;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseFiltering = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Width = 0;
            // 
            // SagsNr
            // 
            this.SagsNr.AspectName = "SagsNr";
            this.SagsNr.IsEditable = false;
            this.SagsNr.Text = "SagsNr";
            // 
            // Arbejdstitel
            // 
            this.Arbejdstitel.AspectName = "Arbejdstitel";
            this.Arbejdstitel.IsEditable = false;
            this.Arbejdstitel.Text = "Arbejdstitel";
            // 
            // StartDate
            // 
            this.StartDate.AspectName = "StartDato";
            this.StartDate.IsEditable = false;
            this.StartDate.Text = "StartDato";
            // 
            // Slutdate
            // 
            this.Slutdate.AspectName = "SlutDato";
            this.Slutdate.Text = "SlutDato";
            // 
            // Kørselstimer
            // 
            this.Kørselstimer.AspectName = "Kørselstimer";
            this.Kørselstimer.Text = "Kørselstimer";
            // 
            // TimeEstimat
            // 
            this.TimeEstimat.AspectName = "TimeEstimat";
            this.TimeEstimat.Text = "TimeEstimat";
            // 
            // SagsBeskrivelse
            // 
            this.SagsBeskrivelse.AspectName = "SagsBeskrivelse";
            this.SagsBeskrivelse.Text = "SagsBeskrivelse";
            this.SagsBeskrivelse.Width = 90;
            // 
            // InterneNoter
            // 
            this.InterneNoter.AspectName = "InterneNoter";
            this.InterneNoter.Text = "InterneNoter";
            // 
            // KlientNr
            // 
            this.KlientNr.AspectName = "KlientNr";
            this.KlientNr.IsEditable = false;
            this.KlientNr.Text = "KlientNr";
            // 
            // MedarbejderNr
            // 
            this.MedarbejderNr.AspectName = "AdvokatId";
            this.MedarbejderNr.Text = "AdvokatId";
            this.MedarbejderNr.Width = 107;
            // 
            // YdelsesTypeNr
            // 
            this.YdelsesTypeNr.AspectName = "YdelsesTypeNr";
            this.YdelsesTypeNr.Text = "YdelsesTypeNr";
            // 
            // Navn
            // 
            this.Navn.AspectName = "Navn";
            this.Navn.Text = "Klient Navn";
            // 
            // Adresse
            // 
            this.Adresse.AspectName = "Adresse";
            this.Adresse.Text = "Adresse";
            // 
            // TelefonNr
            // 
            this.TelefonNr.AspectName = "TelefonNr";
            this.TelefonNr.Text = "TelefonNr";
            // 
            // Advokat_navn
            // 
            this.Advokat_navn.AspectName = "Navn";
            this.Advokat_navn.Text = "Advokat Navn";
            // 
            // YdelsesNr
            // 
            this.YdelsesNr.AspectName = "YdelsesNr";
            this.YdelsesNr.Text = "Ydelses Nr";
            // 
            // YdelseBeskrivelse
            // 
            this.YdelseBeskrivelse.AspectName = "YdelsesBeskrivelse";
            this.YdelseBeskrivelse.Text = "Ydelse Beskrivelse";
            // 
            // Pris
            // 
            this.Pris.AspectName = "Pris";
            this.Pris.Text = "Pris";
            // 
            // Timer
            // 
            this.Timer.AspectName = "Timer";
            this.Timer.Text = "Timer";
            // 
            // AdvokatID
            // 
            this.AdvokatID.AspectName = "AdvokatId";
            this.AdvokatID.Text = "AdvokatId";
            // 
            // btn_GoToFormCreateAdvokat
            // 
            this.btn_GoToFormCreateAdvokat.Location = new System.Drawing.Point(9, 35);
            this.btn_GoToFormCreateAdvokat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GoToFormCreateAdvokat.Name = "btn_GoToFormCreateAdvokat";
            this.btn_GoToFormCreateAdvokat.Size = new System.Drawing.Size(121, 24);
            this.btn_GoToFormCreateAdvokat.TabIndex = 53;
            this.btn_GoToFormCreateAdvokat.Text = "Gå til: Opret Advokat";
            this.btn_GoToFormCreateAdvokat.UseVisualStyleBackColor = true;
            this.btn_GoToFormCreateAdvokat.Click += new System.EventHandler(this.btn_GoToFormCreateAdvokat_Click);
            // 
            // Btn_CreateKlient
            // 
            this.Btn_CreateKlient.Location = new System.Drawing.Point(9, 74);
            this.Btn_CreateKlient.Name = "Btn_CreateKlient";
            this.Btn_CreateKlient.Size = new System.Drawing.Size(121, 23);
            this.Btn_CreateKlient.TabIndex = 54;
            this.Btn_CreateKlient.Text = "Gå til: Opret Klient";
            this.Btn_CreateKlient.UseVisualStyleBackColor = true;
            this.Btn_CreateKlient.Click += new System.EventHandler(this.Btn_CreateKlient_Click);
            // 
            // btn_GåtilYdelse
            // 
            this.btn_GåtilYdelse.Location = new System.Drawing.Point(9, 115);
            this.btn_GåtilYdelse.Name = "btn_GåtilYdelse";
            this.btn_GåtilYdelse.Size = new System.Drawing.Size(121, 23);
            this.btn_GåtilYdelse.TabIndex = 55;
            this.btn_GåtilYdelse.Text = "Gå til: Opret Ydelse";
            this.btn_GåtilYdelse.UseVisualStyleBackColor = true;
            this.btn_GåtilYdelse.Click += new System.EventHandler(this.btn_GåtilYdelse_Click);
            // 
            // Btn_Oversigt
            // 
            this.Btn_Oversigt.Location = new System.Drawing.Point(9, 323);
            this.Btn_Oversigt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Oversigt.Name = "Btn_Oversigt";
            this.Btn_Oversigt.Size = new System.Drawing.Size(121, 98);
            this.Btn_Oversigt.TabIndex = 56;
            this.Btn_Oversigt.Text = "Se oversigt";
            this.Btn_Oversigt.UseVisualStyleBackColor = true;
            this.Btn_Oversigt.Click += new System.EventHandler(this.Btn_Oversigt_Click);
            // 
            // Btn_Help
            // 
            this.Btn_Help.Location = new System.Drawing.Point(9, 448);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(47, 23);
            this.Btn_Help.TabIndex = 58;
            this.Btn_Help.Text = "?";
            this.Btn_Help.UseVisualStyleBackColor = true;
            // 
            // btn_opretsag
            // 
            this.btn_opretsag.Location = new System.Drawing.Point(10, 150);
            this.btn_opretsag.Name = "btn_opretsag";
            this.btn_opretsag.Size = new System.Drawing.Size(121, 23);
            this.btn_opretsag.TabIndex = 59;
            this.btn_opretsag.Text = "Gå til: Opret Sag";
            this.btn_opretsag.UseVisualStyleBackColor = true;
            this.btn_opretsag.Click += new System.EventHandler(this.btn_opretsag_Click);
            // 
            // Startside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 524);
            this.Controls.Add(this.btn_opretsag);
            this.Controls.Add(this.Btn_Help);
            this.Controls.Add(this.Btn_Oversigt);
            this.Controls.Add(this.btn_GåtilYdelse);
            this.Controls.Add(this.Btn_CreateKlient);
            this.Controls.Add(this.btn_GoToFormCreateAdvokat);
            this.Controls.Add(this.DynamicTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UnifiedGuiForm";
            this.Text = "Startside";
            this.DynamicTabControl.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Opret_sag.ResumeLayout(false);
            this.Opret_sag.PerformLayout();
            this.Opret_advokat.ResumeLayout(false);
            this.Opret_advokat.PerformLayout();
            this.Opret_klient.ResumeLayout(false);
            this.Opret_klient.PerformLayout();
            this.Opret_ydelse.ResumeLayout(false);
            this.Opret_ydelse.PerformLayout();
            this.Se_oversigt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DynamicTabControl;
        private System.Windows.Forms.TabPage Opret_advokat;
        private System.Windows.Forms.TabPage Opret_sag;
        private System.Windows.Forms.ComboBox Sag_drop_YdelseTypeNr;
        private System.Windows.Forms.Label lbl_Slut;
        private System.Windows.Forms.Label lbl_Sags;
        private System.Windows.Forms.Label lbl_YdelseNr;
        private System.Windows.Forms.Label lbl_Noter;
        private System.Windows.Forms.Label lbl_Sagsbeskrivelse;
        private System.Windows.Forms.TextBox txt_Sag_InterneNoter;
        private System.Windows.Forms.TextBox txt_Sag_SagsBeskrivelse;
        private System.Windows.Forms.TextBox txt_Sag_StartDato;
        private System.Windows.Forms.ComboBox Sag_drop_MedarbejderNr;
        private System.Windows.Forms.TextBox txt_Sag_KlientNr;
        private System.Windows.Forms.Label lbl_Medarbejder;
        private System.Windows.Forms.Label lbl_Klientnr;
        private System.Windows.Forms.DateTimePicker Datetimepicker_Sag_slutdato;
        private System.Windows.Forms.TextBox txt_Sag_time;
        private System.Windows.Forms.TextBox txt_Sag_titel;
        private System.Windows.Forms.TextBox txt_Sag_kørsel;
        private System.Windows.Forms.TextBox txt_Sag_Sagsnr;
        private System.Windows.Forms.Label lbl_TimeEstimat;
        private System.Windows.Forms.Label lbl_Kørselstimer;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.Label lbl_Titel;
        private System.Windows.Forms.Button btn_GoToFormCreateAdvokat;
        private System.Windows.Forms.Button Btn_CreateKlient;
        private System.Windows.Forms.Button btn_GåtilYdelse;
        private System.Windows.Forms.Button Btn_Oversigt;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button Btn_Help;
        private System.Windows.Forms.TabPage Opret_klient;
        private System.Windows.Forms.TabPage Opret_ydelse;
        private System.Windows.Forms.TabPage Se_oversigt;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Advokat_SpecialeNavn;
        private System.Windows.Forms.TextBox txt_Advokat_AdvokatId;
        private System.Windows.Forms.Label lbl_SpecialeNavn;
        private System.Windows.Forms.Label lbl_AdvokatId;
        private System.Windows.Forms.Label lbl_AdvokatNavn;
        private System.Windows.Forms.TextBox txt_Advokat_AdvokatNavn;
        private System.Windows.Forms.Button btn_AddSpecialToAdvokat;
        private System.Windows.Forms.Button btn_CreateAdvokat;
        private System.Windows.Forms.Button btn_opretsag;
        private System.Windows.Forms.Button bnt_Klient_Opret;
        private System.Windows.Forms.Label lbl_TelefonNr;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.Label lbl_navn;
        private System.Windows.Forms.TextBox Txt_Klient_TelefonNr;
        private System.Windows.Forms.TextBox Txt_Klient_Adresse;
        private System.Windows.Forms.TextBox Txt_Klient_navn;
        private System.Windows.Forms.Button bnt_Ydelse_tilføj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sagsnr;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_pris;
        private System.Windows.Forms.Label lbl_Beskrivelse;
        private System.Windows.Forms.Label lbl_startdato;
        private System.Windows.Forms.Label lbl_Nr;
        private System.Windows.Forms.TextBox txt_ydelse_AdvokatID;
        private System.Windows.Forms.TextBox txt_ydelse_sagsNr;
        private System.Windows.Forms.TextBox txt_ydelse_timer;
        private System.Windows.Forms.TextBox txt_ydelse_Pris;
        private System.Windows.Forms.TextBox txt_ydelse_beskrivelse;
        private System.Windows.Forms.TextBox txt_ydelse_startdato;
        private System.Windows.Forms.TextBox txt_ydelse_ydelsesNr;
        private System.Windows.Forms.Button btn_Update;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn SagsNr;
        private BrightIdeasSoftware.OLVColumn Arbejdstitel;
        private BrightIdeasSoftware.OLVColumn StartDate;
        private BrightIdeasSoftware.OLVColumn Slutdate;
        private BrightIdeasSoftware.OLVColumn Kørselstimer;
        private BrightIdeasSoftware.OLVColumn TimeEstimat;
        private BrightIdeasSoftware.OLVColumn SagsBeskrivelse;
        private BrightIdeasSoftware.OLVColumn InterneNoter;
        private BrightIdeasSoftware.OLVColumn KlientNr;
        private BrightIdeasSoftware.OLVColumn MedarbejderNr;
        private BrightIdeasSoftware.OLVColumn YdelsesTypeNr;
        private BrightIdeasSoftware.OLVColumn Navn;
        private BrightIdeasSoftware.OLVColumn Adresse;
        private BrightIdeasSoftware.OLVColumn TelefonNr;
        private BrightIdeasSoftware.OLVColumn Advokat_navn;
        private BrightIdeasSoftware.OLVColumn YdelsesNr;
        private BrightIdeasSoftware.OLVColumn YdelseBeskrivelse;
        private BrightIdeasSoftware.OLVColumn Pris;
        private BrightIdeasSoftware.OLVColumn Timer;
        private BrightIdeasSoftware.OLVColumn AdvokatID;
        private System.Windows.Forms.ComboBox combobox_hvad_type;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}