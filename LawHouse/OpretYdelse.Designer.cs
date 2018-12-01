namespace GUI
{
    partial class OpretYdelse
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
            this.txt_Nr = new System.Windows.Forms.TextBox();
            this.txt_startdato = new System.Windows.Forms.TextBox();
            this.txt_beskrivelse = new System.Windows.Forms.TextBox();
            this.txt_Pris = new System.Windows.Forms.TextBox();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.txt_sagsNr = new System.Windows.Forms.TextBox();
            this.txt_advokatId = new System.Windows.Forms.TextBox();
            this.lbl_Nr = new System.Windows.Forms.Label();
            this.lbl_startdato = new System.Windows.Forms.Label();
            this.lbl_Beskrivelse = new System.Windows.Forms.Label();
            this.lbl_pris = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_sagsnr = new System.Windows.Forms.Label();
            this.lbl_AdvokatID = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nr
            // 
            this.txt_Nr.Enabled = false;
            this.txt_Nr.Location = new System.Drawing.Point(141, 39);
            this.txt_Nr.Name = "txt_Nr";
            this.txt_Nr.Size = new System.Drawing.Size(97, 22);
            this.txt_Nr.TabIndex = 0;
            // 
            // txt_Startdato
            // 
            this.txt_startdato.Location = new System.Drawing.Point(141, 85);
            this.txt_startdato.Name = "txt_Startdato";
            this.txt_startdato.Size = new System.Drawing.Size(97, 22);
            this.txt_startdato.TabIndex = 1;
            // 
            // txt_Beskrivelse
            // 
            this.txt_beskrivelse.Location = new System.Drawing.Point(141, 129);
            this.txt_beskrivelse.Name = "txt_Beskrivelse";
            this.txt_beskrivelse.Size = new System.Drawing.Size(97, 22);
            this.txt_beskrivelse.TabIndex = 2;
            // 
            // txt_Pris
            // 
            this.txt_Pris.Location = new System.Drawing.Point(141, 168);
            this.txt_Pris.Name = "txt_Pris";
            this.txt_Pris.Size = new System.Drawing.Size(97, 22);
            this.txt_Pris.TabIndex = 3;
            // 
            // txt_timer
            // 
            this.txt_timer.Location = new System.Drawing.Point(141, 217);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.Size = new System.Drawing.Size(97, 22);
            this.txt_timer.TabIndex = 4;
            // 
            // txt_sagsNr
            // 
            this.txt_sagsNr.Location = new System.Drawing.Point(141, 265);
            this.txt_sagsNr.Name = "txt_sagsNr";
            this.txt_sagsNr.Size = new System.Drawing.Size(97, 22);
            this.txt_sagsNr.TabIndex = 5;
            // 
            // txt_advokatId
            // 
            this.txt_advokatId.Location = new System.Drawing.Point(141, 308);
            this.txt_advokatId.Name = "txt_advokatId";
            this.txt_advokatId.Size = new System.Drawing.Size(97, 22);
            this.txt_advokatId.TabIndex = 6;
            // 
            // lbl_Nr
            // 
            this.lbl_Nr.AutoSize = true;
            this.lbl_Nr.Location = new System.Drawing.Point(41, 44);
            this.lbl_Nr.Name = "lbl_Nr";
            this.lbl_Nr.Size = new System.Drawing.Size(75, 17);
            this.lbl_Nr.TabIndex = 7;
            this.lbl_Nr.Text = "Ydelses nr";
            // 
            // lbl_startdato
            // 
            this.lbl_startdato.AutoSize = true;
            this.lbl_startdato.Location = new System.Drawing.Point(41, 90);
            this.lbl_startdato.Name = "lbl_startdato";
            this.lbl_startdato.Size = new System.Drawing.Size(70, 17);
            this.lbl_startdato.TabIndex = 8;
            this.lbl_startdato.Text = "Start dato";
            // 
            // lbl_Beskrivelse
            // 
            this.lbl_Beskrivelse.AutoSize = true;
            this.lbl_Beskrivelse.Location = new System.Drawing.Point(41, 134);
            this.lbl_Beskrivelse.Name = "lbl_Beskrivelse";
            this.lbl_Beskrivelse.Size = new System.Drawing.Size(80, 17);
            this.lbl_Beskrivelse.TabIndex = 9;
            this.lbl_Beskrivelse.Text = "Beskrivelse";
            // 
            // lbl_pris
            // 
            this.lbl_pris.AutoSize = true;
            this.lbl_pris.Location = new System.Drawing.Point(41, 173);
            this.lbl_pris.Name = "lbl_pris";
            this.lbl_pris.Size = new System.Drawing.Size(32, 17);
            this.lbl_pris.TabIndex = 10;
            this.lbl_pris.Text = "Pris";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(41, 222);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(44, 17);
            this.lbl_timer.TabIndex = 11;
            this.lbl_timer.Text = "Timer";
            // 
            // lbl_sagsnr
            // 
            this.lbl_sagsnr.AutoSize = true;
            this.lbl_sagsnr.Location = new System.Drawing.Point(41, 270);
            this.lbl_sagsnr.Name = "lbl_sagsnr";
            this.lbl_sagsnr.Size = new System.Drawing.Size(57, 17);
            this.lbl_sagsnr.TabIndex = 12;
            this.lbl_sagsnr.Text = "Sags nr";
            // 
            // lbl_AdvokatID
            // 
            this.lbl_AdvokatID.AutoSize = true;
            this.lbl_AdvokatID.Location = new System.Drawing.Point(41, 313);
            this.lbl_AdvokatID.Name = "lbl_AdvokatID";
            this.lbl_AdvokatID.Size = new System.Drawing.Size(59, 17);
            this.lbl_AdvokatID.TabIndex = 13;
            this.lbl_AdvokatID.Text = "Advokat";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(44, 361);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(130, 34);
            this.btn_Create.TabIndex = 14;
            this.btn_Create.Text = "Tilføj ydelse";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ydelse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.lbl_AdvokatID);
            this.Controls.Add(this.lbl_sagsnr);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_pris);
            this.Controls.Add(this.lbl_Beskrivelse);
            this.Controls.Add(this.lbl_startdato);
            this.Controls.Add(this.lbl_Nr);
            this.Controls.Add(this.txt_advokatId);
            this.Controls.Add(this.txt_sagsNr);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.txt_Pris);
            this.Controls.Add(this.txt_beskrivelse);
            this.Controls.Add(this.txt_startdato);
            this.Controls.Add(this.txt_Nr);
            this.Name = "Ydelse";
            this.Text = "Ydelse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nr;
        private System.Windows.Forms.TextBox txt_startdato;
        private System.Windows.Forms.TextBox txt_beskrivelse;
        private System.Windows.Forms.TextBox txt_Pris;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.TextBox txt_sagsNr;
        private System.Windows.Forms.TextBox txt_advokatId;
        private System.Windows.Forms.Label lbl_Nr;
        private System.Windows.Forms.Label lbl_startdato;
        private System.Windows.Forms.Label lbl_Beskrivelse;
        private System.Windows.Forms.Label lbl_pris;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_sagsnr;
        private System.Windows.Forms.Label lbl_AdvokatID;
        private System.Windows.Forms.Button btn_Create;
    }
}