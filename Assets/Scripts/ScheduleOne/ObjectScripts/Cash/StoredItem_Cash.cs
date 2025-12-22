namespace ScheduleOne.ObjectScripts.Cash
{
	public class StoredItem_Cash : global::ScheduleOne.Storage.StoredItem
	{
		protected global::ScheduleOne.ItemFramework.CashInstance cashInstance;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.ObjectScripts.Cash.CashStackVisuals Visuals;

		public override void InitializeStoredItem(global::ScheduleOne.Storage.StorableItemInstance _item, global::ScheduleOne.Storage.StorageGrid grid, global::UnityEngine.Vector2 _originCoordinate, float _rotation)
		{
		}

		public override void Destroy()
		{
		}

		private void RefreshShownBills()
		{
		}
	}
}
