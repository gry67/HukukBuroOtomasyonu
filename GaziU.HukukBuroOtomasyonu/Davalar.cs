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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            davalarList.Columns.Add("Dava Konusu", 300);
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

        public void DavaDuzenle()
        {
            if (davalarList.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = davalarList.SelectedItems[0];
                string id = selectedRow.SubItems[0].Text;

                DavaDosyasi selectedDosya = dosyaService.GetById(Convert.ToInt32(id));

                var s = new DavaDosyaEkleme(dosyaService, avService,
                    services.GetRequiredService<IGenericService<YargiTuru>>(),
                    services.GetRequiredService<IGenericService<Mahkeme>>(), selectedDosya);
                s.Show();
            }
        }



        //Eventler

        private void Davalar_Load(object sender, EventArgs e)
        {
            ListViewColumnsAdd();
            ListViewDataAdd();
        }

        private void davalarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DavaDuzenle();
        }

        private void dosyaEkleBtn_Click(object sender, EventArgs e)
        {
            var s = new DavaDosyaEkleme(services.GetRequiredService<IGenericService<DavaDosyasi>>(),
                services.GetRequiredService<IGenericService<Avukat>>()
                , services.GetRequiredService<IGenericService<YargiTuru>>()
                , services.GetRequiredService<IGenericService<Mahkeme>>());
            s.Show();
        }

        private void YenileBtn_Click(object sender, EventArgs e)
        {
            davalarList.Items.Clear();
            ListViewDataAdd();
        }

        private void Davalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            giris.Close();
        }

        private void BulBtn_Click(object sender, EventArgs e)
        {
            int esasNumarasi;

            // EsasNotxt içeriğini sayıya dönüştürmeye çalış
            if (!int.TryParse(EsasNoTxt.Text, out esasNumarasi))
            {
                MessageBox.Show("Geçersiz esas numarası!");
                return;
            }

            bool esasNumarasiBulundu = false;

            // ListView'deki her satırı kontrol et
            foreach (ListViewItem item in davalarList.Items)
            {
                // "Esas Numarası" sütunundaki değeri al
                string esasNumarasıText = item.SubItems[1].Text;
                
                // Esas numarası metin olarak eşleşiyorsa
                if (esasNumarasıText == esasNumarasi.ToString())
                {
                    // Eşleşen satırı itemToAdd olarak ayarla
                    ListViewItem itemToAdd = item.Clone() as ListViewItem;
                    davalarList.Items.Clear();
                    davalarList.Items.Add(itemToAdd);
                    esasNumarasiBulundu = true;
                    break; // Eşleşme bulundu, döngüden çık
                }
            }

            // Eğer eşleşen bir öğe bulunamazsa
            if (!esasNumarasiBulundu)
            {
                MessageBox.Show("Esas numarası bulunamadı!");
            }
        }
    }
}
