using GaziU.HukukBuroOtomasyonu.BL.Services.Abstract;
using GaziU.HukukBuroOtomasyonu.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaziU.HukukBuroOtomasyonu
{
    public partial class AvukatKayit : Form
    {
        private IGenericService<Avukat> avService;
        public AvukatKayit(IGenericService<Avukat> avService)
        {
            InitializeComponent();
            this.avService = avService;
        }

        private void KayitBtn_Click(object sender, EventArgs e)
        {
            var entity = new Avukat()
            {
                Adi = avAdtxt.Text,
                TcKimlikNo = Convert.ToInt64(avTcNotxt.Text),
                Sifre = avSifretxt.Text
            };

            if (avService.Create(entity))
            {
                MessageBox.Show("Kayıt başarılı");
                Close();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
                Close();
            }
        }
    }
}
