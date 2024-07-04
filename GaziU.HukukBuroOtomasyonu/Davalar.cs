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
    public partial class Davalar : Form
    {
        public Avukat avukat;
        public IGenericService<DavaDosyasi> dosyaService;
        public IGenericService<Avukat> avService;
        private ServiceProvider services;
        private Giris giris;
        public Davalar(IGenericService<DavaDosyasi> dosyaService, IGenericService<Avukat> avService, ServiceProvider services, Giris giris)
        {
            InitializeComponent();
            this.dosyaService = dosyaService;
            this.avService = avService;
            this.services = services;
            this.giris = giris;
        }

        public void ListViewColumnsAdd()
        {
            davalarList.Columns.Add("ID", 250);
            davalarList.Columns.Add("Esas Numarası", 250);
            davalarList.Columns.Add("Dava Konusu", 600);
            davalarList.Columns.Add("Atanan Avukat", 300);
            davalarList.Columns.Add("Dosya Açılış Tarihi", 400);
        }

        public void ListViewDataAdd()
        {
            var davalar = dosyaService.GetAll(d => d.AtananAvukatId == avukat.Id);

            foreach (var d in davalar) //hatayı burada veriyor
            {
                string id = d.Id.ToString();
                string esas = d.EsasNumarası.ToString();
                string davaKonusu = d.DavaKonusu;
                string atananAv = avService.GetById(d.AtananAvukatId ?? 0).Adi;
                string dosyaacilis = d.CreatedDate.ToString();

                string[] bilgiler = { id, esas, davaKonusu, atananAv, dosyaacilis };
                ListViewItem item = new ListViewItem(bilgiler);

                davalarList.Items.Add(item);
            }
        }

        private void Davalar_Load(object sender, EventArgs e)
        {
            ListViewColumnsAdd();
            ListViewDataAdd();
        }

        private void davalarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void dosyaEkleBtn_Click(object sender, EventArgs e)
        {
            var s = new DavaDosyaEkleme(services.GetRequiredService<IGenericService<DavaDosyasi>>(),services.GetRequiredService<IGenericService<Avukat>>());
            s.Show();
        }

        private void YenileBtn_Click(object sender, EventArgs e)
        {
            davalarList.Items.Clear();
            ListViewDataAdd();
        }
    }
}
