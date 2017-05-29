using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx
{
    public abstract class Window
    {
        protected string tittle;

        public string Tittle
        {
            get { return tittle; }
            set { tittle = value; }
        }
        public Window(string tittle)
        {
            this.tittle = tittle;
        }
        public abstract string Render();
    }
}
