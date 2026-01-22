namespace ScheduleOne.Economy
{
	public class SupplierLocation : global::UnityEngine.MonoBehaviour
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.Economy.SupplierLocation> AllLocations;

		[global::UnityEngine.Header("Settings")]
		public string LocationName;

		public string LocationDescription;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform GenericContainer;

		public global::UnityEngine.Transform SupplierStandPoint;

		public global::ScheduleOne.Storage.WorldStorageEntity[] DeliveryBays;

		public global::ScheduleOne.Map.POI PoI;

		private global::ScheduleOne.Economy.SupplierLocationConfiguration[] configs;

		public bool IsOccupied => false;

		public global::ScheduleOne.Economy.Supplier ActiveSupplier { get; private set; }

		public void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnSleep()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetActiveSupplier(global::ScheduleOne.Economy.Supplier supplier)
		{
		}

		private void SetDeliveryBaysVisible(bool visible)
		{
		}
	}
}
