namespace TTSandSTT
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
            TTSbuttonPL = new Button();
            TEXTBOXPL = new RichTextBox();
            TEXTBOXENG = new RichTextBox();
            TTSbuttonENG = new Button();
            label1 = new Label();
            label2 = new Label();
            VolumeBar = new TrackBar();
            label3 = new Label();
            VolumeShow = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).BeginInit();
            SuspendLayout();
            // 
            // TTSbuttonPL
            // 
            TTSbuttonPL.Location = new Point(12, 114);
            TTSbuttonPL.Name = "TTSbuttonPL";
            TTSbuttonPL.Size = new Size(95, 37);
            TTSbuttonPL.TabIndex = 0;
            TTSbuttonPL.Text = "TextToSpeech";
            TTSbuttonPL.UseVisualStyleBackColor = true;
            TTSbuttonPL.Click += TTSbutton_Click;
            // 
            // TEXTBOXPL
            // 
            TEXTBOXPL.BackColor = SystemColors.ScrollBar;
            TEXTBOXPL.Location = new Point(12, 12);
            TEXTBOXPL.Name = "TEXTBOXPL";
            TEXTBOXPL.Size = new Size(776, 96);
            TEXTBOXPL.TabIndex = 1;
            TEXTBOXPL.Text = "";
            // 
            // TEXTBOXENG
            // 
            TEXTBOXENG.BackColor = SystemColors.ScrollBar;
            TEXTBOXENG.Location = new Point(12, 218);
            TEXTBOXENG.Name = "TEXTBOXENG";
            TEXTBOXENG.Size = new Size(776, 96);
            TEXTBOXENG.TabIndex = 3;
            TEXTBOXENG.Text = "";
            // 
            // TTSbuttonENG
            // 
            TTSbuttonENG.Location = new Point(12, 320);
            TTSbuttonENG.Name = "TTSbuttonENG";
            TTSbuttonENG.Size = new Size(95, 37);
            TTSbuttonENG.TabIndex = 2;
            TTSbuttonENG.Text = "TextToSpeech";
            TTSbuttonENG.UseVisualStyleBackColor = true;
            TTSbuttonENG.Click += TTSbuttonENG_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 125);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Polish";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 331);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "English";
            // 
            // VolumeBar
            // 
            VolumeBar.Location = new Point(12, 393);
            VolumeBar.Maximum = 100;
            VolumeBar.Name = "VolumeBar";
            VolumeBar.Size = new Size(197, 45);
            VolumeBar.TabIndex = 6;
            VolumeBar.Value = 100;
            VolumeBar.Scroll += VolumeBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 375);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Volume";
            // 
            // VolumeShow
            // 
            VolumeShow.BackColor = SystemColors.ScrollBar;
            VolumeShow.Location = new Point(215, 393);
            VolumeShow.Name = "VolumeShow";
            VolumeShow.ReadOnly = true;
            VolumeShow.Size = new Size(26, 23);
            VolumeShow.TabIndex = 8;
            VolumeShow.Text = "100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(694, 426);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 10;
            label4.Text = "Made by Wungiel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(VolumeShow);
            Controls.Add(label3);
            Controls.Add(VolumeBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TEXTBOXENG);
            Controls.Add(TTSbuttonENG);
            Controls.Add(TEXTBOXPL);
            Controls.Add(TTSbuttonPL);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "TTS by Wungiel";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)VolumeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TTSbuttonPL;
        private RichTextBox TEXTBOXPL;
        private RichTextBox TEXTBOXENG;
        private Button TTSbuttonENG;
        private Label label1;
        private Label label2;
        private TrackBar VolumeBar;
        private Label label3;
        private TextBox VolumeShow;
        private Label label4;
    }
}