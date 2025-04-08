namespace VLB
{
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-effect-flicker/")]
	public class EffectFlicker : global::VLB.EffectAbstractBase
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CCoChangeIntensity_003Ed__13 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::VLB.EffectFlicker _003C_003E4__this;

			public float nextIntensity;

			public float expectedDuration;

			private float _003Cvelocity_003E5__2;

			private float _003Ct_003E5__3;

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
			public _003CCoChangeIntensity_003Ed__13(int _003C_003E1__state)
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
		private sealed class _003CCoFlicker_003Ed__12 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::VLB.EffectFlicker _003C_003E4__this;

			private float _003CremainingDuration_003E5__2;

			private float _003CfreqDuration_003E5__3;

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
			public _003CCoFlicker_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CCoUpdate_003Ed__11 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::VLB.EffectFlicker _003C_003E4__this;

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
			public _003CCoUpdate_003Ed__11(int _003C_003E1__state)
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

		public new const string ClassName = "EffectFlicker";

		[global::UnityEngine.Range(1f, 60f)]
		public float frequency;

		public bool performPauses;

		[global::VLB.MinMaxRange(0f, 10f)]
		public global::VLB.MinMaxRangeFloat flickeringDuration;

		[global::VLB.MinMaxRange(0f, 10f)]
		public global::VLB.MinMaxRangeFloat pauseDuration;

		public bool restoreIntensityOnPause;

		[global::VLB.MinMaxRange(-5f, 5f)]
		public global::VLB.MinMaxRangeFloat intensityAmplitude;

		[global::UnityEngine.Range(0f, 0.25f)]
		public float smoothing;

		private float m_CurrentAdditiveIntensity;

		public override void InitFrom(global::VLB.EffectAbstractBase source)
		{
		}

		protected override void OnEnable()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::VLB.EffectFlicker._003CCoUpdate_003Ed__11))]
		private global::System.Collections.IEnumerator CoUpdate()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::VLB.EffectFlicker._003CCoFlicker_003Ed__12))]
		private global::System.Collections.IEnumerator CoFlicker()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::VLB.EffectFlicker._003CCoChangeIntensity_003Ed__13))]
		private global::System.Collections.IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}
	}
}
