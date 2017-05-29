using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public interface ISubject
    {
        void RegisterObServer(IObServer o);
        void RemoveObServer(IObServer o);
        void NotifyObServer();
    }
}
