using MonkeyWorks.Unmanaged.Headers;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MonkeyWorks.Unmanaged.Libraries
{
    class DismApi
    {
        [DllImport("DismApi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public extern static uint DismInitialize(
            DismAPI.DismLogLevel LogLevel,
            [MarshalAs(UnmanagedType.LPWStr)] string LogFilePath,
            [MarshalAs(UnmanagedType.LPWStr)] string ScratchDirectory
        );

        [DllImport("DismApi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public extern static uint DismOpenSession(
            [MarshalAs(UnmanagedType.LPWStr)] string ImagePath,
            [MarshalAs(UnmanagedType.LPWStr)] string WindowsDirectory,
            [MarshalAs(UnmanagedType.LPWStr)] string SystemDrive,
            [MarshalAs(UnmanagedType.U4)] out uint Session
        );

        [DllImport("DismApi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public extern static uint DismGetCapabilities(
            [MarshalAs(UnmanagedType.U4)] uint Session,
            IntPtr Capability,
            [MarshalAs(UnmanagedType.U4)] out uint Count
        );

        [DllImport("DismApi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public extern static uint DismGetFeatures(
            [MarshalAs(UnmanagedType.U4)] uint Session,
            [MarshalAs(UnmanagedType.LPWStr)] string Identifier,
            DismAPI.DismPackageIdentifier PackageIdentifier,
            out IntPtr Feature,
            [MarshalAs(UnmanagedType.U4)] out uint Count
        );
    }
}
