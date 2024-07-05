using GaziU.HukukBuroOtomasyonu.BL.Services.Abstract;
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
    public partial class ButunDurusmalar : Form
    {
        private ServiceProvider services;
        private IGenericService<Durusma> durusmaService; 
        public ButunDurusmalar(ServiceProvider services)
        {
            InitializeComponent();
            this.services = services;
            durusmaService = services.GetRequiredService<IGenericService<Durusma>>();
        }
        public void ListViewColumnsAdd()
        {
            durusmalarList.Columns.Add("ID", 50);
            durusmalarList.Columns.Add("Duruşma Yeri", 300);
            durusmalarList.Columns.Add("Duruşma Tarihi", 150);
        }
        public void ListViewDataAdd()
        {
            var durusmalar = durusmaService.GetAll();

            foreach (var d in durusmalar) //hatayı burada veriyor
            {
                string id = d.Id.ToString();
                string durusmaYeri = d.DurusmaYeri;
                string durusmaTarihi = d.DurusmaGunu.ToString();
                string[] bilgiler = { id, durusmaYeri, durusmaTarihi };
                ListViewItem item = new ListViewItem(bilgiler);

                durusmalarList.Items.Add(item);
            }
        }

        private void ButunDurusmalar_Load(object sender, EventArgs e)
        {
            ListViewColumnsAdd();
            ListViewDataAdd();
        }
    }
}
