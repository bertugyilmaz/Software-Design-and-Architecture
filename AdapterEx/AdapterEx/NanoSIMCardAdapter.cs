using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx
{
    public class NanoSIMCardAdapter : SIMCard
    {
        private NanoSIMCard nanoSimCard;

        public NanoSIMCardAdapter(NanoSIMCard n)
        {
            this.nanoSimCard = n;
        }

        public Data Read()
        {
            return this.nanoSimCard.Read();
        }

        public void Write(Data data)
        {
            this.nanoSimCard.Write(data);
        }
    }
}
