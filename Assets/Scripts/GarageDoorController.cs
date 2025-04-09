using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GarageDoorController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRotate_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GarageDoorController _003C_003E4__this;

		public Vector3 axis;

		public float angle;

		public float duration;

		private Quaternion _003Cfrom_003E5__2;

		private Quaternion _003Cto_003E5__3;

		private float _003Celapsed_003E5__4;

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
		public _003CRotate_003Ed__4(int _003C_003E1__state)
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

	public GarageDoorStatus doorStatus;

	public Transform garageDoor;

	public Quaternion targetRotation;

	private void OnTriggerStay(Collider other)
	{
	}

	[IteratorStateMachine(typeof(_003CRotate_003Ed__4))]
	private IEnumerator Rotate(Vector3 axis, float angle, float duration = 1f)
	{
		return null;
	}
}
