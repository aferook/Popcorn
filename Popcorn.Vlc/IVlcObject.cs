﻿using System;

namespace Popcorn.Vlc
{
    /// <summary>
    ///     A Vlc unmanaged object.
    /// </summary>
    public interface IVlcObject : IDisposable
    {
        /// <summary>
        ///     A pointer of this Vlc object.
        /// </summary>
        IntPtr InstancePointer { get; }

        /// <summary>
        ///     A relation <see cref="Vlc" /> of this object.
        /// </summary>
        Vlc VlcInstance { get; }
    }

    /// <summary>
    ///     A Vlc unmanaged object with Vlc event system.
    /// </summary>
    public interface IVlcObjectWithEvent : IVlcObject
    {
        /// <summary>
        ///     Vlc event manager.
        /// </summary>
        VlcEventManager EventManager { get; }
    }
}