using MonkeyWorks.Unmanaged.Headers;
using System;
using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Libraries
{
    public sealed class rpcrt4
    {
        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcOpenFileRaw(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr hContext, IntPtr fileName, IntPtr flags);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcEncryptFileSrv(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcDecryptFileSrv(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr openFlag);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcQueryUsersOnFile(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr users);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcQueryRecoveryAgents(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr recoveryAgents);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcRemoveUsersFromFile(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr users);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcAddUsersToFile(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr encryptionCertificates);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcFileKeyInfo(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr infoClass, IntPtr keyInfo);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcDuplicateEncryptionInfoFile(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr srcFileName, IntPtr destFileName,
            IntPtr dwCreationDisposition, IntPtr dwAttributes, IntPtr relativeSd, IntPtr bInheritHandle);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcAddUsersToFileEx(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr dwFlags, IntPtr reserved,
            IntPtr fileName, IntPtr encryptionCertificates);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcFileKeyInfoEx(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr dwFileKeyInfoFlags, IntPtr reserved,
            IntPtr fileName, IntPtr infoClass, IntPtr keyInfo);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcGetEncryptedFileMetadata(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr efsStreamBlob);

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr EfsRpcSetEncryptedFileMetadata(
            IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr oldEfsStreamBlob,
            IntPtr newEfsStreamBlob, IntPtr newEfsSignature);

        internal static class X86
        {
            public static IntPtr EfsRpcOpenFileRaw(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr hContext, IntPtr fileName, IntPtr flags) =>
                Invoke(stub, format, hBinding, hContext, fileName, flags);

            public static IntPtr EfsRpcEncryptFileSrv(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName) =>
                Invoke(stub, format, hBinding, fileName);

            public static IntPtr EfsRpcDecryptFileSrv(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr openFlag) =>
                Invoke(stub, format, hBinding, fileName, openFlag);

            public static IntPtr EfsRpcQueryUsersOnFile(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr users) =>
                Invoke(stub, format, hBinding, fileName, users);

            public static IntPtr EfsRpcQueryRecoveryAgents(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr recoveryAgents) =>
                Invoke(stub, format, hBinding, fileName, recoveryAgents);

            public static IntPtr EfsRpcRemoveUsersFromFile(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr users) =>
                Invoke(stub, format, hBinding, fileName, users);

            public static IntPtr EfsRpcAddUsersToFile(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr encryptionCertificates) =>
                Invoke(stub, format, hBinding, fileName, encryptionCertificates);

            public static IntPtr EfsRpcFileKeyInfo(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr infoClass, IntPtr keyInfo) =>
                Invoke(stub, format, hBinding, fileName, infoClass, keyInfo);

            public static IntPtr EfsRpcDuplicateEncryptionInfoFile(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr srcFileName, IntPtr destFileName,
                IntPtr dwCreationDisposition, IntPtr dwAttributes, IntPtr relativeSd, IntPtr bInheritHandle) =>
                Invoke(stub, format, hBinding, srcFileName, destFileName, dwCreationDisposition, dwAttributes, relativeSd, bInheritHandle);

            public static IntPtr EfsRpcAddUsersToFileEx(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr dwFlags, IntPtr reserved,
                IntPtr fileName, IntPtr encryptionCertificates) =>
                Invoke(stub, format, hBinding, dwFlags, reserved, fileName, encryptionCertificates);

            public static IntPtr EfsRpcFileKeyInfoEx(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr dwFileKeyInfoFlags, IntPtr reserved,
                IntPtr fileName, IntPtr infoClass, IntPtr keyInfo) =>
                Invoke(stub, format, hBinding, dwFileKeyInfoFlags, reserved, fileName, infoClass, keyInfo);

            public static IntPtr EfsRpcGetEncryptedFileMetadata(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr efsStreamBlob) =>
                Invoke(stub, format, hBinding, fileName, efsStreamBlob);

            public static IntPtr EfsRpcSetEncryptedFileMetadata(
                IntPtr stub, IntPtr format, IntPtr hBinding, IntPtr fileName, IntPtr oldEfsStreamBlob,
                IntPtr newEfsStreamBlob, IntPtr newEfsSignature) =>
                Invoke(stub, format, hBinding, fileName, oldEfsStreamBlob, newEfsStreamBlob, newEfsSignature);

            private static IntPtr Invoke(IntPtr stub, IntPtr format, params IntPtr[] args)
            {
                GCHandle argsHandle = GCHandle.Alloc(args, GCHandleType.Pinned);
                try
                {
                    return rpcrt4.NdrClientCall2x86(stub, format, argsHandle.AddrOfPinnedObject());
                }
                finally
                {
                    argsHandle.Free();
                }
            }
        }

        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientCall2", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NdrClientCall2x86(
            IntPtr pStubDesc, 
            IntPtr pProcFormat, 
            IntPtr pArgs
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