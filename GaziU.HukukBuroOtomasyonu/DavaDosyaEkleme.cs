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
    public partial class DavaDosyaEkleme : Form
    {
        private IGenericService<DavaDosyasi> dosyaService;
        private IGenericService<Avukat> avukatService;
        private IGenericService<YargiTuru> yargiService;
        private IGenericService<Mahkeme> mahkemeService;
        private ServiceProvider services;

        private DavaDosyasi existingDosya;


        public DavaDosyaEkleme(IGenericService<DavaDosyasi> dosyaService, IGenericService<Avukat> avukatService, IGenericService<YargiTuru> yargiService, IGenericService<Mahkeme> mahkemeService, DavaDosyasi existingDosya = null, ServiceProvider services = null)
        {
            InitializeComponent();
            this.dosyaService = dosyaService;
            this.avukatService = avukatService;
            this.yargiService = yargiService;
            this.mahkemeService = mahkemeService;
            this.existingDosya = existingDosya;
            this.services = services;
        }

        List<string> dosyaDurumListesi = new List<string>
        {
        "Dava Açıldı",
        "Ön İnceleme Aşaması",
        "Delillerin Toplanması",
        "Tanık Dinleme",
        "Bilirkişi İncelemesi",
        "Karar Verildi",
        "Karar Temyiz Edildi",
        "Karar Onandı",
        "Karar Bozuldu",
        "Karar Kesinleşti",
        "Dava Düşürüldü",
        "İcra Aşamasında"
        };


        private void DavaDosyaEkleme_Load(object sender, EventArgs e)
        {
            DosyaDurumcmb.DataSource = dosyaDurumListesi;

            YargiTurucmb.DataSource = yargiService.GetAll();
            YargiTurucmb.DisplayMember = "YargiTuruAdi"; // Görüntülenecek alan
            YargiTurucmb.ValueMember = "Id";

            AtananAvcmb.DataSource = avukatService.GetAll();
            AtananAvcmb.DisplayMember = "Adi"; // Görüntülenecek alan
            AtananAvcmb.ValueMember = "Id";

            if (existingDosya != null)
            {
                esastxt.Text = existingDosya.EsasNumarası.ToString();
                MahkemeBilgisitxt.Text = existingDosya.MahkemeBilgisi;
                DosyaDurumcmb.SelectedItem = existingDosya.DosyaDurumu;
                DavaciTxt.Text = existingDosya.Davaci;
                Davalitxt.Text = existingDosya.Davali;
                DosyaNotxt.Text = existingDosya.DosyaNumarasi.ToString();
                DavaKonusutxt.Text = existingDosya.DavaKonusu;
                if (existingDosya.AtananAvukatId != null)
                {
                    AtananAvcmb.SelectedItem = existingDosya.AtananAvukatId;
                }


                if (existingDosya.DosyaNotu != null)
                {
                    DosyaNotutxt.Text = existingDosya.DosyaNotu;
                }
                if (existingDosya.IcraTakipKonusu != null)
                {
                    icraKonutxt.Text = existingDosya.IcraTakipKonusu;
                }
                if (existingDosya.IcraTutari != null)
                {
                    icraTutartxt.Text = existingDosya.IcraTutari.ToString();
                }


                // İlgili yargı türünü seç
                YargiTurucmb.SelectedValue = existingDosya.YargiTuruId;

                //İlgili mahkemeyi seç
                Mahkemecmb.SelectedValue = existingDosya.MahkemeId;

                // İlgili avukatı seç
                AtananAvcmb.SelectedValue = existingDosya.AtananAvukatId;

                // İlgili mahkemeyi seç
                Mahkemecmb.SelectedValue = existingDosya.MahkemeId;
            }
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            if (existingDosya != null)
            {
                if (AtananAvcmb.SelectedItem is Avukat secilenAvukat)
                {
                    if (YargiTurucmb.SelectedItem is YargiTuru selectedYargi)
                    {
                        if (Mahkemecmb.SelectedItem is Mahkeme selectedMahkeme)
                        {
                            var yeniDosya = dosyaService.GetById(existingDosya.Id);

                            yeniDosya.CreatedDate = DateTime.Now;
                            yeniDosya.EsasNumarası = Convert.ToInt32(esastxt.Text);
                            yeniDosya.MahkemeBilgisi = MahkemeBilgisitxt.Text;
                            yeniDosya.DosyaDurumu = DosyaDurumcmb.SelectedItem.ToString();
                            yeniDosya.Davaci = DavaciTxt.Text;
                            yeniDosya.Davali = Davalitxt.Text;
                            yeniDosya.DosyaNotu = DosyaNotutxt.Text;
                            yeniDosya.DosyaNumarasi = Convert.ToInt32(DosyaNotxt.Text);
                            yeniDosya.DavaKonusu = DavaKonusutxt.Text;
                            yeniDosya.IcraTakipKonusu = icraKonutxt.Text;
                            yeniDosya.AtananAvukatId = secilenAvukat.Id;
                            yeniDosya.YargiTuruId = selectedYargi.Id;
                            yeniDosya.MahkemeId = selectedMahkeme.Id;


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

                            if (dosyaService.Update(yeniDosya))
                            {
                                MessageBox.Show("Güncelleme Başarılı");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Güncelleme Başarısız");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen bir mahkeme seçiniz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir yargı türü seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir avukat seçiniz");
                }

                return;
            }


            if (AtananAvcmb.SelectedItem is Avukat selectedAvukat)
            {
                if (YargiTurucmb.SelectedItem is YargiTuru selectedYargi)
                {
                    if (Mahkemecmb.SelectedItem is Mahkeme selectedMahkeme)
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
                            AtananAvukatId = selectedAvukat.Id,
                            YargiTuruId = selectedYargi.Id,
                            MahkemeId = selectedMahkeme.Id
                        };

                        if (!string.IsNullOrEmpty(icraTutartxt.Text))
                        {
                            if (double.TryParse(icraTutartxt.Text, out double icraTutari))
                            {
                                yeniDosya.IcraTutari = icraTutari;
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz İcra Tutarı");
                                return;
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
                        MessageBox.Show("Lütfen bir mahkeme seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir yargı türü seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir avukat seçiniz");
            }
        }

        private void YargiTurucmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YargiTurucmb.SelectedItem is YargiTuru selectedYargi)
            {
                var mahkemeler = mahkemeService.GetAll(m => m.YargiTuruId == selectedYargi.Id).ToList();
                Mahkemecmb.DataSource = mahkemeler;
                Mahkemecmb.DisplayMember = "MahkemeAdi";
                Mahkemecmb.ValueMember = "Id";
            }
        }

        private void KayitSilBtn_Click(object sender, EventArgs e)
        {
            if (existingDosya == null)
            {
                MessageBox.Show("Boş bir kaydı silemezsiniz");
                return;
            }

            if (dosyaService.DeleteById(existingDosya.Id))
            {
                MessageBox.Show("Silme başarılı");
                Close();
            }
            else
            {
                MessageBox.Show("Kayıt silinemedi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (existingDosya == null)
            {
                MessageBox.Show("Bu kayıt henüz kaydedilmemiş yada boş. Duruşma Ekleyemezsiniz.");
                return;
            }
            else
            {
                var s = new DurusmaEkle(services, existingDosya);
                s.ShowDialog();
            }
        }

        private void DurusmalariGosterbtn_Click(object sender, EventArgs e)
        {
            if (existingDosya!=null)
            {
                var s = new Durusmalar(existingDosya, services.GetRequiredService<IGenericService<Durusma>>(),services);
                s.Show();
                Close();
            }else
            {
                MessageBox.Show("Bu Kayıt Bomboş. Duruşma Kaydı Olamaz.");
                return;
            }
        }
    }
}
