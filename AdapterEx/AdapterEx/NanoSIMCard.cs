using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx
{
    public class NanoSIMCard
    {
        public Data data;

        public Data Read()
        {
            return data.value;
        }

        public void Write(Data data)
        {
            throw new NotImplementedException();
        }
    }
}
