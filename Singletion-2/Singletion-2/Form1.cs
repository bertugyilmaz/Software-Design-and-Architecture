using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singletion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SingletionTestBtn_Click(object sender, EventArgs e)
        {
            var singletion = Singletion.Instance();     // Nesne oluşturuldu.
            var singletion1 = Singletion.Instance();    // İkinci bir nesne oluşturulmaya çalışıldı. Bu satırda Debug edin.
            singletion.Control = 6;                     // Hata vermedi çünkü return instance dediğinde aslında ilk oluşturduğumuz nesneyi döndürüyor.
                                                        // Bu sebeple MessageBox daki değer 6 olucaktır.
            MessageBox.Show(singletion1.Control.ToString());
        }
    }
}
