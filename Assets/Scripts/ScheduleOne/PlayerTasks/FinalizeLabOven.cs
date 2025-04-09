using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	public class FinalizeLabOven : Task
	{
		[CompilerGenerated]
		private sealed class _003CStartSequence_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FinalizeLabOven _003C_003E4__this;

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
			public _003CStartSequence_003Ed__14(int _003C_003E1__state)
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

		public const float MAX_DISTANCE_FROM_IMPACT_POINT = 0.1f;

		public float SMASH_VELOCITY_THRESHOLD;

		public const int REQUIRED_IMPACTS = 3;

		private Coroutine startSequence;

		private LabOvenHammer hammer;

		private int impactCount;

		private float timeSinceLastImpact;

		public LabOven Oven { get; private set; }

		public FinalizeLabOven(LabOven oven)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		[IteratorStateMachine(typeof(_003CStartSequence_003Ed__14))]
		private IEnumerator StartSequence()
		{
			return null;
		}

		public void Collision(Collision col)
		{
		}

		private void Shatter()
		{
		}
	}
}
