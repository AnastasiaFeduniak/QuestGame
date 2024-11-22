using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lab5
{
    public class QuestGame
    {
        public UserConf user = new UserConf();
        private MediaPlayer player = new MediaPlayer();
        bool music = true;
        public void addName(string name)
        {
            UserConf.Initialize(name);
        }

        public void Exit()
        {
            user.AreYouSure();
        }
        public void Music()
        {
            if (music)
            {
                StopMedia();
                music = false;
            } else
            {
                PlayMedia();
                music = true;
            }
        }


        public void InitializeMusic()
        {
            player.Open(new Uri(string.Format("D:\\LABS_2\\MAPZ\\Lab5\\Lab5\\Music\\Algal_-_Crazy_Train.mp3", AppDomain.CurrentDomain.BaseDirectory)));
            player.MediaEnded += Player_MediaEnded;
            PlayMedia();
        }

        public void Player_MediaEnded(object sender, EventArgs e)
        {
            player.Position = TimeSpan.Zero;
        }

        public void PlayMedia()
        {
            player.Play();
        }
        public void StopMedia()
        {
            player.Stop();
        }

        public bool checkNeedness(MandatoryChoice a)
        {
            return user.checkNeedness(a);
        }

        public void addInventory(int g)
        {
            user.addInventory(g);
        }

        public void addChoice(int a)
        {
            user.addChoice(a);
        }
    }
}
