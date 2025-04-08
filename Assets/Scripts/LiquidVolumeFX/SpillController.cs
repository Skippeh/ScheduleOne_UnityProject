namespace LiquidVolumeFX
{
	public class SpillController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDestroySpill_003Ed__7 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::UnityEngine.GameObject spill;

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
			public _003CDestroySpill_003Ed__7(int _003C_003E1__state)
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

		public global::UnityEngine.GameObject spill;

		private global::LiquidVolumeFX.LiquidVolume lv;

		private global::UnityEngine.GameObject[] dropTemplates;

		private const int DROP_TEMPLATES_COUNT = 10;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::LiquidVolumeFX.SpillController._003CDestroySpill_003Ed__7))]
		private global::System.Collections.IEnumerator DestroySpill(global::UnityEngine.GameObject spill)
		{
			return null;
		}
	}
}
