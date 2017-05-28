using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class AlgorithmFactory
    {
        public Algorithm CreateAlgorithm(int type)
        {
            if (type == 1)
                return new QuickSort();
            else if (type == 2)
                return new SelectionSort();
            else if (type == 3)
                return new BubbleSort();
            else
                throw new Exception("Geçersiz işlem");
        }
    }
}
