using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using lrcP_Layer;

namespace musicP_Layer
{
    public partial class main_win : Form
    {


        public main_win()
        {
            debug_action(Console.WriteLine, "debug mode on");
            InitializeComponent();
        }

        #region Debug mode function
        bool debugmode = true;
        public void debug_action<T>(Action<T> a, T t)
        {
            if (debugmode)
            {
                a.Invoke(t);
            }
        }
        public void debug_action<T1, T2>(Action<T1, T2> a, T1 t1, T2 t2)
        {
            if (debugmode)
            {
                a.Invoke(t1, t2);
            }
        }
        #endregion

        #region Colors Set & startUp & Musiclist Init
        public static string[] startUp_files = new string[0];
        private static musiclistCollection _mlc = new musiclistCollection();
        public static musiclistCollection mlc { get { return _mlc; } }
        Color CForegroundColor = Color.BurlyWood;
        Color CBackgroundColor = Color.Peru;
        Color CFontColorDark = Color.Black;
        Color CFontColorLight = Color.White;
        Color CHighlightColor = SystemColors.Highlight;
        bool use_custom_border = false;
        private void start_up_change_color(object sender, EventArgs e)
        {
            if (!use_custom_border)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                title_panel.Enabled = false;
                top_panel.Enabled = false;
                left_panel.Enabled = false;
                right_panel.Enabled = false;
                down_panel.Enabled = false;
                title_close_button.Enabled = false;
                title_min_button.Enabled = false;
                title_panel.Visible = false;
                top_panel.Visible = false;
                left_panel.Visible = false;
                right_panel.Visible = false;
                down_panel.Visible = false;
                title_close_button.Visible = false;
                title_min_button.Visible = false;
                this.Refresh();
            }



            this.BackColor = CBackgroundColor;

            title_panel.BackColor = CForegroundColor;
            top_panel.BackColor = CForegroundColor;
            left_panel.BackColor = CForegroundColor;
            right_panel.BackColor = CForegroundColor;
            down_panel.BackColor = CForegroundColor;
            m_title_label.BackColor = CForegroundColor;
            m_artist_label.BackColor = CForegroundColor;
            m_playing_trackBar.BackColor = CForegroundColor;
            flowLayoutPanel2.BackColor = CForegroundColor;
            tableLayoutPanel3.BackColor = CForegroundColor;
            c_play_button.BackColor = CForegroundColor;
            c_stop_button.BackColor = CForegroundColor;
            c_mute_button.BackColor = CForegroundColor;
            splitContainer1.Panel2.BackColor = CForegroundColor;
            main_panel.BackColor = CForegroundColor;

            tab_pic.BackColor = CBackgroundColor;
            tab_list.BackColor = CBackgroundColor;
            listView1.BackColor = CBackgroundColor;
            listView2.BackColor = CBackgroundColor;

            menuStrip1.BackColor = CForegroundColor;
            title_close_button.BackColor = CForegroundColor;
            title_min_button.BackColor = CForegroundColor;
            c_volume_trackBar.PointerInColor = CForegroundColor;
            c_volume_trackBar.BorderColor = CForegroundColor;


            title_close_button.ForeColor = CFontColorDark;
            title_min_button.ForeColor = CFontColorDark;
            m_artist_label.ForeColor = CFontColorDark;
            m_title_label.ForeColor = CFontColorDark;
            m_total_time_label.ForeColor = CFontColorDark;
            m_playing_time_label.ForeColor = CFontColorDark;
            c_play_button.ForeColor = CFontColorDark;
            c_stop_button.ForeColor = CFontColorDark;
            c_mute_button.ForeColor = CFontColorDark;

            tab_pic.ForeColor = CFontColorLight;
            tab_list.ForeColor = CFontColorLight;
            listView1.ForeColor = CFontColorLight;
            listView2.ForeColor = CFontColorLight;
            c_volume_trackBar.PointerOutColor = CFontColorDark;
            m_playing_trackBar.PointerOutColor = CFontColorDark;



