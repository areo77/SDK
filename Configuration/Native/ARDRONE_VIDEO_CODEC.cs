﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARDrone2Client.Common.Configuration.Native
{
    public enum ARDRONE_VIDEO_CODEC : ushort
    {
        ARDRONE_VIDEO_CODEC_UVLC = 0x20,
        ARDRONE_VIDEO_CODEC_P264 = 0x40,
        ARDRONE_VIDEO_CODEC_MP4_360P = 0x80,
        ARDRONE_VIDEO_CODEC_H264_360P = 0x81,
        ARDRONE_VIDEO_CODEC_MP4_360P_H264_720P = 0x82,
        ARDRONE_VIDEO_CODEC_H264_720P = 0x83,
        ARDRONE_VIDEO_CODEC_MP4_360P_SLRS = 0x84,
        ARDRONE_VIDEO_CODEC_H264_360P_SLRS = 0x85,
        ARDRONE_VIDEO_CODEC_H264_720P_SLRS = 0x86,
        ARDRONE_VIDEO_CODEC_H264_AUTO_RESIZE = 0x87,
        ARDRONE_VIDEO_CODEC_MP4_360P_H264_360P = 0x88,
    }
}
