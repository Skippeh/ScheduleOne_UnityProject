using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Phone
{
	public class AppsCanvas : PlayerSingleton<AppsCanvas>
	{
		[CompilerGenerated]
		private sealed class _003CDelayedSetCanvasActive_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public AppsCanvas _003C_003E4__this;

			public bool active;

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
			public _003CDelayedSetCanvasActive_003Ed__10(int _003C_003E1__state)
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

		[Header("References")]
		public Canvas canvas;

		private Coroutine delayedSetOpenRoutine;

		public bool isOpen { get; private set; }

		protected override void Awake()
		{
		}

		public override void OnStartClient(bool IsOwner)
		{
		}

		protected void PhoneOpened()
		{
		}

		protected void PhoneClosed()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedSetCanvasActive_003Ed__10))]
		private IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			return null;
		}

		public void SetIsOpen(bool o)
		{
		}

		private void SetCanvasActive(bool a)
		{
		}

		protected override void Start()
		{
		}
	}
}
