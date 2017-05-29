using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class Internet : IObServer   
    {
        public void Update(float faizOrani)
        {
            string a;
            a = "Internet Faiz Orani Guncellendi" + faizOrani;
        }
    }
}
