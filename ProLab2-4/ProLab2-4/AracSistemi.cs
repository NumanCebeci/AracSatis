using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ProLab2_4
{
    public partial class AracSistemi : Form
    {
        SqlConnection baglan;
        SqlCommand komut;
        public static int Arabaid;
        public int ilanID;
        public int ilanGecis;
        public Form1 form1;

        SqlDataAdapter data;
        DataSet dataSet;
     

        public AracSistemi()
        {
            form1 = new Form1();
            InitializeComponent();
            form1.aracsistemfrm = this;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelCombo.Items.Clear();
            if (markaCombo.Text == "Audi")
            {
                modelCombo.Items.Add("A3");
                modelCombo.Items.Add("A4");
                modelCombo.Items.Add("A6");
            }

            else if (markaCombo.Text == "BMW")
            {
                modelCombo.Items.Add("320d");
                modelCombo.Items.Add("418i");
                modelCombo.Items.Add("525d");
            }

            else if (markaCombo.Text == "Mercedes-Benz")
            {
                modelCombo.Items.Add("A180");
                modelCombo.Items.Add("C180");
                modelCombo.Items.Add("E250");
            }

            else if (markaCombo.Text == "Volkswagen")
            {
                modelCombo.Items.Add("Golf");
                modelCombo.Items.Add("Jetta");
                modelCombo.Items.Add("Passat");
            }
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            Arabaid = rastgele.Next(500);
            Random rastgeleIlanID = new Random();
            ilanID = rastgeleIlanID.Next(500);
           

            baglan = new SqlConnection("Data Source=IDEA-PC\\SQLEXPRESS;Initial Catalog=Arac;Integrated Security=SSPI");
            komut = new SqlCommand();
            baglan.Open();

            komut.Connection = baglan;
            komut.CommandText = "insert into Tbl_Araba(ArabaID,Araba_Marka,Araba_Model,Araba_VitesTuruID,Araba_YakitTuruID,Araba_RenkID)values('" + 
            Arabaid + "','"+markaCombo.Text.ToString() + "','" + modelCombo.Text.ToString() + "','" + (vitesCombo.SelectedIndex + 1) + "','" +
            (yakitCombo.SelectedIndex + 1) + "','" + (renkCombo.SelectedIndex + 1 )+ "')";       
            //komut.ExecuteNonQuery();
            DateTime tarih = DateTime.Now;
            string format= "yyyy - MM - dd HH: mm: ss";
            komut.CommandText = "insert into Tbl_Ilan(IlanID,Ilan_Km,Ilan_Fiyat,Ilan_Adi,Ilan_Tarih,Ilan_ArabaID,Ilan_SehirID)values('" + ilanID +"','" + 
            kmTextBox.Text + "','" + fiyatTextBox.Text +"','"+ ilanTextBox.Text.ToString()+"','"+ tarih.ToString(format) + "','"+ilanID+"','"+sehirCombo.SelectedItem+ "')";
            
            komut.ExecuteNonQuery();

            this.Close();      
        }

        private void AracSistemi_Load(object sender, EventArgs e)
        {
            baglan = new SqlConnection("Data Source=IDEA-PC\\SQLEXPRESS;Initial Catalog=Arac;Integrated Security=SSPI");
            data = new SqlDataAdapter("SELECT a.ArabaID, a.Araba_Marka, a.Araba_Model, v.Vites_Turu, y.Yakit_Turu, " +
                "r.Renk from Arac.dbo.Tbl_Araba as a, Arac.dbo.Tbl_Renk as r, " +
                "Arac.dbo.Tbl_VitesTuru as v, Arac.dbo.Tbl_YakitTuru as y " +
                "where a.Araba_VitesTuruID = v.VitesTuruID and " +
                "a.Araba_YakitTuruID = y.YakitTuruID and a.Araba_RenkID = r.RenkID", baglan);
            dataSet = new DataSet();
            baglan.Open();
            data.Fill(dataSet, "Tbl_Araba");
            AracDataGridView.DataSource = dataSet.Tables["Tbl_Araba"];
            baglan.Close();
        }

        private void guncelleButon_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update Arac.dbo.Tbl_Ilan Set Ilan_Fiyat='" + fiyatTextBox.Text + "',Ilan_Km='" + kmTextBox.Text +
            "',Ilan_Adi='" + ilanTextBox.Text + "',Ilan_SehirID=" + (sehirCombo.SelectedIndex+1) + " where IlanID=" + ilanGecis, baglan);
            komut.ExecuteNonQuery();
            AracSistemi.ActiveForm.Close();
            baglan.Close();
        }
    }
}
