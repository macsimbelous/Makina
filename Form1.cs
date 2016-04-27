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
using System.Diagnostics;

namespace Makina
{
    public partial class Form1 : Form
    {
        BindingList<Track> VideoTracks;
        BindingList<Track> AudioTracks;
        BindingList<Track> SubtutleTracks;
        BindingList<Track> AttachmentTracks;
        public Form1()
        {
            InitializeComponent();
            this.VideoTracks = new BindingList<Track>();
            this.AudioTracks = new BindingList<Track>();
            this.SubtutleTracks = new BindingList<Track>();
            this.AttachmentTracks = new BindingList<Track>();
            this.listBox_video.DataSource = this.VideoTracks;
            this.listBox_audio.DataSource = this.AudioTracks;
            this.listBox_subtitle.DataSource = this.SubtutleTracks;
            this.listBox_attachment.DataSource = this.AttachmentTracks;
        }

        private void button_add_video_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = true;
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(string s in this.openFileDialog1.FileNames)
                {
                    this.VideoTracks.Add(new Track(s));
                }
            }
        }

        private void button_add_audio_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = true;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in this.openFileDialog1.FileNames)
                {
                    this.AudioTracks.Add(new Track(s));
                }
            }
        }

        private void button_add_subtitle_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = true;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in this.openFileDialog1.FileNames)
                {
                    this.SubtutleTracks.Add(new Track(s));
                }
            }
        }

        private void button_add_attachment_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = true;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in this.openFileDialog1.FileNames)
                {
                    this.AttachmentTracks.Add(new Track(s));
                }
            }
        }

        private void button_del_video_Click(object sender, EventArgs e)
        {
            this.VideoTracks.RemoveAt(this.listBox_video.SelectedIndex);
        }

        private void button_del_audio_Click(object sender, EventArgs e)
        {
            this.AudioTracks.RemoveAt(this.listBox_audio.SelectedIndex);
        }

        private void button_del_subtitle_Click(object sender, EventArgs e)
        {
            this.SubtutleTracks.RemoveAt(this.listBox_subtitle.SelectedIndex);
        }

        private void button_del_attachment_Click(object sender, EventArgs e)
        {
            this.AttachmentTracks.RemoveAt(this.listBox_attachment.SelectedIndex);
        }

        private void button_clear_video_Click(object sender, EventArgs e)
        {
            this.VideoTracks.Clear();
        }

        private void button_clear_audio_Click(object sender, EventArgs e)
        {
            this.AudioTracks.Clear();
        }

        private void button_clear_subtitle_Click(object sender, EventArgs e)
        {
            this.SubtutleTracks.Clear();
        }

        private void button_clear_attachment_Click(object sender, EventArgs e)
        {
            this.AttachmentTracks.Clear();
        }

        private void button_up_video_Click(object sender, EventArgs e)
        {
            int temp = this.listBox_video.SelectedIndex;
            if (temp > 0)
            {
                Track tr = this.VideoTracks[temp];
                this.VideoTracks.RemoveAt(temp);
                this.VideoTracks.Insert(temp - 1, tr);
                this.listBox_video.SelectedIndex = temp - 1;
            }
        }

        private void button_up_audio_Click(object sender, EventArgs e)
        {
            int temp = this.listBox_audio.SelectedIndex;
            if (temp > 0)
            {
                Track tr = this.AudioTracks[temp];
                this.AudioTracks.RemoveAt(temp);
                this.AudioTracks.Insert(temp - 1, tr);
                this.listBox_audio.SelectedIndex = temp - 1;
            }
        }

        private void button_up_subtitle_Click(object sender, EventArgs e)
        {
            int temp = this.listBox_subtitle.SelectedIndex;
            if (temp > 0)
            {
                Track tr = this.SubtutleTracks[temp];
                this.SubtutleTracks.RemoveAt(temp);
                this.SubtutleTracks.Insert(temp - 1, tr);
                this.listBox_subtitle.SelectedIndex = temp - 1;
            }
        }

        private void button_up_attachment_Click(object sender, EventArgs e)
        {
            int temp = this.listBox_attachment.SelectedIndex;
            if (temp > 0)
            {
                Track tr = this.AttachmentTracks[temp];
                this.AttachmentTracks.RemoveAt(temp);
                this.AttachmentTracks.Insert(temp - 1, tr);
                this.listBox_attachment.SelectedIndex = temp - 1;
            }
        }

        private void button_down_video_Click(object sender, EventArgs e)
        {
            DownElement(this.listBox_video);
        }

        private void button_down_audio_Click(object sender, EventArgs e)
        {
            DownElement(this.listBox_audio);
        }

        private void button_down_subtitle_Click(object sender, EventArgs e)
        {
            DownElement(this.listBox_subtitle);
        }

        private void button_down__attachment_Click(object sender, EventArgs e)
        {
            DownElement(this.listBox_attachment);
        }
        private void DownElement(ListBox Tracks)
        {
            int Index = Tracks.SelectedIndex;
            BindingList<Track> list = (BindingList<Track>)Tracks.DataSource;
            if (Index < (list.Count - 1))
            {
                Track tr = list[Index];
                list.RemoveAt(Index);
                list.Insert(Index + 1, tr);
                Tracks.SelectedIndex = Index + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mkvmerge = "mkvmerge.exe";
            string temp_file = Path.GetTempFileName() + ".bat";
            if(this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string out_path = this.folderBrowserDialog1.SelectedPath + "\\";
                using (StreamWriter bat = new StreamWriter(temp_file))
                {
                    for (int i = 0; i < this.VideoTracks.Count; i++)
                    {
                        //bat.WriteLine("{0} -o {1} {2} {3} {4}", mkvmerge, out_path + Path.GetFileNameWithoutExtension(this.VideoTracks[i].FileName) + ".mkv", this.VideoTracks[i].FullPath, this.AudioTracks[i].FullPath, this.SubtutleTracks[i].FullPath);
                        bat.Write("\"{0}\" -o \"{1}\" \"{2}\"", mkvmerge, out_path + Path.GetFileNameWithoutExtension(this.VideoTracks[i].FileName) + ".mkv", this.VideoTracks[i].FullPath, this.AudioTracks[i].FullPath);
                        bat.WriteLine();
                    }
                    bat.Close();
                }
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.Arguments = @"/C " + temp_file;
                //myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
        }
    }
    public class Track
    {
        public string FullPath;
        public string FileName;
        public Track(string FullPath)
        {
            this.FileName = Path.GetFileName(FullPath);
            this.FullPath = FullPath;
        }
        public override string ToString()
        {
            return FileName;
        }
    }
}
