using DAQMonitor.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQMonitor.Core.Services
{
    /// <summary>
    /// 실제 DAQ 교체 전까지 사용하는 가짜 스트리머
    /// 항상 실행 가능 보장
    /// </summary>
    public sealed class DummyDaqWorker
    {
        public event Action<Frame>? FrameReady;

        private Thread? _thread;
        private bool _running;
        private int _seq;

        public int SampleRate { get; } = 12800;
        public int FrameSamples { get; } = 256;

        public void Start()
        {
            if (_running) return;

            _running = true;
            _thread = new Thread(Loop)
            {
                IsBackground = true,
                Name = "DummyDAQ"
            };
            _thread.Start();
        }

        public void Stop()
        {
            _running = false;
        }

        private void Loop()
        {
            var rnd = new Random();

            while (_running)
            {
                float[][] data =
                {
                    new float[FrameSamples],
                    new float[FrameSamples],
                    new float[FrameSamples]
                };

                for (int i = 0; i < FrameSamples; i++)
                {
                    data[0][i] = (float)Math.Sin(2 * Math.PI * 50 * i / SampleRate);
                    data[1][i] = (float)Math.Cos(2 * Math.PI * 50 * i / SampleRate);
                    data[2][i] = (float)(rnd.NextDouble() * 0.05);
                }

                FrameReady?.Invoke(new Frame(++_seq, data));

                Thread.Sleep(FrameSamples * 1000 / SampleRate);
            }

            
        }

    }
}
