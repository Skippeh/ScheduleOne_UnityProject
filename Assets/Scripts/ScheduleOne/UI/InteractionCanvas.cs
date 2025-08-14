namespace ScheduleOne.UI
{
	public class InteractionCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.InteractionCanvas>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CILerpDisplayScale_003Ed__27 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float startScale;

			public float endScale;

			public global::ScheduleOne.UI.InteractionCanvas _003C_003E4__this;

			private float _003ClerpTime_003E5__2;

			private float _003Ci_003E5__3;

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
			public _003CILerpDisplayScale_003Ed__27(int _003C_003E1__state)
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

		public const float DISPLAY_SIZE_MULTIPLIER = 0.75f;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Color DefaultMessageColor;

		public global::UnityEngine.Color DefaultIconColor;

		public global::UnityEngine.Color DefaultKeyColor;

		public global::UnityEngine.Color InvalidMessageColor;

		public global::UnityEngine.Color InvalidIconColor;

		public global::UnityEngine.Sprite KeyIcon;

		public global::UnityEngine.Sprite LeftMouseIcon;

		public global::UnityEngine.Sprite CrossIcon;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.UI.Image Icon;

		public global::UnityEngine.UI.Text IconText;

		public global::UnityEngine.UI.Text MessageText;

		public global::UnityEngine.RectTransform WSLabelContainer;

		public global::UnityEngine.RectTransform BackgroundImage;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject WSLabelPrefab;

		private bool interactionDisplayEnabledThisFrame;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Interaction.WorldSpaceLabel> ActiveWSlabels;

		private global::UnityEngine.Coroutine ILerpDisplayScale_Coroutine;

		public float TempDisplayScale { get; set; }

		protected virtual void LateUpdate()
		{
		}

		public void EnableInteractionDisplay(global::UnityEngine.Vector3 pos, global::UnityEngine.Sprite icon, string spriteText, string message, global::UnityEngine.Color messageColor, global::UnityEngine.Color iconColor)
		{
		}

		public void LerpDisplayScale(float endScale)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.InteractionCanvas._003CILerpDisplayScale_003Ed__27))]
		protected global::System.Collections.IEnumerator ILerpDisplayScale(float startScale, float endScale)
		{
			return null;
		}
	}
}
