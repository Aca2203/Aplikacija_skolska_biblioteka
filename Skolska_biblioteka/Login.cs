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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void dugme_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_lozinka.Text == "")
            {
                MessageBox.Show("Niste uneli podatke.");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM Korisnik WHERE email = @username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_email.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["lozinka"].ToString(), txt_lozinka.Text) == 0)
                        {
                            MessageBox.Show("Uspesno logovanje");
                            Program.email = tabela.Rows[0]["email"].ToString();

                            this.Hide();

                            if ((int) tabela.Rows[0]["uloga"] == 1)
                            {
                                Clan frm_clan = new Clan();
                                frm_clan.Show();
                            }
                            if ((int)tabela.Rows[0]["uloga"] == 2)
                            {
                                Zaposleni frm_zaposleni = new Zaposleni();
                                frm_zaposleni.Show();
                            }
                            if ((int)tabela.Rows[0]["uloga"] == 3)
                            {
                                Administrator frm_admin = new Administrator();
                                frm_admin.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Pogresna lozinka!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uneli ste nepostojecu imejl adresu!");
                    }

                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
