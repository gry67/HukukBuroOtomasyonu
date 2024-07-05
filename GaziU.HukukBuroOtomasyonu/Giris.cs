using GaziU.HukukBuroOtomasyonu.BL.Services.Abstract;
using GaziU.HukukBuroOtomasyonu.DAL.Dto;
using GaziU.HukukBuroOtomasyonu.DAL.Models;
using GaziU.HukukBuroOtomasyonu.DAL.Repsitory.Abstract;
using Microsoft.Extensions.DependencyInjection;
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
        private ServiceProvider services;
        public Giris(IAvukatService avService,ServiceProvider services)
        {
            InitializeComponent();
            this.avService = avService;
            this.services = services;
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
                var s = new Davalar(services.GetRequiredService<IGenericService<DavaDosyasi>>(), services.GetRequiredService<IGenericService<Avukat>>(),services,this);
                s.avukat = avukat;
                Hide();
                s.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgilerle eşleşen avukat bulunamadı");
            }

            
        }
    }
}
