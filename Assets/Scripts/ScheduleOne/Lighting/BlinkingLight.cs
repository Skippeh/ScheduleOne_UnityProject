using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	[RequireComponent(typeof(ToggleableLight))]
	public class BlinkingLight : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CBlink_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BlinkingLight _003C_003E4__this;

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
			public _003CBlink_003Ed__7(int _003C_003E1__state)
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

		public bool IsOn;

		public float OnTime;

		public float OffTime;

		private ToggleableLight light;

		private Coroutine blinkRoutine;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CBlink_003Ed__7))]
		private IEnumerator Blink()
		{
			return null;
		}
	}
}
