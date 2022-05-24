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
        int id = 0;
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
            cmb_clan.ValueMember = "id";
            cmb_clan.DisplayMember = "email";
            cmb_clan.SelectedIndex = -1;

            adapter = new SqlDataAdapter("select * from knjiga", Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            cmb_knjiga.DataSource = tabela;
            cmb_knjiga.ValueMember = "id";
            cmb_knjiga.DisplayMember = "naziv";
            cmb_knjiga.SelectedIndex = -1;

            grid_popuni();
        }

        private void grid_popuni()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, datum_uzimanja, datum_vracanja, clan_email, knjiga_ISBN, Knjiga.naziv FROM Pozajmica JOIN Knjiga ON Knjiga.ISBN = Pozajmica.knjiga_ISBN WHERE zaposleni_email = " + Program.email, Konekcija.Connect());
            rezervacije = new DataTable();
            adapter.Fill(rezervacije);
            dataGridView1.DataSource = rezervacije;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["knjiga_ISBN"].Visible = false;            
        }
    }
}
