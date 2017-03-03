using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicP_Layer
{
    public class musicinfo
    {
        public FileInfo musicfileinfo;
        public musicinfo(FileInfo fi)
        {
            musicfileinfo = fi;
        }
        static public musicinfo[] fi2mi(FileInfo[] fi)
        {
            musicinfo[] mi = new musicinfo[fi.Length];
            for (int i = 0; i < fi.Length; i++)
            {
                mi[i] = new musicinfo(fi[i]);
            }
            return mi;
        }
    }
    public class musiclist
    {

        public List<musicinfo> musicfiles;
        public List<string> titles;
        public List<string> artists;
        public List<string> tracks;
        public List<string> albums;
        public int playing_song_index = 0;
        public enum StopActionOption
        {
            play_next_in_list,
            play_one_loop
        }
        public static StopActionOption StopAction = StopActionOption.play_next_in_list;

        public musiclist(musicinfo[] mi)
        {
            musicfiles = new List<musicinfo>(mi);
            init_parament();
        }
        public musiclist(FileInfo[] fi)
        {
            musicfiles = new List<musicinfo>(musicinfo.fi2mi(fi));
            init_parament();
        }
        public musiclist()
        {
            musicfiles = new List<musicinfo>();
            init_parament();
        }
        private void init_parament()
        {
            titles = new List<string>(musicfiles.Count);
            artists = new List<string>(musicfiles.Count);
            tracks = new List<string>(musicfiles.Count);
            albums = new List<string>(musicfiles.Count);
            Console.WriteLine(musicfiles.Count);
            for (int i = 0; i < musicfiles.Count; i++)
            {
                var tab = TagLib.File.Create(musicfiles[i].musicfileinfo.FullName);
                titles.Add(tab.Tag.Title);
                if (tab.Tag.Performers.Length > 0)
                    artists.Add(tab.Tag.Performers[0]);
                else
                    artists.Add("unknow");
                tracks.Add(tab.Tag.Track.ToString());
                albums.Add(tab.Tag.Album);
            }
        }
        public void addmusic(musicinfo mi)
        {
            musicfiles.Add(mi);
            var tab = TagLib.File.Create(mi.musicfileinfo.FullName);
            titles.Add(tab.Tag.Title);
            if (tab.Tag.Performers.Length > 0)
                artists.Add(tab.Tag.Performers[0]);
            else
                artists.Add("unknow");
            tracks.Add(tab.Tag.Track.ToString());
            albums.Add(tab.Tag.Album);
        }
        public void addmusic(musicinfo[] mi)
        {
            musicfiles.AddRange(mi);
            foreach (var i in mi)
            {
                var tab = TagLib.File.Create(i.musicfileinfo.FullName);
                titles.Add(tab.Tag.Title);
                if (tab.Tag.Performers.Length > 0)
                    artists.Add(tab.Tag.Performers[0]);
                else
                    artists.Add("unknow");
                tracks.Add(tab.Tag.Track.ToString());
                albums.Add(tab.Tag.Album);
            }
        }
        public bool check_if_existed(musicinfo mi)
        {
            foreach (var i in musicfiles)
            {
                if (i.musicfileinfo.FullName.Equals(mi.musicfileinfo.FullName))
                {
                    return true;
                }
            }
            return false;
        }
        public FileInfo get_next()
        {
            switch (StopAction)
            {
                case StopActionOption.play_next_in_list:
                    if (playing_song_index != musicfiles.Count - 1)
                        return musicfiles[++playing_song_index].musicfileinfo;
                    else
                        goto default;
                case StopActionOption.play_one_loop:
                    return main_win.P_Layer.last_selected_music;
                default:
                    return null;
            }

        }


    }
    public class musiclistCollection
    {
        public List<musiclist> collection = new List<musiclist>();
        public List<string> names = new List<string>();
        public int now_list_index = 0;
        public musiclist CurrenList { get { return collection[now_list_index]; } }
        public musiclistCollection()
        {
            //collection.Add( new musiclist( musicinfo.fi2mi(explorer.get_certain_directory_file(new DirectoryInfo("D://User/Music/ACG Music")))));
            collection.Add(new musiclist());
            names.Add("[預設清單]");
        }
        public musiclist CreateEmptyList()
        {
            collection.Add(new musiclist());
            names.Add("播放清單" + collection.Count);
            return collection[collection.Count - 1];
        }


    }
}
