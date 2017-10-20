﻿using System;

namespace Popcorn.Vlc
{
    public class VlcSettingsAttribute : Attribute
    {
        public VlcSettingsAttribute(String vlcPath) : this(vlcPath, null)
        {
        }

        public VlcSettingsAttribute(String vlcPath, params String[] option)
        {
            LibVlcPath = vlcPath;
            VlcOption = option;
        }

        public String LibVlcPath { get; set; }

        public String[] VlcOption { get; set; }
    }
}