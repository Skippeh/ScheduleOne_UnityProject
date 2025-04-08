namespace ScheduleOne.Building
{
	public class BuildStart_StoredItem : global::ScheduleOne.Building.BuildStart_Base
	{
		public override void StartBuilding(global::ScheduleOne.ItemFramework.ItemInstance itemInstance)
		{
		}

		protected virtual global::UnityEngine.GameObject CreateGhostModel(global::ScheduleOne.Storage.StorableItemInstance item)
		{
			return null;
		}
	}
}
