﻿using System;
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
         public int toplamsoru, dogrusayisi, yanlissayisi, bossorusayisi;
        public double toplampuan;
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
