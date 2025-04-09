using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class CashCounter : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLerpNote_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CashCounter _003C_003E4__this;

			public Transform note;

			private float _003Ci_003E5__2;

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
			public _003CLerpNote_003Ed__10(int _003C_003E1__state)
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

		public const float NoteLerpTime = 0.18f;

		public bool IsOn;

		[Header("References")]
		public GameObject UpperNotes;

		public GameObject LowerNotes;

		public Transform NoteStartPoint;

		public Transform NoteEndPoint;

		public List<Transform> MovingNotes;

		public AudioSourceController Audio;

		private bool lerping;

		public virtual void LateUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CLerpNote_003Ed__10))]
		private IEnumerator LerpNote(Transform note)
		{
			return null;
		}
	}
}
