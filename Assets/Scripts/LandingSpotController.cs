public class LandingSpotController : global::UnityEngine.MonoBehaviour
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CInstantLand_003Ed__23 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public LandingSpotController _003C_003E4__this;

		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		public _003CInstantLand_003Ed__23(int _003C_003E1__state)
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.Collections.IEnumerator.Reset()
		{
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CInstantLandOnStart_003Ed__22 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public LandingSpotController _003C_003E4__this;

		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			get
			{
				return null;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		public _003CInstantLandOnStart_003Ed__22(int _003C_003E1__state)
		{
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		void global::System.Collections.IEnumerator.Reset()
		{
		}
	}

	public bool _randomRotate;

	public global::UnityEngine.Vector2 _autoCatchDelay;

	public global::UnityEngine.Vector2 _autoDismountDelay;

	public float _maxBirdDistance;

	public float _minBirdDistance;

	public bool _takeClosest;

	public FlockController _flock;

	public bool _landOnStart;

	public bool _soarLand;

	public bool _onlyBirdsAbove;

	public float _landingSpeedModifier;

	public float _landingTurnSpeedModifier;

	public global::UnityEngine.Transform _featherPS;

	public global::UnityEngine.Transform _thisT;

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

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(LandingSpotController._003CInstantLandOnStart_003Ed__22))]
	public global::System.Collections.IEnumerator InstantLandOnStart(float delay)
	{
		return null;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(LandingSpotController._003CInstantLand_003Ed__23))]
	public global::System.Collections.IEnumerator InstantLand(float delay)
	{
		return null;
	}
}
