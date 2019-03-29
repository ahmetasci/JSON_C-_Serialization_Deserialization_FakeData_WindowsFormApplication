using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Dosya okuma için çağırdım

namespace JsonFakeData
{

    //********************JSON veri türündeki bilgileri deserialize edip tabloda listeleyecek*****************************************
    public partial class FormJSONVeriyiOkuma_Deserialize : Form
    {
        List<Personel> JsonVeriListesi;
        public FormJSONVeriyiOkuma_Deserialize()
        {
            InitializeComponent();
        }

        private void btnJSONVeriyiOku_Click(object sender, EventArgs e)
        {
            string JSONTurdenOkunanDeger = File.ReadAllText(" c:\\JsonIslemlerim\\Personellerim.json");
           JsonVeriListesi= Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(JSONTurdenOkunanDeger);
           
                MessageBox.Show("Veri okuma işlemi başarılıyla gerçekleştirildi");
            
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
           
                dataGridViewDeserialize.DataSource = JsonVeriListesi;
           
        }
    }
}
