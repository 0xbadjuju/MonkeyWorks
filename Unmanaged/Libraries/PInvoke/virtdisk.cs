using System;
using System.Runtime.InteropServices;
using MonkeyWorks.Unmanaged.Headers;

namespace MonkeyWorks.Unmanaged.Libraries
{
    public sealed class virtdisk
    {
        [DllImport("virtdisk.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint DetachVirtualDisk(
            IntPtr virtualDiskHandle,
            [MarshalAs(UnmanagedType.U4)]
            uint flags,
            [MarshalAs(UnmanagedType.U4)]
            uint providerSpecificFlags
        );

        [DllImport("virtdisk.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint OpenVirtualDisk(
            ref VirtDisk.VIRTUAL_STORAGE_TYPE virtualStorageType,
            [MarshalAs(UnmanagedType.LPWStr)]
            string path,
            VirtDisk.VIRTUAL_DISK_ACCESS_MASK virtualDiskAccessMask,
            VirtDisk.OPEN_VIRTUAL_DISK_FLAG flags,
            VirtDisk.OPEN_VIRTUAL_DISK_PARAMETERS parameters,
            ref IntPtr handle
        );

    }
}
