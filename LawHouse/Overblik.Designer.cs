namespace GUI
{
    partial class Overblik
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
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SagsNr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Arbejdstitel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.StartDato = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SlutDato = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataSetDropBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDrop = new GUI.DataSetDrop();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.AdvokatID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDropBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.SagsNr);
            this.objectListView1.AllColumns.Add(this.Arbejdstitel);
            this.objectListView1.AllColumns.Add(this.StartDato);
            this.objectListView1.AllColumns.Add(this.SlutDato);
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
            this.StartDato,
            this.SlutDato,
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
            this.objectListView1.Location = new System.Drawing.Point(44, 78);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.ShowImagesOnSubItems = true;
            this.objectListView1.Size = new System.Drawing.Size(1219, 427);
            this.objectListView1.TabIndex = 1;
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
            this.StartDato.AspectName = "StartDato";
            this.StartDato.IsEditable = false;
            this.StartDato.Text = "StartDato";
            // 
            // Slutdate
            // 
            this.SlutDato.AspectName = "SlutDato";
            this.SlutDato.Text = "SlutDato";
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
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(44, 12);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(124, 25);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Opdater";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataSetDropBindingSource
            // 
            this.dataSetDropBindingSource.DataSource = this.dataSetDrop;
            this.dataSetDropBindingSource.Position = 0;
            // 
            // dataSetDrop
            // 
            this.dataSetDrop.DataSetName = "DataSetDrop";
            this.dataSetDrop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(692, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Btn_Help
            // 
            this.Btn_Help.Location = new System.Drawing.Point(193, 48);
            this.Btn_Help.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(100, 28);
            this.Btn_Help.TabIndex = 7;
            this.Btn_Help.Text = "?";
            this.Btn_Help.UseVisualStyleBackColor = true;
            // 
            // Overblik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 530);
            this.Controls.Add(this.Btn_Help);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.objectListView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Overblik";
            this.Text = "Overblik";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDropBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn SagsNr;
        private BrightIdeasSoftware.OLVColumn Arbejdstitel;
        private BrightIdeasSoftware.OLVColumn StartDato;
        private BrightIdeasSoftware.OLVColumn SlutDato;
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

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.BindingSource dataSetDropBindingSource;
        private DataSetDrop dataSetDrop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_Help;
    }
}