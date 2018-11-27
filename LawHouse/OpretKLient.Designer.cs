namespace GUI
{
    partial class OpretKLient
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
            this.Txt_navn = new System.Windows.Forms.TextBox();
            this.Txt_Adresse = new System.Windows.Forms.TextBox();
            this.Txt_TelefonNr = new System.Windows.Forms.TextBox();
            this.navn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_CreateKLient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_navn
            // 
            this.Txt_navn.Location = new System.Drawing.Point(17, 16);
            this.Txt_navn.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_navn.Name = "Txt_navn";
            this.Txt_navn.Size = new System.Drawing.Size(132, 22);
            this.Txt_navn.TabIndex = 0;
            // 
            // Txt_Adresse
            // 
            this.Txt_Adresse.Location = new System.Drawing.Point(17, 68);
            this.Txt_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Adresse.Name = "Txt_Adresse";
            this.Txt_Adresse.Size = new System.Drawing.Size(132, 22);
            this.Txt_Adresse.TabIndex = 1;
            // 
            // Txt_TelefonNr
            // 
            this.Txt_TelefonNr.Location = new System.Drawing.Point(17, 123);
            this.Txt_TelefonNr.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_TelefonNr.Name = "Txt_TelefonNr";
            this.Txt_TelefonNr.Size = new System.Drawing.Size(132, 22);
            this.Txt_TelefonNr.TabIndex = 2;
            // 
            // navn
            // 
            this.navn.AutoSize = true;
            this.navn.Location = new System.Drawing.Point(199, 16);
            this.navn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.navn.Name = "navn";
            this.navn.Size = new System.Drawing.Size(41, 17);
            this.navn.TabIndex = 3;
            this.navn.Text = "Navn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TelefonNr";
            // 
            // Btn_CreateKLient
            // 
            this.Btn_CreateKLient.Location = new System.Drawing.Point(17, 182);
            this.Btn_CreateKLient.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CreateKLient.Name = "Btn_CreateKLient";
            this.Btn_CreateKLient.Size = new System.Drawing.Size(221, 28);
            this.Btn_CreateKLient.TabIndex = 6;
            this.Btn_CreateKLient.Text = "Opret Klient";
            this.Btn_CreateKLient.UseVisualStyleBackColor = true;
            this.Btn_CreateKLient.Click += new System.EventHandler(this.Btn_CreateKLient_Click);
            // 
            // OpretKLient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 366);
            this.Controls.Add(this.Btn_CreateKLient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navn);
            this.Controls.Add(this.Txt_TelefonNr);
            this.Controls.Add(this.Txt_Adresse);
            this.Controls.Add(this.Txt_navn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OpretKLient";
            this.Text = "OpretKlient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_navn;
        private System.Windows.Forms.TextBox Txt_Adresse;
        private System.Windows.Forms.TextBox Txt_TelefonNr;
        private System.Windows.Forms.Label navn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_CreateKLient;
    }
}