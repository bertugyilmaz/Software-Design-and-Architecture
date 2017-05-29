using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {
        }

        public override string draw()
        {
            var a = base.draw();
            return a + Environment.NewLine +  "Scroll Decorator";
        }
    }
}
