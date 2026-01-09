using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQMonitor.Core.Models
{
    /// <summary>
    /// 스트리밍 데이터의 최소 단위
    /// (DAQ / Feature / AI / Storage 공통)
    /// </summary>
    public sealed class Frame
    {
        public int Sequence { get; }
        public int ChannelCount { get; }
        public int SamplesPerChannel { get; }
        public float[][] Data { get; }

        public Frame(int sequence, float[][] data)
        {
            Sequence = sequence;
            Data = data;
            ChannelCount = data.Length;
            SamplesPerChannel = data[0].Length;
        }
    }
}
