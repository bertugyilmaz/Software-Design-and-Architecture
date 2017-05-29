using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx
{
    public class ScrollDecorator : WindowDecorator
    {
        public ScrollDecorator(Window targetWindow, string tittle) : base(targetWindow, tittle)
        {
        }

        public override string Render()
        {
            return this.TargetWindow.Render();
        }
        public string ScrollBy(int amount)
        {
            return TargetWindow.Tittle + "Başlıklı pencere " + amount + "birim kaydırıldı" + Environment.NewLine + Render();
            
        }
    }
}
