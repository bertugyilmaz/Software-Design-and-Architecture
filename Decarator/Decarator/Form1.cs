using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decarator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decoratorTestBtn_Click(object sender, EventArgs e)
        {
            Widget widget = new BorderDecorator(
                                new BorderDecorator(
                                   new ScrollDecorator(
                                      new TextField(100, 80))));

            MessageBox.Show(widget.draw());
        }
    }
}
