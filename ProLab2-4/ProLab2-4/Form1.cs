//Numan CEBECİ  140202008
//Zeynep ERKOÇ  150202021
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
    public partial class Form1 : Form
    {
        public AracSistemi aracsistemfrm;
        SqlConnection baglan;
        SqlDataAdapter data;
        DataSet dataSet;
        public int ilanid;
        

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            veriler();
        }

        public void veriler()
        {
            baglan = new SqlConnection("Data Source=IDEA-PC\\SQLEXPRESS;Initial Catalog=Arac;Integrated Security=SSPI");
            data = new SqlDataAdapter("Select *From Tbl_Ilan", baglan);
            dataSet = new DataSet();
            baglan.Open();
            data.Fill(dataSet, "Tbl_Ilan");
            dataGridView1.DataSource = dataSet.Tables["Tbl_Ilan"];
            baglan.Close();
        }

        private void Kayıt_Ekle_Click(object sender, EventArgs e)
        {
            
            AracSistemi form2 = new AracSistemi();
            form2.ShowDialog();           
            veriler();
        }

        private void Kayıt_Sil_Click(object sender, EventArgs e)
        {
            int IlanID = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Ilan where IlanID='"+IlanID+"' Delete From Tbl_Araba where ArabaID='"+IlanID+"'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veriler();         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(dataGridView1.SelectedCells[0].ColumnIndex!=0)
            {
                //AracSistemi f1 = new AracSistemi();
                //f1.AracDataGridView = dataGridView1;
                AracSistemi aracAc = new AracSistemi();
                aracAc.Show();
                aracAc.AracDataGridView.Visible = true;

                int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
                aracAc.ilanGecis = Int32.Parse(dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString());
                
                string Adi = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
                string Ilan_Fiyat = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
                string Ilan_Km = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();
                string Ilan_SehirID =dataGridView1.Rows[seciliAlan].Cells[5].Value.ToString();

                aracAc.markaCombo.Enabled = false;
                aracAc.modelCombo.Enabled = false;
                aracAc.yakitCombo.Enabled = false;
                aracAc.vitesCombo.Enabled = false;
                aracAc.renkCombo.Enabled = false;

                aracAc.ilanTextBox.Text = Adi;
                aracAc.fiyatTextBox.Text = Ilan_Fiyat;
                aracAc.kmTextBox.Text = Ilan_Km;
                aracAc.sehirCombo.SelectedItem = Ilan_SehirID;

                veriler();
            }
        }

        private void Arama_Click(object sender, EventArgs e)
        {
            String sehirArama = "";
            if(sehirAramacomboBox.SelectedItem != null)
            {
                sehirArama = "Ilan_SehirID='"+ sehirAramacomboBox.SelectedItem + "'";
            }

            String fiyatArama = "";
            String KmArama = "";
            String TarihArama = "";

            if (sehirArama != "")
            {
                fiyatArama += " and ";
            }
            if(minAramatextBox.Text != "" && maxAramatextBox.Text != "")
            {
                fiyatArama += "Ilan_Fiyat between "+ minAramatextBox.Text+" and "+ maxAramatextBox.Text;
            }
            else if(minAramatextBox.Text != "")
            {
                fiyatArama += "Ilan_Fiyat > " + minAramatextBox.Text;
            }
            else if (maxAramatextBox.Text != "")
            {
                fiyatArama += "Ilan_Fiyat < " + maxAramatextBox.Text;
            }
            else
            {
                fiyatArama = "";
            }
            

            if (sehirArama != "" || fiyatArama != "")
            {
                KmArama += " and ";
            }
            if (minKmtextBox.Text != "" && maxKmtextBox.Text != "")
            {
                KmArama += "Ilan_Km between " + minKmtextBox.Text + " and " + maxKmtextBox.Text;
            }
            else if (minKmtextBox.Text != "")
            {
                KmArama += "Ilan_Km > " + minKmtextBox.Text;
            }
            else if (maxKmtextBox.Text  != "")
            {
                KmArama += "Ilan_Km < " + maxKmtextBox.Text;
            }
            else
            {
                KmArama = "";
            }
            
            if (sehirArama != "" || fiyatArama != "" || KmArama!= "")
            {
                TarihArama += " and ";
            }
            if(ilanAramacomboBox.SelectedIndex==0)
            {
                TarihArama += "Ilan_Tarih >=DATEADD(hour,-24,getdate()) and Ilan_Tarih <=getdate()";
            }
            
            else if (ilanAramacomboBox.SelectedIndex==1)
            {
                TarihArama+= "Ilan_Tarih >=DATEADD(day,-7,getdate()) and Ilan_Tarih <=getdate()";
            }
            else if(ilanAramacomboBox.SelectedIndex==2)
            {
                TarihArama += "Ilan_Tarih >=DATEADD(month,-1,getdate()) and Ilan_Tarih <=getdate()";
            }
            else
            {
                TarihArama = "";
            }

            dataGridView1.DataSource = "";
            data = new SqlDataAdapter("Select * From Tbl_Ilan where " + sehirArama + fiyatArama + KmArama + TarihArama , baglan);
            dataSet = new DataSet();
            baglan.Open();
            data.Fill(dataSet, "Tbl_Ilan");
            dataGridView1.DataSource = dataSet.Tables["Tbl_Ilan"];
            baglan.Close();

        }

    }
}
