using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-pulse/")]
	public class EffectPulse : EffectAbstractBase
	{
		[CompilerGenerated]
		private sealed class _003CCoUpdate_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EffectPulse _003C_003E4__this;

			private float _003Ct_003E5__2;

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
			public _003CCoUpdate_003Ed__5(int _003C_003E1__state)
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

		public new const string ClassName = "EffectPulse";

		[Range(0.1f, 60f)]
		public float frequency;

		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude;

		public override void InitFrom(EffectAbstractBase source)
		{
		}

		protected override void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CCoUpdate_003Ed__5))]
		private IEnumerator CoUpdate()
		{
			return null;
		}
	}
}
