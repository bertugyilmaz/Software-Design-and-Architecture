using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3") || audioType.Equals("mp4"))
            {
                Console.WriteLine("Playing Mp3 fileç Name : " + fileName);
            }
            else if (audioType.Equals("vlc"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }
            else
                Console.WriteLine("Invalid media. " + audioType + " format not supported.");
        }
    }
}
