using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx
{
    public class SmartPhone
    {
        public SIMCardSocket simCardSocket = new SIMCardSocket();
    }
}
