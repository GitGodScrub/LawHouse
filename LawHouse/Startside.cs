using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using BusinessLogic;
using DataClassLib;


namespace GUI
{
    public partial class Startside : Form
    {   
         public Startside()
        {
            InitializeComponent();

            //Denne kode er til at oprette sag
            txt_Sag_StartDato.Text = DateTime.Now.ToString("dd-MM-yyyy");
           // txt_Sag_StartDato.Text = DateTime.Today.ToString("dd-MM-yyyy-hh-mm-ss ", CultureInfo.InvariantCulture);
          //  txt_Sag_StartDato.Text = DateTime.UtcNow.ToString("hh-mm-ss");
            Datetimepicker_Sag_slutdato.Format = DateTimePickerFormat.Custom;
            Datetimepicker_Sag_slutdato.MinDate = DateTime.Today;
            Datetimepicker_Sag_slutdato.CustomFormat = " ";
            

            combobox_SagSagsType.DataSource = Controller.GetAllYdelseType();
            combobox_SagSagsType.DisplayMember = "YdelsesNavn";
         //   YdelseType ydelseType = (YdelseType)combobox_SagSagsType.SelectedItem;
            combobox_SagSagsType.ValueMember = "YdelsesTypeNr";
        //    combobox_SagMedarbejderNr.DataSource = Controller.GetAllAdvokatFromYdelse(ydelseType.YdelsesTypeNr);
            combobox_SagMedarbejderNr.DisplayMember = "Navn";
            combobox_SagMedarbejderNr.ValueMember = "AdvokatId";
            combobox_SagMedarbejderNr.SelectedIndex = -1;

            //Denne kode er til oversigt over sag 
            myObjectListView.SetObjects(Controller.GetAllKlient());
            combobox_OversigtYdelseType.DataSource = Controller.GetAllItems();
            combobox_OversigtYdelseType.DisplayMember = "What_type";

        }

       

          //Tab index 1 //Hvad der sker når man klikker på tabs'ne
                          
            private void txt_YdelseTypeNr_SelectedIndexChanged(object sender, EventArgs e)
            {
                YdelseType ydelseType = (YdelseType)combobox_SagSagsType.SelectedItem;
                combobox_SagMedarbejderNr.DataSource = Controller.GetAllAdvokatFromYdelse(ydelseType.YdelsesTypeNr);
                combobox_SagMedarbejderNr.SelectedIndex = -1;
            }                    

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.CreateSag(txt_Sag_titel.Text, txt_Sag_StartDato.Text, Datetimepicker_Sag_slutdato.Text, txt_Sag_kørsel.Text, txt_Sag_time.Text, txt_Sag_SagsBeskrivelse.Text, txt_Sag_InterneNoter.Text, Convert.ToInt32(txt_Sag_KlientNr.Text), (int)combobox_SagMedarbejderNr.SelectedValue, (int)combobox_SagSagsType.SelectedValue);

