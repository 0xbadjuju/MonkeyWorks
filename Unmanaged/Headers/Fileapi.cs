using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Headers
{
    using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

    public sealed class Fileapi
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _BY_HANDLE_FILE_INFORMATION
        {
            [MarshalAs(UnmanagedType.U4)]
            public uint dwFileAttributes;
            public FILETIME ftCreationTime;
            public FILETIME ftLastAccessTime;
            public FILETIME ftLastWriteTime;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwVolumeSerialNumber;
            [MarshalAs(UnmanagedType.U4)]
            public uint nFileSizeHigh;
            [MarshalAs(UnmanagedType.U4)]
            public uint nFileSizeLow;
            [MarshalAs(UnmanagedType.U4)]
            public uint nNumberOfLinks;
            [MarshalAs(UnmanagedType.U4)]
            public uint nFileIndexHigh;
            [MarshalAs(UnmanagedType.U4)]
            public uint nFileIndexLow;
        }
    
        public enum CreationDisposition : uint
        {
            CREATE_NEW = 1,
            CREATE_ALWAYS = 2,
            OPEN_EXISTING = 3,
            OPEN_ALWAYS = 4,
            TRUNCATE_EXISTING = 5
        }

        
        public uint FILE_SHARE_READ = 0x00000001;
        public uint FILE_SHARE_WRITE = 0x00000002;
        public uint FILE_SHARE_DELETE = 0x00000004;
        public uint FILE_ATTRIBUTE_READONLY = 0x00000001;
        public uint FILE_ATTRIBUTE_HIDDEN = 0x00000002;
        public uint FILE_ATTRIBUTE_SYSTEM = 0x00000004; 
        public uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
        public uint FILE_ATTRIBUTE_ARCHIVE = 0x00000020;
        public uint FILE_ATTRIBUTE_DEVICE = 0x00000040;
        public uint FILE_ATTRIBUTE_NORMAL = 0x00000080;
        public uint FILE_ATTRIBUTE_TEMPORARY = 0x00000100;
        public uint FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200;
        public uint FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400;
        public uint FILE_ATTRIBUTE_COMPRESSED = 0x00000800;
        public uint FILE_ATTRIBUTE_OFFLINE = 0x00001000;
        public uint FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000;
        public uint FILE_ATTRIBUTE_ENCRYPTED = 0x00004000;
        public uint FILE_ATTRIBUTE_INTEGRITY_STREAM = 0x00008000;
        public uint FILE_ATTRIBUTE_VIRTUAL = 0x00010000;
        public uint FILE_ATTRIBUTE_NO_SCRUB_DATA = 0x00020000;
        public uint FILE_ATTRIBUTE_EA = 0x00040000;
        public uint FILE_ATTRIBUTE_PINNED = 0x00080000;
        public uint FILE_ATTRIBUTE_RECALL_ON_OPEN = 0x00040000;
        public uint FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS = 0x00400000;
        public uint TREE_CONNECT_ATTRIBUTE_PRIVACY = 0x00004000;
        public uint TREE_CONNECT_ATTRIBUTE_INTEGRITY = 0x00008000;
        public uint TREE_CONNECT_ATTRIBUTE_GLOBAL = 0x00000004;
        public uint TREE_CONNECT_ATTRIBUTE_PINNED = 0x00000002;
        public uint FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL = 0x20000000;
        public uint FILE_NOTIFY_CHANGE_FILE_NAME = 0x00000001;
        public uint FILE_NOTIFY_CHANGE_DIR_NAME = 0x00000002;
        public uint FILE_NOTIFY_CHANGE_ATTRIBUTES = 0x00000004;
        public uint FILE_NOTIFY_CHANGE_SIZE = 0x00000008;
        public uint FILE_NOTIFY_CHANGE_LAST_WRITE = 0x00000010;
        public uint FILE_NOTIFY_CHANGE_LAST_ACCESS = 0x00000020;
        public uint FILE_NOTIFY_CHANGE_CREATION = 0x00000040;
        public uint FILE_NOTIFY_CHANGE_SECURITY = 0x00000100;
        public uint FILE_ACTION_ADDED = 0x00000001;
        public uint FILE_ACTION_REMOVED = 0x00000002;
        public uint FILE_ACTION_MODIFIED = 0x00000003;
        public uint FILE_ACTION_RENAMED_OLD_NAME = 0x00000004;
        public uint FILE_ACTION_RENAMED_NEW_NAME = 0x00000005;

        public uint FILE_CASE_SENSITIVE_SEARCH = 0x00000001;
        public uint FILE_CASE_PRESERVED_NAMES = 0x00000002;
        public uint FILE_UNICODE_ON_DISK = 0x00000004;
        public uint FILE_PERSISTENT_ACLS = 0x00000008;
        public uint FILE_FILE_COMPRESSION = 0x00000010;
        public uint FILE_VOLUME_QUOTAS = 0x00000020;
        public uint FILE_SUPPORTS_SPARSE_FILES = 0x00000040;
        public uint FILE_SUPPORTS_REPARSE_POINTS = 0x00000080; 
        public uint FILE_SUPPORTS_REMOTE_STORAGE = 0x00000100;
        public uint FILE_RETURNS_CLEANUP_RESULT_INFO = 0x00000200;
        public uint FILE_SUPPORTS_POSIX_UNLINK_RENAME = 0x00000400;
        public uint FILE_SUPPORTS_BYPASS_IO = 0x00000800;
        public uint FILE_SUPPORTS_STREAM_SNAPSHOTS = 0x00001000;
        public uint FILE_SUPPORTS_CASE_SENSITIVE_DIRS = 0x00002000;

        public uint FILE_VOLUME_IS_COMPRESSED = 0x00008000;
        public uint FILE_SUPPORTS_OBJECT_IDS = 0x00010000;
        public uint FILE_SUPPORTS_ENCRYPTION = 0x00020000;
        public uint FILE_NAMED_STREAMS = 0x00040000;
        public uint FILE_READ_ONLY_VOLUME = 0x00080000;
        public uint FILE_SEQUENTIAL_WRITE_ONCE = 0x00100000;
        public uint FILE_SUPPORTS_TRANSACTIONS = 0x00200000;
        public uint FILE_SUPPORTS_HARD_LINKS = 0x00400000;
        public uint FILE_SUPPORTS_EXTENDED_ATTRIBUTES = 0x00800000;
        public uint FILE_SUPPORTS_OPEN_BY_FILE_ID = 0x01000000;
        public uint FILE_SUPPORTS_USN_JOURNAL = 0x02000000;
        public uint FILE_SUPPORTS_INTEGRITY_STREAMS = 0x04000000; 
        public uint FILE_SUPPORTS_BLOCK_REFCOUNTING = 0x08000000;
        public uint FILE_SUPPORTS_SPARSE_VDL = 0x10000000;
        public uint FILE_DAX_VOLUME = 0x20000000;
        public uint FILE_SUPPORTS_GHOSTING = 0x40000000;

    }
}
