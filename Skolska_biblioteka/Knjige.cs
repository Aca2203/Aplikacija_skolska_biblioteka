using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skolska_biblioteka
{
    public partial class Knjige : Form
    {
        SqlConnection veza = Konekcija.Connect();
        int broj_sloga = 0;
        SqlDataAdapter adapter;
        DataTable tabela, dt_podaci;

        public Knjige()
        {
            InitializeComponent();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM Izdavac", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
            cmb_izdavac.DataSource = tabela;
            cmb_izdavac.ValueMember = "id";
            cmb_izdavac.DisplayMember = "ime";

            Ucitaj_Podatke();
            Txt_Ucitaj();            
        }

        private void Ucitaj_Podatke()
        {
            cmb_izdavac.SelectedIndex = -1;

            adapter = new SqlDataAdapter("SELECT * FROM Knjiga", veza);
            dt_podaci = new DataTable();
            adapter.Fill(dt_podaci);
        }

        private void Txt_Ucitaj()
        {
            if (dt_podaci.Rows.Count != 0)
            {
                txt_isbn.Text = dt_podaci.Rows[broj_sloga]["ISBN"].ToString();
                txt_naziv.Text = dt_podaci.Rows[broj_sloga]["naziv"].ToString();
                cmb_izdavac.SelectedValue = dt_podaci.Rows[broj_sloga]["izdavac_id"];
                txt_kolicina.Text = dt_podaci.Rows[broj_sloga]["kolicina"].ToString();

                btn_izmeni.Enabled = true;
                btn_obrisi.Enabled = true;
                if (broj_sloga == 0)
                {
                    btn_prvi.Enabled = false;
                    btn_prethodni.Enabled = false;
                }
                else
                {
                    btn_prvi.Enabled = true;
                    btn_prethodni.Enabled = true;
                }

                if (broj_sloga == dt_podaci.Rows.Count - 1)
                {
                    btn_poslednji.Enabled = false;
                    btn_sledeci.Enabled = false;
                }
                else
                {
                    btn_poslednji.Enabled = true;
                    btn_sledeci.Enabled = true;
                }
            }
            else
            {
                txt_isbn.Text = "";
                txt_naziv.Text = "";
                cmb_izdavac.SelectedIndex = -1;

                btn_prvi.Enabled = false;
                btn_prethodni.Enabled = false;
                btn_poslednji.Enabled = false;
                btn_sledeci.Enabled = false;
                btn_izmeni.Enabled = false;
                btn_obrisi.Enabled = false;
            }
        }

        private void btn_prvi_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Ucitaj();
        }

        private void btn_poslednji_Click(object sender, EventArgs e)
        {
            broj_sloga = dt_podaci.Rows.Count - 1;
            Txt_Ucitaj();
        }

        private void btn_prethodni_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Ucitaj();
        }

        private void btn_sledeci_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Ucitaj();
        }        

        private void btn_izmeni_Click(object sender, EventArgs e)
        {           
            try
            {
                StringBuilder naredba = new StringBuilder("UPDATE Knjiga SET ");
                naredba.Append("naziv = N'" + txt_naziv.Text + "', ");
                naredba.Append("izdavac_id = " + cmb_izdavac.SelectedValue + ", ");
                naredba.Append("kolicina = " + txt_kolicina.Text + " ");
                naredba.Append("WHERE ISBN = '" + txt_isbn.Text + "'");
                //MessageBox.Show(naredba.ToString());

                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Ucitaj_Podatke();
            Txt_Ucitaj();
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM Knjiga WHERE ISBN = '" + txt_isbn.Text + "'";
            //MessageBox.Show(naredba.ToString());

            SqlCommand komanda = new SqlCommand(naredba, veza);
            bool brisano = false;
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            if (brisano)
            {
                Ucitaj_Podatke();
                if (broj_sloga > 0) broj_sloga--;

                Txt_Ucitaj();
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {            
            try
            {
                StringBuilder naredba = new StringBuilder("INSERT INTO Knjiga(ISBN, naziv, izdavac_id, kolicina) VALUES (N'");
                naredba.Append(txt_isbn.Text + "', N'");
                naredba.Append(txt_naziv.Text + "', ");
                naredba.Append(cmb_izdavac.SelectedValue + ", ");
                naredba.Append(txt_kolicina.Text + ")");
                //MessageBox.Show(naredba.ToString());

                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Ucitaj_Podatke();
            broj_sloga = dt_podaci.Rows.Count - 1;
            Txt_Ucitaj();
        }
    }
}
