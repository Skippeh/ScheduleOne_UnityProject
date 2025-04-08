public class GarageDoorController : global::UnityEngine.MonoBehaviour
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private sealed class _003CRotate_003Ed__4 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GarageDoorController _003C_003E4__this;

		public global::UnityEngine.Vector3 axis;

		public float angle;

		public float duration;

		private global::UnityEngine.Quaternion _003Cfrom_003E5__2;

		private global::UnityEngine.Quaternion _003Cto_003E5__3;

		private float _003Celapsed_003E5__4;

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
		public _003CRotate_003Ed__4(int _003C_003E1__state)
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

	public GarageDoorStatus doorStatus;

	public global::UnityEngine.Transform garageDoor;

	public global::UnityEngine.Quaternion targetRotation;

	private void OnTriggerStay(global::UnityEngine.Collider other)
	{
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(GarageDoorController._003CRotate_003Ed__4))]
	private global::System.Collections.IEnumerator Rotate(global::UnityEngine.Vector3 axis, float angle, float duration = 1f)
	{
		return null;
	}
}
