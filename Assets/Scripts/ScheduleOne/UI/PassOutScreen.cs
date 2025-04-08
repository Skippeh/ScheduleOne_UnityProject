namespace ScheduleOne.UI
{
	public class PassOutScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.PassOutScreen>
	{
		public const float CASH_LOSS_MIN = 50f;

		public const float CASH_LOSS_MAX = 500f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.CanvasGroup Group;

		public global::UnityEngine.Transform RecoveryPointsContainer;

		public global::TMPro.TextMeshProUGUI MainLabel;

		public global::TMPro.TextMeshProUGUI ContextLabel;

		public global::UnityEngine.Animation Anim;

		private float cashLoss;

		public bool isOpen { get; protected set; }

		protected override void Awake()
		{
		}

		private void Continue()
		{
		}

		private void LoadSaveClicked()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}
	}
}
