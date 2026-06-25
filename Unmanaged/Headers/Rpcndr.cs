using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MonkeyWorks.Unmanaged.Headers
{
    public sealed class Rpcndr
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _COMM_FAULT_OFFSETS
        {
            public short CommOffset;
            public short FaultOffset;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct _MIDL_STUB_DESC
        {
            public IntPtr RpcInterfaceInformation;
            public IntPtr pfnAllocate;
            public IntPtr pfnFree;
            public IntPtr pAutoBindHandle;
            public IntPtr apfnNdrRundownRoutines;
            public IntPtr aGenericBindingRoutinePairs;
            public IntPtr apfnExprEval;
            public IntPtr aXmitQuintuple;
            public IntPtr pFormatTypes;
            public int fCheckBounds;
            public uint Version;
            public IntPtr pMallocFreeStruct;
            public int MIDLVersion;
            public IntPtr CommFaultOffsets;
            public IntPtr aUserMarshalQuadruple;
            public IntPtr NotifyRoutineTable;
            public IntPtr mFlags;
            public IntPtr CsRoutineTables;
            public IntPtr ProxyServerInfo;
            public IntPtr pExprInfo;

            public _MIDL_STUB_DESC(IntPtr pFormatTypesPtr, IntPtr rpcInterfaceInformationPtr, IntPtr commFaultOffsetsPtr, IntPtr pfnAllocatePtr, IntPtr pfnFreePtr)
            {
                RpcInterfaceInformation = rpcInterfaceInformationPtr;
                pfnAllocate = pfnAllocatePtr;
                pfnFree = pfnFreePtr;
                pAutoBindHandle = IntPtr.Zero;
                apfnNdrRundownRoutines = IntPtr.Zero;
                aGenericBindingRoutinePairs = IntPtr.Zero;
                apfnExprEval = IntPtr.Zero;
                aXmitQuintuple = IntPtr.Zero;
                pFormatTypes = pFormatTypesPtr;
                fCheckBounds = 1;
                Version = 0x50002u;
                pMallocFreeStruct = IntPtr.Zero;
                MIDLVersion = 0x801026e;
                CommFaultOffsets = commFaultOffsetsPtr;
                aUserMarshalQuadruple = IntPtr.Zero;
                NotifyRoutineTable = IntPtr.Zero;
                mFlags = new IntPtr(0x00000001);
                CsRoutineTables = IntPtr.Zero;
                ProxyServerInfo = IntPtr.Zero;
                pExprInfo = IntPtr.Zero;
            }
        }
    }
}