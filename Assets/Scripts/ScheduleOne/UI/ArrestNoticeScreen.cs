namespace ScheduleOne.UI
{
	public class ArrestNoticeScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.ArrestNoticeScreen>
	{
		public const float VEHICLE_POSSESSION_TIMEOUT = 30f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.CanvasGroup CanvasGroup;

		public global::UnityEngine.RectTransform CrimeEntryContainer;

		public global::UnityEngine.RectTransform PenaltyEntryContainer;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.RectTransform CrimeEntryPrefab;

		public global::UnityEngine.RectTransform PenaltyEntryPrefab;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Law.Crime, int> recordedCrimes;

		private global::ScheduleOne.Vehicles.LandVehicle vehicle;

		public bool isOpen { get; protected set; }

		protected override void Awake()
		{
		}

		private void PlayerSpawned()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void RecordCrimes()
		{
		}

		private void RecordPossession(global::ScheduleOne.Product.Packaging.EStealthLevel maxStealthLevel)
		{
		}

		private void ConfiscateItems(global::ScheduleOne.Product.Packaging.EStealthLevel maxStealthLevel)
		{
		}

		private void ClearEntries()
		{
		}
	}
}
