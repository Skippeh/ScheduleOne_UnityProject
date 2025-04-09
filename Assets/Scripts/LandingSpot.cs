using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LandingSpot : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetFlockChild_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float minDelay;

		public float maxDelay;

		public LandingSpot _003C_003E4__this;

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
		public _003CGetFlockChild_003Ed__12(int _003C_003E1__state)
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

	[HideInInspector]
	public FlockChild landingChild;

	[HideInInspector]
	public bool landing;

	private int lerpCounter;

	[HideInInspector]
	public LandingSpotController _controller;

	private bool _idle;

	public Transform _thisT;

	public bool _gotcha;

	public void Start()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public void LateUpdate()
	{
	}

	public void StraightenBird()
	{
	}

	public void RotateBird()
	{
	}

	[IteratorStateMachine(typeof(_003CGetFlockChild_003Ed__12))]
	public IEnumerator GetFlockChild(float minDelay, float maxDelay)
	{
		return null;
	}

	public void InstantLand()
	{
	}

	public void ReleaseFlockChild()
	{
	}
}
