namespace Makina
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_tracks = new System.Windows.Forms.TabControl();
            this.tabPage_video = new System.Windows.Forms.TabPage();
            this.button_down_video = new System.Windows.Forms.Button();
            this.button_up_video = new System.Windows.Forms.Button();
            this.button_clear_video = new System.Windows.Forms.Button();
            this.button_del_video = new System.Windows.Forms.Button();
            this.button_add_video = new System.Windows.Forms.Button();
            this.listBox_video = new System.Windows.Forms.ListBox();
            this.tabPage_audio = new System.Windows.Forms.TabPage();
            this.button_down_audio = new System.Windows.Forms.Button();
            this.button_up_audio = new System.Windows.Forms.Button();
            this.button_clear_audio = new System.Windows.Forms.Button();
            this.button_del_audio = new System.Windows.Forms.Button();
            this.button_add_audio = new System.Windows.Forms.Button();
            this.listBox_audio = new System.Windows.Forms.ListBox();
            this.tabPage_subtitle = new System.Windows.Forms.TabPage();
            this.button_down_subtitle = new System.Windows.Forms.Button();
            this.button_up_subtitle = new System.Windows.Forms.Button();
            this.button_clear_subtitle = new System.Windows.Forms.Button();
            this.button_del_subtitle = new System.Windows.Forms.Button();
            this.button_add_subtitle = new System.Windows.Forms.Button();
            this.listBox_subtitle = new System.Windows.Forms.ListBox();
            this.tabPage_attachments = new System.Windows.Forms.TabPage();
            this.button_down__attachment = new System.Windows.Forms.Button();
            this.button_up_attachment = new System.Windows.Forms.Button();
            this.button_clear_attachment = new System.Windows.Forms.Button();
            this.button_del_attachment = new System.Windows.Forms.Button();
            this.button_add_attachment = new System.Windows.Forms.Button();
            this.listBox_attachment = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl_tracks.SuspendLayout();
            this.tabPage_video.SuspendLayout();
            this.tabPage_audio.SuspendLayout();
            this.tabPage_subtitle.SuspendLayout();
            this.tabPage_attachments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_tracks
            // 
            this.tabControl_tracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_tracks.Controls.Add(this.tabPage_video);
            this.tabControl_tracks.Controls.Add(this.tabPage_audio);
            this.tabControl_tracks.Controls.Add(this.tabPage_subtitle);
            this.tabControl_tracks.Controls.Add(this.tabPage_attachments);
            this.tabControl_tracks.Location = new System.Drawing.Point(12, 12);
            this.tabControl_tracks.Name = "tabControl_tracks";
            this.tabControl_tracks.SelectedIndex = 0;
            this.tabControl_tracks.Size = new System.Drawing.Size(392, 572);
            this.tabControl_tracks.TabIndex = 0;
            // 
            // tabPage_video
            // 
            this.tabPage_video.Controls.Add(this.button_down_video);
            this.tabPage_video.Controls.Add(this.button_up_video);
            this.tabPage_video.Controls.Add(this.button_clear_video);
            this.tabPage_video.Controls.Add(this.button_del_video);
            this.tabPage_video.Controls.Add(this.button_add_video);
            this.tabPage_video.Controls.Add(this.listBox_video);
            this.tabPage_video.Location = new System.Drawing.Point(4, 22);
            this.tabPage_video.Name = "tabPage_video";
            this.tabPage_video.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_video.Size = new System.Drawing.Size(384, 546);
            this.tabPage_video.TabIndex = 0;
            this.tabPage_video.Text = "Видео";
            this.tabPage_video.UseVisualStyleBackColor = true;
            // 
            // button_down_video
            // 
            this.button_down_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_down_video.Location = new System.Drawing.Point(303, 122);
            this.button_down_video.Name = "button_down_video";
            this.button_down_video.Size = new System.Drawing.Size(75, 23);
            this.button_down_video.TabIndex = 5;
            this.button_down_video.Text = "Вниз";
            this.button_down_video.UseVisualStyleBackColor = true;
            this.button_down_video.Click += new System.EventHandler(this.button_down_video_Click);
            // 
            // button_up_video
            // 
            this.button_up_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_up_video.Location = new System.Drawing.Point(303, 93);
            this.button_up_video.Name = "button_up_video";
            this.button_up_video.Size = new System.Drawing.Size(75, 23);
            this.button_up_video.TabIndex = 4;
            this.button_up_video.Text = "Вверх";
            this.button_up_video.UseVisualStyleBackColor = true;
            this.button_up_video.Click += new System.EventHandler(this.button_up_video_Click);
            // 
            // button_clear_video
            // 
            this.button_clear_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_video.Location = new System.Drawing.Point(303, 64);
            this.button_clear_video.Name = "button_clear_video";
            this.button_clear_video.Size = new System.Drawing.Size(75, 23);
            this.button_clear_video.TabIndex = 3;
            this.button_clear_video.Text = "Очистить";
            this.button_clear_video.UseVisualStyleBackColor = true;
            this.button_clear_video.Click += new System.EventHandler(this.button_clear_video_Click);
            // 
            // button_del_video
            // 
            this.button_del_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_del_video.Location = new System.Drawing.Point(303, 35);
            this.button_del_video.Name = "button_del_video";
            this.button_del_video.Size = new System.Drawing.Size(75, 23);
            this.button_del_video.TabIndex = 2;
            this.button_del_video.Text = "Удалить";
            this.button_del_video.UseVisualStyleBackColor = true;
            this.button_del_video.Click += new System.EventHandler(this.button_del_video_Click);
            // 
            // button_add_video
            // 
            this.button_add_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add_video.Location = new System.Drawing.Point(303, 6);
            this.button_add_video.Name = "button_add_video";
            this.button_add_video.Size = new System.Drawing.Size(75, 23);
            this.button_add_video.TabIndex = 1;
            this.button_add_video.Text = "Добавить";
            this.button_add_video.UseVisualStyleBackColor = true;
            this.button_add_video.Click += new System.EventHandler(this.button_add_video_Click);
            // 
            // listBox_video
            // 
            this.listBox_video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_video.FormattingEnabled = true;
            this.listBox_video.Location = new System.Drawing.Point(6, 6);
            this.listBox_video.Name = "listBox_video";
            this.listBox_video.Size = new System.Drawing.Size(291, 537);
            this.listBox_video.TabIndex = 0;
            // 
            // tabPage_audio
            // 
            this.tabPage_audio.Controls.Add(this.button_down_audio);
            this.tabPage_audio.Controls.Add(this.button_up_audio);
            this.tabPage_audio.Controls.Add(this.button_clear_audio);
            this.tabPage_audio.Controls.Add(this.button_del_audio);
            this.tabPage_audio.Controls.Add(this.button_add_audio);
            this.tabPage_audio.Controls.Add(this.listBox_audio);
            this.tabPage_audio.Location = new System.Drawing.Point(4, 22);
            this.tabPage_audio.Name = "tabPage_audio";
            this.tabPage_audio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_audio.Size = new System.Drawing.Size(384, 546);
            this.tabPage_audio.TabIndex = 1;
            this.tabPage_audio.Text = "Аудио";
            this.tabPage_audio.UseVisualStyleBackColor = true;
            // 
            // button_down_audio
            // 
            this.button_down_audio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_down_audio.Location = new System.Drawing.Point(303, 122);
            this.button_down_audio.Name = "button_down_audio";
            this.button_down_audio.Size = new System.Drawing.Size(75, 23);
            this.button_down_audio.TabIndex = 11;
            this.button_down_audio.Text = "Вниз";
            this.button_down_audio.UseVisualStyleBackColor = true;
            this.button_down_audio.Click += new System.EventHandler(this.button_down_audio_Click);
            // 
            // button_up_audio
            // 
            this.button_up_audio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_up_audio.Location = new System.Drawing.Point(303, 93);
            this.button_up_audio.Name = "button_up_audio";
            this.button_up_audio.Size = new System.Drawing.Size(75, 23);
            this.button_up_audio.TabIndex = 10;
            this.button_up_audio.Text = "Вверх";
            this.button_up_audio.UseVisualStyleBackColor = true;
            this.button_up_audio.Click += new System.EventHandler(this.button_up_audio_Click);
            // 
            // button_clear_audio
            // 
            this.button_clear_audio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_audio.Location = new System.Drawing.Point(303, 64);
            this.button_clear_audio.Name = "button_clear_audio";
            this.button_clear_audio.Size = new System.Drawing.Size(75, 23);
            this.button_clear_audio.TabIndex = 9;
            this.button_clear_audio.Text = "Очистить";
            this.button_clear_audio.UseVisualStyleBackColor = true;
            this.button_clear_audio.Click += new System.EventHandler(this.button_clear_audio_Click);
            // 
            // button_del_audio
            // 
            this.button_del_audio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_del_audio.Location = new System.Drawing.Point(303, 35);
            this.button_del_audio.Name = "button_del_audio";
            this.button_del_audio.Size = new System.Drawing.Size(75, 23);
            this.button_del_audio.TabIndex = 8;
            this.button_del_audio.Text = "Удалить";
            this.button_del_audio.UseVisualStyleBackColor = true;
            this.button_del_audio.Click += new System.EventHandler(this.button_del_audio_Click);
            // 
            // button_add_audio
            // 
            this.button_add_audio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add_audio.Location = new System.Drawing.Point(303, 6);
            this.button_add_audio.Name = "button_add_audio";
            this.button_add_audio.Size = new System.Drawing.Size(75, 23);
            this.button_add_audio.TabIndex = 7;
            this.button_add_audio.Text = "Добавить";
            this.button_add_audio.UseVisualStyleBackColor = true;
            this.button_add_audio.Click += new System.EventHandler(this.button_add_audio_Click);
            // 
            // listBox_audio
            // 
            this.listBox_audio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_audio.FormattingEnabled = true;
            this.listBox_audio.Location = new System.Drawing.Point(6, 6);
            this.listBox_audio.Name = "listBox_audio";
            this.listBox_audio.Size = new System.Drawing.Size(291, 537);
            this.listBox_audio.TabIndex = 6;
            // 
            // tabPage_subtitle
            // 
            this.tabPage_subtitle.Controls.Add(this.button_down_subtitle);
            this.tabPage_subtitle.Controls.Add(this.button_up_subtitle);
            this.tabPage_subtitle.Controls.Add(this.button_clear_subtitle);
            this.tabPage_subtitle.Controls.Add(this.button_del_subtitle);
            this.tabPage_subtitle.Controls.Add(this.button_add_subtitle);
            this.tabPage_subtitle.Controls.Add(this.listBox_subtitle);
            this.tabPage_subtitle.Location = new System.Drawing.Point(4, 22);
            this.tabPage_subtitle.Name = "tabPage_subtitle";
            this.tabPage_subtitle.Size = new System.Drawing.Size(384, 546);
            this.tabPage_subtitle.TabIndex = 2;
            this.tabPage_subtitle.Text = "Субтитры";
            this.tabPage_subtitle.UseVisualStyleBackColor = true;
            // 
            // button_down_subtitle
            // 
            this.button_down_subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_down_subtitle.Location = new System.Drawing.Point(303, 122);
            this.button_down_subtitle.Name = "button_down_subtitle";
            this.button_down_subtitle.Size = new System.Drawing.Size(75, 23);
            this.button_down_subtitle.TabIndex = 11;
            this.button_down_subtitle.Text = "Вниз";
            this.button_down_subtitle.UseVisualStyleBackColor = true;
            this.button_down_subtitle.Click += new System.EventHandler(this.button_down_subtitle_Click);
            // 
            // button_up_subtitle
            // 
            this.button_up_subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_up_subtitle.Location = new System.Drawing.Point(303, 93);
            this.button_up_subtitle.Name = "button_up_subtitle";
            this.button_up_subtitle.Size = new System.Drawing.Size(75, 23);
            this.button_up_subtitle.TabIndex = 10;
            this.button_up_subtitle.Text = "Вверх";
            this.button_up_subtitle.UseVisualStyleBackColor = true;
            this.button_up_subtitle.Click += new System.EventHandler(this.button_up_subtitle_Click);
            // 
            // button_clear_subtitle
            // 
            this.button_clear_subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_subtitle.Location = new System.Drawing.Point(303, 64);
            this.button_clear_subtitle.Name = "button_clear_subtitle";
            this.button_clear_subtitle.Size = new System.Drawing.Size(75, 23);
            this.button_clear_subtitle.TabIndex = 9;
            this.button_clear_subtitle.Text = "Очистить";
            this.button_clear_subtitle.UseVisualStyleBackColor = true;
            this.button_clear_subtitle.Click += new System.EventHandler(this.button_clear_subtitle_Click);
            // 
            // button_del_subtitle
            // 
            this.button_del_subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_del_subtitle.Location = new System.Drawing.Point(303, 35);
            this.button_del_subtitle.Name = "button_del_subtitle";
            this.button_del_subtitle.Size = new System.Drawing.Size(75, 23);
            this.button_del_subtitle.TabIndex = 8;
            this.button_del_subtitle.Text = "Удалить";
            this.button_del_subtitle.UseVisualStyleBackColor = true;
            this.button_del_subtitle.Click += new System.EventHandler(this.button_del_subtitle_Click);
            // 
            // button_add_subtitle
            // 
            this.button_add_subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add_subtitle.Location = new System.Drawing.Point(303, 6);
            this.button_add_subtitle.Name = "button_add_subtitle";
            this.button_add_subtitle.Size = new System.Drawing.Size(75, 23);
            this.button_add_subtitle.TabIndex = 7;
            this.button_add_subtitle.Text = "Добавить";
            this.button_add_subtitle.UseVisualStyleBackColor = true;
            this.button_add_subtitle.Click += new System.EventHandler(this.button_add_subtitle_Click);
            // 
            // listBox_subtitle
            // 
            this.listBox_subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_subtitle.FormattingEnabled = true;
            this.listBox_subtitle.Location = new System.Drawing.Point(6, 6);
            this.listBox_subtitle.Name = "listBox_subtitle";
            this.listBox_subtitle.Size = new System.Drawing.Size(291, 537);
            this.listBox_subtitle.TabIndex = 6;
            // 
            // tabPage_attachments
            // 
            this.tabPage_attachments.Controls.Add(this.button_down__attachment);
            this.tabPage_attachments.Controls.Add(this.button_up_attachment);
            this.tabPage_attachments.Controls.Add(this.button_clear_attachment);
            this.tabPage_attachments.Controls.Add(this.button_del_attachment);
            this.tabPage_attachments.Controls.Add(this.button_add_attachment);
            this.tabPage_attachments.Controls.Add(this.listBox_attachment);
            this.tabPage_attachments.Location = new System.Drawing.Point(4, 22);
            this.tabPage_attachments.Name = "tabPage_attachments";
            this.tabPage_attachments.Size = new System.Drawing.Size(384, 546);
            this.tabPage_attachments.TabIndex = 3;
            this.tabPage_attachments.Text = "Вложения";
            this.tabPage_attachments.UseVisualStyleBackColor = true;
            // 
            // button_down__attachment
            // 
            this.button_down__attachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_down__attachment.Location = new System.Drawing.Point(303, 122);
            this.button_down__attachment.Name = "button_down__attachment";
            this.button_down__attachment.Size = new System.Drawing.Size(75, 23);
            this.button_down__attachment.TabIndex = 11;
            this.button_down__attachment.Text = "Вниз";
            this.button_down__attachment.UseVisualStyleBackColor = true;
            this.button_down__attachment.Click += new System.EventHandler(this.button_down__attachment_Click);
            // 
            // button_up_attachment
            // 
            this.button_up_attachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_up_attachment.Location = new System.Drawing.Point(303, 93);
            this.button_up_attachment.Name = "button_up_attachment";
            this.button_up_attachment.Size = new System.Drawing.Size(75, 23);
            this.button_up_attachment.TabIndex = 10;
            this.button_up_attachment.Text = "Вверх";
            this.button_up_attachment.UseVisualStyleBackColor = true;
            this.button_up_attachment.Click += new System.EventHandler(this.button_up_attachment_Click);
            // 
            // button_clear_attachment
            // 
            this.button_clear_attachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_attachment.Location = new System.Drawing.Point(303, 64);
            this.button_clear_attachment.Name = "button_clear_attachment";
            this.button_clear_attachment.Size = new System.Drawing.Size(75, 23);
            this.button_clear_attachment.TabIndex = 9;
            this.button_clear_attachment.Text = "Очистить";
            this.button_clear_attachment.UseVisualStyleBackColor = true;
            this.button_clear_attachment.Click += new System.EventHandler(this.button_clear_attachment_Click);
            // 
            // button_del_attachment
            // 
            this.button_del_attachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_del_attachment.Location = new System.Drawing.Point(303, 35);
            this.button_del_attachment.Name = "button_del_attachment";
            this.button_del_attachment.Size = new System.Drawing.Size(75, 23);
            this.button_del_attachment.TabIndex = 8;
            this.button_del_attachment.Text = "Удалить";
            this.button_del_attachment.UseVisualStyleBackColor = true;
            this.button_del_attachment.Click += new System.EventHandler(this.button_del_attachment_Click);
            // 
            // button_add_attachment
            // 
            this.button_add_attachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add_attachment.Location = new System.Drawing.Point(303, 6);
            this.button_add_attachment.Name = "button_add_attachment";
            this.button_add_attachment.Size = new System.Drawing.Size(75, 23);
            this.button_add_attachment.TabIndex = 7;
            this.button_add_attachment.Text = "Добавить";
            this.button_add_attachment.UseVisualStyleBackColor = true;
            this.button_add_attachment.Click += new System.EventHandler(this.button_add_attachment_Click);
            // 
            // listBox_attachment
            // 
            this.listBox_attachment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_attachment.FormattingEnabled = true;
            this.listBox_attachment.Location = new System.Drawing.Point(6, 6);
            this.listBox_attachment.Name = "listBox_attachment";
            this.listBox_attachment.Size = new System.Drawing.Size(291, 537);
            this.listBox_attachment.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(410, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Микшировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl_tracks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl_tracks.ResumeLayout(false);
            this.tabPage_video.ResumeLayout(false);
            this.tabPage_audio.ResumeLayout(false);
            this.tabPage_subtitle.ResumeLayout(false);
            this.tabPage_attachments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_tracks;
        private System.Windows.Forms.TabPage tabPage_video;
        private System.Windows.Forms.TabPage tabPage_audio;
        private System.Windows.Forms.TabPage tabPage_subtitle;
        private System.Windows.Forms.TabPage tabPage_attachments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_video;
        private System.Windows.Forms.Button button_down_video;
        private System.Windows.Forms.Button button_up_video;
        private System.Windows.Forms.Button button_clear_video;
        private System.Windows.Forms.Button button_del_video;
        private System.Windows.Forms.Button button_add_video;
        private System.Windows.Forms.Button button_down_audio;
        private System.Windows.Forms.Button button_up_audio;
        private System.Windows.Forms.Button button_clear_audio;
        private System.Windows.Forms.Button button_del_audio;
        private System.Windows.Forms.Button button_add_audio;
        private System.Windows.Forms.ListBox listBox_audio;
        private System.Windows.Forms.Button button_down_subtitle;
        private System.Windows.Forms.Button button_up_subtitle;
        private System.Windows.Forms.Button button_clear_subtitle;
        private System.Windows.Forms.Button button_del_subtitle;
        private System.Windows.Forms.Button button_add_subtitle;
        private System.Windows.Forms.ListBox listBox_subtitle;
        private System.Windows.Forms.Button button_down__attachment;
        private System.Windows.Forms.Button button_up_attachment;
        private System.Windows.Forms.Button button_clear_attachment;
        private System.Windows.Forms.Button button_del_attachment;
        private System.Windows.Forms.Button button_add_attachment;
        private System.Windows.Forms.ListBox listBox_attachment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

