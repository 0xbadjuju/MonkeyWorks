using System;
using System.Runtime.InteropServices;
using MonkeyWorks.Unmanaged.Headers;

namespace MonkeyWorks.Unmanaged.Libraries
{
    public sealed class ktmw32
    {
        [DllImport("Ktmw32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CommitTransaction(
            IntPtr TransactionHandle
        );

        [DllImport("KtmW32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateTransaction(
            ref Winbase._SECURITY_ATTRIBUTES lpTransactionAttributes,
            IntPtr UOW,
            [MarshalAs(UnmanagedType.U4)]
            uint CreateOptions,
            [MarshalAs(UnmanagedType.U4)]
            uint IsolationLevel,
            [MarshalAs(UnmanagedType.U4)]
            uint IsolationFlags,
            [MarshalAs(UnmanagedType.U4)]
            uint Timeout,
            [MarshalAs(UnmanagedType.LPWStr)]
            string Description
        );

        [DllImport("KtmW32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RollbackComplete(
            IntPtr EnlistmentHandle,
            ref ulong TmVirtualClock
        );

        [DllImport("KtmW32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RollbackTransaction(
            IntPtr TransactionHandle
        );

        [DllImport("KtmW32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RollbackTransactionAsync(
            IntPtr TransactionHandle
        );
    }
}