namespace ScheduleOne.Map.Infrastructure
{
	public class Intersection : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRun_003Ed__8 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Map.Infrastructure.Intersection _003C_003E4__this;

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
			public _003CRun_003Ed__8(int _003C_003E1__state)
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

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Map.Infrastructure.TrafficLight> path1Lights;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Map.Infrastructure.TrafficLight> path2Lights;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.GameObject> path1Obstacles;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.GameObject> path2Obstacles;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected float path1Time;

		[global::UnityEngine.SerializeField]
		protected float path2Time;

		[global::UnityEngine.SerializeField]
		protected float timeOffset;

		protected virtual void Start()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Map.Infrastructure.Intersection._003CRun_003Ed__8))]
		protected global::System.Collections.IEnumerator Run()
		{
			return null;
		}

		protected void SetPath1Lights(global::ScheduleOne.Map.Infrastructure.TrafficLight.State state)
		{
		}

		protected void SetPath2Lights(global::ScheduleOne.Map.Infrastructure.TrafficLight.State state)
		{
		}
	}
}
