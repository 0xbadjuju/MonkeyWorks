using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MonkeyWorks.Unmanaged.Libraries
{
    public sealed class ntdsapi
    {
        [DllImport("ntdsapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint DsGetRdnW(
            ref IntPtr ppDN,
            [MarshalAs(UnmanagedType.U4)] ref uint pcDN,
            out IntPtr ppKey,
            [MarshalAs(UnmanagedType.U4)] out uint pcKey,
            out IntPtr ppVal,
            [MarshalAs(UnmanagedType.U4)] out uint pcVal
        );
    }
}
