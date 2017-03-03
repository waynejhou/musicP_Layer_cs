using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicP_Layer
{
    public class musicP
    {
        public IWavePlayer player;
        public AudioFileReader reader;
        public TagLib.File tag;
        public FileInfo last_selected_music;
        public float c_volume = 1;

        public void open_play_file(FileInfo music)
        {
            last_selected_music = music;
            if (player != null)
            {

                player.Stop();
                player.Dispose();
                player = null;
            }
            player = new WaveOut();
            reader = new AudioFileReader(music.FullName);
            reader.Volume = c_volume;
            tag = TagLib.File.Create(music.FullName);
            player.Init(reader);
            player.Play();
            //(new Thread(playing_thr)).Start();
            Console.WriteLine("Now Playing :" + tag.Tag.Title + " - " + tag.Tag.Album);
        }
        static void playing_thr()
        {

            Console.WriteLine("Thr killed");
        }
        public void stop_play_file()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }

        }


    }
}
