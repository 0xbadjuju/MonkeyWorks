﻿using System;

namespace MonkeyWorks.SMB.SMB2
{
    sealed class SMB2CloseRequest
    {
        private readonly Byte[] StructureSize = { 0x18, 0x00 };
        private readonly Byte[] Flags = { 0x00, 0x00 };
        private readonly Byte[] Reserved = { 0x00, 0x00, 0x00, 0x00 };
        private Byte[] FileID = new Byte[16];

        internal SMB2CloseRequest()
        {

        }

        internal void SetFileID(Byte[] FileID)
        {
            if (FileID.Length == this.FileID.Length)
            {
                this.FileID = FileID;
            }
        }

        internal Byte[] GetRequest()
        {
            Byte[] request = Combine.combine(StructureSize, Flags);
            request = Combine.combine(request, Reserved);
            return Combine.combine(request, FileID);
        }
    }
}
