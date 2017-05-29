using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Uye : IUye
    {
        public string email { get; set; }

        public void Update(absUrun urun)
        {
            Console.WriteLine("{0} ın fiyatı {1} oldu {2} adresine gönderildi.", urun.urunAdi, urun.Fiyat.ToString("C2"), email);
        }
    }
}
