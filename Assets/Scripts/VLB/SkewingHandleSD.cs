using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VLB
{
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle-sd/")]
	public class SkewingHandleSD : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoUpdate_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkewingHandleSD _003C_003E4__this;

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
			public _003CCoUpdate_003Ed__9(int _003C_003E1__state)
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

		public const string ClassName = "SkewingHandleSD";

		public VolumetricLightBeamSD volumetricLightBeam;

		public bool shouldUpdateEachFrame;

		public bool IsAttachedToSelf()
		{
			return false;
		}

		public bool CanSetSkewingVector()
		{
			return false;
		}

		public bool CanUpdateEachFrame()
		{
			return false;
		}

		private bool ShouldUpdateEachFrame()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CCoUpdate_003Ed__9))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		private void SetSkewingVector()
		{
		}
	}
}
