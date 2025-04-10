namespace ScheduleOne.UI
{
	public class PawnShopInterface : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.PawnShopInterface>
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

		private global::ScheduleOne.UI.PawnShopInterface.EState CurrentState;

		private global::ScheduleOne.UI.PawnShopInterface.EPlayerResponse PlayerResponse;

		private int CurrentNegotiationRound;

		private float InitialShopOffer;

		private float LastShopOffer;

		private float LastRefusedAmount;

		public global::ScheduleOne.NPCs.NPC PawnShopNPC;

		public global::UnityEngine.AnimationCurve RandomCurve;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::ScheduleOne.UI.ItemSlotUI[] Slots;

		public global::TMPro.TextMeshProUGUI[] ValueRangeLabels;

		public global::TMPro.TextMeshProUGUI TotalValueLabel;

		public global::UnityEngine.UI.Button StartButton;

		public global::UnityEngine.Animation Step1Animation;

		public global::UnityEngine.CanvasGroup Step1CanvasGroup;

		public global::UnityEngine.Animation Step2Animation;

		public global::UnityEngine.CanvasGroup Step2CanvasGroup;

		public global::UnityEngine.AnimationClip FadeInAnim;

		public global::UnityEngine.AnimationClip FadeOutAnim;

		public global::TMPro.TMP_InputField OfferInputField;

		public global::UnityEngine.UI.Slider AngerSlider;

		public global::TMPro.TextMeshProUGUI AcceptCounterButtonLabel;

		[global::UnityEngine.Header("Settings")]
		public string[] OfferLines;

		public string[] ThinkLines;

		public string[] AcceptLines;

		public string[] CounterLines;

		public string[] RefusalLines;

		public string[] DealFinalizedLines;

		public string[] AngeredLines;

		public string[] CrashOutLines;

		private global::ScheduleOne.ItemFramework.ItemSlot[] PawnSlots;

		private global::UnityEngine.Coroutine routine;

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

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
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

		private global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> GetPawnItems()
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

		private void PlayShopResponse(global::ScheduleOne.UI.PawnShopInterface.EShopResponse response, float counter)
		{
		}

		private global::ScheduleOne.UI.PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			counterAmount = default(float);
			angerChange = default(float);
			return default(global::ScheduleOne.UI.PawnShopInterface.EShopResponse);
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

		public void SetPlayerResponse(global::ScheduleOne.UI.PawnShopInterface.EPlayerResponse response)
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

		private float GetItemValue(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return 0f;
		}

		private void ResetUI()
		{
		}
	}
}
