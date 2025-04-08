namespace ScheduleOne.Economy
{
	public class SupplierStash : global::UnityEngine.MonoBehaviour
	{
		public string locationDescription;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Economy.Supplier Supplier;

		public global::ScheduleOne.Storage.StorageEntity Storage;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::ScheduleOne.DevUtilities.OptimizedLight Light;

		public global::ScheduleOne.Map.POI StashPoI;

		public float CashAmount { get; private set; }

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void SupplierUnlocked()
		{
		}

		private void RecalculateCash()
		{
		}

		private void Interacted()
		{
		}

		public void RemoveCash(float amount)
		{
		}

		private void UpdateDeadDrop()
		{
		}
	}
}
