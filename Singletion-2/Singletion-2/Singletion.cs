using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletion_2
{
    public class Singletion
    {
        private static Singletion instance;
        public int Control { get; set; }
        protected Singletion() // Constructor protected olmalı!
        {
        }
        public static Singletion Instance()
        {
            if (instance == null)
            {
                instance = new Singletion();
            }
            return instance;
        }

    }
}
