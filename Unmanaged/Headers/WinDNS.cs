using System;
using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Headers
{
    //https://learn.microsoft.com/en-us/windows/win32/dns/dns-constants
    public sealed class WinDNS
    {
        [Flags]
        public enum DNS_STATUS : uint 
        {
            DNS_ERROR_RCODE_NO_ERROR = 0,
            DNS_ERROR_RCODE_FORMAT_ERROR = 9001,
            DNS_ERROR_RCODE_SERVER_FAILURE = 9002,
            DNS_ERROR_RCODE_NAME_ERROR = 9003,
            DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004,
            DNS_ERROR_RCODE_REFUSED = 9005
        }
   
        [Flags]
        public enum DnsRecordTypes : ushort
        {
            DNS_TYPE_A = 0x1,
            DNS_TYPE_NS = 0x2,
            DNS_TYPE_MD = 0x3,
            DNS_TYPE_MF = 0x4,
            DNS_TYPE_CNAME = 0x5,
            DNS_TYPE_SOA = 0x6,
            DNS_TYPE_MB = 0x7,
            DNS_TYPE_MG = 0x8,
            DNS_TYPE_MR = 0x9,
            DNS_TYPE_NULL = 0xA,
            DNS_TYPE_WKS = 0xB,
            DNS_TYPE_PTR = 0xC,
            DNS_TYPE_HINFO = 0xD,
            DNS_TYPE_MINFO = 0xE,
            DNS_TYPE_MX = 0xF,
            DNS_TYPE_TEXT = 0x10,
            DNS_TYPE_RP = 0x11,
            DNS_TYPE_AFSDB = 0x12,
            DNS_TYPE_X25 = 0x13,
            DNS_TYPE_ISDN = 0x14,
            DNS_TYPE_RT = 0x15,
            DNS_TYPE_NSAP = 0x16,
            DNS_TYPE_NSAPPTR = 0x17,
            DNS_TYPE_SIG = 0x18,
            DNS_TYPE_KEY = 0x19,
            DNS_TYPE_PX = 0x1A,
            DNS_TYPE_GPOS = 0x1B,
            DNS_TYPE_AAAA = 0x1C,
            DNS_TYPE_LOC = 0x1D,
            DNS_TYPE_NXT = 0x1E,
            DNS_TYPE_EID = 0x1F,
            DNS_TYPE_NIMLOC = 0x20,
            DNS_TYPE_SRV = 0x21,
            DNS_TYPE_ATMA = 0x22,
            DNS_TYPE_NAPTR = 0x23,
            DNS_TYPE_KX = 0x24,
            DNS_TYPE_CERT = 0x25,
            DNS_TYPE_A6 = 0x26,
            DNS_TYPE_DNAME = 0x27,
            DNS_TYPE_SINK = 0x28,
            DNS_TYPE_OPT = 0x29,
            DNS_TYPE_DS = 0x2B,
            DNS_TYPE_RRSIG = 0x2E,
            DNS_TYPE_NSEC = 0x2F,
            DNS_TYPE_DNSKEY = 0x30,
            DNS_TYPE_DHCID = 0x31,
            DNS_TYPE_UINFO = 0x64,
            DNS_TYPE_UID = 0x65,
            DNS_TYPE_GID = 0x66,
            DNS_TYPE_UNSPEC = 0x67,
            DNS_TYPE_ADDRS = 0xF8,
            DNS_TYPE_TKEY = 0xF9,
            DNS_TYPE_TSIG = 0xFA,
            DNS_TYPE_IXFR = 0xFB,
            DNS_TYPE_AXFR = 0xFC,
            DNS_TYPE_MAILB = 0xFD,
            DNS_TYPE_MAILA = 0xFE,
            DNS_TYPE_ALL = 0xFF,
            DNS_TYPE_ANY = 0xFF,
            DNS_TYPE_WINS = 0xFF01,
            DNS_TYPE_WINSR = 0xFF02,
            DNS_TYPE_NBSTAT = DNS_TYPE_WINSR
        }

        [Flags]
        public enum DnsClassTypes
        {
            DNS_CLASS_INTERNET = 0x0001,
            DNS_CLASS_CSNET = 0x0002,
            DNS_CLASS_CHAOS = 0x0003,
            DNS_CLASS_HESIOD = 0x0004,
            DNS_CLASS_NONE = 0x00fe,
            DNS_CLASS_ALL = 0x00ff,
            DNS_CLASS_ANY = 0x00ff
        }

        [Flags]
        public enum DnsQueryTypes
        {
            DNS_OPCODE_QUERY = 0x0000,
            DNS_OPCODE_IQUERY = 0x0001,
            DNS_OPCODE_SERVER_STATUS = 0x0002,
            DNS_OPCODE_UNKNOWN = 0x0003,
            DNS_OPCODE_NOTIFY = 0x0004,
            DNS_OPCODE_UPDATE = 0x0005
        }

        [Flags]
        public enum DnsRecordFlags
        {
            DNSREC_QUESTION	= 0x00000000,
            DNSREC_ANSWER = 0x00000001,
            DNSREC_AUTHORITY = 0x00000002,
            DNSREC_ADDITIONAL = 0x00000003,
            DNSREC_ZONE = 0x00000000,
            DNSREC_PREREQ = 0x00000001,
            DNSREC_UPDATE = 0x00000002,
            DNSREC_DELETE = 0x00000004,
            DNSREC_NOEXIST = 0x00000004
        }

        [Flags]
        public enum DnsQueryOptions : ulong
        {
            DNS_QUERY_STANDARD = 0x0,
            DNS_QUERY_ACCEPT_TRUNCATED_RESPONSE = 0x1,
            DNS_QUERY_USE_TCP_ONLY = 0x2,
            DNS_QUERY_NO_RECURSION = 0x4,
            DNS_QUERY_BYPASS_CACHE = 0x8,
            DNS_QUERY_NO_WIRE_QUERY = 0x10,
            DNS_QUERY_NO_LOCAL_NAME = 0x20,
            DNS_QUERY_NO_HOSTS_FILE = 0x40,
            DNS_QUERY_NO_NETBT = 0x80,
            DNS_QUERY_WIRE_ONLY = 0x100,
            DNS_QUERY_RETURN_MESSAGE = 0x200,
            DNS_QUERY_MULTICAST_ONLY = 0x400,
            DNS_QUERY_NO_MULTICAST = 0x800,
            DNS_QUERY_TREAT_AS_FQDN = 0x1000,
            DNS_QUERY_ADDRCONFIG = 0x2000,
            DNS_QUERY_DUAL_ADDR = 0x4000,
            DNS_QUERY_MULTICAST_WAIT = 0x20000,
            DNS_QUERY_MULTICAST_VERIFY = 0x40000,
            DNS_QUERY_DONT_RESET_TTL_VALUES = 0x100000,
            DNS_QUERY_DISABLE_IDN_ENCODING = 0x200000,
            DNS_QUERY_APPEND_MULTILABEL = 0x800000,
            DNS_QUERY_RESERVED = 0xF0000000
        }

        [Flags]
        public enum DnsUpdateOptions : uint
        {
            DNS_UPDATE_SECURITY_USE_DEFAULT = 0x00000000,
            DNS_UPDATE_SECURITY_OFF = 0x00000010,
            DNS_UPDATE_SECURITY_ON = 0x00000020,
            DNS_UPDATE_SECURITY_ONLY = 0x00000100,
            DNS_UPDATE_CACHE_SECURITY_CONTEXT = 0x00000200,
            DNS_UPDATE_TEST_USE_LOCAL_SYS_ACCT = 0x00000400,
            DNS_UPDATE_FORCE_SECURITY_NEGO = 0x00000800,
            DNS_UPDATE_TRY_ALL_MASTER_SERVERS = 0x00001000,
            DNS_UPDATE_SKIP_NO_UPDATE_ADAPTERS = 0x00002000,
            DNS_UPDATE_REMOTE_SERVER = 0x00004000,
            DNS_UPDATE_RESERVED = 0xffff0000,
        }

        //https://learn.microsoft.com/en-us/windows/win32/api/windns/ne-windns-dns_free_type
        [Flags]
        public enum DNS_FREE_TYPE
        {
            DnsFreeFlat = 0,
            DnsFreeRecordList = 1,
            DnsFreeParsedMessageFields = 2
        }

        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public struct DNS_RECORD
        {
            [FieldOffset(0)] public IntPtr pNext;

            [FieldOffset(8), MarshalAs(UnmanagedType.LPWStr)]
            public string Name;

            [FieldOffset(16)] public DnsRecordTypes wType;

            [FieldOffset(18), MarshalAs(UnmanagedType.I2)]
            public ushort wDataLength;

            [FieldOffset(20)] public int DW;

            [FieldOffset(24), MarshalAs(UnmanagedType.I4)]
            public int dwTtl;

            [FieldOffset(28), MarshalAs(UnmanagedType.I4)]
            public int dwReserved;

            [FieldOffset(32)]
            [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 56 - 32)]
            private byte[] Data;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public delegate void QueryCompletionCallback(IntPtr queryContext, IntPtr queryResults);

        [StructLayout(LayoutKind.Sequential)]
        public struct _DNS_QUERY_REQUEST
        {
            [MarshalAs(UnmanagedType.U4)] public uint Version;
            [MarshalAs(UnmanagedType.LPWStr)] public string QueryName;
            [MarshalAs(UnmanagedType.U2)] public DnsRecordTypes QueryType;
            [MarshalAs(UnmanagedType.U8)] public DnsQueryOptions QueryOptions;
            public IntPtr pDnsServerList;
            [MarshalAs(UnmanagedType.U4)] public uint InterfaceIndex;
            [MarshalAs(UnmanagedType.FunctionPtr)] public QueryCompletionCallback pQueryCompletionCallback;
            public IntPtr pQueryContext;
        }

        public struct _DNS_QUERY_RESULT
        {
            [MarshalAs(UnmanagedType.U4)] public uint Version;
            [MarshalAs(UnmanagedType.U4)] public DNS_STATUS QueryStatus;
            [MarshalAs(UnmanagedType.U8)] public DnsQueryOptions QueryOptions;
            public IntPtr pQueryRecords;
            public IntPtr Reserved;
        }

        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public struct DNS_QUERY_CANCEL
        {
            [FieldOffset(0), MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 32)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_A_DATA
        {
            [MarshalAs(UnmanagedType.U4)] public uint ipv4Address;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_AAAA_DATA
        {
            [MarshalAs(UnmanagedType.U4)] public uint Ip6Address0;
            [MarshalAs(UnmanagedType.U4)] public uint Ip6Address1;
            [MarshalAs(UnmanagedType.U4)] public uint Ip6Address2;
            [MarshalAs(UnmanagedType.U4)] public uint Ip6Address3;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_MX_DATAA
        {
            [MarshalAs(UnmanagedType.LPStr)] public string pNameExchange;
            [MarshalAs(UnmanagedType.U2)] public ushort wPreference;
            [MarshalAs(UnmanagedType.U2)] public ushort Pad;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_MX_DATAW
        {
            [MarshalAs(UnmanagedType.LPWStr)] public string pNameExchange;
            [MarshalAs(UnmanagedType.U2)] public ushort wPreference;
            [MarshalAs(UnmanagedType.U2)] public ushort Pad;
        }

        //DNS_TXT_DATAA
        //DNS_TXT_DATAW
        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_TXT_DATA
        {
            [MarshalAs(UnmanagedType.U4)] public uint StringCount;
            public IntPtr StringArray;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_SRV_DATAA
        {
            [MarshalAs(UnmanagedType.LPStr)] public string pNameTarget;
            [MarshalAs(UnmanagedType.I2)] public ushort wPriority;
            [MarshalAs(UnmanagedType.I2)] public ushort wWeight;
            [MarshalAs(UnmanagedType.I2)] public ushort wPort;
            [MarshalAs(UnmanagedType.I2)] public ushort Pad;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_SRV_DATAW
        {
            [MarshalAs(UnmanagedType.LPWStr)] public string pNameTarget;
            [MarshalAs(UnmanagedType.I2)] public ushort wPriority;
            [MarshalAs(UnmanagedType.I2)] public ushort wWeight;
            [MarshalAs(UnmanagedType.I2)] public ushort wPort;
            [MarshalAs(UnmanagedType.I2)] public ushort Pad;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_PTR_DATAA
        {
            [MarshalAs(UnmanagedType.LPStr)] public string pNameHost;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DNS_PTR_DATAW
        {
            [MarshalAs(UnmanagedType.LPWStr)] public string pNameHost;
        }
    }
}