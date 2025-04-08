namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle-sd/")]
	public class SkewingHandleSD : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CCoUpdate_003Ed__9 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::VLB.SkewingHandleSD _003C_003E4__this;

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
			public _003CCoUpdate_003Ed__9(int _003C_003E1__state)
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

		public const string ClassName = "SkewingHandleSD";

		public global::VLB.VolumetricLightBeamSD volumetricLightBeam;

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

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::VLB.SkewingHandleSD._003CCoUpdate_003Ed__9))]
		private global::System.Collections.IEnumerator CoUpdate()
		{
			return null;
		}

		private void SetSkewingVector()
		{
		}
	}
}
