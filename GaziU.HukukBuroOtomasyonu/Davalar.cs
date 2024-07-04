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
        public Davalar()
        {
            InitializeComponent();
        }

        public void ListViewColumnsAdd()
        {
            davalarList.Columns.Add("ID", 250);
            davalarList.Columns.Add("Esas Numarası", 250);
            davalarList.Columns.Add("Dava Konusu", 600);
            davalarList.Columns.Add("Atanan Avukat", 300);
            davalarList.Columns.Add("Dosya Açılış Tarihi", 400);
        }



        private void Davalar_Load(object sender, EventArgs e)
        {
            ListViewColumnsAdd();
            string id = "50";
            string esas = "984986";
            string davaKonusu = " gdngdsfdopısfj hpj pdzfj hmpdoşf";
            string atananAv = "güray gülgün";
            string dosyaacilis = "epofgmsoagmqsapğ";

            string[] bilgiler = { id, esas, davaKonusu, atananAv, dosyaacilis };
            ListViewItem item = new ListViewItem(bilgiler);

            davalarList.Items.Add(item);
        }

        private void davalarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
