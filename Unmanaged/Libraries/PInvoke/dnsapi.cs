using MonkeyWorks.Unmanaged.Headers;
using System;
using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Libraries
{
    public sealed class dnsapi
    {
        [DllImport("dnsapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern WinDNS.DNS_STATUS DnsQueryEx(
            IntPtr pQueryRequest, 
            IntPtr pQueryResults, 
            IntPtr pCancelHandle
        );

        [DllImport("dnsapi.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern WinDNS.DNS_STATUS DnsQuery_A(
            [MarshalAs(UnmanagedType.LPStr)] string lpstrName,
            [MarshalAs(UnmanagedType.U2)] WinDNS.DnsRecordTypes wType,
            [MarshalAs(UnmanagedType.U4)] WinDNS.DnsQueryOptions options,
            IntPtr pExtra,
            ref IntPtr ppQueryResultsSet,
            IntPtr pReserved
        );

        [DllImport("dnsapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern WinDNS.DNS_STATUS DnsQuery_W(
            [MarshalAs(UnmanagedType.LPWStr)] string pszName,
            [MarshalAs(UnmanagedType.U2)] WinDNS.DnsRecordTypes wType,
            [MarshalAs(UnmanagedType.U4)] WinDNS.DnsQueryOptions Options,
            IntPtr pExtra,
            ref IntPtr ppQueryResultsSet,
            IntPtr pReserved
        );

        //https://www.pinvoke.net/default.aspx/dnsapi/DnsQueryEx.html
        [DllImport("dnsapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern void DnsRecordListFree(
            IntPtr pRecordList, 
            WinDNS.DNS_FREE_TYPE FreeType
        );

        [DllImport("dnsapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern WinDNS.DNS_STATUS DnsCancelQuery(
            WinDNS.DNS_QUERY_CANCEL cancel
        );  
    }
}
