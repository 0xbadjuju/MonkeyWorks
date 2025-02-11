using System;

namespace MonkeyWorks.Unmanaged.Headers
{
    public sealed class LmJoin
    {
        [Flags]
        public enum NetJoinStatus
        {
            NetSetupUnknownStatus = 0,
            NetSetupUnjoined,
            NetSetupWorkgroupName,
            NetSetupDomainName
        }
    }
}
