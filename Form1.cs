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
