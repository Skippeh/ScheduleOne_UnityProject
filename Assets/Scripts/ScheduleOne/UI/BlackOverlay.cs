using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class BlackOverlay : Singleton<BlackOverlay>
	{
		[CompilerGenerated]
		private sealed class _003CFade_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BlackOverlay _003C_003E4__this;

			public float endOpacity;

			public float fadeTime;

			private float _003Cstart_003E5__2;

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
			public _003CFade_003Ed__10(int _003C_003E1__state)
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

		public CanvasGroup group;

		private Coroutine fadeRoutine;

		public bool isShown { get; protected set; }

		protected override void Awake()
		{
		}

		public void Open(float fadeTime = 0.5f)
		{
		}

		public void Close(float fadeTime = 0.5f)
		{
		}

		[IteratorStateMachine(typeof(_003CFade_003Ed__10))]
		private IEnumerator Fade(float endOpacity, float fadeTime)
		{
			return null;
		}
	}
}
