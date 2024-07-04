using GaziU.HukukBuroOtomasyonu.BL.Services.Abstract;
using GaziU.HukukBuroOtomasyonu.DAL.Dto;
using GaziU.HukukBuroOtomasyonu.DAL.Repsitory.Abstract;
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
    public partial class Giris : Form
    {
        private IAvukatService avService;
        public Giris(IAvukatRepository avService)
        {
            InitializeComponent();
            this.avService = avService;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            var logindto = new AvukatLoginDto()
            {
                AvukatTcNo = Convert.ToInt64(avTcTxt.Text),
                Sifre = avSifreTxt.Text
            };

            var avukat = avService.GetAvukatByLogin(logindto);
            if (avukat!=null)
            {
                var s = new Davalar(avukat);
                s.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgilerle eşleşen avukat bulunamadı");
            }

            
        }
    }
}
