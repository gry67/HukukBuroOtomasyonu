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
    public partial class DavaDosyaEkleme : Form
    {
        private IGenericService<DavaDosyasi> dosyaService;
        private IGenericService<Avukat> avukatService;
        public DavaDosyaEkleme(IGenericService<DavaDosyasi> dosyaService, IGenericService<Avukat> avukatService)
        {
            InitializeComponent();
            this.dosyaService = dosyaService;
            this.avukatService = avukatService;
        }

        public enum DosyaDurumu
        {
            DavaAcildi,
            OnIncelemeAsamasi,
            DelillerinToplanmasi,
            TanikDinleme,
            BilirkişiIncelemesi,
            KararVerildi,
            KararTemyizEdildi,
            KararOnandi,
            KararBozuldu,
            KararKesinlesti,
            DavaDusuruldu,
            IcraAsamasinda
        }


        private void DavaDosyaEkleme_Load(object sender, EventArgs e)
        {
            foreach (var durum in Enum.GetValues(typeof(DosyaDurumu)))
            {
                DosyaDurumcmb.Items.Add(durum.ToString());
            }

            AtananAvcmb.DataSource = avukatService.GetAll();
            AtananAvcmb.DisplayMember = "Adi"; // Görüntülenecek alan
            AtananAvcmb.ValueMember = "Id";
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            if (AtananAvcmb.SelectedItem is Avukat selectedAvukat)
            {
                var yeniDosya = new DavaDosyasi()
                {
                    CreatedDate = DateTime.Now,
                    EsasNumarası = Convert.ToInt32(esastxt.Text),
                    MahkemeBilgisi = MahkemeBilgisitxt.Text,
                    DosyaDurumu = DosyaDurumcmb.SelectedItem.ToString(),
                    Davaci = DavaciTxt.Text,
                    Davali = Davalitxt.Text,
                    DosyaNotu = DosyaNotutxt.Text,
                    DosyaNumarasi = Convert.ToInt32(DosyaNotxt.Text),
                    DavaKonusu = DavaKonusutxt.Text,
                    IcraTakipKonusu = icraKonutxt.Text,
                };
                yeniDosya.AtananAvukatId = selectedAvukat.Id;
                if (!string.IsNullOrEmpty(icraTutartxt.Text))
                {
                    if (double.TryParse(icraTutartxt.Text, out double icraTutari))
                    {
                        yeniDosya.IcraTutari = icraTutari;
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz İcra Tutarı");
                        return; // Hata durumunda işlemi sonlandır
                    }
                }

                if (dosyaService.Create(yeniDosya))
                {
                    MessageBox.Show("Kayıt Başarılı");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir avukat seçiniz");
            }
        }

        
    }
}
