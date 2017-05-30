using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    public class MediaAdapter : MediaPlayer
    {
        AdvencedMediaPlayer advencedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advencedMusicPlayer = new VlcPlayer();
                advencedMusicPlayer = new Mp4Player();
            }
            else if (audioType.Equals("mp4"))
            {
                advencedMusicPlayer = new Mp4Player();
            }
        }
        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advencedMusicPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advencedMusicPlayer.playMp4(fileName);
            }
        }
    }
}
