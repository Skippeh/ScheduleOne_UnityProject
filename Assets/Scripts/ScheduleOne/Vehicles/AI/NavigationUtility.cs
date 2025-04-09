using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Pathfinding;
using ScheduleOne.Math;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	public class NavigationUtility
	{
		public enum ENavigationCalculationResult
		{
			Success = 0,
			Failed = 1
		}

		public delegate void NavigationCalculationCallback(ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path);

		public delegate void PathGroupEvent(PathGroup calculatedGroup);

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public Path lastCalculatedPath;

			internal bool _003CGenerateNavigationGroup_003Eb__1()
			{
				return false;
			}

			internal bool _003CGenerateNavigationGroup_003Eb__2()
			{
				return false;
			}

			internal bool _003CGenerateNavigationGroup_003Eb__3()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGenerateNavigationGroup_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Vector3 startPoint;

			public Vector3 destination;

			public Seeker generalSeeker;

			public Vector3 entryPoint;

			private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

			public PathGroupEvent callback;

			public Seeker roadSeeker;

			public NodeLink exitLink;

			public Vector3 exitPoint;

			private Vector3 _003CdestinationOnGraph_003E5__2;

			private Path _003Cpath_StartToEntry_003E5__3;

			private Path _003Cpath_EntryToExit_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGenerateNavigationGroup_003Ed__9(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public const float ROAD_MULTIPLIER = 1f;

		public const float OFFROAD_MULTIPLIER = 3f;

		public static Coroutine CalculatePath(Vector3 startPosition, Vector3 destination, NavigationSettings navSettings, DriveFlags flags, Seeker generalSeeker, Seeker roadSeeker, NavigationCalculationCallback callback)
		{
			return null;
		}

		private static void AdjustExitPoint(PathGroup group)
		{
		}

		private static void AdjustEntryPoint(PathGroup group)
		{
		}

		private static bool DoesCloseDistanceExist(List<Vector3> vectorList, Vector3 point, float thresholdDistance)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CGenerateNavigationGroup_003Ed__9))]
		private static IEnumerator GenerateNavigationGroup(Vector3 startPoint, Vector3 entryPoint, NodeLink exitLink, Vector3 exitPoint, Vector3 destination, Seeker generalSeeker, Seeker roadSeeker, PathGroupEvent callback)
		{
			return null;
		}

		public static void DrawPath(PathGroup group, float duration = 10f)
		{
		}

		private static PathSmoothingUtility.SmoothedPath GetSmoothedPath(PathGroup group)
		{
			return null;
		}

		public static Vector3 SampleVehicleGraph(Vector3 destination)
		{
			return default(Vector3);
		}

		public static Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
		{
			return default(Vector3);
		}
	}
}
