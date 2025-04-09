using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LandingSpotController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInstantLand_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public LandingSpotController _003C_003E4__this;

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
		public _003CInstantLand_003Ed__23(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CInstantLandOnStart_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public LandingSpotController _003C_003E4__this;

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
		public _003CInstantLandOnStart_003Ed__22(int _003C_003E1__state)
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

	public bool _randomRotate;

	public Vector2 _autoCatchDelay;

	public Vector2 _autoDismountDelay;

	public float _maxBirdDistance;

	public float _minBirdDistance;

	public bool _takeClosest;

	public FlockController _flock;

	public bool _landOnStart;

	public bool _soarLand;

	public bool _onlyBirdsAbove;

	public float _landingSpeedModifier;

	public float _landingTurnSpeedModifier;

	public Transform _featherPS;

	public Transform _thisT;

	public int _activeLandingSpots;

	public float _snapLandDistance;

	public float _landedRotateSpeed;

	public float _gizmoSize;

	public void Start()
	{
	}

	public void ScareAll()
	{
	}

	public void ScareAll(float minDelay, float maxDelay)
	{
	}

	public void LandAll()
	{
	}

	[IteratorStateMachine(typeof(_003CInstantLandOnStart_003Ed__22))]
	public IEnumerator InstantLandOnStart(float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInstantLand_003Ed__23))]
	public IEnumerator InstantLand(float delay)
	{
		return null;
	}
}