            ListViewItem[] trans = new ListViewItem[mlc.names.Count];
            for (int i = 0; i < trans.Length; i++)
            {
                trans[i] = new ListViewItem(mlc.names[i]);
            }
            listView1.Items.AddRange(trans);

            trans = new ListViewItem[mlc.collection[0].titles.Count];
            for (int i = 0; i < trans.Length; i++)
            {
                trans[i] = new ListViewItem("【" + mlc.collection[0].albums[i] + "】" + mlc.collection[0].titles[i] + "【" + mlc.collection[0].artists[i] + "】");
            }
            listView2.Items.AddRange(trans);

            if (startUp_files.Length != 0)
            {
                foreach (var i in startUp_files)
                {
                    add_music(new FileInfo(i));
                }
                if (P_Layer.player == null)
                    prepare_playing(startUp_files[0]);
            }
        }
        #endregion

        #region Custome Border Event
        Point pre_point, ori_point;
        Size ori_size;
        bool isTitlePanelDragged = false;
        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isDownPanelDragged = false;
        private void border_panel_MouseUp(object sender, MouseEventArgs e)
        {
            isTitlePanelDragged = false;
            isTopPanelDragged = false;
            isLeftPanelDragged = false;
            isRightPanelDragged = false;
            isDownPanelDragged = false;
            debug_action<string>(Console.WriteLine, sender.ToString() + "MouseUp");
        }
        private void border_panel_MouseDown(object sender, MouseEventArgs e)
        {
            var pp = (sender as Panel);
            if (pp == title_panel || pp == flowLayoutPanel1 || pp == tableLayoutPanel1 || (sender as Label) == title_label)
            {
                isTitlePanelDragged = true;
            }
            else if (pp == down_panel)
            {
                isDownPanelDragged = true;
            }
            else if (pp == right_panel)
            {
                isRightPanelDragged = true;
            }
            else if (pp == left_panel)
            {
                isLeftPanelDragged = true;
            }
            else if (pp == top_panel)
            {
                isTopPanelDragged = true;
            }
            pre_point = MousePosition;
            ori_size = this.Size;
            ori_point = this.Location;
            debug_action<string>(Console.WriteLine, sender.ToString() + "MouseDown");
        }
        private void border_panel_MouseMove(object sender, MouseEventArgs e)
        {
            var pp = sender as Panel;
            if (isDownPanelDragged || isRightPanelDragged || isTopPanelDragged || isLeftPanelDragged)
            {
                if (pp.Cursor == Cursors.SizeNS)// [ | ]
                {
                    if (pp == down_panel)
                    {
                        this.Size = new Size(ori_size.Width, ori_size.Height + MousePosition.Y - pre_point.Y);
                    }
                    else if (pp == top_panel)
                    {
                        this.Size = new Size(ori_size.Width, ori_size.Height - (MousePosition.Y - pre_point.Y));
                        if (this.Size != this.MinimumSize)
                            this.Location = new Point(ori_point.X, ori_point.Y + MousePosition.Y - pre_point.Y);
                    }

                }
                else if (pp.Cursor == Cursors.SizeWE)// [ - ]
                {
                    if (pp == right_panel)
                    {
                        this.Size = new Size(ori_size.Width + MousePosition.X - pre_point.X, ori_size.Height);
                    }
                    else if (pp == left_panel)
                    {
                        this.Size = new Size(ori_size.Width - (MousePosition.X - pre_point.X), ori_size.Height);
                        if (this.Size != this.MinimumSize)
                            this.Location = new Point(ori_point.X + MousePosition.X - pre_point.X, ori_point.Y);
                    }
                }
                else if (pp.Cursor == Cursors.SizeNWSE)// [ \ ]
                {
                    if (pp == right_panel || pp == down_panel)
                    {
                        this.Size = new Size(ori_size.Width + MousePosition.X - pre_point.X, ori_size.Height + MousePosition.Y - pre_point.Y);
                    }
                    else if (pp == left_panel || pp == top_panel)
                    {
                        this.Size = new Size(ori_size.Width - (MousePosition.X - pre_point.X), ori_size.Height - (MousePosition.Y - pre_point.Y));
                        if (this.Size == this.MinimumSize) { }
                        else if (this.Size.Width == this.MinimumSize.Width)
                            this.Location = new Point(this.Location.X, ori_point.Y + MousePosition.Y - pre_point.Y);
                        else if (this.Size.Height == this.MinimumSize.Height)
                            this.Location = new Point(ori_point.X + MousePosition.X - pre_point.X, this.Location.Y);
                        else
                            this.Location = new Point(ori_point.X + MousePosition.X - pre_point.X, ori_point.Y + MousePosition.Y - pre_point.Y);
                    }
                }
                else if (pp.Cursor == Cursors.SizeNESW)// [ / ]
                {
                    if (pp == right_panel || pp == top_panel)
                    {
                        this.Size = new Size(ori_size.Width + MousePosition.X - pre_point.X, ori_size.Height - (MousePosition.Y - pre_point.Y));
                        if (this.Size == this.MinimumSize) { }
                        else if (this.Size.Height == this.MinimumSize.Height) { }
                        else
                            this.Location = new Point(ori_point.X, ori_point.Y + MousePosition.Y - pre_point.Y);
                    }
                    else if (pp == left_panel || pp == down_panel)
                    {
                        this.Size = new Size(ori_size.Width - (MousePosition.X - pre_point.X), ori_size.Height + (MousePosition.Y - pre_point.Y));
                        if (this.Size == this.MinimumSize) { }
                        else if (this.Size.Width == this.MinimumSize.Width) { }
                        else
                            this.Location = new Point(ori_point.X + MousePosition.X - pre_point.X, ori_point.Y);
                    }
                }
            }
            else if (isTitlePanelDragged)
            {
                this.Location = new Point(ori_point.X + MousePosition.X - pre_point.X, ori_point.Y + MousePosition.Y - pre_point.Y);
            }
            else
            {
                if (pp == down_panel)
                {
                    if (e.X < 10)
                    {
                        pp.Cursor = Cursors.SizeNESW;
                    }
                    else if (e.X > pp.Size.Width - 10)
                    {
                        pp.Cursor = Cursors.SizeNWSE;
                    }
                    else
                    {
                        pp.Cursor = Cursors.SizeNS;
                    }
                }
                else if (pp == right_panel)
                {
                    if (e.Y < 10)
                    {
                        pp.Cursor = Cursors.SizeNESW;
                    }
                    else if (e.Y > pp.Size.Height - 10)
                    {
                        pp.Cursor = Cursors.SizeNWSE;
                    }
                    else
                    {
                        pp.Cursor = Cursors.SizeWE;
                    }
                }
                else if (pp == left_panel)
                {
                    if (e.Y < 10)
                    {
                        pp.Cursor = Cursors.SizeNWSE;
                    }
                    else if (e.Y > pp.Size.Height - 10)
                    {
                        pp.Cursor = Cursors.SizeNESW;
                    }
                    else
                    {
                        pp.Cursor = Cursors.SizeWE;
                    }
                }
                else if (pp == top_panel)
                {
                    if (e.X < 10)
                    {
                        pp.Cursor = Cursors.SizeNWSE;
                    }
                    else if (e.X > pp.Size.Width - 10)
                    {
                        pp.Cursor = Cursors.SizeNESW;
                    }
                    else
                    {
                        pp.Cursor = Cursors.SizeNS;
                    }
                }
            }
        }

