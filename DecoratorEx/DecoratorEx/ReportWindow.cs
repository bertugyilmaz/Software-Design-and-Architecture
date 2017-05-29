using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx
{
    public class ReportWindow : Window
    {
        public ReportWindow(string tittle) : base(tittle)
        {
        }
        

        public override string Render()
        {
            return tittle + "Başlıklı rapor ekrani render edildi";
        }
    }
}
