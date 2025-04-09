using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class PawnShopInterface : Singleton<PawnShopInterface>
	{
		public enum EState
		{
			WaitingForOffer = 0,
			Negotiating = 1
		}

		public enum EPlayerResponse
		{
			None = 0,
			Accept = 1,
			Counter = 2,
			Cancel = 3
		}

		public enum EShopResponse
		{
			Accept = 0,
			Counter = 1,
			Refusal = 2
		}

		public const float PAYMENT_MIN = 1f;

		public const float PAYMENT_MAX = 999999f;

		public const float THINK_TIME = 0.75f;

		public const float MIN_VALUE_MULTIPLIER = 0.5f;

		public const float MAX_VALUE_MULTIPLIER = 2f;

		public const int PAWN_SLOT_COUNT = 5;

		private EState CurrentState;

		private EPlayerResponse PlayerResponse;

		private int CurrentNegotiationRound;

		private float InitialShopOffer;

		private float LastShopOffer;

		private float LastRefusedAmount;

		public NPC PawnShopNPC;

		public AnimationCurve RandomCurve;

		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public ItemSlotUI[] Slots;

		public TextMeshProUGUI[] ValueRangeLabels;

		public TextMeshProUGUI TotalValueLabel;

		public Button StartButton;

		public Animation Step1Animation;

		public CanvasGroup Step1CanvasGroup;

		public Animation Step2Animation;

		public CanvasGroup Step2CanvasGroup;

		public AnimationClip FadeInAnim;

		public AnimationClip FadeOutAnim;

		public TMP_InputField OfferInputField;

		public Slider AngerSlider;

		public TextMeshProUGUI AcceptCounterButtonLabel;

		[Header("Settings")]
		public string[] OfferLines;

		public string[] ThinkLines;

		public string[] AcceptLines;

		public string[] CounterLines;

		public string[] RefusalLines;

		public string[] DealFinalizedLines;

		public string[] AngeredLines;

		public string[] CrashOutLines;

		private ItemSlot[] PawnSlots;

		private Coroutine routine;

		public bool IsOpen { get; private set; }

		public float SelectedPayment { get; private set; }

		public float NPCAnger { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Open()
		{
		}

		public void Close(bool returnItemsToPlayer)
		{
		}

		private void Exit(ExitAction action)
		{
		}

		private void OnMinPass()
		{
		}

		private void OnDayPass()
		{
		}

		private void Update()
		{
		}

		private List<ItemInstance> GetPawnItems()
		{
			return null;
		}

		private void PawnSlotChanged()
		{
		}

		private void UpdateValueRangeLabels()
		{
		}

		public void StartButtonPressed()
		{
		}

		private void StartNegotiation()
		{
		}

		private void PlayShopResponse(EShopResponse response, float counter)
		{
		}

		private EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			counterAmount = default(float);
			angerChange = default(float);
			return default(EShopResponse);
		}

		private void EndNegotiation()
		{
		}

		public void PaymentSubmitted(string value)
		{
		}

		public void ChangePayment(float change)
		{
		}

		public void SetSelectedPayment(float amount)
		{
		}

		public void SetPlayerResponse(EPlayerResponse response)
		{
		}

		public void AcceptOrCounter()
		{
		}

		public void Cancel()
		{
		}

		private void ChangeAnger(float change)
		{
		}

		private void SetAngeredToday(bool angered)
		{
		}

		private void Think()
		{
		}

		private void SetOffer(float amount)
		{
		}

		private void FinalizeDeal(float amount)
		{
		}

		private float GetTotalValue()
		{
			return 0f;
		}

		private float RoundOffer(float offer)
		{
			return 0f;
		}

		private float GetItemValue(ItemInstance item)
		{
			return 0f;
		}

		private void ResetUI()
		{
		}
	}
}
