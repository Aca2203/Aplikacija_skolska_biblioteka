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
    public partial class Zaposleni : Form
    {
        SqlDataAdapter adapter;
        int forma_id = 0;
        DataTable rezervacije, tabela;

        public Zaposleni()
        {
            InitializeComponent();
        }

        private void Zaposleni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Zaposleni_Load(object sender, EventArgs e)
        {            
            adapter = new SqlDataAdapter("select * from korisnik where uloga = 1", Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            cmb_clan.DataSource = tabela;
            cmb_clan.ValueMember = "email";
            cmb_clan.DisplayMember = "email";
            cmb_clan.SelectedIndex = -1;

            adapter = new SqlDataAdapter("select * from knjiga", Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            cmb_knjiga.DataSource = tabela;
            cmb_knjiga.ValueMember = "ISBN";
            cmb_knjiga.DisplayMember = "naziv";
            cmb_knjiga.SelectedIndex = -1;

            grid_popuni();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection veza = Konekcija.Connect();

                SqlCommand komanda = new SqlCommand();
                komanda.Connection = veza;
                komanda.CommandType = CommandType.StoredProcedure;
                komanda.CommandText = "Pozajmica_Insert";

                komanda.Parameters.Add(new SqlParameter("@datum_uzimanja", SqlDbType.Date, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, cmb_datum_uzimanja.Value));
                komanda.Parameters.Add(new SqlParameter("@datum_vracanja", SqlDbType.Date, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, cmb_datum_vracanja.Value));
                komanda.Parameters.Add(new SqlParameter("@clan_email", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, cmb_clan.SelectedValue));
                komanda.Parameters.Add(new SqlParameter("@zaposleni_email", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, Program.email));
                komanda.Parameters.Add(new SqlParameter("@knjiga_ISBN", SqlDbType.Char, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, cmb_knjiga.SelectedValue));
                komanda.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));

                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                int ret;
                ret = (int) komanda.Parameters["@RETURN_VALUE"].Value;
                if (ret == -2)
                {
                    MessageBox.Show("Nema dovoljno knjiga u biblioteci!");
                }
                if (ret == -1)
                {
                    MessageBox.Show("Vec imate rezervaciju u toku");
                }
                if (ret == 0)
                {
                    grid_popuni();
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();

            SqlCommand komanda = new SqlCommand();
            komanda.Connection = veza;
            komanda.CommandType = CommandType.StoredProcedure;
            komanda.CommandText = "Pozajmica_Delete";

            komanda.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, forma_id));
            komanda.Parameters.Add(new SqlParameter("@knjiga_ISBN", SqlDbType.Char, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, cmb_knjiga.SelectedValue));

            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();

            grid_popuni();            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                postavi(e.RowIndex);
                forma_id = (int)rezervacije.Rows[e.RowIndex]["id"];
            }
        }

        private void postavi(int broj_sloga)
        {
            cmb_datum_uzimanja.Value = (DateTime)rezervacije.Rows[broj_sloga]["datum_uzimanja"];
            cmb_datum_vracanja.Value = (DateTime)rezervacije.Rows[broj_sloga]["datum_vracanja"];
            cmb_clan.SelectedValue = rezervacije.Rows[broj_sloga]["clan_email"];
            cmb_knjiga.SelectedValue = rezervacije.Rows[broj_sloga]["knjiga_ISBN"];
        }

        private void grid_popuni()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, datum_uzimanja, datum_vracanja, clan_email, zaposleni_email, knjiga_ISBN, Knjiga.naziv FROM Pozajmica JOIN Knjiga ON Knjiga.ISBN = Pozajmica.knjiga_ISBN WHERE zaposleni_email = '" + Program.email + "'", Konekcija.Connect());
            rezervacije = new DataTable();
            adapter.Fill(rezervacije);
            dataGridView1.DataSource = rezervacije;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["knjiga_ISBN"].Visible = false;            
            dataGridView1.Columns["zaposleni_email"].Visible = false;            
        }
    }
}
