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
using NAudio.Dsp;
using NAudio.Wave;

namespace DSound
{
    public partial class mainWindow : Form
    {
        private IWavePlayer _waveOutDevice;
        private AudioFileReader _audioFileReader;
        private List<BiQuadFilter[]> _filters;
        private ISampleProvider _filtered;

        private bool _playing;

        public mainWindow()
        {
            InitializeComponent();

            _filters = new List<BiQuadFilter[]>();

            _playing = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _audioFileReader = new AudioFileReader(openFileDialog.FileName);
                waveViewer.WaveStream = new MediaFoundationReader(openFileDialog.FileName);
                waveViewer.FitToScreen();

                _playing = false;
                playButton.Text = "Play";

                Reevaluate();
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
            playButton.Text = "Play";
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonHighPass_Click(object sender, EventArgs e)
        {
            try
            {
                _filters.Add(Filters.Filter.CreateFiltersTable(BiQuadFilter.HighPassFilter(_audioFileReader.WaveFormat.SampleRate, (float)CutoffNumeric.Value, (float)QNumeric.Value), _audioFileReader.WaveFormat.Channels));
                Reevaluate();
            }
            catch(Exception ex)
            { }
        }

        private void buttonLowPass_Click(object sender, EventArgs e)
        {
            try
            {
                _filters.Add(
                    Filters.Filter.CreateFiltersTable(
                        BiQuadFilter.LowPassFilter(_audioFileReader.WaveFormat.SampleRate, (float) CutoffNumeric.Value,
                            (float) QNumeric.Value), _audioFileReader.WaveFormat.Channels));
                Reevaluate();
            }
            catch(Exception ex)
            { }
            
        }

        private void Reevaluate()
        {
            var _filtered = new Filters.Filter(_audioFileReader, _filters);

            if (_waveOutDevice != null)
                _waveOutDevice.Dispose();
            _waveOutDevice = new WasapiOut();

            _waveOutDevice.Init(_filtered);

            _playing = false;
            playButton.Text = "Play";
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            try
            {
                _filters.Clear();
                Reevaluate();
            }
            catch(Exception ex)
            { }
        }

        private void buttonCPG_Click(object sender, EventArgs e)
        {
            try
            {
                _filters.Add(
                    Filters.Filter.CreateFiltersTable(
                        BiQuadFilter.BandPassFilterConstantPeakGain(_audioFileReader.WaveFormat.SampleRate, (float)CutoffNumeric.Value,
                            (float)QNumeric.Value), _audioFileReader.WaveFormat.Channels));
                Reevaluate();
            }
            catch (Exception ex)
            { }
        }

        private void buttonCSG_Click(object sender, EventArgs e)
        {
            try
            {
                _filters.Add(
                    Filters.Filter.CreateFiltersTable(
                        BiQuadFilter.BandPassFilterConstantSkirtGain(_audioFileReader.WaveFormat.SampleRate, (float)CutoffNumeric.Value,
                            (float)QNumeric.Value), _audioFileReader.WaveFormat.Channels));
                Reevaluate();
            }
            catch (Exception ex)
            { }
        }
    }
}
