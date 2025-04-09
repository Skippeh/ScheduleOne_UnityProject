using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class CrimeStatusUI : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CrimeStatusUI _003C_003E4__this;

			private float _003ClerpTime_003E5__2;

			private float _003Ct_003E5__3;

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
			public _003CRoutine_003Ed__14(int _003C_003E1__state)
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

		public const float SmallTextSize = 0.75f;

		public const float LargeTextSize = 1f;

		[Header("References")]
		public RectTransform CrimeStatusContainer;

		public CanvasGroup CrimeStatusGroup;

		public GameObject BodysearchLabel;

		public Image InvestigatingMask;

		public Image UnderArrestMask;

		public Image WantedMask;

		public Image WantedDeadMask;

		public GameObject ArrestProgressContainer;

		private bool animateText;

		private Coroutine routine;

		public void UpdateStatus()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CRoutine_003Ed__14))]
		private IEnumerator Routine()
		{
			return null;
		}
	}
}
