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
    public partial class Istatistikler : Form
    {
        public Istatistikler()
        {
            InitializeComponent();
        }
         public int toplamsoru, dogrusayisi, yanlissayisi, toplampuan, bossorusayisi;

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnyenidenbaslat_Click(object sender, EventArgs e)
        {
            BilgiYarismasiGiris basla = new BilgiYarismasiGiris();
            basla.Show();
        }

        private void Istatistikler_Load(object sender, EventArgs e)
        {
            lbltoplamsoru.Text = toplamsoru.ToString();
            lbldogrusayisi.Text = dogrusayisi.ToString();
            lblyanlissayisi.Text = yanlissayisi.ToString();
            lblpuan.Text = toplampuan.ToString();
            lblbossoru.Text = bossorusayisi.ToString();
        }
    }
}
