using System;
using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Headers
{
    public sealed class WinEfs
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct EFS_RPC_BLOB
        {
            [MarshalAs(UnmanagedType.U4)]
            public uint CbData;
            public IntPtr BData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ENCRYPTION_CERTIFICATE_HASH_LIST
        {
            [MarshalAs(UnmanagedType.U4)]
            public uint NCertHash;
            public IntPtr Users;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ENCRYPTION_CERTIFICATE_LIST
        {
            [MarshalAs(UnmanagedType.U4)]
            public uint NUsers;
            public IntPtr Users;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ENCRYPTED_FILE_METADATA_SIGNATURE
        {
            [MarshalAs(UnmanagedType.U4)]
            public uint DwEfsAccessType;
            public IntPtr CertificatesAdded;
            public IntPtr EncryptionCertificate;
            public IntPtr EfsStreamSignature;
        }
    }
}
