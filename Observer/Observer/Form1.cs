using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void observerTestBtn_Click(object sender, EventArgs e)
        {
            absUrun Kitap = new Urun("Kitap",10.25M);                           // Subject nesnesi oluşturuluyor

            Kitap.TakipList.Add(new Uye { email = "info@bertugyilmaz.com" });   //Subject nesnemizi ile ilgili olan Uye(Observer) listesine nesne ekliyoruz
            Kitap.TakipList.Add(new Uye { email = "ylmazbertug@gmail.com" });   //Subject yani ürün fiyatınıı değiştirdiğimizde listedeki observer nesnelerinin ilgili metodu çalıştırılacak.
            Kitap.Fiyat = 8.99M;
                                             
        }
    }
}
