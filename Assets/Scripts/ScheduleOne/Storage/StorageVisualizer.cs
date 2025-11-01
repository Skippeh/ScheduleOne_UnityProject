namespace ScheduleOne.Storage
{
	public class StorageVisualizer : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Storage.StorageGrid[] StorageGrids;

		public global::UnityEngine.Transform ItemContainer;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Tooltip("Should storage visuals be fully recalculated when item(s) are removed?")]
		public bool FullRefreshOnItemRemoved;

		protected global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> itemSlots;

		protected int totalFootprintCapacity;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StorableItemInstance, global::System.Collections.Generic.List<global::ScheduleOne.Storage.StoredItem>> activeStoredItems;

		public bool BlockRefreshes;

		private bool isUpdatingVisuals;

		protected virtual void Awake()
		{
		}

		public void AddSlot(global::ScheduleOne.ItemFramework.ItemSlot slot, bool update = false)
		{
		}

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StorableItemInstance, int> GetVisualRepresentation()
		{
			return null;
		}

		public virtual void RefreshVisuals()
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Storage.StoredItem> EnsureSufficientStoredItems(global::ScheduleOne.Storage.StorableItemInstance item, int quantityRequirement)
		{
			return null;
		}

		private void DestroyExcessStoredItems(global::ScheduleOne.Storage.StorableItemInstance item, int quantityRequirement)
		{
		}

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StorableItemInstance, int> GetContentsDictionary()
		{
			return null;
		}

		protected void QueueRefresh()
		{
		}
	}
}
