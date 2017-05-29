using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class Kredi : ISubject
    {
        private float faizOrani;
        private List<IObServer> observers = new List<IObServer>();


        public void SetFaizOrani(float faizOrani)
        {
            this.faizOrani = faizOrani;
            this.NotifyObServer();
        }

        public void NotifyObServer()
        {
            foreach (IObServer o in this.observers)
            {
                o.Update(this.faizOrani);
            }
        }

        public void RegisterObServer(IObServer o)
        {
            this.observers.Add(o);
        }

        public void RemoveObServer(IObServer o)
        {
            this.observers.Remove(o);
        }
    }
}
