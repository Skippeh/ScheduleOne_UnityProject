namespace ScheduleOne.UI
{
	public class HUD : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.HUD>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CFadeBlackOverlay_003Ed__44 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool visible;

			public global::ScheduleOne.UI.HUD _003C_003E4__this;

			public float fadeTime;

			private float _003CstartAlpha_003E5__2;

			private float _003CendAlpha_003E5__3;

			private float _003Ci_003E5__4;

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
			public _003CFadeBlackOverlay_003Ed__44(int _003C_003E1__state)
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

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas canvas;

		public global::UnityEngine.RectTransform canvasRect;

		public global::UnityEngine.UI.Image crosshair;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Image blackOverlay;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Image radialIndicator;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.GraphicRaycaster raycaster;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI topScreenText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform topScreenText_Background;

		public global::UnityEngine.UI.Text fpsLabel;

		public global::UnityEngine.RectTransform cashSlotContainer;

		public global::UnityEngine.RectTransform cashSlotUI;

		public global::UnityEngine.RectTransform onlineBalanceContainer;

		public global::UnityEngine.RectTransform onlineBalanceSlotUI;

		public global::UnityEngine.RectTransform managementSlotContainer;

		public global::ScheduleOne.UI.ItemSlotUI managementSlotUI;

		public global::UnityEngine.RectTransform HotbarContainer;

		public global::UnityEngine.RectTransform SlotContainer;

		public global::ScheduleOne.UI.ItemSlotUI discardSlot;

		public global::UnityEngine.UI.Image discardSlotFill;

		public global::TMPro.TextMeshProUGUI selectedItemLabel;

		public global::UnityEngine.RectTransform QuestEntryContainer;

		public global::TMPro.TextMeshProUGUI QuestEntryTitle;

		public global::ScheduleOne.UI.CrimeStatusUI CrimeStatusUI;

		public global::ScheduleOne.UI.BalanceDisplay OnlineBalanceDisplay;

		public global::ScheduleOne.UI.BalanceDisplay SafeBalanceDisplay;

		public global::ScheduleOne.UI.CrosshairText CrosshairText;

		public global::UnityEngine.RectTransform UnreadMessagesPrompt;

		public global::TMPro.TextMeshProUGUI SleepPrompt;

		public global::TMPro.TextMeshProUGUI CurfewPrompt;

		public global::UnityEngine.CanvasGroup NotificationsCanvasGroup;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Gradient RedGreenGradient;

		private int SampleSize;

		private global::System.Collections.Generic.List<float> _previousFPS;

		private global::UnityEngine.EventSystems.EventSystem eventSystem;

		private global::UnityEngine.Coroutine blackOverlayFade;

		private bool radialIndicatorSetThisFrame;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void SetCrosshairVisible(bool vis)
		{
		}

		public void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
		}

		private void Update()
		{
		}

		private void UpdateQuestEntryTitle()
		{
		}

		private void RefreshFPS()
		{
		}

		private float GetAverageFPS()
		{
			return 0f;
		}

		protected virtual void LateUpdate()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.HUD._003CFadeBlackOverlay_003Ed__44))]
		protected global::System.Collections.IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
		{
			return null;
		}

		public void ShowRadialIndicator(float fill)
		{
		}

		public void ShowTopScreenText(string t)
		{
		}

		public void HideTopScreenText()
		{
		}
	}
}