        private void close_the_app_event(object sender, EventArgs e)
        {
            prepare_stop();
            Application.Exit();
        }
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        private void min_the_app_event(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            AnimateWindow(this.Handle, 300, 0x00080000 | 0x00010000);
            this.WindowState = FormWindowState.Minimized;
            //this.FormBorderStyle = FormBorderStyle.None;
        }
        #endregion

        #region file_chooser event & addmusic
        private void file_chooser_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var i in file_chooser.FileNames)
            {
                FileInfo fi;
                mlc.CurrenList.playing_song_index = mlc.CurrenList.musicfiles.Count;
                add_music(fi = new FileInfo(i));
            }
            prepare_playing(file_chooser.FileName);
        }
        public void add_music(FileInfo fi)
        {
            var mi = new musicinfo(fi);
            if (!mlc.collection[mlc.now_list_index].check_if_existed(mi))
            {
                mlc.collection[mlc.now_list_index].addmusic(mi);
                var index = mlc.collection[mlc.now_list_index].musicfiles.Count - 1;
                var album = mlc.collection[mlc.now_list_index].albums[index];
                var title = mlc.collection[mlc.now_list_index].titles[index];
                var artist = mlc.collection[mlc.now_list_index].artists[index];
                listView2.Items.Add(new ListViewItem("【" + album + "】" + title + "【" + artist + "】"));
            }
        }
        public void add_music(FileInfo[] fi)
        {
            var mi = musicinfo.fi2mi(fi);
            foreach (var i in mi)
            {
                if (!mlc.collection[mlc.now_list_index].check_if_existed(i))
                {
                    mlc.collection[mlc.now_list_index].addmusic(i);
                    var index = mlc.collection[mlc.now_list_index].musicfiles.Count - 1;
                    var album = mlc.collection[mlc.now_list_index].albums[index];
                    var title = mlc.collection[mlc.now_list_index].titles[index];
                    var artist = mlc.collection[mlc.now_list_index].artists[index];
                    listView2.Items.Add(new ListViewItem("【" + album + "】" + title + "【" + artist + "】"));
                }

            }

        }
        #endregion

        #region preparing playing & stop
        Thread upt_trd;
        public static musicP P_Layer = new musicP();
        private void prepare_playing(string name)
        {
            prepare_stop();
            FileInfo fi = new FileInfo(name);
            fi = new FileInfo(fi.FullName.Replace(fi.Extension, ".lrc"));
            if (fi.Exists)
            {
                lyric_reader lr = new lyric_reader(fi);
                lrcD_Isplay1.lyric = lr.lyrics.ToArray();
                lrcD_Isplay1.time = lr.times.ToArray();
            }
            else
            {
                Console.WriteLine("lrc reading failed");
                lrcD_Isplay1.lyric = null;
                lrcD_Isplay1.time = null;
            }

            P_Layer.open_play_file(new FileInfo(name));
            P_Layer.player.PlaybackStopped += Player_PlaybackStopped;
            m_title_label.Text = "Title: " + P_Layer.tag.Tag.Title;
            if (P_Layer.tag.Tag.Performers.Length > 0)
            {
                m_artist_label.Text = "Artist: " + P_Layer.tag.Tag.Performers[0];
                this.Text = String.Format("{0} - {1}", P_Layer.tag.Tag.Title, P_Layer.tag.Tag.Performers[0]);
            }
            else
            {
                m_artist_label.Text = "Artist: " + "Unknow";
                this.Text = String.Format("{0}", P_Layer.tag.Tag.Title);
            }

            m_total_time_label.Text = String.Format("{0:mm}:{0:ss}", P_Layer.reader.TotalTime);
            if (P_Layer.tag.Tag.Pictures.Length > 0)
            {
                m_image_box.Image = Image.FromStream(new MemoryStream(P_Layer.tag.Tag.Pictures[0].Data.Data));
            }else
            {
                m_image_box.Image = null;
            }
            m_playing_trackBar.Max = (int)(P_Layer.reader.TotalTime.TotalMilliseconds);

            c_play_button.Text = "⏸";
            (upt_trd = new Thread(time_update)).Start();
        }
        private void Player_PlaybackStopped(object sender, NAudio.Wave.StoppedEventArgs e)
        {
            FileInfo next = mlc.CurrenList.get_next();
            if (next != null)
            {
                prepare_playing(next.FullName);
            }
            else
            {
                prepare_stop();
            }

        }

        private void prepare_stop()
        {
            if (upt_trd != null)
                upt_trd.Abort();
            c_play_button.Text = "▶︎";
            P_Layer.stop_play_file();
            m_title_label.Text = "Title: ";
            m_artist_label.Text = "Artist: ";
            m_total_time_label.Text = "99:99";
            m_image_box.Image = null;
            m_playing_time_label.Text = "00:00";
            m_playing_trackBar.Val = 0;
            lrcD_Isplay1.time = null;
            lrcD_Isplay1.lyric = null;
            this.Text = "musicP_Layer";
        }
        private void time_update()
        {
            while (true)
            {
                if (!traceBar_draged)
                {
                    LabelSetText(m_playing_time_label, String.Format("{0:mm}:{0:ss}", (P_Layer.reader.CurrentTime < P_Layer.reader.TotalTime) ? P_Layer.reader.CurrentTime : P_Layer.reader.TotalTime));
                    var ttt = (int)(P_Layer.reader.CurrentTime.TotalMilliseconds);
                    BarSetVal(m_playing_trackBar, (ttt > 0 && ttt < m_playing_trackBar.Max) ? ttt : m_playing_trackBar.Max);
                    BarSetTime(lrcD_Isplay1, P_Layer.reader.CurrentTime);
                    Thread.Sleep(200);
                }
            }
        }
        delegate void BarSetTimeCallback(LrcD_Isplay t, TimeSpan val);
        private void BarSetTime(LrcD_Isplay t, TimeSpan val)
        {
            //InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (t.InvokeRequired)
            {
                BarSetTimeCallback d = new BarSetTimeCallback(BarSetTime);
                this.Invoke(d, new object[] { t, val });
            }
            else
            {
                t.nowTime = val;
            }
        }
        delegate void LabelSetTextCallback(Label l, string text);
        private void LabelSetText(Label l, string text)
        {
            //InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (l.InvokeRequired)
            {
                LabelSetTextCallback d = new LabelSetTextCallback(LabelSetText);
                this.Invoke(d, new object[] { l, text });
            }
            else
            {
                l.Text = text;
            }
        }
        delegate void BarSetValCallback(TrackBar_C t, int val);
        private void BarSetVal(TrackBar_C t, int val)
        {
            //InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (t.InvokeRequired)
            {
                BarSetValCallback d = new BarSetValCallback(BarSetVal);
                this.Invoke(d, new object[] { t, val });
            }
            else
            {
                t.Val = val;
            }
        }
        #endregion

        #region file_dragdrop event
        private void main_win_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<FileInfo> fi = new List<FileInfo>();
            foreach (var f in files)
            {
                if (f.EndsWith(".mp3") || f.EndsWith(".wav") || f.EndsWith(".flac"))
                    fi.Add(new FileInfo(f));
            }
            mlc.CurrenList.playing_song_index = mlc.CurrenList.musicfiles.Count;
            add_music(fi.ToArray());
            if (P_Layer.player == null)
                prepare_playing(fi[0].FullName);

        }
        private void main_win_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        #endregion

        #region control_tool_event
        private void open_file_browser(object sender, EventArgs e)
        {
            file_chooser.ShowDialog();
        }
        private void play_music_event(object sender, EventArgs e)
        {
            if (P_Layer.player != null)
            {
                if (P_Layer.player.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    P_Layer.player.Pause();
                    c_play_button.Text = "▶︎";
                }
                else if (P_Layer.player.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                {
                    P_Layer.player.Play();
                    c_play_button.Text = "⏸";
                }
            }
            else if (P_Layer.last_selected_music != null)
            {
                prepare_playing(P_Layer.last_selected_music.FullName);
                c_play_button.Text = "⏸";
            }
            else
            {
                open_file_browser(Handle, e);
            };
        }
        private void stop_music_event(object sender, EventArgs e)
        {
            if (P_Layer.player != null)
            {
                prepare_stop();
            }
        }
        private void c_volume_trackBar_Scroll(object sender, EventArgs e)
        {
            P_Layer.c_volume = (float)c_volume_trackBar.Val / 100;
            if (P_Layer.reader != null)
            {
                c_mute_button.Text = "🔊";
                P_Layer.reader.Volume = P_Layer.c_volume;
            }
        }


        bool traceBar_draged = false;
        TimeSpan ori_time;
        int ori_trace_val;
        private void m_playing_trackBar_Scroll(object sender, EventArgs e)
        {

        }
        private void m_playing_trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (ori_trace_val != m_playing_trackBar.Val)
            {
                if (P_Layer.reader != null)
                    P_Layer.reader.CurrentTime = new TimeSpan(0, 0, 0, 0, m_playing_trackBar.Val);
            }
            traceBar_draged = false;
        }
        private void m_playing_trackBar_MouseDown(object sender, MouseEventArgs e)
        {
            traceBar_draged = true;
            if (P_Layer.reader != null)
            {
                ori_time = P_Layer.reader.CurrentTime;
                ori_trace_val = m_playing_trackBar.Val;
            }
        }


        TimeSpan ori_lrc_val;
        private void lrcD_Isplay1_MouseDown(object sender, MouseEventArgs e)
        {
            traceBar_draged = true;
            if (P_Layer.reader != null)
            {
                ori_time = P_Layer.reader.CurrentTime;
                ori_lrc_val = lrcD_Isplay1.nowTime;
            }
        }

        private void lrcD_Isplay1_MouseUp(object sender, MouseEventArgs e)
        {
            if (ori_lrc_val != lrcD_Isplay1.nowTime)
            {
                if (P_Layer.reader != null)
                    P_Layer.reader.CurrentTime = lrcD_Isplay1.nowTime;
            }
            traceBar_draged = false;
        }



        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 1)
            {
                int index = Convert.ToInt32(listView2.SelectedItems[0].Index);
                mlc.collection[mlc.now_list_index].playing_song_index = index;
                prepare_playing(mlc.collection[mlc.now_list_index].musicfiles[index].musicfileinfo.FullName);
            }
        }
        private void listView2_Resize(object sender, EventArgs e)
        {
            l_music.Width = listView2.Width;
        }
        private void main_win_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (upt_trd != null)
            {
                upt_trd.Abort();
            }
        }

        private void flowLayoutPanel2_Resize(object sender, EventArgs e)
        {

        }

        private void OpendirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                var fi = (explorer.get_certain_directory_file(new DirectoryInfo(folderBrowserDialog1.SelectedPath))).ToArray<FileInfo>();
                mlc.CurrenList.playing_song_index = mlc.CurrenList.musicfiles.Count;
                if (fi.Length > 0)
                {
                    add_music(fi);
                    if (P_Layer.player == null)
                        prepare_playing(fi[0].FullName);
                }

            }
            folderBrowserDialog1.SelectedPath = "";
        }

        private void mute_event(object sender, EventArgs e)
        {
            if (P_Layer.reader != null)
            {
                if (P_Layer.reader.Volume != 0)
                {
                    c_mute_button.Text = "🔇";
                    P_Layer.reader.Volume = 0;
                }
                else
                {
                    c_mute_button.Text = "🔊";
                    P_Layer.reader.Volume = P_Layer.c_volume;
                }
            }

        }
    #endregion
    }
}
