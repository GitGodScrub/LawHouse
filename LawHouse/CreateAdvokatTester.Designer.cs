namespace GUI
{
    partial class CreateAdvokatTester
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
            this.btn_CreateAdvokat = new System.Windows.Forms.Button();
            this.btn_AddSpecialToAdvokat = new System.Windows.Forms.Button();
            this.txt_AdvokatNavn = new System.Windows.Forms.TextBox();
            this.lbl_AdvokatNavn = new System.Windows.Forms.Label();
            this.lbl_AdvokatId = new System.Windows.Forms.Label();
            this.lbl_SpecialeNavn = new System.Windows.Forms.Label();
            this.txt_AdvokatId = new System.Windows.Forms.TextBox();
            this.txt_SpecialeNavn = new System.Windows.Forms.TextBox();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateAdvokat
            // 
            this.btn_CreateAdvokat.Location = new System.Drawing.Point(12, 21);
            this.btn_CreateAdvokat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateAdvokat.Name = "btn_CreateAdvokat";
            this.btn_CreateAdvokat.Size = new System.Drawing.Size(139, 71);
            this.btn_CreateAdvokat.TabIndex = 0;
            this.btn_CreateAdvokat.Text = "Opret Advokat";
            this.btn_CreateAdvokat.UseVisualStyleBackColor = true;
            this.btn_CreateAdvokat.Click += new System.EventHandler(this.btn_CreateAdvokat_Click);
            // 
            // btn_AddSpecialToAdvokat
            // 
            this.btn_AddSpecialToAdvokat.Location = new System.Drawing.Point(12, 194);
            this.btn_AddSpecialToAdvokat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddSpecialToAdvokat.Name = "btn_AddSpecialToAdvokat";
            this.btn_AddSpecialToAdvokat.Size = new System.Drawing.Size(133, 76);
            this.btn_AddSpecialToAdvokat.TabIndex = 1;
            this.btn_AddSpecialToAdvokat.Text = "Tilføj Speciale";
            this.btn_AddSpecialToAdvokat.UseVisualStyleBackColor = true;
            this.btn_AddSpecialToAdvokat.Click += new System.EventHandler(this.btn_AddSpecialToAdvokat_Click);
            // 
            // txt_AdvokatNavn
            // 
            this.txt_AdvokatNavn.Location = new System.Drawing.Point(277, 46);
            this.txt_AdvokatNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AdvokatNavn.Name = "txt_AdvokatNavn";
            this.txt_AdvokatNavn.Size = new System.Drawing.Size(100, 22);
            this.txt_AdvokatNavn.TabIndex = 2;
            // 
            // lbl_AdvokatNavn
            // 
            this.lbl_AdvokatNavn.AutoSize = true;
            this.lbl_AdvokatNavn.Location = new System.Drawing.Point(171, 49);
            this.lbl_AdvokatNavn.Name = "lbl_AdvokatNavn";
            this.lbl_AdvokatNavn.Size = new System.Drawing.Size(100, 17);
            this.lbl_AdvokatNavn.TabIndex = 3;
            this.lbl_AdvokatNavn.Text = "Advokat Navn:";
            // 
            // lbl_AdvokatId
            // 
            this.lbl_AdvokatId.AutoSize = true;
            this.lbl_AdvokatId.Location = new System.Drawing.Point(199, 194);
            this.lbl_AdvokatId.Name = "lbl_AdvokatId";
            this.lbl_AdvokatId.Size = new System.Drawing.Size(78, 17);
            this.lbl_AdvokatId.TabIndex = 4;
            this.lbl_AdvokatId.Text = "Advokat Id:";
            // 
            // lbl_SpecialeNavn
            // 
            this.lbl_SpecialeNavn.AutoSize = true;
            this.lbl_SpecialeNavn.Location = new System.Drawing.Point(173, 235);
            this.lbl_SpecialeNavn.Name = "lbl_SpecialeNavn";
            this.lbl_SpecialeNavn.Size = new System.Drawing.Size(103, 17);
            this.lbl_SpecialeNavn.TabIndex = 5;
            this.lbl_SpecialeNavn.Text = "Speciale Navn:";
            // 
            // txt_AdvokatId
            // 
            this.txt_AdvokatId.Location = new System.Drawing.Point(283, 194);
            this.txt_AdvokatId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AdvokatId.Name = "txt_AdvokatId";
            this.txt_AdvokatId.Size = new System.Drawing.Size(100, 22);
            this.txt_AdvokatId.TabIndex = 6;
            // 
            // txt_SpecialeNavn
            // 
            this.txt_SpecialeNavn.Location = new System.Drawing.Point(283, 235);
            this.txt_SpecialeNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SpecialeNavn.Name = "txt_SpecialeNavn";
            this.txt_SpecialeNavn.Size = new System.Drawing.Size(100, 22);
            this.txt_SpecialeNavn.TabIndex = 7;
            // 
            // Btn_Help
            // 
            this.Btn_Help.Location = new System.Drawing.Point(12, 134);
            this.Btn_Help.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(100, 28);
            this.Btn_Help.TabIndex = 8;
            this.Btn_Help.Text = "?";
            this.Btn_Help.UseVisualStyleBackColor = true;
            this.Btn_Help.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAdvokatTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 314);
            this.Controls.Add(this.Btn_Help);
            this.Controls.Add(this.txt_SpecialeNavn);
            this.Controls.Add(this.txt_AdvokatId);
            this.Controls.Add(this.lbl_SpecialeNavn);
            this.Controls.Add(this.lbl_AdvokatId);
            this.Controls.Add(this.lbl_AdvokatNavn);
            this.Controls.Add(this.txt_AdvokatNavn);
            this.Controls.Add(this.btn_AddSpecialToAdvokat);
            this.Controls.Add(this.btn_CreateAdvokat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateAdvokatTester";
            this.Text = "CreateAdvokatTester";
            this.Load += new System.EventHandler(this.CreateAdvokatTester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateAdvokat;
        private System.Windows.Forms.Button btn_AddSpecialToAdvokat;
        private System.Windows.Forms.TextBox txt_AdvokatNavn;
        private System.Windows.Forms.Label lbl_AdvokatNavn;
        private System.Windows.Forms.Label lbl_AdvokatId;
        private System.Windows.Forms.Label lbl_SpecialeNavn;
        private System.Windows.Forms.TextBox txt_AdvokatId;
        private System.Windows.Forms.TextBox txt_SpecialeNavn;
        private System.Windows.Forms.Button Btn_Help;
    }
}