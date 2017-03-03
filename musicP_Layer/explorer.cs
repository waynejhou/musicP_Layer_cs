using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicP_Layer
{
    static class explorer
    {
        public static DirectoryInfo folder = new DirectoryInfo("D://"/*Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)*/);
        public static DirectoryInfo[] dirs = folder.GetDirectories();
        public static FileInfo[] files = folder.GetFiles("*.mp3;*.flac;*.wav");
        public static void move_next(DirectoryInfo next)
        {
            if (next != null && next.Exists)
            {
                try
                {
                    dirs = next.GetDirectories();
                    folder = next;
                    files = next.GetFiles("*.mp3;*.flac;*.wav");
                }
                catch (UnauthorizedAccessException UAE)
                {
                    Console.WriteLine(UAE);
                }
            }

        }
        public static DirectoryInfo[] get_disk_indexs()
        {
            string[] disk_names = Directory.GetLogicalDrives();
            DirectoryInfo[] disks = new DirectoryInfo[disk_names.Length];
            for (int i = 0; i < disks.Length; i++)
            {
                disks[i] = new DirectoryInfo(disk_names[i]);
            }
            return disks;
        }
        public static IEnumerable<FileInfo> get_certain_directory_file(DirectoryInfo dir)
        {
            /*List<FileInfo> newone = new List<FileInfo>(dir.GetFiles("*.mp3"));
            newone.AddRange(dir.GetFiles("*.flac"));
            newone.AddRange(dir.GetFiles("*.wav"));
            return newone.ToArray();*/
            List<FileInfo> newone = new List<FileInfo>(dir.GetFiles());
            foreach (var f in newone)
            {
                if (f.FullName.EndsWith("mp3") || f.FullName.EndsWith("flac") || f.FullName.EndsWith("wav"))
                {
                    yield return f;
                }
            }
        }
    }
}
