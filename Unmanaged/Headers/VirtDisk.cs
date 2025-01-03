using System;
using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Headers
{
    public sealed class VirtDisk
    {
        public static Guid VIRTUAL_STORAGE_TYPE_VENDOR_MICROSOFT = new Guid("EC984AEC-A0F9-47e9-901F-71415A66345B");
        public static Guid VIRTUAL_STORAGE_TYPE_VENDOR_UNKNOWN   = new Guid("00000000-0000-0000-0000-000000000000");

        [Flags]
        public enum VIRTUAL_DISK_ACCESS_MASK {
            VIRTUAL_DISK_ACCESS_NONE = 0x00000000,
            VIRTUAL_DISK_ACCESS_ATTACH_RO = 0x00010000,
            VIRTUAL_DISK_ACCESS_ATTACH_RW = 0x00020000,
            VIRTUAL_DISK_ACCESS_DETACH = 0x00040000,
            VIRTUAL_DISK_ACCESS_GET_INFO = 0x00080000,
            VIRTUAL_DISK_ACCESS_CREATE = 0x00100000,
            VIRTUAL_DISK_ACCESS_METAOPS = 0x00200000,
            VIRTUAL_DISK_ACCESS_READ = 0x000d0000,
            VIRTUAL_DISK_ACCESS_ALL = 0x003f0000,
            VIRTUAL_DISK_ACCESS_WRITABLE = 0x00320000
        }

        [Flags]
        public enum OPEN_VIRTUAL_DISK_FLAG {
            OPEN_VIRTUAL_DISK_FLAG_NONE = 0x00000000,
            OPEN_VIRTUAL_DISK_FLAG_NO_PARENTS = 0x00000001,
            OPEN_VIRTUAL_DISK_FLAG_BLANK_FILE = 0x00000002,
            OPEN_VIRTUAL_DISK_FLAG_BOOT_DRIVE = 0x00000004,
            OPEN_VIRTUAL_DISK_FLAG_CACHED_IO = 0x00000008,
            OPEN_VIRTUAL_DISK_FLAG_CUSTOM_DIFF_CHAIN = 0x00000010,
            OPEN_VIRTUAL_DISK_FLAG_PARENT_CACHED_IO = 0x00000020,
            OPEN_VIRTUAL_DISK_FLAG_VHDSET_FILE_ONLY = 0x00000040,
            OPEN_VIRTUAL_DISK_FLAG_IGNORE_RELATIVE_PARENT_LOCATOR = 0x00000080,
            OPEN_VIRTUAL_DISK_FLAG_NO_WRITE_HARDENING = 0x00000100,
            OPEN_VIRTUAL_DISK_FLAG_SUPPORT_COMPRESSED_VOLUMES,
            OPEN_VIRTUAL_DISK_FLAG_SUPPORT_SPARSE_FILES_ANY_FS,
            OPEN_VIRTUAL_DISK_FLAG_SUPPORT_ENCRYPTED_FILES
        } 

        [Flags]
        public enum VIRTUAL_STORAGE
        {
            VIRTUAL_STORAGE_TYPE_DEVICE_UNKNOWN = 0,
            VIRTUAL_STORAGE_TYPE_DEVICE_ISO = 1,
            VIRTUAL_STORAGE_TYPE_DEVICE_VHD = 2,
            VIRTUAL_STORAGE_TYPE_DEVICE_VHDX = 3
        }

        [Flags]
        public enum OPEN_VIRTUAL_DISK_VERSION
        {
            OPEN_VIRTUAL_DISK_VERSION_1 = 1,
            OPEN_VIRTUAL_DISK_VERSION_2 = 2
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VIRTUAL_STORAGE_TYPE
        {
            public VIRTUAL_STORAGE DeviceId;
            public Guid VendorId;
        }

		public partial struct OPEN_VIRTUAL_DISK_PARAMETERS
		{
			public OPEN_VIRTUAL_DISK_VERSION Version;

			internal _Anonymous_Union Anonymous;

			[StructLayout(LayoutKind.Explicit)]
			internal partial struct _Anonymous_Union
			{
				[FieldOffset(0)]
				internal _Version1 Version1;

				[FieldOffset(0)]
				internal _Version2 Version2;

				[FieldOffset(0)]
				internal _Version3 Version3;

				internal partial struct _Version1
				{
					internal uint RWDepth;
				}

				internal partial struct _Version2
				{
					internal bool GetInfoOnly;

					internal bool ReadOnly;

					internal Guid ResiliencyGuid;
				}

				internal partial struct _Version3
				{
					internal bool GetInfoOnly;

					internal bool ReadOnly;

					internal Guid ResiliencyGuid;

					internal Guid SnapshotId;
				}
			}
		}

        [StructLayout(LayoutKind.Sequential)]
        public struct OPEN_VIRTUAL_DISK_PARAMETERS_V1
        {
            public uint RWDepth;
        }
    }
}
