﻿/*
 * Copyright (c) 2013 Sam Harwell, Tunnel Vision Laboratories LLC
 * All rights reserved.
 */

namespace NOpenCL
{
    using System;

    [Flags]
    public enum FloatingPointConfiguration : ulong
    {
        None = 0,
        Denorm = 1 << 0,
        InfNaN = 1 << 1,
        RoundToNearest = 1 << 2,
        RoundToZero = 1 << 3,
        RoundToInf = 1 << 4,
        Fma = 1 << 5,
        SoftFloat = 1 << 6,
        CorrectlyRoundedDivideSqrt = 1 << 7,
    }
}
