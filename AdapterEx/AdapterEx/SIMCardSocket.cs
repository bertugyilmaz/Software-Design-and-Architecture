using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx
{
    public class SIMCardSocket
    {
        private SIMCard simCard;

        public void Insert(SIMCard simcard)
        {
            this.simCard = simcard;
        }
    }
}
