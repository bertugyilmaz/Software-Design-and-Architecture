using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx
{
    public abstract class WindowDecorator : Window
    {
        private Window targetWindow;

        public Window TargetWindow
        {
            get { return targetWindow; }
            set { targetWindow = value; }
        }

        public WindowDecorator(Window targetWindow ,string tittle) : base(tittle)
        {
            this.targetWindow = targetWindow;
            this.targetWindow.Tittle = tittle;
        }
    }
}
