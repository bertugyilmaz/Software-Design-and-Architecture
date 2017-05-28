using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            AlgorithmFactory af = new AlgorithmFactory();

            Algorithm[] algoritms = new Algorithm[3];
            for (int i = 0; i < 3; i++)
            {
                algoritms[i] = af.CreateAlgorithm(i + 1);
            }
            foreach (Algorithm alg in algoritms)
            {
                MessageBox.Show(alg.Run());

            }
        }
    }
}
