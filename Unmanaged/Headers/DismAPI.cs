using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MonkeyWorks.Unmanaged.Headers
{
    public sealed class DismAPI
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
        public struct DismCapability
        {
            public string Name;
            public DismPackageFeatureState State;
        }

        [Flags]
        public enum DismPackageFeatureState
        {
            DismStateNotPresent = 0,
            DismStateUninstallPending = 1,
            DismStateStaged = 2,
            DismStateRemoved = 3,
            DismStateInstalled = 4,
            DismStateInstallPending = 5,
            DismStateSuperseded = 6,
            DismStatePartiallyInstalled = 7
        };

        [Flags]
        public enum DismLogLevel
        {
            DismLogErrors = 0,
            DismLogErrorsWarnings = 1,
            DismLogErrorsWarningsInfo = 2
        };

        [Flags]
        public enum DismPackageIdentifier
        {
            DismPackageNone = 0,
            DismPackageName = 1,
            DismPackagePath = 2
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
        public struct _DismFeature
        {
            public string FeatureName;
            public DismPackageFeatureState State;
        }
    }
}
