using MonkeyWorks.Unmanaged.Headers;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MonkeyWorks.Unmanaged.Libraries
{
    public sealed class rpcrt4
    {
        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NdrClientCall2x86(
            IntPtr pStubDesc, 
            IntPtr pProcFormat, 
            IntPtr pArgs
        );

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern IntPtr NdrClientCall2x64(
            IntPtr pStubDesc,
            IntPtr pProcFormat,
            IntPtr binding,
            IntPtr phContext,
            [MarshalAs(UnmanagedType.LPWStr)]
            string fileName,
            int flags
        );

        [DllImport("rpcrt4.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint RpcStringBindingComposeW(
            [MarshalAs(UnmanagedType.LPWStr)] 
            string ObjectUuid,
            [MarshalAs(UnmanagedType.LPWStr)] 
            string ProtocolSequence,
            [MarshalAs(UnmanagedType.LPWStr)] 
            string NetworkAddress,
            [MarshalAs(UnmanagedType.LPWStr)] 
            string Endpoint,
            [MarshalAs(UnmanagedType.LPWStr)] 
            string Options,
            out IntPtr StringBinding
        );

        [DllImport("rpcrt4.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint RpcBindingFromStringBindingW(
            IntPtr StringBinding, 
            out IntPtr Binding
        );

        [DllImport("rpcrt4.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint RpcBindingSetAuthInfoW(
            IntPtr Binding,
            [MarshalAs(UnmanagedType.LPWStr)] 
            string AuthServer,
            Rpcdce.AUTHENTICATION_SERVICE_CONSTANTS AuthLevel,
            Rpcdce.AUTHENTICATION_SERVICE_CONSTANTS AuthService,
            int AuthIdentity,
            uint AuthzNone
        );

        [DllImport("rpcrt4.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint RpcBindingSetOption(
            IntPtr Binding, 
            [MarshalAs(UnmanagedType.U4)]
            uint Option, 
            IntPtr Value
        );

        [DllImport("rpcrt4.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint RpcStringFreeA(
            ref IntPtr StringBinding
        );

        [DllImport("rpcrt4.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint RpcStringFreeW(
            ref IntPtr StringBinding
        );

        [DllImport("rpcrt4.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint RpcBindingFree(
            ref IntPtr Binding
        );
    }
}