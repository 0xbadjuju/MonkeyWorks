using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MonkeyWorks.Unmanaged.Headers
{
    public class Psapi
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _MODULEINFO
        {
            public UIntPtr lpBaseOfDll;
            public uint SizeOfImage;
            public UIntPtr EntryPoint;
        }
    }
}
