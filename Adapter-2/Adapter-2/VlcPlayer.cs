using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    public class VlcPlayer : AdvencedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name : " + fileName);
        }

        public void playVlc(string fileName)
        {
            //do Nothing
        }
    }
}
