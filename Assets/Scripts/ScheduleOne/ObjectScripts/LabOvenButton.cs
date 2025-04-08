namespace ScheduleOne.ObjectScripts
{
	public class LabOvenButton : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CMoveButton_003Ed__14 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.ObjectScripts.LabOvenButton _003C_003E4__this;

			public global::UnityEngine.Transform destination;

			private global::UnityEngine.Vector3 _003CstartPos_003E5__2;

			private global::UnityEngine.Vector3 _003CendPos_003E5__3;

			private float _003ClerpTime_003E5__4;

			private float _003Ct_003E5__5;

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
			public _003CMoveButton_003Ed__14(int _003C_003E1__state)
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

		public global::UnityEngine.Transform Button;

		public global::UnityEngine.Transform PressedTransform;

		public global::UnityEngine.Transform DepressedTransform;

		public global::ScheduleOne.Misc.ToggleableLight Light;

		public global::ScheduleOne.PlayerTasks.Clickable Clickable;

		private global::UnityEngine.Coroutine pressCoroutine;

		public bool Pressed { get; private set; }

		private void Start()
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void Press(global::UnityEngine.RaycastHit hit)
		{
		}

		public void SetPressed(bool pressed)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.ObjectScripts.LabOvenButton._003CMoveButton_003Ed__14))]
		private global::System.Collections.IEnumerator MoveButton(global::UnityEngine.Transform destination)
		{
			return null;
		}
	}
}
