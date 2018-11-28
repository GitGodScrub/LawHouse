namespace GUI
{
    partial class New_case
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.lbl_Titel = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_Kørselstimer = new System.Windows.Forms.Label();
            this.lbl_TimeEstimat = new System.Windows.Forms.Label();
            this.txt_nr = new System.Windows.Forms.TextBox();
            this.txt_kørsel = new System.Windows.Forms.TextBox();
            this.txt_titel = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.Slutdato = new System.Windows.Forms.DateTimePicker();
            this.txt_KlientNr = new System.Windows.Forms.TextBox();
            this.lbl_Medarbejder = new System.Windows.Forms.Label();
            this.lbl_Klientnr = new System.Windows.Forms.Label();
            this.StartDato = new System.Windows.Forms.TextBox();
            this.Btn_Oversigt = new System.Windows.Forms.Button();
            this.txt_SagsBeskrivelse = new System.Windows.Forms.TextBox();
            this.txt_InterneNoter = new System.Windows.Forms.TextBox();
            this.lbl_Sagsbeskrivelse = new System.Windows.Forms.Label();
            this.lbl_Noter = new System.Windows.Forms.Label();
            this.btn_GoToFormCreateAdvokat = new System.Windows.Forms.Button();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.Btn_CreateKlient = new System.Windows.Forms.Button();
            this.lbl_YdelseNr = new System.Windows.Forms.Label();
            this.txt_MedarbejderNr = new System.Windows.Forms.ComboBox();
            this.lbl_Sags = new System.Windows.Forms.Label();
            this.lbl_Slut = new System.Windows.Forms.Label();
            this.txt_YdelseTypeNr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(3, 450);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(161, 46);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Opret Sag";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // lbl_Titel
            // 
            this.lbl_Titel.AutoSize = true;
            this.lbl_Titel.Location = new System.Drawing.Point(251, 109);
            this.lbl_Titel.Name = "lbl_Titel";
            this.lbl_Titel.Size = new System.Drawing.Size(78, 17);
            this.lbl_Titel.TabIndex = 2;
            this.lbl_Titel.Text = "Arbejdstitel";
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Location = new System.Drawing.Point(251, 148);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(72, 17);
            this.lbl_Start.TabIndex = 3;
            this.lbl_Start.Text = "Start Dato";
            // 
            // lbl_Kørselstimer
            // 
            this.lbl_Kørselstimer.AutoSize = true;
            this.lbl_Kørselstimer.Location = new System.Drawing.Point(251, 227);
            this.lbl_Kørselstimer.Name = "lbl_Kørselstimer";
            this.lbl_Kørselstimer.Size = new System.Drawing.Size(86, 17);
            this.lbl_Kørselstimer.TabIndex = 5;
            this.lbl_Kørselstimer.Text = "Kørselstimer";
            // 
            // lbl_TimeEstimat
            // 
            this.lbl_TimeEstimat.AutoSize = true;
            this.lbl_TimeEstimat.Location = new System.Drawing.Point(251, 267);
            this.lbl_TimeEstimat.Name = "lbl_TimeEstimat";
            this.lbl_TimeEstimat.Size = new System.Drawing.Size(89, 17);
            this.lbl_TimeEstimat.TabIndex = 6;
            this.lbl_TimeEstimat.Text = "Time Estimat";
            // 
            // txt_nr
            // 
            this.txt_nr.Enabled = false;
            this.txt_nr.Location = new System.Drawing.Point(372, 67);
            this.txt_nr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nr.Name = "txt_nr";
            this.txt_nr.Size = new System.Drawing.Size(170, 22);
            this.txt_nr.TabIndex = 7;
            // 
            // txt_kørsel
            // 
            this.txt_kørsel.Location = new System.Drawing.Point(372, 222);
            this.txt_kørsel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kørsel.Name = "txt_kørsel";
            this.txt_kørsel.Size = new System.Drawing.Size(170, 22);
            this.txt_kørsel.TabIndex = 8;
            // 
            // txt_titel
            // 
            this.txt_titel.Location = new System.Drawing.Point(372, 104);
            this.txt_titel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_titel.Name = "txt_titel";
            this.txt_titel.Size = new System.Drawing.Size(170, 22);
            this.txt_titel.TabIndex = 9;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(372, 262);
            this.txt_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(170, 22);
            this.txt_time.TabIndex = 10;
            // 
            // Slutdato
            // 
            this.Slutdato.Location = new System.Drawing.Point(372, 183);
            this.Slutdato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Slutdato.Name = "Slutdato";
            this.Slutdato.Size = new System.Drawing.Size(170, 22);
            this.Slutdato.TabIndex = 12;
            // 
            // txt_KlientNr
            // 
            this.txt_KlientNr.Location = new System.Drawing.Point(372, 474);
            this.txt_KlientNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_KlientNr.Name = "txt_KlientNr";
            this.txt_KlientNr.Size = new System.Drawing.Size(170, 22);
            this.txt_KlientNr.TabIndex = 15;
            // 
            // lbl_Medarbejder
            // 
            this.lbl_Medarbejder.AutoSize = true;
            this.lbl_Medarbejder.Location = new System.Drawing.Point(251, 414);
            this.lbl_Medarbejder.Name = "lbl_Medarbejder";
            this.lbl_Medarbejder.Size = new System.Drawing.Size(88, 17);
            this.lbl_Medarbejder.TabIndex = 14;
            this.lbl_Medarbejder.Text = "Medarbejder";
            // 
            // lbl_Klientnr
            // 
            this.lbl_Klientnr.AutoSize = true;
            this.lbl_Klientnr.Location = new System.Drawing.Point(254, 479);
            this.lbl_Klientnr.Name = "lbl_Klientnr";
            this.lbl_Klientnr.Size = new System.Drawing.Size(56, 17);
            this.lbl_Klientnr.TabIndex = 13;
            this.lbl_Klientnr.Text = "Klientnr";
            // 
            // StartDato
            // 
            this.StartDato.Enabled = false;
            this.StartDato.Location = new System.Drawing.Point(372, 143);
            this.StartDato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDato.Name = "StartDato";
            this.StartDato.Size = new System.Drawing.Size(170, 22);
            this.StartDato.TabIndex = 17;
            // 
            // Btn_Oversigt
            // 
            this.Btn_Oversigt.Location = new System.Drawing.Point(3, 389);
            this.Btn_Oversigt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Oversigt.Name = "Btn_Oversigt";
            this.Btn_Oversigt.Size = new System.Drawing.Size(161, 46);
            this.Btn_Oversigt.TabIndex = 18;
            this.Btn_Oversigt.Text = "Se oversigt";
            this.Btn_Oversigt.UseVisualStyleBackColor = true;
            this.Btn_Oversigt.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SagsBeskrivelse
            // 
            this.txt_SagsBeskrivelse.Location = new System.Drawing.Point(372, 303);
            this.txt_SagsBeskrivelse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_SagsBeskrivelse.Name = "txt_SagsBeskrivelse";
            this.txt_SagsBeskrivelse.Size = new System.Drawing.Size(170, 22);
            this.txt_SagsBeskrivelse.TabIndex = 19;
            // 
            // txt_InterneNoter
            // 
            this.txt_InterneNoter.Location = new System.Drawing.Point(372, 361);
            this.txt_InterneNoter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_InterneNoter.Name = "txt_InterneNoter";
            this.txt_InterneNoter.Size = new System.Drawing.Size(170, 22);
            this.txt_InterneNoter.TabIndex = 20;
            // 
            // lbl_Sagsbeskrivelse
            // 
            this.lbl_Sagsbeskrivelse.AutoSize = true;
            this.lbl_Sagsbeskrivelse.Location = new System.Drawing.Point(251, 303);
            this.lbl_Sagsbeskrivelse.Name = "lbl_Sagsbeskrivelse";
            this.lbl_Sagsbeskrivelse.Size = new System.Drawing.Size(111, 17);
            this.lbl_Sagsbeskrivelse.TabIndex = 21;
            this.lbl_Sagsbeskrivelse.Text = "Sagsbeskrivelse";
            // 
            // lbl_Noter
            // 
            this.lbl_Noter.AutoSize = true;
            this.lbl_Noter.Location = new System.Drawing.Point(251, 364);
            this.lbl_Noter.Name = "lbl_Noter";
            this.lbl_Noter.Size = new System.Drawing.Size(91, 17);
            this.lbl_Noter.TabIndex = 22;
            this.lbl_Noter.Text = "Interne Noter";
            // 
            // btn_GoToFormCreateAdvokat
            // 
            this.btn_GoToFormCreateAdvokat.Location = new System.Drawing.Point(3, 1);
            this.btn_GoToFormCreateAdvokat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GoToFormCreateAdvokat.Name = "btn_GoToFormCreateAdvokat";
            this.btn_GoToFormCreateAdvokat.Size = new System.Drawing.Size(161, 30);
            this.btn_GoToFormCreateAdvokat.TabIndex = 24;
            this.btn_GoToFormCreateAdvokat.Text = "Gå til: Opret advokat";
            this.btn_GoToFormCreateAdvokat.UseVisualStyleBackColor = true;
            this.btn_GoToFormCreateAdvokat.Click += new System.EventHandler(this.btn_GoToFormCreateAdvokat_Click);
            // 
            // Btn_Help
            // 
            this.Btn_Help.Location = new System.Drawing.Point(3, 104);
            this.Btn_Help.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(161, 28);
            this.Btn_Help.TabIndex = 25;
            this.Btn_Help.Text = "?";
            this.Btn_Help.UseVisualStyleBackColor = true;
            // 
            // Btn_CreateKlient
            // 
            this.Btn_CreateKlient.Location = new System.Drawing.Point(3, 56);
            this.Btn_CreateKlient.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CreateKlient.Name = "Btn_CreateKlient";
            this.Btn_CreateKlient.Size = new System.Drawing.Size(161, 28);
            this.Btn_CreateKlient.TabIndex = 26;
            this.Btn_CreateKlient.Text = "Gå Til Opret Klient";
            this.Btn_CreateKlient.UseVisualStyleBackColor = true;
            this.Btn_CreateKlient.Click += new System.EventHandler(this.Btn_CreateKlient_Click);
            // 
            // lbl_YdelseNr
            // 
            this.lbl_YdelseNr.AutoSize = true;
            this.lbl_YdelseNr.Location = new System.Drawing.Point(253, 27);
            this.lbl_YdelseNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_YdelseNr.Name = "lbl_YdelseNr";
            this.lbl_YdelseNr.Size = new System.Drawing.Size(87, 17);
            this.lbl_YdelseNr.TabIndex = 25;
            this.lbl_YdelseNr.Text = "Ydelse Type";
            // 
            // txt_MedarbejderNr
            // 
            this.txt_MedarbejderNr.Location = new System.Drawing.Point(372, 411);
            this.txt_MedarbejderNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MedarbejderNr.Name = "txt_MedarbejderNr";
            this.txt_MedarbejderNr.Size = new System.Drawing.Size(170, 24);
            this.txt_MedarbejderNr.TabIndex = 26;
            // 
            // lbl_Sags
            // 
            this.lbl_Sags.AutoSize = true;
            this.lbl_Sags.Location = new System.Drawing.Point(251, 67);
            this.lbl_Sags.Name = "lbl_Sags";
            this.lbl_Sags.Size = new System.Drawing.Size(59, 17);
            this.lbl_Sags.TabIndex = 28;
            this.lbl_Sags.Text = "Sags Nr";
            // 
            // lbl_Slut
            // 
            this.lbl_Slut.AutoSize = true;
            this.lbl_Slut.Location = new System.Drawing.Point(251, 188);
            this.lbl_Slut.Name = "lbl_Slut";
            this.lbl_Slut.Size = new System.Drawing.Size(66, 17);
            this.lbl_Slut.TabIndex = 29;
            this.lbl_Slut.Text = "Slut Dato";
            // 
            // txt_YdelseTypeNr
            // 
            this.txt_YdelseTypeNr.FormattingEnabled = true;
            this.txt_YdelseTypeNr.Location = new System.Drawing.Point(372, 20);
            this.txt_YdelseTypeNr.Name = "txt_YdelseTypeNr";
            this.txt_YdelseTypeNr.Size = new System.Drawing.Size(170, 24);
            this.txt_YdelseTypeNr.TabIndex = 30;
            this.txt_YdelseTypeNr.SelectedIndexChanged += new System.EventHandler(this.txt_YdelseTypeNr_SelectedIndexChanged);
            // 
            // New_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(675, 570);
            this.Controls.Add(this.txt_YdelseTypeNr);
            this.Controls.Add(this.lbl_Slut);
            this.Controls.Add(this.lbl_Sags);
            this.Controls.Add(this.lbl_YdelseNr);
            this.Controls.Add(this.Btn_CreateKlient);
            this.Controls.Add(this.Btn_Help);
            this.Controls.Add(this.btn_GoToFormCreateAdvokat);
            this.Controls.Add(this.lbl_Noter);
            this.Controls.Add(this.lbl_Sagsbeskrivelse);
            this.Controls.Add(this.txt_InterneNoter);
            this.Controls.Add(this.txt_SagsBeskrivelse);
            this.Controls.Add(this.Btn_Oversigt);
            this.Controls.Add(this.StartDato);
            this.Controls.Add(this.txt_MedarbejderNr);
            this.Controls.Add(this.txt_KlientNr);
            this.Controls.Add(this.lbl_Medarbejder);
            this.Controls.Add(this.lbl_Klientnr);
            this.Controls.Add(this.Slutdato);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_titel);
            this.Controls.Add(this.txt_kørsel);
            this.Controls.Add(this.txt_nr);
            this.Controls.Add(this.lbl_TimeEstimat);
            this.Controls.Add(this.lbl_Kørselstimer);
            this.Controls.Add(this.lbl_Start);
            this.Controls.Add(this.lbl_Titel);
            this.Controls.Add(this.btn_Create);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "New_case";
            this.Text = "Ny sag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label lbl_Titel;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.Label lbl_Kørselstimer;
        private System.Windows.Forms.Label lbl_TimeEstimat;
        private System.Windows.Forms.TextBox txt_nr;
        private System.Windows.Forms.TextBox txt_kørsel;
        private System.Windows.Forms.TextBox txt_titel;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.DateTimePicker Slutdato;
        private System.Windows.Forms.TextBox txt_KlientNr;
        private System.Windows.Forms.Label lbl_Medarbejder;
        private System.Windows.Forms.Label lbl_Klientnr;
        private System.Windows.Forms.TextBox StartDato;
        private System.Windows.Forms.Button Btn_Oversigt;
        private System.Windows.Forms.TextBox txt_SagsBeskrivelse;
        private System.Windows.Forms.TextBox txt_InterneNoter;
        private System.Windows.Forms.Label lbl_Sagsbeskrivelse;
        private System.Windows.Forms.Label lbl_Noter;
        private System.Windows.Forms.Button btn_GoToFormCreateAdvokat;
        private System.Windows.Forms.Label lbl_YdelseNr;
        private System.Windows.Forms.Button Btn_Help;
        private System.Windows.Forms.Button Btn_CreateKlient;
        private System.Windows.Forms.ComboBox txt_MedarbejderNr;
        private System.Windows.Forms.Label lbl_Sags;
        private System.Windows.Forms.Label lbl_Slut;
        private System.Windows.Forms.ComboBox txt_YdelseTypeNr;
    }
}

