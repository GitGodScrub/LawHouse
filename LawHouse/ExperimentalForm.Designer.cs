namespace GUI
{
    partial class ExperimentalForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.tabSag = new System.Windows.Forms.TabPage();
            this.tabAdvokat = new System.Windows.Forms.TabPage();
            this.tabKlient = new System.Windows.Forms.TabPage();
            this.tabYdelse = new System.Windows.Forms.TabPage();
            this.tabClickHereFirst = new System.Windows.Forms.TabPage();
            this.buttonHelpMe = new System.Windows.Forms.Button();
            this.buttomAddNewObject = new System.Windows.Forms.Button();
            this.buttonAnnuller = new System.Windows.Forms.Button();
            this.buttomSave = new System.Windows.Forms.Button();
            this.dropdownCombobox = new System.Windows.Forms.ComboBox();
            this.buttomRefresh = new System.Windows.Forms.Button();
            this.myObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.DynamicTabControl.SuspendLayout();
            this.tabStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabClickHereFirst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myObjectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // DynamicTabControl
            // 
            this.DynamicTabControl.Controls.Add(this.tabStart);
            this.DynamicTabControl.Controls.Add(this.tabSag);
            this.DynamicTabControl.Controls.Add(this.tabAdvokat);
            this.DynamicTabControl.Controls.Add(this.tabKlient);
            this.DynamicTabControl.Controls.Add(this.tabYdelse);
            this.DynamicTabControl.Controls.Add(this.tabClickHereFirst);
            this.DynamicTabControl.ItemSize = new System.Drawing.Size(170, 20);
            this.DynamicTabControl.Location = new System.Drawing.Point(11, 11);
            this.DynamicTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.DynamicTabControl.Name = "DynamicTabControl";
            this.DynamicTabControl.SelectedIndex = 0;
            this.DynamicTabControl.Size = new System.Drawing.Size(1002, 559);
            this.DynamicTabControl.TabIndex = 0;
            // 
            // tabStart
            // 
            this.tabStart.Controls.Add(this.pictureBox1);
            this.tabStart.Location = new System.Drawing.Point(4, 24);
            this.tabStart.Margin = new System.Windows.Forms.Padding(2);
            this.tabStart.Name = "tabStart";
            this.tabStart.Size = new System.Drawing.Size(994, 531);
            this.tabStart.TabIndex = 5;
            this.tabStart.Text = "Startside";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images_første_forsøg_Tydeligt_500x500;
            this.pictureBox1.Location = new System.Drawing.Point(238, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 497);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabSag
            // 
            this.tabSag.Location = new System.Drawing.Point(4, 24);
            this.tabSag.Name = "tabSag";
            this.tabSag.Size = new System.Drawing.Size(994, 531);
            this.tabSag.TabIndex = 6;
            this.tabSag.Text = "Sag";
            this.tabSag.UseVisualStyleBackColor = true;
            // 
            // tabAdvokat
            // 
            this.tabAdvokat.Location = new System.Drawing.Point(4, 24);
            this.tabAdvokat.Name = "tabAdvokat";
            this.tabAdvokat.Size = new System.Drawing.Size(994, 531);
            this.tabAdvokat.TabIndex = 7;
            this.tabAdvokat.Text = "Advokat";
            this.tabAdvokat.UseVisualStyleBackColor = true;
            // 
            // tabKlient
            // 
            this.tabKlient.Location = new System.Drawing.Point(4, 24);
            this.tabKlient.Name = "tabKlient";
            this.tabKlient.Size = new System.Drawing.Size(994, 531);
            this.tabKlient.TabIndex = 8;
            this.tabKlient.Text = "Klient";
            this.tabKlient.UseVisualStyleBackColor = true;
            // 
            // tabYdelse
            // 
            this.tabYdelse.Location = new System.Drawing.Point(4, 24);
            this.tabYdelse.Name = "tabYdelse";
            this.tabYdelse.Size = new System.Drawing.Size(994, 531);
            this.tabYdelse.TabIndex = 9;
            this.tabYdelse.Text = "Ydelse";
            this.tabYdelse.UseVisualStyleBackColor = true;
            // 
            // tabClickHereFirst
            // 
            this.tabClickHereFirst.Controls.Add(this.buttonHelpMe);
            this.tabClickHereFirst.Controls.Add(this.buttomAddNewObject);
            this.tabClickHereFirst.Controls.Add(this.buttonAnnuller);
            this.tabClickHereFirst.Controls.Add(this.buttomSave);
            this.tabClickHereFirst.Controls.Add(this.dropdownCombobox);
            this.tabClickHereFirst.Controls.Add(this.buttomRefresh);
            this.tabClickHereFirst.Controls.Add(this.myObjectListView);
            this.tabClickHereFirst.Location = new System.Drawing.Point(4, 24);
            this.tabClickHereFirst.Name = "tabClickHereFirst";
            this.tabClickHereFirst.Padding = new System.Windows.Forms.Padding(3);
            this.tabClickHereFirst.Size = new System.Drawing.Size(994, 531);
            this.tabClickHereFirst.TabIndex = 10;
            this.tabClickHereFirst.Text = "ClickHereFirst";
            this.tabClickHereFirst.UseVisualStyleBackColor = true;
            // 
            // buttonHelpMe
            // 
            this.buttonHelpMe.Location = new System.Drawing.Point(554, 8);
            this.buttonHelpMe.Margin = new System.Windows.Forms.Padding(5);
            this.buttonHelpMe.Name = "buttonHelpMe";
            this.buttonHelpMe.Size = new System.Drawing.Size(76, 76);
            this.buttonHelpMe.TabIndex = 6;
            this.buttonHelpMe.Text = "HelpMe";
            this.buttonHelpMe.UseVisualStyleBackColor = true;
            this.buttonHelpMe.Click += new System.EventHandler(this.buttonHelpMe_Click);
            // 
            // buttomAddNewObject
            // 
            this.buttomAddNewObject.Location = new System.Drawing.Point(395, 8);
            this.buttomAddNewObject.Margin = new System.Windows.Forms.Padding(5);
            this.buttomAddNewObject.Name = "buttomAddNewObject";
            this.buttomAddNewObject.Size = new System.Drawing.Size(149, 45);
            this.buttomAddNewObject.TabIndex = 5;
            this.buttomAddNewObject.Text = "AddNewObject";
            this.buttomAddNewObject.UseVisualStyleBackColor = true;
            this.buttomAddNewObject.Click += new System.EventHandler(this.buttomAddNewObject_Click);
            // 
            // buttonAnnuller
            // 
            this.buttonAnnuller.Location = new System.Drawing.Point(238, 8);
            this.buttonAnnuller.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAnnuller.Name = "buttonAnnuller";
            this.buttonAnnuller.Size = new System.Drawing.Size(147, 45);
            this.buttonAnnuller.TabIndex = 4;
            this.buttonAnnuller.Text = "Annuller";
            this.buttonAnnuller.UseVisualStyleBackColor = true;
            this.buttonAnnuller.Click += new System.EventHandler(this.buttonAnnuller_Click);
            // 
            // buttomSave
            // 
            this.buttomSave.Location = new System.Drawing.Point(107, 8);
            this.buttomSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttomSave.Name = "buttomSave";
            this.buttomSave.Size = new System.Drawing.Size(121, 45);
            this.buttomSave.TabIndex = 3;
            this.buttomSave.Text = "Save";
            this.buttomSave.UseVisualStyleBackColor = true;
            this.buttomSave.Click += new System.EventHandler(this.buttomSave_Click);
            // 
            // dropdownCombobox
            // 
            this.dropdownCombobox.FormattingEnabled = true;
            this.dropdownCombobox.Location = new System.Drawing.Point(107, 60);
            this.dropdownCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownCombobox.Name = "dropdownCombobox";
            this.dropdownCombobox.Size = new System.Drawing.Size(121, 21);
            this.dropdownCombobox.TabIndex = 2;
            // 
            // buttomRefresh
            // 
            this.buttomRefresh.Location = new System.Drawing.Point(8, 8);
            this.buttomRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.buttomRefresh.Name = "buttomRefresh";
            this.buttomRefresh.Size = new System.Drawing.Size(89, 76);
            this.buttomRefresh.TabIndex = 1;
            this.buttomRefresh.Text = "Refresh";
            this.buttomRefresh.UseVisualStyleBackColor = true;
            this.buttomRefresh.Click += new System.EventHandler(this.buttomRefresh_Click);
            // 
            // myObjectListView
            // 
            this.myObjectListView.CellEditUseWholeCell = false;
            this.myObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.myObjectListView.Location = new System.Drawing.Point(8, 94);
            this.myObjectListView.Margin = new System.Windows.Forms.Padding(5);
            this.myObjectListView.Name = "myObjectListView";
            this.myObjectListView.Size = new System.Drawing.Size(622, 429);
            this.myObjectListView.TabIndex = 0;
            this.myObjectListView.UseCompatibleStateImageBehavior = false;
            this.myObjectListView.View = System.Windows.Forms.View.Details;
            this.myObjectListView.SelectedIndexChanged += new System.EventHandler(this.myObjectListView_SelectedIndexChanged);
            // 
            // ExperimentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 723);
            this.Controls.Add(this.DynamicTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExperimentalForm";
            this.Text = "ExperimentalForm";
            this.Load += new System.EventHandler(this.ExperimentalForm_Load);
            this.DynamicTabControl.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabClickHereFirst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myObjectListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DynamicTabControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.TabPage tabSag;
        private System.Windows.Forms.TabPage tabAdvokat;
        private System.Windows.Forms.TabPage tabKlient;
        private System.Windows.Forms.TabPage tabYdelse;
        private System.Windows.Forms.TabPage tabClickHereFirst;
        private System.Windows.Forms.ComboBox dropdownCombobox;
        private System.Windows.Forms.Button buttomRefresh;
        private BrightIdeasSoftware.ObjectListView myObjectListView;
        private System.Windows.Forms.Button buttonHelpMe;
        private System.Windows.Forms.Button buttomAddNewObject;
        private System.Windows.Forms.Button buttonAnnuller;
        private System.Windows.Forms.Button buttomSave;
    }
}