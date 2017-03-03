namespace musicP_Layer
{
    partial class main_win
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.title_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.title_close_button = new System.Windows.Forms.Button();
            this.title_min_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.left_panel = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.down_panel = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_pic = new System.Windows.Forms.TabPage();
            this.m_image_box = new System.Windows.Forms.PictureBox();
            this.tab_list = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.l_music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.m_playing_time_label = new System.Windows.Forms.Label();
            this.m_total_time_label = new System.Windows.Forms.Label();
            this.m_title_label = new System.Windows.Forms.Label();
            this.m_artist_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.c_play_button = new System.Windows.Forms.Button();
            this.c_stop_button = new System.Windows.Forms.Button();
            this.c_mute_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpendirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.結束ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.file_chooser = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.m_playing_trackBar = new musicP_Layer.TrackBar_C();
            this.c_volume_trackBar = new musicP_Layer.TrackBar_C();
            this.title_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_image_box)).BeginInit();
            this.tab_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.OrangeRed;
            this.title_panel.Controls.Add(this.tableLayoutPanel1);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title_panel.Location = new System.Drawing.Point(5, 5);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(490, 24);
            this.title_panel.TabIndex = 0;
            this.title_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseDown);
            this.title_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseMove);
            this.title_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.17241F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.title_label, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.title_close_button);
            this.flowLayoutPanel1.Controls.Add(this.title_min_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(271, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 22);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseUp);
            // 
            // title_close_button
            // 
            this.title_close_button.FlatAppearance.BorderSize = 0;
            this.title_close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_close_button.Location = new System.Drawing.Point(197, 1);
            this.title_close_button.Margin = new System.Windows.Forms.Padding(1);
            this.title_close_button.Name = "title_close_button";
            this.title_close_button.Size = new System.Drawing.Size(20, 20);
            this.title_close_button.TabIndex = 0;
            this.title_close_button.Text = "❌";
            this.title_close_button.UseVisualStyleBackColor = true;
            this.title_close_button.Click += new System.EventHandler(this.close_the_app_event);
            // 
            // title_min_button
            // 
            this.title_min_button.FlatAppearance.BorderSize = 0;
            this.title_min_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_min_button.Location = new System.Drawing.Point(175, 1);
            this.title_min_button.Margin = new System.Windows.Forms.Padding(1);
            this.title_min_button.Name = "title_min_button";
            this.title_min_button.Size = new System.Drawing.Size(20, 20);
            this.title_min_button.TabIndex = 1;
            this.title_min_button.Text = "―";
            this.title_min_button.UseVisualStyleBackColor = true;
            this.title_min_button.Click += new System.EventHandler(this.min_the_app_event);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_label.Location = new System.Drawing.Point(3, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(264, 24);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "musicP_Layer";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseDown);
            this.title_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseMove);
            this.title_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseUp);
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.Chartreuse;
            this.left_panel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 5);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(5, 590);
            this.left_panel.TabIndex = 1;
            this.left_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseDown);
            this.left_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseMove);
            this.left_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseUp);
            // 
            // right_panel
            // 
            this.right_panel.BackColor = System.Drawing.Color.Chartreuse;
            this.right_panel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_panel.Location = new System.Drawing.Point(495, 5);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(5, 590);
            this.right_panel.TabIndex = 2;
            this.right_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseDown);
            this.right_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseMove);
            this.right_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseUp);
            // 
            // down_panel
            // 
            this.down_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.down_panel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.down_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.down_panel.Location = new System.Drawing.Point(0, 595);
            this.down_panel.Name = "down_panel";
            this.down_panel.Size = new System.Drawing.Size(500, 5);
            this.down_panel.TabIndex = 3;
            this.down_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseDown);
            this.down_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseMove);
            this.down_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseUp);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.top_panel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(500, 5);
            this.top_panel.TabIndex = 4;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseDown);
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseMove);
            this.top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_panel_MouseUp);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.splitContainer1);
            this.main_panel.Controls.Add(this.menuStrip1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(5, 29);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(490, 566);
            this.main_panel.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(490, 542);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_pic);
            this.tabControl1.Controls.Add(this.tab_list);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_pic
            // 
            this.tab_pic.Controls.Add(this.m_image_box);
            this.tab_pic.Location = new System.Drawing.Point(4, 22);
            this.tab_pic.Name = "tab_pic";
            this.tab_pic.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pic.Size = new System.Drawing.Size(482, 374);
            this.tab_pic.TabIndex = 0;
            this.tab_pic.Text = "圖片";
            this.tab_pic.UseVisualStyleBackColor = true;
            // 
            // m_image_box
            // 
            this.m_image_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_image_box.Location = new System.Drawing.Point(3, 3);
            this.m_image_box.Name = "m_image_box";
            this.m_image_box.Size = new System.Drawing.Size(476, 368);
            this.m_image_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_image_box.TabIndex = 0;
            this.m_image_box.TabStop = false;
            // 
            // tab_list
            // 
            this.tab_list.Controls.Add(this.splitContainer2);
            this.tab_list.Location = new System.Drawing.Point(4, 22);
            this.tab_list.Name = "tab_list";
            this.tab_list.Padding = new System.Windows.Forms.Padding(3);
            this.tab_list.Size = new System.Drawing.Size(482, 374);
            this.tab_list.TabIndex = 1;
            this.tab_list.Text = "清單";
            this.tab_list.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView2);
            this.splitContainer2.Size = new System.Drawing.Size(476, 368);
            this.splitContainer2.SplitterDistance = 158;
            this.splitContainer2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(158, 368);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Window;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.l_music});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(314, 368);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            this.listView2.Resize += new System.EventHandler(this.listView2_Resize);
            // 
            // l_music
            // 
            this.l_music.Text = "music";
            this.l_music.Width = 500;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.m_title_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.m_artist_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 141);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.05276F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.95309F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.994137F));
            this.tableLayoutPanel3.Controls.Add(this.m_playing_time_label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.m_total_time_label, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.m_playing_trackBar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(484, 46);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // m_playing_time_label
            // 
            this.m_playing_time_label.AutoSize = true;
            this.m_playing_time_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_playing_time_label.Location = new System.Drawing.Point(3, 0);
            this.m_playing_time_label.Name = "m_playing_time_label";
            this.m_playing_time_label.Size = new System.Drawing.Size(42, 46);
            this.m_playing_time_label.TabIndex = 0;
            this.m_playing_time_label.Text = "00:00";
            this.m_playing_time_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_total_time_label
            // 
            this.m_total_time_label.AutoSize = true;
            this.m_total_time_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_total_time_label.Location = new System.Drawing.Point(437, 0);
            this.m_total_time_label.Name = "m_total_time_label";
            this.m_total_time_label.Size = new System.Drawing.Size(44, 46);
            this.m_total_time_label.TabIndex = 1;
            this.m_total_time_label.Text = "99:99";
            this.m_total_time_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_title_label
            // 
            this.m_title_label.AutoSize = true;
            this.m_title_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_title_label.Location = new System.Drawing.Point(3, 0);
            this.m_title_label.Name = "m_title_label";
            this.m_title_label.Size = new System.Drawing.Size(484, 12);
            this.m_title_label.TabIndex = 1;
            this.m_title_label.Text = "Title: ";
            this.m_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_artist_label
            // 
            this.m_artist_label.AutoSize = true;
            this.m_artist_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_artist_label.Location = new System.Drawing.Point(3, 12);
            this.m_artist_label.Name = "m_artist_label";
            this.m_artist_label.Size = new System.Drawing.Size(484, 12);
            this.m_artist_label.TabIndex = 2;
            this.m_artist_label.Text = "Artist: ";
            this.m_artist_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.c_play_button);
            this.flowLayoutPanel2.Controls.Add(this.c_stop_button);
            this.flowLayoutPanel2.Controls.Add(this.c_mute_button);
            this.flowLayoutPanel2.Controls.Add(this.c_volume_trackBar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 79);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(484, 59);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // c_play_button
            // 
            this.c_play_button.FlatAppearance.BorderSize = 0;
            this.c_play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_play_button.Font = new System.Drawing.Font("新細明體", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.c_play_button.Location = new System.Drawing.Point(1, 1);
            this.c_play_button.Margin = new System.Windows.Forms.Padding(1);
            this.c_play_button.Name = "c_play_button";
            this.c_play_button.Size = new System.Drawing.Size(64, 64);
            this.c_play_button.TabIndex = 0;
            this.c_play_button.Text = "▶︎";
            this.c_play_button.UseVisualStyleBackColor = true;
            this.c_play_button.Click += new System.EventHandler(this.play_music_event);
            // 
            // c_stop_button
            // 
            this.c_stop_button.FlatAppearance.BorderSize = 0;
            this.c_stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_stop_button.Font = new System.Drawing.Font("新細明體", 40F);
            this.c_stop_button.Location = new System.Drawing.Point(67, 1);
            this.c_stop_button.Margin = new System.Windows.Forms.Padding(1);
            this.c_stop_button.Name = "c_stop_button";
            this.c_stop_button.Size = new System.Drawing.Size(64, 64);
            this.c_stop_button.TabIndex = 2;
            this.c_stop_button.Text = "◼️";
            this.c_stop_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.c_stop_button.UseVisualStyleBackColor = true;
            this.c_stop_button.Click += new System.EventHandler(this.stop_music_event);
            // 
            // c_mute_button
            // 
            this.c_mute_button.FlatAppearance.BorderSize = 0;
            this.c_mute_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_mute_button.Font = new System.Drawing.Font("新細明體", 40F);
            this.c_mute_button.Location = new System.Drawing.Point(133, 1);
            this.c_mute_button.Margin = new System.Windows.Forms.Padding(1);
            this.c_mute_button.Name = "c_mute_button";
            this.c_mute_button.Size = new System.Drawing.Size(64, 64);
            this.c_mute_button.TabIndex = 3;
            this.c_mute_button.Text = "🔊";
            this.c_mute_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.c_mute_button.UseVisualStyleBackColor = true;
            this.c_mute_button.Click += new System.EventHandler(this.mute_event);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟ToolStripMenuItem,
            this.OpendirToolStripMenuItem,
            this.結束ToolStripMenuItem,
            this.結束ToolStripMenuItem1});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.開啟ToolStripMenuItem.Text = "開啟檔案";
            this.開啟ToolStripMenuItem.Click += new System.EventHandler(this.open_file_browser);
            // 
            // OpendirToolStripMenuItem
            // 
            this.OpendirToolStripMenuItem.Name = "OpendirToolStripMenuItem";
            this.OpendirToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.OpendirToolStripMenuItem.Text = "開啟資料夾";
            this.OpendirToolStripMenuItem.Click += new System.EventHandler(this.OpendirToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(131, 6);
            // 
            // 結束ToolStripMenuItem1
            // 
            this.結束ToolStripMenuItem1.Name = "結束ToolStripMenuItem1";
            this.結束ToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.結束ToolStripMenuItem1.Text = "結束應用";
            this.結束ToolStripMenuItem1.Click += new System.EventHandler(this.close_the_app_event);
            // 
            // file_chooser
            // 
            this.file_chooser.FileName = "file_choose";
            this.file_chooser.Filter = "Audio files(*.mp3;*.wav;*.flac)|*.mp3;*.wav;*.flac";
            this.file_chooser.Multiselect = true;
            this.file_chooser.FileOk += new System.ComponentModel.CancelEventHandler(this.file_chooser_FileOk);
            // 
            // m_playing_trackBar
            // 
            this.m_playing_trackBar.BorderColor = System.Drawing.Color.Gray;
            this.m_playing_trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_playing_trackBar.Location = new System.Drawing.Point(51, 3);
            this.m_playing_trackBar.Max = 10;
            this.m_playing_trackBar.Min = 0;
            this.m_playing_trackBar.Name = "m_playing_trackBar";
            this.m_playing_trackBar.PointerCircleSize = 20;
            this.m_playing_trackBar.PointerInCircleDistence = 3;
            this.m_playing_trackBar.PointerInColor = System.Drawing.Color.White;
            this.m_playing_trackBar.PointerOutColor = System.Drawing.Color.Black;
            this.m_playing_trackBar.PointerRectSize = new System.Drawing.Size(10, 20);
            this.m_playing_trackBar.PointerStyle = musicP_Layer.TrackBar_C.PointerStyleOption.rectangle;
            this.m_playing_trackBar.Size = new System.Drawing.Size(380, 40);
            this.m_playing_trackBar.TabIndex = 5;
            this.m_playing_trackBar.Text = "trackBar_C1";
            this.m_playing_trackBar.Val = 0;
            this.m_playing_trackBar.Scroll += new System.EventHandler(this.m_playing_trackBar_Scroll);
            this.m_playing_trackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_playing_trackBar_MouseDown);
            this.m_playing_trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_playing_trackBar_MouseUp);
            // 
            // c_volume_trackBar
            // 
            this.c_volume_trackBar.BorderColor = System.Drawing.Color.Gray;
            this.c_volume_trackBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c_volume_trackBar.Location = new System.Drawing.Point(201, 3);
            this.c_volume_trackBar.Max = 100;
            this.c_volume_trackBar.Min = 0;
            this.c_volume_trackBar.Name = "c_volume_trackBar";
            this.c_volume_trackBar.PointerCircleSize = 20;
            this.c_volume_trackBar.PointerInCircleDistence = 3;
            this.c_volume_trackBar.PointerInColor = System.Drawing.Color.White;
            this.c_volume_trackBar.PointerOutColor = System.Drawing.Color.Black;
            this.c_volume_trackBar.PointerRectSize = new System.Drawing.Size(10, 20);
            this.c_volume_trackBar.PointerStyle = musicP_Layer.TrackBar_C.PointerStyleOption.rectangle;
            this.c_volume_trackBar.Size = new System.Drawing.Size(87, 64);
            this.c_volume_trackBar.TabIndex = 4;
            this.c_volume_trackBar.Text = "trackBar_C1";
            this.c_volume_trackBar.Val = 100;
            this.c_volume_trackBar.Scroll += new System.EventHandler(this.c_volume_trackBar_Scroll);
            // 
            // main_win
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.title_panel);
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.down_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "main_win";
            this.Text = "musicP_Layer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_win_FormClosing);
            this.Shown += new System.EventHandler(this.start_up_change_color);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.main_win_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.main_win_DragEnter);
            this.title_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_image_box)).EndInit();
            this.tab_list.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Panel right_panel;
        private System.Windows.Forms.Panel down_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button title_close_button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.OpenFileDialog file_chooser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label m_playing_time_label;
        private System.Windows.Forms.Label m_total_time_label;
        private System.Windows.Forms.Label m_title_label;
        private System.Windows.Forms.Label m_artist_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button c_play_button;
        private System.Windows.Forms.Button c_stop_button;
        private System.Windows.Forms.PictureBox m_image_box;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_pic;
        private System.Windows.Forms.TabPage tab_list;
        private System.Windows.Forms.Button title_min_button;
        private System.Windows.Forms.Button c_mute_button;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader l_music;
        private TrackBar_C c_volume_trackBar;
        private System.Windows.Forms.ToolStripMenuItem OpendirToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private TrackBar_C m_playing_trackBar;
    }
}

