using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Headers
{
    public sealed class Rpcdce
    {
        public static readonly Guid EfsInterfaceId = new Guid("df1941c5-fe89-4e79-bf10-463657acf44d");
        public static readonly Guid DceTransferSyntax = new Guid("8A885D04-1CEB-11C9-9FE8-08002B104860");

        public static readonly byte[] MIDL_ProcFormatStringx64 =
        {
            0x00, 0x00,
            0x00, 0x48,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00,
            0x28, 0x00,
            0x32, 0x00,
            0x00, 0x00,
            0x08, 0x00,
            0x40, 0x00,
            0x46, 0x04,
            0x0a, 0x41,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x10, 0x01, 0x08, 0x00, 0x06, 0x00,
            0x0b, 0x01, 0x10, 0x00, 0x0c, 0x00,
            0x48, 0x00, 0x18, 0x00, 0x08, 0x00,
            0x70, 0x00, 0x20, 0x00, 0x08, 0x00
        };

        public static readonly byte[] MIDL_TypeFormatStringx64 =
        {
            0x00, 0x00, 0x00, 0x00, 0x11, 0x04, 0x02, 0x00,
            0x30, 0xa0, 0x00, 0x00, 0x11, 0x08, 0x25, 0x5c,
            0x00, 0x00
        };

        public static readonly byte[] MIDL_TypeFormatStringx86 =
        {
            0x00, 0x00, 0x00, 0x00, 0x11, 0x04, 0x02, 0x00,
            0x30, 0xa0, 0x00, 0x00, 0x11, 0x08, 0x25, 0x5c,
            0x00, 0x00
        };

        public static readonly byte[] MIDL_ProcFormatStringx86 =
        {
            0x00, 0x00,
            0x00, 0x48,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00,
            0x10, 0x00,
            0x32, 0x00,
            0x00, 0x00,
            0x08, 0x00,
            0x24, 0x00,
            0x46, 0x04,
            0x08, 0x01,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x10, 0x01, 0x04, 0x00, 0x06, 0x00,
            0x0b, 0x01, 0x08, 0x00, 0x0c, 0x00,
            0x48, 0x00, 0x0c, 0x00, 0x08, 0x00,
            0x70, 0x00, 0x10, 0x00, 0x08, 0x00
        };

        public const uint RPC_C_AUTHZ_NONE = 0;
        public const uint RPC_C_AUTHZ_NAME = 1;
        public const uint RPC_C_AUTHZ_DCE = 2;
        public const uint RPC_C_AUTHZ_DEFAULT = 0xffffffff;

        public enum AUTHENTICATION_SERVICE_CONSTANTS : uint
        {
            [Description("No authentication.")]
            RPC_C_AUTHN_NONE = 0,

            [Description("Same as RPC_C_AUTHN_LEVEL_CONNECT.")]
            RPC_C_AUTHN_LEVEL_DEFAULT = 0,

            [Description("Use Distributed Computing Environment (DCE) private key authentication.")]
            RPC_C_AUTHN_DCE_PRIVATE = 1,

            [Description("No authentication.")]
            RPC_C_AUTHN_LEVEL_NONE = 1,

            [Description("DCE public key authentication (reserved for future use).")]
            RPC_C_AUTHN_DCE_PUBLIC = 2,

            [Description("Authenticates the credentials of the client and server.")]
            RPC_C_AUTHN_LEVEL_CONNECT = 2,

            [Description("Same as RPC_C_AUTHN_LEVEL_PKT.")]
            RPC_C_AUTHN_LEVEL_CALL = 3,

            [Description("DEC public key authentication (reserved for future use).")]
            RPC_C_AUTHN_DEC_PUBLIC = 4,

            [Description("Same as RPC_C_AUTHN_LEVEL_CONNECT but also prevents replay attacks.")]
            RPC_C_AUTHN_LEVEL_PKT = 4,

            [Description("Same as RPC_AUTHN_LEVEL_PKT but also ensures that the data transferred can only be seen unencrypted by the client and server.")]
            RPC_C_AUTHN_LEVEL_PKT_INTEGRITY = 5,

            [Description("Same as RPC_AUTHN_LEVEL_PKT_INTEGRITY but also ensures that the data transferred can only be seen unencrypted by the client and server.")]
            RPC_C_AUTHN_LEVEL_PKT_PRIVACY = 6,

            [Description("Use the Microsoft Negotiate SSP. This SSP negotiates between the use of the NTLM and Kerberos protocol Security Support Providers (SSP).")]
            RPC_C_AUTHN_GSS_NEGOTIATE = 9,

            [Description("Use the Microsoft NT LAN Manager (NTLM) SSP.")]
            RPC_C_AUTHN_WINNT = 10,

            [Description("Use the Schannel SSP. This SSP supports Secure Socket Layer (SSL), private communication technology (PCT), and transport level security (TLS).")]
            RPC_C_AUTHN_GSS_SCHANNEL = 14,

            [Description("Use the Microsoft Kerberos SSP.")]
            RPC_C_AUTHN_GSS_KERBEROS = 16,

            [Description("Use Distributed Password Authentication (DPA).")]
            RPC_C_AUTHN_DPA = 17,

            [Description("Authentication protocol SSP used for the Microsoft Network (MSN).")]
            RPC_C_AUTHN_MSN = 18,

            [Description("Windows XP or later: Use the Microsoft Digest SSP")]
            RPC_C_AUTHN_DIGEST = 21,

            [Description("Windows 7 or later: Reserved. Do not use")]
            RPC_C_AUTHN_NEGO_EXTENDER = 30,

            [Description("This SSP provides an SSPI-compatible wrapper for the Microsoft Message Queue (MSMQ) transport-level protocol.")]
            RPC_C_AUTHN_MQ = 100,

            [Description("Use the default authentication.")]
            RPC_C_AUTHN_DEFAULT = 0xffffffff,        
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct _GUID
        {
            internal int Data1;
            internal short Data2;
            internal short Data3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            internal byte[] Data4;
        }
    }
}