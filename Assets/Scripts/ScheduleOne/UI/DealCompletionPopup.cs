namespace ScheduleOne.UI
{
	public class DealCompletionPopup : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.DealCompletionPopup>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.CanvasGroup Group;

		public global::UnityEngine.Animation Anim;

		public global::TMPro.TextMeshProUGUI Title;

		public global::TMPro.TextMeshProUGUI PaymentLabel;

		public global::TMPro.TextMeshProUGUI SatisfactionValueLabel;

		public global::ScheduleOne.UI.Relations.RelationCircle RelationCircle;

		public global::TMPro.TextMeshProUGUI RelationshipLabel;

		public global::UnityEngine.Gradient SatisfactionGradient;

		public global::ScheduleOne.Audio.AudioSourceController SoundEffect;

		public global::TMPro.TextMeshProUGUI[] BonusLabels;

		private global::UnityEngine.Coroutine routine;

		public bool IsPlaying { get; protected set; }

		protected override void Awake()
		{
		}

		public void PlayPopup(global::ScheduleOne.Economy.Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, global::System.Collections.Generic.List<global::ScheduleOne.Quests.Contract.BonusPayment> bonuses)
		{
		}

		private void SetRelationshipLabel(float delta)
		{
		}
	}
}
