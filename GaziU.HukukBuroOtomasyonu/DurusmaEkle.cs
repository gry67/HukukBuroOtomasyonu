using GaziU.HukukBuroOtomasyonu.BL.Services.Abstract;
using GaziU.HukukBuroOtomasyonu.DAL.Models;
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
    public partial class DurusmaEkle : Form
    {
        private ServiceProvider services;
        private IGenericService<Durusma> durusmaService;
        private DavaDosyasi dosya;
        private Durusma durusma;
        public DurusmaEkle(ServiceProvider services, DavaDosyasi dosya, Durusma durusma = null)
        {
            InitializeComponent();
            this.services = services;
            durusmaService = services.GetRequiredService<IGenericService<Durusma>>();
            this.dosya = dosya;
            this.durusma = durusma;
        }

        private void DurusmaEkleBtn_Click(object sender, EventArgs e)
        {
            if (durusma != null)
            {
                var entity = durusmaService.GetById(durusma.Id);
                entity.DurusmaYeri = DurusmaYeriTxt.Text;
                entity.DurusmaGunu = DurusmaTarihPick.Value;

                MessageBox.Show("duruşma Güncellendi");
                Close();
                return;
            }


            if (DurusmaYeriTxt.Text == string.Empty)
            {
                MessageBox.Show("Duruşma yeri girmediniz.");
                return;
            }
            else
            {
                var durusma = new Durusma()
                {
                    DavaDosyasiId = dosya.Id,
                    DurusmaGunu = DurusmaTarihPick.Value.Date,
                    DurusmaYeri = DurusmaYeriTxt.Text,
                };


                if (durusmaService.Create(durusma))
                {
                    MessageBox.Show("Duruşma Eklendi.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Duruşma Eklenemedi");
                }
            }
        }

        private void DurusmaEkle_Load(object sender, EventArgs e)
        {
            if (durusma != null)
            {
                DurusmaYeriTxt.Text = durusma.DurusmaYeri;
                DurusmaTarihPick.Value = durusma.DurusmaGunu;
            }
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            if (durusma!=null)
            {
                if (durusmaService.DeleteById(durusma.Id))
                {
                    MessageBox.Show("Duruşma Kaydı silindi.");
                    Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Boş kayıt silinemez.");
                }
            }
        }
    }
}
