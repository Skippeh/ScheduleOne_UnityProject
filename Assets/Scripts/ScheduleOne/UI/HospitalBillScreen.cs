namespace ScheduleOne.UI
{
	public class HospitalBillScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.HospitalBillScreen>
	{
		public const float BILL_COST = 250f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.CanvasGroup CanvasGroup;

		public global::TMPro.TextMeshProUGUI PatientNameLabel;

		public global::TMPro.TextMeshProUGUI BillNumberLabel;

		public global::TMPro.TextMeshProUGUI PaidAmountLabel;

		private bool arrested;

		public bool isOpen { get; protected set; }

		protected override void Awake()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void PlayerSpawned()
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
