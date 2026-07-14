using System.Speech.Synthesis;
using System.IO;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace accent


{
    public partial class Echo : Form
    {
        private MMDeviceEnumerator deviceEnumerator;
        private SpeechSynthesizer synth;
        private List<MMDevice> devices;
        public Echo()
        {
            InitializeComponent();
            synth = new SpeechSynthesizer();
            deviceEnumerator = new MMDeviceEnumerator();
            loadVoices();
            loadDevices();
            LoadSettings();
        }

        private void LoadSettings()
        {
            stayOnTop.Checked = Properties.Settings.Default.StayOnTop;
            clearTextBox.Checked = Properties.Settings.Default.ClearTextBox;
            TopMost = stayOnTop.Checked;

            if (Properties.Settings.Default.lastVoice >= 0 &&
                Properties.Settings.Default.lastVoice < voiceComboBox.Items.Count)
            {

            }

            voiceComboBox.SelectedIndex = Properties.Settings.Default.lastVoice;

            if (Properties.Settings.Default.lastDeviceId >= 0 &&
                Properties.Settings.Default.lastDeviceId < outputComboBox.Items.Count)
            {

            }

            outputComboBox.SelectedIndex = Properties.Settings.Default.lastDeviceId;
        }

        private void loadVoices()
        {
            voiceComboBox.Items.Clear();
            foreach (var voice in synth.GetInstalledVoices())
            {
                voiceComboBox.Items.Add(voice.VoiceInfo.Name);
                System.Diagnostics.Debug.WriteLine(voice.VoiceInfo.Name);
            }

        }

        private void loadDevices()
        {
            outputComboBox.Items.Clear();
            devices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToList();

            foreach (var device in devices)
            {
                outputComboBox.Items.Add(device);
            }

        }

        private async void SpeakTo(string text, string deviceId)
        {
            string SelectedVoice = voiceComboBox.Text;

            if (text.Length > 0)
            {
                await Task.Run(() =>
                {
                    using (var ms = new MemoryStream())
                    {
                        var localSynth = new SpeechSynthesizer();
                        localSynth.SetOutputToWaveStream(ms);

                        try { localSynth.SelectVoice(SelectedVoice); }
                        catch
                        {

                        }

                        localSynth.Speak(text);
                        ms.Position = 0;

                        var enumerator = new MMDeviceEnumerator();
                        var device = enumerator.GetDevice(deviceId);

                        using (var reader = new WaveFileReader(ms))
                        using (var outputDevice = new WasapiOut(device, AudioClientShareMode.Shared, true, 200))
                        {
                            outputDevice.Init(reader);
                            outputDevice.Play();
                            while (outputDevice.PlaybackState == PlaybackState.Playing)
                                System.Threading.Thread.Sleep(100);
                        }
                    }
                });
            }
        }

        private void speak()
        {
            var selectedDevice = devices[outputComboBox.SelectedIndex];
            SpeakTo(textBox1.Text, selectedDevice.ID);
            if (clearTextBox.Checked == true)
            {
                textBox1.Clear();
            }
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            speak();
        }

        private void voicesReloadButton_Click(object sender, EventArgs e)
        {
            loadVoices();
        }

        private void voiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(voiceComboBox.Text);
            synth.SelectVoice(voiceComboBox.Text);
            Properties.Settings.Default.lastVoice = voiceComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void outputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastDeviceId = outputComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void stayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = stayOnTop.Checked;
            Properties.Settings.Default.StayOnTop = stayOnTop.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                speak();
            }
        }

        private void clearTextBox_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClearTextBox = clearTextBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void devicesReload_Click(object sender, EventArgs e)
        {
            loadDevices();
        }
    }
}
