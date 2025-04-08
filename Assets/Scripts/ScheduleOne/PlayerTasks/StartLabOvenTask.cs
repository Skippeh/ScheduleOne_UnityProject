namespace ScheduleOne.PlayerTasks
{
	public class StartLabOvenTask : global::ScheduleOne.PlayerTasks.Task
	{
		public enum EStep
		{
			OpenDoor = 0,
			Pour = 1,
			CloseDoor = 2,
			PressButton = 3
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CPlayPourAnimation_003Ed__24 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.PlayerTasks.StartLabOvenTask _003C_003E4__this;

			private float _003CpourTime_003E5__2;

			private float _003Ci_003E5__3;

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
			public _003CPlayPourAnimation_003Ed__24(int _003C_003E1__state)
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

		private global::ScheduleOne.ItemFramework.ItemInstance ingredient;

		private global::UnityEngine.Coroutine pourRoutine;

		private global::ScheduleOne.StationFramework.StationItem stationItem;

		private global::ScheduleOne.StationFramework.PourableModule pourableModule;

		private bool pourAnimDone;

		public global::ScheduleOne.ObjectScripts.LabOven Oven { get; private set; }

		public global::ScheduleOne.PlayerTasks.StartLabOvenTask.EStep CurrentStep { get; protected set; }

		public StartLabOvenTask(global::ScheduleOne.ObjectScripts.LabOven oven)
		{
		}

		public override void Update()
		{
		}

		public override void Success()
		{
		}

		public override void StopTask()
		{
		}

		private void CheckProgress()
		{
		}

		private void ProgressStep()
		{
		}

		private void CheckStep_OpenDoor()
		{
		}

		private void CheckStep_Pour()
		{
		}

		private void CheckStep_CloseDoor()
		{
		}

		private void CheckStep_PressButton()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerTasks.StartLabOvenTask._003CPlayPourAnimation_003Ed__24))]
		private global::System.Collections.IEnumerator PlayPourAnimation()
		{
			return null;
		}

		public static string GetStepInstruction(global::ScheduleOne.PlayerTasks.StartLabOvenTask.EStep step)
		{
			return null;
		}
	}
}
