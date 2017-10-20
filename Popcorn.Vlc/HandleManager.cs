﻿using System;
using System.Collections.Generic;

namespace Popcorn.Vlc
{
    internal static class HandleManager
    {
        private static readonly Dictionary<IntPtr, IVlcObject> HandleDic = new Dictionary<IntPtr, IVlcObject>();

        public static IVlcObject GetVlcObject(IntPtr pointer)
        {
            if (HandleDic.ContainsKey(pointer))
            {
                return HandleDic[pointer];
            }
            return null;
        }

        public static void Add(IVlcObject vlcObject)
        {
            if (!HandleDic.ContainsKey(vlcObject.InstancePointer))
            {
                HandleDic.Add(vlcObject.InstancePointer, vlcObject);
            }
        }

        public static void Remove(IVlcObject vlcObject)
        {
            if (HandleDic.ContainsKey(vlcObject.InstancePointer))
            {
                HandleDic.Remove(vlcObject.InstancePointer);
            }
        }
    }
}