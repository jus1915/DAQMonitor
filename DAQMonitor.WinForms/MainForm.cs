using DAQMonitor.Core.Models;
using DAQMonitor.Core.Services;

namespace DAQMonitor.WinForms;

public partial class MainForm : Form
{
    private readonly DummyDaqWorker _daq;

    public MainForm()
    {
        InitializeComponent();

        _daq = new DummyDaqWorker();
        _daq.FrameReady += OnFrameReady;
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        _daq.Start();
        lblStatus.Text = "Running...";
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        _daq.Stop();
        lblStatus.Text = "Stopped";
    }

    private void OnFrameReady(Frame frame)
    {
        if (InvokeRequired)
        {
            BeginInvoke(() => OnFrameReady(frame));
            return;
        }

        lblFrame.Text =
            $"Seq: {frame.Sequence} | " +
            $"Ch: {frame.ChannelCount} | " +
            $"Samples: {frame.SamplesPerChannel}";
    }
}
