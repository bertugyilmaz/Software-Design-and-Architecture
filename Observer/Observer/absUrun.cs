using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class absUrun
    {
        public string urunAdi { get; set; }
        private decimal _Fiyat;

        public List<IUye> TakipList = new List<IUye>();

        public absUrun(string UrunAd, decimal UrunFiyat)
        {
            this.urunAdi = UrunAd;
            this._Fiyat = UrunFiyat;
        }

        public decimal Fiyat
        {
            get { return Fiyat; }
            set
            {
                if (_Fiyat > value)
                {
                    NotifyUrun();
                }
                _Fiyat = value;
            }
        }

        public void NotifyUrun()
        {
            foreach (IUye item in TakipList)
            {
                item.Update(this);
            }
        }
    }
}
