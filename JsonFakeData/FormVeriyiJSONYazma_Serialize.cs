using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Directory ve File sınıfı için ekledik
using Newtonsoft.Json; //JsonConvert sınıfı için


namespace JsonFakeData
{
    //********************FAKEDATA'dan çektiğim verileri JSON formatına çevirecek.*****************************************
    public partial class FormVeriyiJSONYazma_Serialize : Form
    {
        List<Personel> PersonellerListesi;
        public FormVeriyiJSONYazma_Serialize()
        {
            InitializeComponent();
        }

        private void DataGridDoldur()
        {
            PersonellerListesi = new List<Personel>();
            for (int i = 0; i < 100; i++)
            {
                Personel p = new Personel();
                p.ID = FakeData.NumberData.GetNumber();
                p.Isim = FakeData.NameData.GetFirstName();
                p.SoyIsim = FakeData.NameData.GetSurname();
                p.EmailAdres = $"{p.Isim}.{ p.SoyIsim}@{FakeData.NetworkData.GetDomain()}";
                p.TelefonNumarasi = FakeData.PhoneNumberData.GetPhoneNumber();
                p.Sehir = FakeData.PlaceData.GetCity();
                PersonellerListesi.Add(p);
            }


            dataGridView1.DataSource = PersonellerListesi;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            DataGridDoldur();
        }

        private void btnJsonYaz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler JSON Formatında C:\\JsonIslemlerim\\Personellerim.json olarak kaydedilecektir.");

            Directory.CreateDirectory("c:\\JsonIslemlerim\\"); //C'nin içinde bir klasör oluşturur.

             string JsonPersonellerim = JsonConvert.SerializeObject(PersonellerListesi);
            //İlgili objemi (PersonellerListesi) SerializeObject Metoduna verdim.
            //Bunu bize string olarak JSON formatında verecek.
            File.WriteAllText(" c:\\JsonIslemlerim\\Personellerim.json", JsonPersonellerim);  //Json verilerinin olduğu dosyayı yazmak için 
                                                                                                                            //İlk Parametre: dosyayı nereye yazacağı
                                                                                                                            //İkinci parametre: yazacağı dosyanın içeriği

            MessageBox.Show("Serialize işlemi başarılı");


        }
    }
}
