using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public partial class FormMüşteri : Form
    {
        DBİşlemleri db = DBİşlemleri.GetInstance();
        public bool ilkAçılış = true;
        public bool debugMode=false;
        



        public FormMüşteri()
        {
            InitializeComponent();
        }

        private void FormMüşteri_Load(object sender, EventArgs e)
        {
            if(ilkAçılış && !debugMode) // Eğer ilk kez giriş yapılıyorsa db'den bilgileri çek
            {
                db.MüşteriOtelleriAl();
                db.YorumlarıAl();
                db.OtelAğacı.InOrder();
                lblHoşgeldin.Text += " " + db.OturumMüşteri.ad;
                txtOtelBilgileri.Text = db.OtelAğacı.DugumleriYazdir();
            }
            else if(!ilkAçılış && !debugMode)
            {
                lblHoşgeldin.Text += " " + db.OturumMüşteri.ad;
                txtOtelBilgileri.Text = db.OtelAğacı.DugumleriYazdir();
            }
            else if (debugMode)
            {
                lblDebug.Visible = true;
                lblHeader.Text = "Customer Panel";
                btnOtelİşlemleri.Text = "Hotel Operations";
                lblHoşgeldin.Text = "Welcome";
            }
                

        }

        private void btnOtelİşlemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMüşteriOtelİşlemleri formMüşteriOtelİşlemleri = new FormMüşteriOtelİşlemleri();
            if (debugMode)
                formMüşteriOtelİşlemleri.debugMode = true;
            formMüşteriOtelİşlemleri.ShowDialog();
            this.Close();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            db.OtelAğacı.PreOrder();
            txtOtelBilgileri.Text = db.OtelAğacı.DugumleriYazdir();
        }

        private void BtnInOrder_Click(object sender, EventArgs e)
        {
 
           db.OtelAğacı.InOrder();
           txtOtelBilgileri.Text = db.OtelAğacı.DugumleriYazdir();
        }


        private void BtnAğaçBilgileri_Click(object sender, EventArgs e)
        {
            if (!debugMode)
                MessageBox.Show("Eleman sayısı: " + db.OtelAğacı.DugumSayisiBul().ToString()+Environment.NewLine+"Derinlik Sayısı: " + db.OtelAğacı.DerinlikBul());
            else
                MessageBox.Show("YOU ARE IN DEBUG MODE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnPostOrder_Click_1(object sender, EventArgs e)
        {
            db.OtelAğacı.PostOrder();
            txtOtelBilgileri.Text = db.OtelAğacı.DugumleriYazdir();
        }
    }
}
