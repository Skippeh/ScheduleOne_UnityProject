namespace ScheduleOne.PlayerTasks
{
	public class FinalizeLabOven : global::ScheduleOne.PlayerTasks.Task
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CStartSequence_003Ed__15 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.PlayerTasks.FinalizeLabOven _003C_003E4__this;

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
			public _003CStartSequence_003Ed__15(int _003C_003E1__state)
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

		public const float MAX_DISTANCE_FROM_IMPACT_POINT = 0.1f;

		public float SMASH_VELOCITY_THRESHOLD;

		public float SMASH_COOLDOWN;

		public const int REQUIRED_IMPACTS = 3;

		private global::UnityEngine.Coroutine startSequence;

		private global::ScheduleOne.ObjectScripts.LabOvenHammer hammer;

		private int impactCount;

		private float timeSinceLastImpact;

		public global::ScheduleOne.ObjectScripts.LabOven Oven { get; private set; }

		public FinalizeLabOven(global::ScheduleOne.ObjectScripts.LabOven oven)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerTasks.FinalizeLabOven._003CStartSequence_003Ed__15))]
		private global::System.Collections.IEnumerator StartSequence()
		{
			return null;
		}

		public void Collision(global::UnityEngine.Collision col)
		{
		}

		private void Shatter()
		{
		}
	}
}
