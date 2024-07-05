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
    public partial class Durusmalar : Form
    {
        private DavaDosyasi dosya;
        private IGenericService<Durusma> durusmaService;
        private IGenericService<DavaDosyasi> dosyaService;
        private ServiceProvider services;
        public Durusmalar(DavaDosyasi dosya, IGenericService<Durusma> durusmaService, ServiceProvider services)
        {
            InitializeComponent();
            this.dosya = dosya;
            this.durusmaService = durusmaService;
            this.services = services;
        }


        public void ListViewColumnsAdd()
        {
            durusmaList.Columns.Add("ID", 50);
            durusmaList.Columns.Add("Duruşma Yeri", 300);
            durusmaList.Columns.Add("Duruşma Tarihi", 150);
        }

        public void ListViewDataAdd()
        {
            var durusmalar = durusmaService.GetAll(d => d.DavaDosyasiId == dosya.Id);

            foreach (var d in durusmalar) //hatayı burada veriyor
            {
                string id = d.Id.ToString();
                string durusmaYeri = d.DurusmaYeri;
                string durusmaTarihi = d.DurusmaGunu.ToString();
                string[] bilgiler = { id, durusmaYeri, durusmaTarihi };
                ListViewItem item = new ListViewItem(bilgiler);

                durusmaList.Items.Add(item);
            }
        }

        public void DurusmaDuzenle()
        {
            if (durusmaList.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = durusmaList.SelectedItems[0];
                string id = selectedRow.SubItems[0].Text;

                Durusma selectedDurusma = durusmaService.GetById(Convert.ToInt32(id));

                var s = new DurusmaEkle(services, dosya, selectedDurusma);
                s.Show();
            }
        }


        private void Durusmalar_Load(object sender, EventArgs e)
        {
            ListViewColumnsAdd();
            ListViewDataAdd();
        }

        private void durusmaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DurusmaDuzenle();
        }

        private void YenileBtn_Click(object sender, EventArgs e)
        {
            durusmaList.Items.Clear();
            ListViewDataAdd();
        }
    }
}
