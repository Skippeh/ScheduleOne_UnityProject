namespace ScheduleOne.Vehicles.AI
{
	public class NavigationUtility
	{
		public enum ENavigationCalculationResult
		{
			Success = 0,
			Failed = 1
		}

		public delegate void NavigationCalculationCallback(global::ScheduleOne.Vehicles.AI.NavigationUtility.ENavigationCalculationResult result, global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path);

		public delegate void PathGroupEvent(global::ScheduleOne.Vehicles.AI.PathGroup calculatedGroup);

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public global::Pathfinding.Path lastCalculatedPath;

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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CGenerateNavigationGroup_003Ed__9 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::UnityEngine.Vector3 startPoint;

			public global::UnityEngine.Vector3 destination;

			public global::Pathfinding.Seeker generalSeeker;

			public global::UnityEngine.Vector3 entryPoint;

			private global::ScheduleOne.Vehicles.AI.NavigationUtility._003C_003Ec__DisplayClass9_0 _003C_003E8__1;

			public global::ScheduleOne.Vehicles.AI.NavigationUtility.PathGroupEvent callback;

			public global::Pathfinding.Seeker roadSeeker;

			public global::Pathfinding.NodeLink exitLink;

			public global::UnityEngine.Vector3 exitPoint;

			private global::UnityEngine.Vector3 _003CdestinationOnGraph_003E5__2;

			private global::Pathfinding.Path _003Cpath_StartToEntry_003E5__3;

			private global::Pathfinding.Path _003Cpath_EntryToExit_003E5__4;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CGenerateNavigationGroup_003Ed__9(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		public const float ROAD_MULTIPLIER = 1f;

		public const float OFFROAD_MULTIPLIER = 3f;

		public static global::UnityEngine.Coroutine CalculatePath(global::UnityEngine.Vector3 startPosition, global::UnityEngine.Vector3 destination, global::ScheduleOne.Vehicles.AI.NavigationSettings navSettings, global::ScheduleOne.Vehicles.AI.DriveFlags flags, global::Pathfinding.Seeker generalSeeker, global::Pathfinding.Seeker roadSeeker, global::ScheduleOne.Vehicles.AI.NavigationUtility.NavigationCalculationCallback callback)
		{
			return null;
		}

		private static void AdjustExitPoint(global::ScheduleOne.Vehicles.AI.PathGroup group)
		{
		}

		private static void AdjustEntryPoint(global::ScheduleOne.Vehicles.AI.PathGroup group)
		{
		}

		private static bool DoesCloseDistanceExist(global::System.Collections.Generic.List<global::UnityEngine.Vector3> vectorList, global::UnityEngine.Vector3 point, float thresholdDistance)
		{
			return false;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Vehicles.AI.NavigationUtility._003CGenerateNavigationGroup_003Ed__9))]
		private static global::System.Collections.IEnumerator GenerateNavigationGroup(global::UnityEngine.Vector3 startPoint, global::UnityEngine.Vector3 entryPoint, global::Pathfinding.NodeLink exitLink, global::UnityEngine.Vector3 exitPoint, global::UnityEngine.Vector3 destination, global::Pathfinding.Seeker generalSeeker, global::Pathfinding.Seeker roadSeeker, global::ScheduleOne.Vehicles.AI.NavigationUtility.PathGroupEvent callback)
		{
			return null;
		}

		public static void DrawPath(global::ScheduleOne.Vehicles.AI.PathGroup group, float duration = 10f)
		{
		}

		private static global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath GetSmoothedPath(global::ScheduleOne.Vehicles.AI.PathGroup group)
		{
			return null;
		}

		public static global::UnityEngine.Vector3 SampleVehicleGraph(global::UnityEngine.Vector3 destination)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetClosestPointOnFiniteLine(global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 line_start, global::UnityEngine.Vector3 line_end)
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
