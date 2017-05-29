using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx
{
    public class LoginWindow : Window
    {
        
        public LoginWindow(string tittle) : base(tittle)
        {
        }
        
        public override string Render()
        {
            return tittle + "Başlıklı login ekrani render edildi";
        }
    }
}
