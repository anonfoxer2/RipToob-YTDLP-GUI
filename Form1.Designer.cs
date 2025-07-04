
namespace RipTube_YTDLP_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileMp4 = new System.Windows.Forms.RadioButton();
            this.fileWav = new System.Windows.Forms.RadioButton();
            this.fileMp3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.downLoadButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileMp4);
            this.groupBox1.Controls.Add(this.fileWav);
            this.groupBox1.Controls.Add(this.fileMp3);
            this.groupBox1.Location = new System.Drawing.Point(166, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // fileMp4
            // 
            this.fileMp4.AutoSize = true;
            this.fileMp4.Location = new System.Drawing.Point(7, 65);
            this.fileMp4.Name = "fileMp4";
            this.fileMp4.Size = new System.Drawing.Size(47, 17);
            this.fileMp4.TabIndex = 2;
            this.fileMp4.TabStop = true;
            this.fileMp4.Text = "MP4";
            this.fileMp4.UseVisualStyleBackColor = true;
            this.fileMp4.CheckedChanged += new System.EventHandler(this.fileMp4_CheckedChanged);
            // 
            // fileWav
            // 
            this.fileWav.AutoSize = true;
            this.fileWav.Location = new System.Drawing.Point(7, 42);
            this.fileWav.Name = "fileWav";
            this.fileWav.Size = new System.Drawing.Size(50, 17);
            this.fileWav.TabIndex = 1;
            this.fileWav.TabStop = true;
            this.fileWav.Text = "WAV";
            this.fileWav.UseVisualStyleBackColor = true;
            this.fileWav.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // fileMp3
            // 
            this.fileMp3.AutoSize = true;
            this.fileMp3.Location = new System.Drawing.Point(7, 19);
            this.fileMp3.Name = "fileMp3";
            this.fileMp3.Size = new System.Drawing.Size(47, 17);
            this.fileMp3.TabIndex = 0;
            this.fileMp3.TabStop = true;
            this.fileMp3.Text = "MP3";
            this.fileMp3.UseVisualStyleBackColor = true;
            this.fileMp3.CheckedChanged += new System.EventHandler(this.fileMp3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(262, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video";
            // 
            // linkText
            // 
            this.linkText.Location = new System.Drawing.Point(77, 42);
            this.linkText.Name = "linkText";
            this.linkText.Size = new System.Drawing.Size(167, 20);
            this.linkText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Video URL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "RipToob";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a yt-dlp gui by anonfoxer";
            // 
            // downLoadButton
            // 
            this.downLoadButton.Location = new System.Drawing.Point(20, 85);
            this.downLoadButton.Name = "downLoadButton";
            this.downLoadButton.Size = new System.Drawing.Size(128, 23);
            this.downLoadButton.TabIndex = 5;
            this.downLoadButton.Text = "Download";
            this.downLoadButton.UseVisualStyleBackColor = true;
            this.downLoadButton.Click += new System.EventHandler(this.downLoadButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "github.com/anonfoxer2/";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.outputBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 382);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Console";
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.outputBox.Location = new System.Drawing.Point(3, 24);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(494, 355);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(524, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downLoadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RipToob";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fileWav;
        private System.Windows.Forms.RadioButton fileMp3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton fileMp4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox linkText;
        private System.Windows.Forms.Button downLoadButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

