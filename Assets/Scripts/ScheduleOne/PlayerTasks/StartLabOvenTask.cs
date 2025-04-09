using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	public class StartLabOvenTask : Task
	{
		public enum EStep
		{
			OpenDoor = 0,
			Pour = 1,
			CloseDoor = 2,
			PressButton = 3
		}

		[CompilerGenerated]
		private sealed class _003CPlayPourAnimation_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StartLabOvenTask _003C_003E4__this;

			private float _003CpourTime_003E5__2;

			private float _003Ci_003E5__3;

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
			public _003CPlayPourAnimation_003Ed__24(int _003C_003E1__state)
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

		private ItemInstance ingredient;

		private Coroutine pourRoutine;

		private StationItem stationItem;

		private PourableModule pourableModule;

		private bool pourAnimDone;

		public LabOven Oven { get; private set; }

		public EStep CurrentStep { get; protected set; }

		public StartLabOvenTask(LabOven oven)
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

		[IteratorStateMachine(typeof(_003CPlayPourAnimation_003Ed__24))]
		private IEnumerator PlayPourAnimation()
		{
			return null;
		}

		public static string GetStepInstruction(EStep step)
		{
			return null;
		}
	}
}
