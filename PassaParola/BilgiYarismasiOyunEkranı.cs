using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class PassaParolaBilgiYarismasi : Form
    {
        public PassaParolaBilgiYarismasi()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0, puan = 0, bossoru = 0;

        private void btnsoru_Click(object sender, EventArgs e)
        {
            btncevapla.Visible = true;
            soruno++;
            txtcevap.Clear();
            txtcevap.Focus();
            groupBox1.Text = "SORU" + " " + soruno;

            if (soruno == 1)
            {
                btnharfler.Text = "A";
                rchsoru.Text = "ÜLKEMİZİN GÜNEY KISMINDAKİ DENİZİN ADI ?";
                btna.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 2)
            {
                btnharfler.Text = "B";
                btncevapla.Visible = true;
                rchsoru.Text = "YEŞİLLİĞİYLE ÜNLÜ MARMARA İLİMİZ ?";
                btnb.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 3)
            {
                btnharfler.Text = "C";
                btncevapla.Visible = true;
                rchsoru.Text = "ŞEKLİ BEYNE BENZEYEN BİR KURUYEMİŞ ?";
                btnc.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 4)
            {
                btnharfler.Text = "D";
                btncevapla.Visible = true;
                rchsoru.Text = "PERİYODİK TABLODA FE OLAN ELEMENTİN ADI ?";
                btnd.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 5)
            {
                btnharfler.Text = "E";
                btncevapla.Visible = true;
                rchsoru.Text = "VÜCUDUMUZDA 5 ADET PARMAĞI OLAN ORGAN ?";
                btne.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 6)
            {
                btnharfler.Text = "F";
                btncevapla.Visible = true;
                rchsoru.Text = "ATLI ŞEKİLDE TURİSTİK AMAÇLI BİNDİĞİMİZ ARAÇ ?";
                btnf.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 7)
            {
                btnharfler.Text = "G";
                btncevapla.Visible = true;
                rchsoru.Text = "ÜLKEMİZDE BULUNAN İLK VE TEK 4 YILDIZLI TAKIM ?";
                btng.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 8)
            {
                btnharfler.Text = "H";
                btncevapla.Visible = true;
                rchsoru.Text = "KEDİ, KÖPEK, KUŞ GİBİ VARLIKLARIN GENEL ADI ?";
                btnh.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 9)
            {
                btnharfler.Text = "I";
                btncevapla.Visible = true;
                rchsoru.Text = "TÜRKİYENİN GÜNEY DOĞUSUNDA BULUNAN KOMŞU ÜLKE ?";
                btnı.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 10)
            {
                btnharfler.Text = "İ";
                btncevapla.Visible = true;
                rchsoru.Text = "BOĞA GÜREŞİYLE MEŞHUR ÜLKE ?";
                btni.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 11)
            {
                btnharfler.Text = "J";
                btncevapla.Visible = true;
                rchsoru.Text = "TÜRKİYENİN KOLLUK KUVVETİ ?";
                btnj.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 12)
            {
                btnharfler.Text = "K";
                btncevapla.Visible = true;
                rchsoru.Text = "VÜCUDUMUZDA BULUNAN VE KAN POMPALAYAN ORGAN ?";
                btnk.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 13)
            {
                btnharfler.Text = "L";
                btncevapla.Visible = true;
                rchsoru.Text = "HOLLANDANIN EN MEŞHUR ÇİÇEĞİ ?";
                btnl.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 14)
            {
                btnharfler.Text = "M";
                btncevapla.Visible = true;
                rchsoru.Text = "UZAĞI GÖREMEYEN HASTALARA KOYULAN TEŞHİS ?";
                btnm.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 15)
            {
                btnharfler.Text = "N";
                btncevapla.Visible = true;
                rchsoru.Text = "İSLAM DİNİNDE GÜNDE 5 DEFA YAPILMASI FARZ OLAN İBADET ?";
                btnn.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 16)
            {
                btnharfler.Text = "O";
                btncevapla.Visible = true;
                rchsoru.Text = "TÜRKİYENİN KARADENİZ BÖLGESİNDE BULUNAN ŞEHİR ?";
                btno.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 17)
            {
                btnharfler.Text = "P";
                btncevapla.Visible = true;
                rchsoru.Text = "UZAYDA BULUNAN BİR GEZEGEN ?";
                btnp.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 18)
            {
                btnharfler.Text = "R";
                btncevapla.Visible = true;
                rchsoru.Text = "DÜNYANIN EN BÜYÜK YÜZÖLÇMÜNE SAHİP ÜLKE ?";
                btnr.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 19)
            {
                btnharfler.Text = "S";
                btncevapla.Visible = true;
                rchsoru.Text = "ERKEKLERİN YÜZÜNDE ÇIKAN KILLARIN TÜMÜ ?";
                btns.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 20)
            {
                btnharfler.Text = "T";
                btncevapla.Visible = true;
                rchsoru.Text = "TAŞITLARDA KULLANILAN ÇEMBER BİÇİMLİ PARÇA ?";
                btnt.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 21)
            {
                btnharfler.Text = "U";
                btncevapla.Visible = true;
                rchsoru.Text = "HATIRLAMAMAK ?";
                btnu.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 22)
            {
                btnharfler.Text = "V";
                btncevapla.Visible = true;
                rchsoru.Text = "TÜRKİYEDE KEDİSİYLE MEŞHUR ŞEHİR ?";
                btnv.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 23)
            {
                btnharfler.Text = "Y";
                btncevapla.Visible = true;
                rchsoru.Text = "BİR MEVSİM ?";
                btny.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
            }
            if (soruno == 24)
            {
                btnharfler.Text = "Z";
                rchsoru.Text = "SİYAH BEYAZ BİR HAYVAN ?";
                btnz.BackColor = Color.White;
                btnharfler.BackColor = Color.White;
                btncevapla.Visible = true;
                btnsoru.Visible = false;
                btnbitir.Visible = true;
            }
        }

        private void PassaParolaBilgiYarismasi_Load(object sender, EventArgs e)
        {
            btncevapla.Visible = false;
        }

        private void btnbitir_Click(object sender, EventArgs e)
        {
            bossoru = soruno - (dogru + yanlis);
            Istatistikler istatistik = new Istatistikler();
            istatistik.toplamsoru = soruno;
            istatistik.dogrusayisi = dogru;
            istatistik.yanlissayisi = yanlis;
            istatistik.toplampuan = puan;
            istatistik.bossorusayisi = bossoru;
            istatistik.Show();
            this.Close();
        }

        private void btncevapla_Click(object sender, EventArgs e)
        {

            if (soruno == 1)
            {
                if (txtcevap.Text == "AKDENİZ" || txtcevap.Text == "akdeniz")
                {
                    dogru++;
                    puan += 100;
                    lblpuan.Text = puan.ToString();
                    lbldogru.Text = dogru.ToString();
                    btna.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    yanlis++;
                    btna.BackColor = Color.Red;
                    lblyanlis.Text = yanlis.ToString();
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (soruno == 2)
            {

                if (txtcevap.Text == "BURSA" || txtcevap.Text == "bursa")
                {
                    dogru++;
                    puan += 100;
                    lblpuan.Text = puan.ToString();
                    lbldogru.Text = dogru.ToString();
                    btnb.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnb.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 3)
            {
                if (txtcevap.Text == "CEVİZ" || txtcevap.Text == "ceviz")
                {
                    dogru++;
                    puan += 100;
                    lblpuan.Text = puan.ToString();
                    lbldogru.Text = dogru.ToString();
                    btnc.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnc.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            else if (soruno == 4)
            {
                if (txtcevap.Text == "DEMİR" || txtcevap.Text == "demir")
                {
                    dogru++;
                    puan += 100;
                    lblpuan.Text = puan.ToString();
                    lbldogru.Text = dogru.ToString();
                    btnd.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnd.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (soruno == 5)
            {
                if (txtcevap.Text == "EL" || txtcevap.Text == "el")
                {
                    dogru++;
                    puan += 100;
                    lblpuan.Text = puan.ToString();
                    lbldogru.Text = dogru.ToString();
                    btne.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btne.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (soruno == 6)
            {
                if (txtcevap.Text == "FAYTON" || txtcevap.Text == "fayton")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnf.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnf.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 7)
            {
                if (txtcevap.Text == "GALATASARAY" || txtcevap.Text == "galatasaray")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btng.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;

                    lblyanlis.Text = yanlis.ToString();
                    btng.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 8)
            {
                if (txtcevap.Text == "HAYVAN" || txtcevap.Text == "hayvan")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnh.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnh.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 9)
            {
                if (txtcevap.Text == "IRAK" || txtcevap.Text == "ırak")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnı.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnı.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 10)
            {
                if (txtcevap.Text == "İSPANYA" || txtcevap.Text == "ispanya")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btni.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btni.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 11)
            {
                if (txtcevap.Text == "JANDARMA" || txtcevap.Text == "jandarma")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnj.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnj.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 12)
            {
                if (txtcevap.Text == "KALP" || txtcevap.Text == "kalp")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnk.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnk.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 13)
            {
                if (txtcevap.Text == "LALE" || txtcevap.Text == "lale")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnl.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnl.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 14)
            {
                if (txtcevap.Text == "MİYOP" || txtcevap.Text == "miyop")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnm.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnm.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 15)
            {
                if (txtcevap.Text == "NAMAZ" || txtcevap.Text == "namaz")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnn.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnn.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 16)
            {
                if (txtcevap.Text == "ORDU" || txtcevap.Text == "ordu")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btno.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btno.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 17)
            {
                if (txtcevap.Text == "URANÜS" || txtcevap.Text == "uranüs")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnp.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnp.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 18)
            {
                if (txtcevap.Text == "RUSYA" || txtcevap.Text == "rusya")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnr.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnr.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 19)
            {
                if (txtcevap.Text == "SAKAL" || txtcevap.Text == "sakal")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btns.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btns.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (soruno == 20)
            {
                if (txtcevap.Text == "TEKERLEK" || txtcevap.Text == "tekerlek")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnt.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnt.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 21)
            {
                if (txtcevap.Text == "UNUTMAK" || txtcevap.Text == "unutmak")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnu.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnu.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 22)
            {
                if (txtcevap.Text == "VAN" || txtcevap.Text == "van")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnv.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnv.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 23)
            {
                if (txtcevap.Text == "YAZ" || txtcevap.Text == "yaz")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btny.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btny.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (soruno == 24)
            {

                if (txtcevap.Text == "ZEBRA" || txtcevap.Text == "zebra")
                {
                    dogru++;
                    puan += 100;
                    lbldogru.Text = dogru.ToString();
                    lblpuan.Text = puan.ToString();
                    btnz.BackColor = Color.Green;
                    btnharfler.BackColor = Color.Green;
                    btncevapla.Visible = false;
                    btnbitir.Visible = true;
                    MessageBox.Show("TEBRİKLER DOĞRU CEVAP", "DOĞRU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                    btnz.BackColor = Color.Red;
                    btnharfler.BackColor = Color.Red;
                    btncevapla.Visible = false;
                    MessageBox.Show("YANLIŞ CEVAP", "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}