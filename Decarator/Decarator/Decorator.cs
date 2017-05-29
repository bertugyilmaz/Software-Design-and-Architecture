using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    public abstract class Decorator : Widget
    {
        private Widget widget;
        public Decorator(Widget w)
        {
            this.widget = w;
        }
        public virtual string draw()
        {
            return widget.draw();
        }
    }
}
