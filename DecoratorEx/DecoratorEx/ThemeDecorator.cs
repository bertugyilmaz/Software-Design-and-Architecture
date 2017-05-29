using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx
{
    public class ThemeDecorator : WindowDecorator
    {
        public ThemeDecorator(Window targetWindow, string tittle) : base(targetWindow, tittle)
        {
        }

        public override string Render()
        {
            return this.TargetWindow.Render();
        }
        public string setTheme(string name)
        {
            return TargetWindow.Tittle + "Başlıklı pencereye" + name + "Teması uygulandı" + Environment.NewLine + Render();
            
        }
    }
}
