using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Misc;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class LabOvenButton : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMoveButton_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LabOvenButton _003C_003E4__this;

			public Transform destination;

			private Vector3 _003CstartPos_003E5__2;

			private Vector3 _003CendPos_003E5__3;

			private float _003ClerpTime_003E5__4;

			private float _003Ct_003E5__5;

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
			public _003CMoveButton_003Ed__14(int _003C_003E1__state)
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

		public Transform Button;

		public Transform PressedTransform;

		public Transform DepressedTransform;

		public ToggleableLight Light;

		public Clickable Clickable;

		private Coroutine pressCoroutine;

		public bool Pressed { get; private set; }

		private void Start()
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void Press(RaycastHit hit)
		{
		}

		public void SetPressed(bool pressed)
		{
		}

		[IteratorStateMachine(typeof(_003CMoveButton_003Ed__14))]
		private IEnumerator MoveButton(Transform destination)
		{
			return null;
		}
	}
}
