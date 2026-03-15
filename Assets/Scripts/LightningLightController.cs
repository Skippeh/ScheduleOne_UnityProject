public class LightningLightController : global::UnityEngine.MonoBehaviour
{
	[global::System.Serializable]
	public class LightEntry
	{
		public global::UnityEngine.Light light;

		public global::UnityEngine.AnimationCurve flashCurve;

		public float maxIntensity;

		public float strikeDuration;

		public float startDelay;
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CDoStrikeRoutine_003Ed__7 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LightningLightController _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

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
		public _003CDoStrikeRoutine_003Ed__7(int _003C_003E1__state)
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

	[global::UnityEngine.Header("Light Entries (max 4)")]
	public LightningLightController.LightEntry[] lightEntries;

	[global::UnityEngine.Header("Auto-Strike Timing")]
	public float minTimeBetweenStrikes;

	public float maxTimeBetweenStrikes;

	private global::UnityEngine.Coroutine _strikeCo;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(LightningLightController._003CDoStrikeRoutine_003Ed__7))]
	private global::System.Collections.IEnumerator DoStrikeRoutine()
	{
		return null;
	}
}
