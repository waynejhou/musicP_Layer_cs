using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lrcP_Layer
{
    public class lyric_reader
    {
        private List<TimeSpan> _times = new List<TimeSpan>();
        private List<string> _lyrics = new List<string>();
        public List<TimeSpan> times
        {
            get { return _times; }
        }
        public List<string> lyrics
        {
            get { return _lyrics; }
        }
        public lyric_reader(FileInfo fi)
        {
            string[] raw = File.ReadAllLines(fi.FullName);
            foreach (var i in raw)
            {
                string[] t = i.Split(']');
                foreach (var tt in t)
                {
                    //Console.Write(tt);
                    if (tt.StartsWith("["))
                    {
                        string[] time_min_ss = tt.Substring(1).Split(':');
                        try
                        {
                            int min = Convert.ToInt32(time_min_ss[0]);
                            string[] time_sec_ss = time_min_ss[1].Split('.');
                            int sec = Convert.ToInt32(time_sec_ss[0]);
                            int msec = 0;
                            if (time_sec_ss.Length >= 2)
                            {
                                if (time_sec_ss[1].Length == 2)
                                {
                                    msec = Convert.ToInt32(time_sec_ss[1]) * 10;
                                }else
                                {
                                    msec = Convert.ToInt32(time_sec_ss[1]);
                                }
                                
                            } 
                            _times.Add(new TimeSpan(0, 0, min, sec, msec));
                        }
                        catch (FormatException)
                        {

                        }
                    }
                }
            }
            _times.Sort();
            foreach (var i in _times)
            {
                bool found = false;
                foreach (var j in raw)
                {
                    //Console.WriteLine(string.Format("{0:mm}:{0:ss}.{0:fff}", i)+ j);
                    //Console.WriteLine(i);
                    if (j.Contains(string.Format("[{0:mm}:{0:ss}.{0:fff}]", i)) || j.Contains(string.Format("[{0:mm}:{0:ss}]", i)) || j.Contains(string.Format("[{0:mm}:{0:ss}.{0:ff}]", i)))
                    {
                        string[] t = j.Split(']');
                        _lyrics.Add(t.Last<string>());
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    _lyrics.Add(" _ ");
                }
            }
        }

    }
}
