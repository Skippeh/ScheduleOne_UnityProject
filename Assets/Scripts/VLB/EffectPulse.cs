namespace VLB
{
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-effect-pulse/")]
	public class EffectPulse : global::VLB.EffectAbstractBase
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CCoUpdate_003Ed__5 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::VLB.EffectPulse _003C_003E4__this;

			private float _003Ct_003E5__2;

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
			public _003CCoUpdate_003Ed__5(int _003C_003E1__state)
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

		public new const string ClassName = "EffectPulse";

		[global::UnityEngine.Range(0.1f, 60f)]
		public float frequency;

		[global::VLB.MinMaxRange(-5f, 5f)]
		public global::VLB.MinMaxRangeFloat intensityAmplitude;

		public override void InitFrom(global::VLB.EffectAbstractBase source)
		{
		}

		protected override void OnEnable()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::VLB.EffectPulse._003CCoUpdate_003Ed__5))]
		private global::System.Collections.IEnumerator CoUpdate()
		{
			return null;
		}
	}
}
