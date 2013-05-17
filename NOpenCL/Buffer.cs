﻿namespace NOpenCL
{
    using System;

    public sealed class Buffer : MemObject<BufferSafeHandle>
    {
        private readonly Buffer _parent;

        internal Buffer(Context context, BufferSafeHandle handle)
            : base(context, handle)
        {
        }

        internal Buffer(Context context, Buffer parent, BufferSafeHandle handle)
            : base(context, handle)
        {
            if (parent == null)
                throw new ArgumentNullException("parent");

            _parent = parent;
        }

        public Buffer AssociatedMemObject
        {
            get
            {
                return _parent;
            }
        }

        public UIntPtr Offset
        {
            get
            {
                return UnsafeNativeMethods.GetMemObjectInfo(Handle, UnsafeNativeMethods.MemObjectInfo.Offset);
            }
        }

        public Buffer CreateSubBuffer(MemoryFlags flags, BufferRegion regionInfo)
        {
            BufferSafeHandle subBuffer = UnsafeNativeMethods.CreateSubBuffer(Handle, flags, regionInfo);
            return new Buffer(Context, this, subBuffer);
        }
    }
}