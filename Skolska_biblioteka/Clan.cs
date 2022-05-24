using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skolska_biblioteka
{
    public partial class Clan : Form
    {
        public Clan()
        {
            InitializeComponent();
        }

        private void Clan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
