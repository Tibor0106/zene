﻿namespace zenesszar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HandleAddMusic = new Button();
            openFileDialog1 = new OpenFileDialog();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // HandleAddMusic
            // 
            HandleAddMusic.Location = new Point(28, 51);
            HandleAddMusic.Name = "HandleAddMusic";
            HandleAddMusic.Size = new Size(75, 23);
            HandleAddMusic.TabIndex = 0;
            HandleAddMusic.Text = "Add Music";
            HandleAddMusic.UseVisualStyleBackColor = true;
            HandleAddMusic.Click += HandleAddMusic_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(192, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(558, 349);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(HandleAddMusic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button HandleAddMusic;
        private OpenFileDialog openFileDialog1;
        private ListBox listBox1;
    }
}
