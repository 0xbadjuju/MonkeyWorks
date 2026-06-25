using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Headers
{
    public sealed class Rpcdcep
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _RPC_VERSION
        {
            public ushort MajorVersion;
            public ushort MinorVersion;

            public _RPC_VERSION(ushort major, ushort minor)
            {
                MajorVersion = major;
                MinorVersion = minor;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct _RPC_SYNTAX_IDENTIFIER
        {
            public Guid SyntaxGUID;
            public _RPC_VERSION SyntaxVersion;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct _RPC_CLIENT_INTERFACE
        {
            public uint Length;
            public _RPC_SYNTAX_IDENTIFIER InterfaceId;
            public _RPC_SYNTAX_IDENTIFIER TransferSyntax;
            public IntPtr DispatchTable;
            public uint RpcProtseqEndpointCount;
            public IntPtr RpcProtseqEndpoint;
            public IntPtr Reserved;
            public IntPtr InterpreterInfo;
            public uint Flags;

            public _RPC_CLIENT_INTERFACE(Guid iid, ushort majorVersion, ushort minorVersion)
            {
                Length = (uint)Marshal.SizeOf(typeof(_RPC_CLIENT_INTERFACE));
                InterfaceId = new _RPC_SYNTAX_IDENTIFIER
                {
                    SyntaxGUID = iid,
                    SyntaxVersion = new _RPC_VERSION(majorVersion, minorVersion)
                };
                TransferSyntax = new _RPC_SYNTAX_IDENTIFIER
                {
                    SyntaxGUID = Rpcdce.DceTransferSyntax,
                    SyntaxVersion = new _RPC_VERSION(2, 0)
                };
                DispatchTable = IntPtr.Zero;
                RpcProtseqEndpointCount = 0;
                RpcProtseqEndpoint = IntPtr.Zero;
                Reserved = IntPtr.Zero;
                InterpreterInfo = IntPtr.Zero;
                Flags = 0;
            }
        }
    }
}