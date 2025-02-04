using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MonkeyWorks.Unmanaged.Libraries 
{
    public sealed class kernelbase
    {
        [DllImport("kernelbase.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint GetFileVersionInfoSizeW(
            [MarshalAs(UnmanagedType.LPWStr)] 
            StringBuilder lptstrFilename,
            [MarshalAs(UnmanagedType.U4)]
            ref uint lpdwHandle
        );

        [DllImport("kernelbase.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileVersionInfoW(
            [MarshalAs(UnmanagedType.LPWStr)] 
            StringBuilder lptstrFilename,
            [MarshalAs(UnmanagedType.U4)]
            uint dwHandle,
            [MarshalAs(UnmanagedType.U4)]
            uint dwLen,
            IntPtr lpData
        );

        [DllImport( "kernelbase.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerQueryValueW(
            IntPtr pBlock,
            [MarshalAs(UnmanagedType.LPWStr)] 
            StringBuilder lpSubBlock,
            ref IntPtr lplpBuffer,
            [MarshalAs(UnmanagedType.U4)]
            ref uint puLen
        );
    }
}
