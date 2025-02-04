using MonkeyWorks.Unmanaged.Headers;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MonkeyWorks.Unmanaged.Libraries
{
    public sealed class psapi
    {
        
        [DllImport("Psapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint GetModuleFileNameExW(
            IntPtr hProcess,
            IntPtr hModule,
            [MarshalAs(UnmanagedType.LPWStr)] 
            StringBuilder lpFilename,
            [MarshalAs(UnmanagedType.U4)]
            uint nSize
        );

        [DllImport("Psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumProcessModulesEx(
            IntPtr hProcess,
            IntPtr[] lphModule,
            [MarshalAs(UnmanagedType.U4)]
            uint cb,
            [MarshalAs(UnmanagedType.U4)]
            out uint lpcbNeeded,
            [MarshalAs(UnmanagedType.U4)]
            uint dwFilterFlag
        );

        [DllImport("Psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetModuleInformation(
            IntPtr hProcess,
            IntPtr hModule,
            ref Psapi._MODULEINFO lpmodinfo,
            [MarshalAs(UnmanagedType.U4)]
            uint cb
        );
    }
}
