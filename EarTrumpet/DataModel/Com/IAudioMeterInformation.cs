﻿using System.Runtime.InteropServices;

namespace EarTrumpet.DataModel.Com
{
    [Guid("C02216F6-8C67-4B5B-9D00-D008E73E0064")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAudioMeterInformation
    {
        void GetPeakValue(out float pfPeak);
        void GetMeteringChannelCount(out uint pnChannelCount);
        void GetChannelsPeakValues(uint u32ChannelCount, out float afPeakValues);
        void QueryHardwareSupport(out uint pdwHardwareSupportMask);
    }
}