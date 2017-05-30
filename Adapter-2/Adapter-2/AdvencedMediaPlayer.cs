using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    public interface AdvencedMediaPlayer
    {
        void playVlc(string fileName);
        void playMp4(string fileName);
    }
}
