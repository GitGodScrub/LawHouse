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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nr = new System.Windows.Forms.TextBox();
            this.txt_kørsel = new System.Windows.Forms.TextBox();
            this.txt_titel = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.Slutdato = new System.Windows.Forms.DateTimePicker();
            this.txt_KlientNr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartDato = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_SagsBeskrivelse = new System.Windows.Forms.TextBox();
            this.txt_InterneNoter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_GoToFormCreateAdvokat = new System.Windows.Forms.Button();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.Btn_CreateKlient = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_MedarbejderNr = new System.Windows.Forms.ComboBox();
            this.Sags = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arbejdstitel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "StartDato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kørselstimer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "TimeEstimat";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Medarbejder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Klientnr";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Se oversigt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "SagsBeskrivelse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "InterneNoter";
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
            this.Btn_Help.Click += new System.EventHandler(this.button2_Click);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "YdelseTypeNr";
            // 
            // txt_MedarbejderNr
            // 
            this.txt_MedarbejderNr.Location = new System.Drawing.Point(372, 411);
            this.txt_MedarbejderNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MedarbejderNr.Name = "txt_MedarbejderNr";
            this.txt_MedarbejderNr.Size = new System.Drawing.Size(170, 24);
            this.txt_MedarbejderNr.TabIndex = 26;
            // 
            // Sags
            // 
            this.Sags.AutoSize = true;
            this.Sags.Location = new System.Drawing.Point(251, 67);
            this.Sags.Name = "Sags";
            this.Sags.Size = new System.Drawing.Size(55, 17);
            this.Sags.TabIndex = 28;
            this.Sags.Text = "SagsNr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "SlutDato";
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sags);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_CreateKlient);
            this.Controls.Add(this.Btn_Help);
            this.Controls.Add(this.btn_GoToFormCreateAdvokat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_InterneNoter);
            this.Controls.Add(this.txt_SagsBeskrivelse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartDato);
            this.Controls.Add(this.txt_MedarbejderNr);
            this.Controls.Add(this.txt_KlientNr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Slutdato);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_titel);
            this.Controls.Add(this.txt_kørsel);
            this.Controls.Add(this.txt_nr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Create);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "New_case";
            this.Text = "Ny sag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nr;
        private System.Windows.Forms.TextBox txt_kørsel;
        private System.Windows.Forms.TextBox txt_titel;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.DateTimePicker Slutdato;
        private System.Windows.Forms.TextBox txt_KlientNr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StartDato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_SagsBeskrivelse;
        private System.Windows.Forms.TextBox txt_InterneNoter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_GoToFormCreateAdvokat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Help;
        private System.Windows.Forms.Button Btn_CreateKlient;
        private System.Windows.Forms.ComboBox txt_MedarbejderNr;
        private System.Windows.Forms.Label Sags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_YdelseTypeNr;
    }
}

