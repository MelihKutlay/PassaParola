using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class BilgiYarismasiGiris : Form
    {
        public BilgiYarismasiGiris()
        {
            InitializeComponent();
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            PassaParolaBilgiYarismasi basla = new PassaParolaBilgiYarismasi();
            basla.Show();
            this.Hide();
        }
    }
}
