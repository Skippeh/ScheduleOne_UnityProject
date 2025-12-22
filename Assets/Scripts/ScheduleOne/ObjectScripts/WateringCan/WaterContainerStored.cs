namespace ScheduleOne.ObjectScripts.WateringCan
{
	public class WaterContainerStored : global::ScheduleOne.Storage.StoredItem
	{
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.WaterContainerVisualizer _visuals;

		public override void InitializeStoredItem(global::ScheduleOne.Storage.StorableItemInstance _item, global::ScheduleOne.Storage.StorageGrid grid, global::UnityEngine.Vector2 _originCoordinate, float _rotation)
		{
		}

		public override void Destroy()
		{
		}
	}
}
