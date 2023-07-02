using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;


namespace TTSandSTT
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer synthesizer;
        public Form1()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void TTSbutton_Click(object sender, EventArgs e)
        {
            string text = TEXTBOXPL.Text;

            int volume = VolumeBar.Value; // Pobierz wartoœæ g³oœnoœci z TrackBar

            synthesizer.Volume = volume; // Ustaw g³oœnoœæ na wartoœæ pobran¹ z TrackBar

            //zmiana jezyku
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pl-PL"));


            using (MemoryStream stream = new MemoryStream())
            {
                synthesizer.SetOutputToWaveStream(stream);
                synthesizer.Speak(text);
                stream.Position = 0;

                using (var player = new System.Media.SoundPlayer(stream))
                {
                    player.Play();
                }
            }
        }

        private void TTSbuttonENG_Click(object sender, EventArgs e)
        {
            string text = TEXTBOXENG.Text;
            int volume = VolumeBar.Value; // Pobierz wartoœæ g³oœnoœci z TrackBar

            synthesizer.Volume = volume; // Ustaw g³oœnoœæ na wartoœæ pobran¹ z TrackBar

            //zmiana jezyku
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("en-US"));

            using (MemoryStream stream = new MemoryStream())
            {
                synthesizer.SetOutputToWaveStream(stream);
                synthesizer.Speak(text);
                stream.Position = 0;

                using (var player = new System.Media.SoundPlayer(stream))
                {
                    player.Play();
                }
            }
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            VolumeShow.Text = VolumeBar.Value.ToString();
        }
    }
}