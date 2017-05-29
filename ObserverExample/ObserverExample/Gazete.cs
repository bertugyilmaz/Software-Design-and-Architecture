using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class Gazete : IObServer
    {
        
        public void Update(float faizOrani)
        {
            string a;
            a="Gazete Faiz Orani Guncellendi" + faizOrani; 
        }
    }
}
