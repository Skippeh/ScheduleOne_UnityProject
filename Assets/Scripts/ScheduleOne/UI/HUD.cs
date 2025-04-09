using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class HUD : Singleton<HUD>
	{
		[CompilerGenerated]
		private sealed class _003CFadeBlackOverlay_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool visible;

			public HUD _003C_003E4__this;

			public float fadeTime;

			private float _003CstartAlpha_003E5__2;

			private float _003CendAlpha_003E5__3;

			private float _003Ci_003E5__4;

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
			public _003CFadeBlackOverlay_003Ed__43(int _003C_003E1__state)
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

		[Header("References")]
		public Canvas canvas;

		public RectTransform canvasRect;

		public Image crosshair;

		[SerializeField]
		protected Image blackOverlay;

		[SerializeField]
		protected Image radialIndicator;

		[SerializeField]
		protected GraphicRaycaster raycaster;

		[SerializeField]
		protected TextMeshProUGUI topScreenText;

		[SerializeField]
		protected RectTransform topScreenText_Background;

		public Text fpsLabel;

		public RectTransform cashSlotContainer;

		public RectTransform cashSlotUI;

		public RectTransform onlineBalanceContainer;

		public RectTransform onlineBalanceSlotUI;

		public RectTransform managementSlotContainer;

		public ItemSlotUI managementSlotUI;

		public RectTransform HotbarContainer;

		public RectTransform SlotContainer;

		public ItemSlotUI discardSlot;

		public Image discardSlotFill;

		public TextMeshProUGUI selectedItemLabel;

		public RectTransform QuestEntryContainer;

		public TextMeshProUGUI QuestEntryTitle;

		public CrimeStatusUI CrimeStatusUI;

		public BalanceDisplay OnlineBalanceDisplay;

		public BalanceDisplay SafeBalanceDisplay;

		public CrosshairText CrosshairText;

		public RectTransform UnreadMessagesPrompt;

		public TextMeshProUGUI SleepPrompt;

		public TextMeshProUGUI CurfewPrompt;

		[Header("Settings")]
		public Gradient RedGreenGradient;

		private int SampleSize;

		private List<float> _previousFPS;

		private EventSystem eventSystem;

		private Coroutine blackOverlayFade;

		private bool radialIndicatorSetThisFrame;

		protected override void Awake()
		{
		}

		public void SetCrosshairVisible(bool vis)
		{
		}

		public void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
		}

		protected virtual void Update()
		{
		}

		private void FixedUpdate()
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

		[IteratorStateMachine(typeof(_003CFadeBlackOverlay_003Ed__43))]
		protected IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
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
