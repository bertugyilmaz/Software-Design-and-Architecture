using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Window wind1 = new LoginWindow("Sisteme Giriş");
            Window wind2 = new ReportWindow("Stok Raporu Ekrani");
            Window wind3 = new ReportWindow("Satış Raporu Ekrani");

            ScrollDecorator decorator1 = new ScrollDecorator(wind2, "Stok raporu ekrani");
            ThemeDecorator decorator2 = new ThemeDecorator(wind1, "Sisteme Giriş");
            ThemeDecorator decorator3 = new ThemeDecorator(wind3, "Satış Raporu Ekrani");
            ThemeDecorator decorator4 = new ThemeDecorator(wind2, "Stok raporu Ekrani");
            
            MessageBox.Show(decorator1.ScrollBy(5));
            MessageBox.Show(decorator2.setTheme("Gökyüzü"));
            MessageBox.Show(decorator3.setTheme("Sonbahar"));
            MessageBox.Show(decorator4.setTheme("Deniz"));
            
            
            
        }
    }
}
