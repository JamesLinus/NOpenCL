﻿/*
 * Copyright (c) 2013 Sam Harwell, Tunnel Vision Laboratories LLC
 * All rights reserved.
 */

namespace NOpenCL
{
    public enum PartitionProperty
    {
        PartitionEqually = 0x1086,
        PartitionByCounts = 0x1087,
        PartitionByCountsListEnd = 0x0000,
        PartitionByAffinityDomain = 0x1088,
    }
}
