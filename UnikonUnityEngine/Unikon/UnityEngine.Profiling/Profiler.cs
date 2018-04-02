using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
	[MovedFrom("UnityEngine")]
	public sealed class Profiler
	{
		public static  bool supported
		{
			get;
		}

		public static  string logFile
		{
			get;
			set;
		}

		public static  bool enableBinaryLog
        { 
			get;
			set;
		}

		public static  bool enabled
		{
			get;
			set;
		}

		[Obsolete("maxNumberOfSamplesPerFrame is no longer needed, as the profiler buffers auto expand as needed")]
		public static  int maxNumberOfSamplesPerFrame
		{
			get;
			set;
		}

		[Obsolete("usedHeapSize has been deprecated since it is limited to 4GB. Please use usedHeapSizeLong instead.")]
		public static  uint usedHeapSize
		{
			get;
		}

		public static  long usedHeapSizeLong
		{
			get;
		}

		private Profiler()
		{
		}

        [Conditional("UNITY_EDITOR"), GeneratedByOldBindingsGenerator]
        public static void AddFramesFromFile(string file) { }

		[Conditional("ENABLE_PROFILER")]
		public static void BeginSample(string name)
		{
		}

		[Conditional("ENABLE_PROFILER"), GeneratedByOldBindingsGenerator]
		public static  void BeginSample(string name, UnityEngine.Object targetObject)
        {

        }


		public static  void EndSample()
        {

        }

		[Obsolete("GetRuntimeMemorySize has been deprecated since it is limited to 2GB. Please use GetRuntimeMemorySizeLong() instead.")]
		public static int GetRuntimeMemorySize(UnityEngine.Object o)
		{
			return (int)Profiler.GetRuntimeMemorySizeLong(o);
		}

		[GeneratedByOldBindingsGenerator]
		public static  long GetRuntimeMemorySizeLong(UnityEngine.Object o)
        {
            return 0;
        }

		[Obsolete("GetMonoHeapSize has been deprecated since it is limited to 4GB. Please use GetMonoHeapSizeLong() instead.")]
		public static uint GetMonoHeapSize()
		{
			return (uint)Profiler.GetMonoHeapSizeLong();
		}

        [GeneratedByOldBindingsGenerator]
        public static  long GetMonoHeapSizeLong() { return 0; }

		[Obsolete("GetMonoUsedSize has been deprecated since it is limited to 4GB. Please use GetMonoUsedSizeLong() instead.")]
		public static uint GetMonoUsedSize()
		{
			return (uint)Profiler.GetMonoUsedSizeLong();
		}

        [GeneratedByOldBindingsGenerator]
        public static  long GetMonoUsedSizeLong() { return 0; }

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public static extern bool SetTempAllocatorRequestedSize(uint size);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public static extern uint GetTempAllocatorSize();

		[Obsolete("GetTotalAllocatedMemory has been deprecated since it is limited to 4GB. Please use GetTotalAllocatedMemoryLong() instead.")]
		public static uint GetTotalAllocatedMemory()
		{
			return (uint)Profiler.GetTotalAllocatedMemoryLong();
		}

        [GeneratedByOldBindingsGenerator]
        public static  long GetTotalAllocatedMemoryLong() { return 0; }

		[Obsolete("GetTotalUnusedReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalUnusedReservedMemoryLong() instead.")]
		public static uint GetTotalUnusedReservedMemory()
		{
			return (uint)Profiler.GetTotalUnusedReservedMemoryLong();
		}

        [GeneratedByOldBindingsGenerator]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static long GetTotalUnusedReservedMemoryLong() { return 0; }

		[Obsolete("GetTotalReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalReservedMemoryLong() instead.")]
		public static uint GetTotalReservedMemory()
		{
			return (uint)Profiler.GetTotalReservedMemoryLong();
		}

        [GeneratedByOldBindingsGenerator]
        public static long GetTotalReservedMemoryLong() { return 0; }
	}
}
