using System;
using System.Runtime.InteropServices;

/// https://github.com/lucasg/processhacker2/blob/master/phnt/include/ntexapi.h

namespace MonkeyWorks.Unmanaged.Headers
{
    public sealed class Ntexapi
    {
        
        [Flags]
        public enum _SET_WORKERFACTORYINFOCLASS
        {
            WorkerFactoryTimeout = 0,
            WorkerFactoryRetryTimeout = 1,
            WorkerFactoryIdleTimeout = 2,
            WorkerFactoryBindingCount = 3,
            WorkerFactoryThreadMinimum = 4,
            WorkerFactoryThreadMaximum = 5,
            WorkerFactoryPaused = 6,
            WorkerFactoryAdjustThreadGoal = 8,
            WorkerFactoryCallbackType = 9,
            WorkerFactoryStackInformation = 10,
            WorkerFactoryThreadBasePriority = 11,
            WorkerFactoryTimeoutWaiters = 12,
            WorkerFactoryFlags = 13,
            WorkerFactoryThreadSoftMaximum = 14,
            WorkerFactoryMaxInfoClass = 15 /* Not implemented */
        }

        [StructLayout(LayoutKind.Sequential)]
        public class WnfTypeId
        {
            public Guid TypeId;
        }
        
        [Flags]
        public enum _WORKERFACTORYINFOCLASS
        {
            WorkerFactoryTimeout,
            WorkerFactoryRetryTimeout,
            WorkerFactoryIdleTimeout,
            WorkerFactoryBindingCount,
            WorkerFactoryThreadMinimum,
            WorkerFactoryThreadMaximum,
            WorkerFactoryPaused,
            WorkerFactoryBasicInformation,
            WorkerFactoryAdjustThreadGoal,
            WorkerFactoryCallbackType,
            WorkerFactoryStackInformation, // 10
            WorkerFactoryThreadBasePriority,
            WorkerFactoryTimeoutWaiters, // since THRESHOLD
            WorkerFactoryFlags,
            WorkerFactoryThreadSoftMaximum,
            MaxWorkerFactoryInfoClass
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct _WORKER_FACTORY_BASIC_INFORMATION
        {
            public Winnt.LARGE_INTEGER Timeout;
            public Winnt.LARGE_INTEGER RetryTimeout;
            public Winnt.LARGE_INTEGER IdleTimeout;
            public bool Paused;
            public bool TimerSet;
            public bool QueuedToExWorker;
            public bool MayCreate;
            public bool CreateInProgress;
            public bool InsertedIntoQueue;
            public bool Shutdown;
            public uint BindingCount;
            public uint ThreadMinimum;
            public uint ThreadMaximum;
            public uint PendingWorkerCount;
            public uint WaitingWorkerCount;
            public uint TotalWorkerCount;
            public uint ReleaseCount;
            public long InfiniteWaitGoal;
            public IntPtr StartRoutine;
            public IntPtr StartParameter;
            public IntPtr ProcessId;
            public uint StackReserve;
            public uint StackCommit;
            public uint LastThreadCreationStatus;
        }

        [StructLayout(LayoutKind.Explicit, Size = 120)]
        public struct WorkerFactoryBasicInformation
        {
            [FieldOffset(0)]  public Winnt.LARGE_INTEGER Timeout;
            [FieldOffset(8)]  public Winnt.LARGE_INTEGER RetryTimeout;
            [FieldOffset(16)] public Winnt.LARGE_INTEGER IdleTimeout;

            [FieldOffset(24)] public byte Paused;
            [FieldOffset(25)] public byte TimerSet;
            [FieldOffset(26)] public byte QueuedToExWorker;
            [FieldOffset(27)] public byte MayCreate;
            [FieldOffset(28)] public byte CreateInProgress;
            [FieldOffset(29)] public byte InsertedIntoQueue;
            [FieldOffset(30)] public byte Shutdown;

            // Aligned to 4-byte boundary
            [FieldOffset(32)] public uint BindingCount;
            [FieldOffset(36)] public uint ThreadMinimum;
            [FieldOffset(40)] public uint ThreadMaximum;
            [FieldOffset(44)] public uint PendingWorkerCount;
            [FieldOffset(48)] public uint WaitingWorkerCount;
            [FieldOffset(52)] public uint TotalWorkerCount;
            [FieldOffset(56)] public uint ReleaseCount;

            // Aligned to 8-byte boundary for long
            [FieldOffset(64)] public long InfiniteWaitGoal;
            [FieldOffset(72)] public IntPtr StartRoutine;
            [FieldOffset(80)] public IntPtr StartParameter;
            [FieldOffset(88)] public IntPtr ProcessId;

            [FieldOffset(96)]  public IntPtr StackReserve;
            [FieldOffset(104)] public IntPtr StackCommit;
            [FieldOffset(112)] public int LastThreadCreationStatus;
        } 
    }
}