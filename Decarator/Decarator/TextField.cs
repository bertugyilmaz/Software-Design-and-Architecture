using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    public class TextField : Widget
    {
        private int width, height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }
        public string draw()
        {
            return ("Textfield: " + width + " , "  + height);
        }
    }
}
