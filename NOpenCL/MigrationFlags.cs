﻿/*
 * Copyright (c) 2013 Sam Harwell, Tunnel Vision Laboratories LLC
 * All rights reserved.
 */

namespace NOpenCL
{
    using System;

    /// <summary>
    /// Specifies the options for <see cref="CommandQueue.EnqueueMigrateMemObjects"/>.
    /// </summary>
    [Flags]
    public enum MigrationFlags : ulong
    {
        /// <summary>
        /// No options are specified.
        /// </summary>
        None = 0,

        /// <summary>
        /// This flag indicates that the specified set of memory objects are to be migrated
        /// to the host, regardless of the target command-queue.
        /// </summary>
        Host = 1 << 0,

        /// <summary>
        /// This flag indicates that the contents of the set of memory objects are undefined
        /// after migration. The specified set of memory objects are migrated to the device
        /// associated with the command queue without incurring the overhead of migrating
        /// their contents.
        /// </summary>
        ContentUndefined = 1 << 1,
    }
}
