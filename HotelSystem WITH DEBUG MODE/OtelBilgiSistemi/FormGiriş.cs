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
    public partial class FormGiriş : Form
    {

        DBİşlemleri dB = DBİşlemleri.GetInstance();
        public FormGiriş()
        {
            InitializeComponent();
        }


        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (dB.OturumVer(txtKullanıcıAdı.Text, txtŞifre.Text) == false) //Böyle bir kullanıcı yoksa
            {
                MessageBox.Show("Kullanıcı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dB.MüşteriOturumu(txtKullanıcıAdı.Text, txtŞifre.Text)==true)  
            {
                
                  this.Hide();
                  FormMüşteri formMüşteri = new FormMüşteri();
                  formMüşteri.ShowDialog();
                  this.Close();

            }
            else
            {
                  this.Hide();
                  FormYönetici formYönetici = new FormYönetici();
                  formYönetici.ShowDialog();
                  this.Close();
            } 

         

        }

        private void btnDebugAdmin_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormYönetici formYönetici = new FormYönetici();
            formYönetici.debugMode = true;
            formYönetici.ShowDialog();
            this.Close();
        }

        private void btnDebugCustomer_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormMüşteri formMüşteri = new FormMüşteri();
            formMüşteri.debugMode = true;
            formMüşteri.ShowDialog();
            this.Close();
        }
    }
}
