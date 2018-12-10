using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using BusinessLogic;

namespace GUI
{
    public partial class ExperimentalForm //Julius(Port) - Design of items by others
    {
        //Laver nye Items til brug i GUI'en
        private ObjectListView GetMyObjectListView(string name)//Design by Daniella, Ported by Julius
        {
            ObjectListView newObjectListView = new ObjectListView();
            newObjectListView.AllColumns.Add(olvColumn1);
            newObjectListView.AllColumns.Add(SagsNr);
            newObjectListView.AllColumns.Add(Arbejdstitel);
            newObjectListView.AllColumns.Add(StartDato);
            newObjectListView.AllColumns.Add(SlutDato);
            newObjectListView.AllColumns.Add(Kørselstimer);
            newObjectListView.AllColumns.Add(TimeEstimat);
            newObjectListView.AllColumns.Add(SagsBeskrivelse);
            newObjectListView.AllColumns.Add(InterneNoter);
            newObjectListView.AllColumns.Add(KlientNr);
            newObjectListView.AllColumns.Add(MedarbejderNr);
            newObjectListView.AllColumns.Add(YdelsesTypeNr);
            newObjectListView.AllColumns.Add(Navn);
            newObjectListView.AllColumns.Add(Adresse);
            newObjectListView.AllColumns.Add(TelefonNr);
            newObjectListView.AllColumns.Add(Advokat_navn);
            newObjectListView.AllColumns.Add(YdelsesNr);
            newObjectListView.AllColumns.Add(YdelseBeskrivelse);
            newObjectListView.AllColumns.Add(Pris);
            newObjectListView.AllColumns.Add(Timer);
            newObjectListView.AllColumns.Add(AdvokatID);
            newObjectListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            newObjectListView.CellEditUseWholeCell = false;
            newObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            olvColumn1,
            SagsNr,
            Arbejdstitel,
            StartDato,
            SlutDato,
            Kørselstimer,
            TimeEstimat,
            SagsBeskrivelse,
            InterneNoter,
            KlientNr,
            MedarbejderNr,
            YdelsesTypeNr,
            Navn,
            Adresse,
            TelefonNr,
            Advokat_navn,
            YdelsesNr,
            YdelseBeskrivelse,
            Pris,
            Timer,
            AdvokatID});
            newObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            newObjectListView.FullRowSelect = true;
            newObjectListView.GridLines = true;
            newObjectListView.HasCollapsibleGroups = false;
            newObjectListView.Location = new System.Drawing.Point(5, 117);
            newObjectListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            newObjectListView.Name = name;
            newObjectListView.ShowGroups = false;
            newObjectListView.ShowImagesOnSubItems = true;
            newObjectListView.Size = new System.Drawing.Size(857, 427);
            newObjectListView.TabIndex = 9;
            newObjectListView.UseCompatibleStateImageBehavior = false;
            newObjectListView.UseFiltering = true;
            newObjectListView.View = System.Windows.Forms.View.Details;
            return newObjectListView;
        }

        private ComboBox GetCombobox(string name)//Original(s) by Daniella, Uniformaliced and Documented by Julius
        {
            ComboBox newComboBox = new ComboBox();

            switch (name)
            {
                case "comboboxYdelseType"://?
                    newComboBox.DataSource = Controller.GetAllYdelseType(); //Hvor den får sine mugligheder fra
                    newComboBox.DisplayMember = "YdelsesNavn"; //Hvad muglighederne skal vises som
                    newComboBox.ValueMember = "YdelsesTypeNr"; //Hvilken værdi hver valgmuglighed representere
                    break;
                case "comboboxOversigt":
                    newComboBox.DataSource = Controller.GetAllItems();
                    newComboBox.DisplayMember = "What_type"; 
                    //newComboBox.ValueMember = "What_type";
                    
                    newComboBox.FormattingEnabled = true;
                    newComboBox.Location = new System.Drawing.Point(107, 60);
                    newComboBox.Margin = new System.Windows.Forms.Padding(2);
                    newComboBox.Name = name;
                    newComboBox.Size = new System.Drawing.Size(121, 21);
                    newComboBox.TabIndex = 2;
                    newComboBox.SelectedIndexChanged += (comboboxOversigt_SelectedIndexChanged);
                    break;
                case "comboboxAdvokat"://?  - Er denne rigtig?
                    newComboBox.DataSource = Controller.GetAllItems();
                    newComboBox.DisplayMember = "Navn";
                    newComboBox.ValueMember = "AdvokatId";
                    break;

            }
            return newComboBox;
        }

        private DateTimePicker GetDateTimePicker(string name)//Original by Daniella //Bad port, broken
        {
            DateTimePicker newDateTimePicker = new DateTimePicker();



            newDateTimePicker.Format = DateTimePickerFormat.Custom; //slutdato samt kode
            newDateTimePicker.MinDate = DateTime.Today; //skal måske sikres
            newDateTimePicker.CustomFormat = " ";
            throw new NotImplementedException();
            return newDateTimePicker;
        }

        private Button GetButtomRefresh(string name) //load form //bliver kaldt fra update som det er nu
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(8, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(89, 76);
            newButton.TabIndex = 1;
            newButton.Text = "Refresh";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttomRefresh_Click);
            return newButton;
        }

        private Button GetButtomSave(string name) //update
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(107, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(121, 45);
            newButton.TabIndex = 3;
            newButton.Text = "Save";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttomSave_Click);
            return newButton;
        }

        private Button GetButtonAnnuller(string name) //basically refresh
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(238, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(147, 45);
            newButton.TabIndex = 4;
            newButton.Text = "Annuller";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttonAnnuller_Click);
            return newButton;
        }

        private Button GetButtomAddNewObjectButton(string name)
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(395, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(149, 45);
            newButton.TabIndex = 5;
            newButton.Text = "AddNewObject";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttomAddNewObject_Click);
            return newButton;
        }
        private Button GetButtonHelpMe(string name)
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(554, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(76, 76);
            newButton.TabIndex = 6;
            newButton.Text = "HelpMe";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttonHelpMe_Click);
            return newButton;
        }
    }
}
