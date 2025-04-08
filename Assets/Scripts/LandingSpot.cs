public class LandingSpot : global::UnityEngine.MonoBehaviour
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CGetFlockChild_003Ed__12 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float minDelay;

		public float maxDelay;

		public LandingSpot _003C_003E4__this;

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
		public _003CGetFlockChild_003Ed__12(int _003C_003E1__state)
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

	[global::UnityEngine.HideInInspector]
	public FlockChild landingChild;

	[global::UnityEngine.HideInInspector]
	public bool landing;

	private int lerpCounter;

	[global::UnityEngine.HideInInspector]
	public LandingSpotController _controller;

	private bool _idle;

	public global::UnityEngine.Transform _thisT;

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

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(LandingSpot._003CGetFlockChild_003Ed__12))]
	public global::System.Collections.IEnumerator GetFlockChild(float minDelay, float maxDelay)
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