                txt_Sag_titel.Clear();
                txt_Sag_StartDato.Clear();
                txt_Sag_kørsel.Clear();
                txt_Sag_kørsel.Clear();
                txt_Sag_time.Clear();
                txt_Sag_SagsBeskrivelse.Clear();
                txt_Sag_InterneNoter.Clear();
                txt_Sag_KlientNr.Clear();
                MessageBox.Show("Sagen er nu oprette, du kan finde den i sags oversigt");
            }
            catch (Exception)
            {
                MessageBox.Show("Ikke alle er udfyldt, vend venligst tilbage til Opret sag");
       
            }
           
            
        }

        private void btn_GoToFormCreateAdvokat_Click(object sender, EventArgs e)
        {
            
            dynamicTabControl.SelectedTab = tab_OpretAdvokat;
        }

        private void Btn_CreateKlient_Click(object sender, EventArgs e)
        {
             
            dynamicTabControl.SelectedTab = tab_OpretKlient;
        }

        private void btn_GåtilYdelse_Click(object sender, EventArgs e)
        {
            dynamicTabControl.SelectedTab = tab_OpretYdelse;
        }

        private void Btn_Oversigt_Click(object sender, EventArgs e)
        {
            dynamicTabControl.SelectedTab = tab_Oversigt;
        }
        private void btn_opretsag_Click(object sender, EventArgs e)
        {
            dynamicTabControl.SelectedTab = tabOpretSag;
        }

        //Koden under til opret advokat

        private void btn_CreateAdvokat_Click(object sender, EventArgs e)
        {
            try
            {
               // Controller.CreateSag(txt_Sag_titel.Text, txt_Sag_StartDato.Text, Datetimepicker_Sag_slutdato.Text, txt_Sag_kørsel.Text, txt_Sag_time.Text, txt_Sag_SagsBeskrivelse.Text, txt_Sag_InterneNoter.Text, Convert.ToInt32(txt_Sag_KlientNr.Text), (int)combobox_SagMedarbejderNr.SelectedValue, (int)combobox_SagSagsType.SelectedValue);

              //  string navn = txt_Advokat_AdvokatNavn.Text;
                Controller.CreateAdvokat(txt_Advokat_AdvokatNavn.Text);
                MessageBox.Show("Oprettet.");
                txt_Advokat_AdvokatNavn.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ikke alt er valgt, gå venligst tilbage og indtast informatioen ");

            }
           
        }

        private void btn_AddSpecialToAdvokat_Click(object sender, EventArgs e)
        {
            try
            {

                string specialeNavn = txt_Advokat_SpecialeNavn.Text;
                int advokatId = Convert.ToInt32(txt_Advokat_AdvokatId.Text);
                Controller.AddSpecialToAdvokat(specialeNavn, advokatId);
                MessageBox.Show("Speciale tilføjet.");
                txt_Advokat_SpecialeNavn.Clear();
                txt_Advokat_AdvokatId.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ikke alt er valgt, gå venligst tilbage og indtast informatioen ");

            }
        }
        //Koden under er til Klient

        private void btn_OpretKlient(object sender, EventArgs e)
        {
            
            try
            {
                string navn = Txt_Klient_navn.Text;
                string Adresse = Txt_Klient_Adresse.Text;
                string TelefonNr = Txt_Klient_TelefonNr.Text;
                Controller.CreateKlient(navn, Adresse, TelefonNr);
                MessageBox.Show("Oprettet");
                Txt_Klient_navn.Clear();
                Txt_Klient_Adresse.Clear();
                Txt_Klient_TelefonNr.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ikke alt er valgt, gå venligst tilbage og indtast informatioen ");

            }
        }

        private void btn_opret_ydelse(object sender, EventArgs e)
        {
            try
            {
                Controller.CreateYdelse(txt_ydelse_startdato.Text, txt_ydelse_beskrivelse.Text, txt_ydelse_Pris.Text, txt_ydelse_timer.Text, Convert.ToInt32(txt_ydelse_sagsNr.Text), Convert.ToInt32(txt_ydelse_AdvokatID.Text));
                MessageBox.Show("Ydelsen er nu oprettet");
            }
            catch (Exception)
            {
                MessageBox.Show("Ikke alt er valgt, gå venligst tilbage og indtast informatioen ");
            }
        }



        //Koden under er ikke noget der har med nogle funktionelle krav at gøre, 
        //det er lavt så man kan skifte visningen af kolonner, alt efter om det er sag, klient osv.
        //Der er tilføjet en ekstra kolonne, fordi man ikke kan skjule den primære kolonnen
        
         
           

        private void btn_Update_Click(object sender, EventArgs e)
        {
            foreach (object item in myObjectListView.Objects)
            {

                if (item is Sag)
                {
                    Controller.UpdateSag(item);

                }
                else if (item is Advokat)
                {
                    Controller.UpdateAdvokat(item);
                }
                else if (item is Ydelse)
                {
                    Controller.UpdateYdelse(item);
                }
                else if (item is Klient)
                {
                    Controller.UpdateKLient(item);
                }
            }
            MessageBox.Show("færdig");
        }

        private void combobox_hvad_type_SelectedIndexChanged(object sender, EventArgs e)
        {
                ListItems listItem = (ListItems)combobox_OversigtYdelseType.SelectedItem;
                switch (listItem.What_type)
                {

                    case "Klient":
                        myObjectListView.SetObjects(Controller.GetAllKlient());
                        foreach (var item in myObjectListView.AllColumns)
                        {
                            item.IsVisible = false;
                        }
                        KlientNr.IsVisible = true;
                        Navn.IsVisible = true;
                        Adresse.IsVisible = true;
                        TelefonNr.IsVisible = true;
                        break;

                    case "Sag":
                        myObjectListView.SetObjects(Controller.GetAllSag());
                        foreach (var item in myObjectListView.AllColumns)
                        {
                            item.IsVisible = false;
                        }
                        SagsNr.IsVisible = true;
                        Arbejdstitel.IsVisible = true;
                        StartDate.IsVisible = true;
                        Slutdate.IsVisible = true;
                        TimeEstimat.IsVisible = true;
                        SagsBeskrivelse.IsVisible = true;
                        InterneNoter.IsVisible = true;
                        KlientNr.IsVisible = true;
                        MedarbejderNr.IsVisible = true;
                        YdelsesTypeNr.IsVisible = true;
                        break;
                    case "Advokat":
                        myObjectListView.SetObjects(Controller.GetAllAdvokat());
                        foreach (var item in myObjectListView.AllColumns)
                        {
                            item.IsVisible = false;
                        }
                        MedarbejderNr.IsVisible = true;
                        Advokat_navn.IsVisible = true;
                        break;
                    case "Ydelse":
                        myObjectListView.SetObjects(Controller.GetAllYdelses());
                        foreach (var item in myObjectListView.AllColumns)
                        {
                            item.IsVisible = false;
                        }
                        YdelsesNr.IsVisible = true;
                        StartDate.IsVisible = true;
                        YdelseBeskrivelse.IsVisible = true;
                        Pris.IsVisible = true;
                        Timer.IsVisible = true;
                        SagsNr.IsVisible = true;
                        AdvokatID.IsVisible = true;
                        break;
                }
                myObjectListView.RebuildColumns();
            }

        private void Sag_drop_YdelseTypeNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            YdelseType ydelseType = (YdelseType)combobox_SagSagsType.SelectedItem;
            combobox_SagMedarbejderNr.DataSource = Controller.GetAllAdvokatFromYdelse(ydelseType.YdelsesTypeNr);
            combobox_SagMedarbejderNr.SelectedIndex = -1;
        }

        private void Startside_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDrop.YdelseType' table. You can move, or remove it, as needed.
            this.ydelseTypeTableAdapter.Fill(this.dataSetDrop.YdelseType);
            // TODO: This line of code loads data into the 'dataSetDrop.Ydelse' table. You can move, or remove it, as needed.
            this.ydelseTableAdapter.Fill(this.dataSetDrop.Ydelse);
            // TODO: This line of code loads data into the 'dataSetDrop.Ydelse' table. You can move, or remove it, as needed.
            //  this.ydelseTableAdapter.Fill(this.dataSetDrop.Ydelse);

        }


        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {

        ListItems listItem = (ListItems)combobox_OversigtYdelseType.SelectedItem;
        switch (listItem.What_type)
        {

            case "Klient":
                dynamicTabControl.SelectedTab = tabDybere;
                tabDybereOverblik.SelectedTab = Klient;
                break;

            case "Sag":
                    dynamicTabControl.SelectedTab = tabDybere;
                    tabDybereOverblik.SelectedTab = Sag;
                    break;
            case "Advokat":
                    dynamicTabControl.SelectedTab = tabDybere;
                    tabDybereOverblik.SelectedTab = Advokat;
                    break;
            case "Ydelse":
                    dynamicTabControl.SelectedTab = tabDybere;
                    tabDybereOverblik.SelectedTab = Ydelse;
                    break;

        }
        }
    }
}

