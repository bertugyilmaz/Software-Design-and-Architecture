using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx
{
    public interface SIMCard
    {
        Data Read();
        void Write(Data data);
    }
}
