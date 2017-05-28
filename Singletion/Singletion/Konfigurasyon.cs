using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletion
{
    public class Konfigurasyon
    {
        private static Konfigurasyon instance=null;
        public int MaxKullanici { get; set; }
        public string LogDosyaAdi { get; set; }

        protected Konfigurasyon()
        {
            this.MaxKullanici = 10;
            this.LogDosyaAdi = "D://USER.LOG";
        }

        public static Konfigurasyon Instance()
        {
            if (instance == null)
                instance = new Konfigurasyon();
            return instance;
        }
    }
}
