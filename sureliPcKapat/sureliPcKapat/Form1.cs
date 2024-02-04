using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sureliPcKapat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if(dkAyarlama.Value>0)
            {
                int kapanmaSuresi = (int)dkAyarlama.Value;
                Process.Start("shutdown", $"/s /t {kapanmaSuresi * 60}");
                MessageBox.Show($"{kapanmaSuresi} dakika sonra bilgisayar kapanacaktır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dkAyarlama.Value <= 0)
            {
                MessageBox.Show("Lütfen süre seçimi yapınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kullanıcı problemli hata!", "Büyük Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(dkAyarlama.Value > 0)
            {
                Process.Start("shutdown", "/a");
                MessageBox.Show("İşlem iptal edilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(dkAyarlama.Value <= 0)
            {
                MessageBox.Show("Lütfen süre seçimi yapınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen süre seçimi yapınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            string pcAdi = Environment.MachineName;
            MessageBox.Show($"Uygulamamı kullandığın için teşekkürler {pcAdi}", "Ahmet TOPAL's Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}