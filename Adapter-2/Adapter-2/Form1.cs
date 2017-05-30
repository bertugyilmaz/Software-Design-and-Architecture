using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adapterTestBtn_Click(object sender, EventArgs e)
        {
            AudioPlayer a = new AudioPlayer();

            a.play("mp3","baba_mrb.mp3");
            a.play("mp4", "ahmet_fatih_twerk_1080p_canli_izle.mp4");
        }
    }
}
