using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decarator
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w)
        {
        }

        public override string draw()
        {
            var  a = base.draw();
            return a + Environment.NewLine + "Border Decorator";
        }
    }
}
