using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    public class Mp4Player : AdvencedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name : " + fileName);
        }

        public void playVlc(string fileName)
        {
           //do nothing
        }
    }
}
