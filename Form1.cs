using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace DSound
{
    public partial class mainWindow : Form
    {
        private IWavePlayer _waveOutDevice;
        //private AudioFileReader _audioFileReader;
        private WaveFileReader _audioFileReader;

        private Boolean _playing;

        public mainWindow()
        {
            InitializeComponent();

            _waveOutDevice = new WaveOut();
            _playing = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _audioFileReader = new WaveFileReader(openFileDialog.FileName);
                waveViewer.WaveStream = new WaveFileReader(openFileDialog.FileName);
                waveViewer.FitToScreen();

                _waveOutDevice.Init(_audioFileReader);
                playButton.Text = "Play";
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if(_audioFileReader != null)
            {
                if (!_playing)
                {
                    _waveOutDevice.Play();
                    _playing = true;
                    playButton.Text = "Pause";
                }
                else
                {
                    _waveOutDevice.Pause();
                    _playing = false;
                    playButton.Text = "Play";
                }
            }
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _playing = false;
            if (_waveOutDevice != null)
            {
                _waveOutDevice.Stop();
                if (_audioFileReader != null)
                    _audioFileReader.Position = 0;
            }
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_audioFileReader != null)
            {
                _audioFileReader.Dispose();
                _audioFileReader = null;
            }
            if (_waveOutDevice != null)
            {
                _waveOutDevice.Dispose();
                _waveOutDevice = null;
            }
        }
    }
}
