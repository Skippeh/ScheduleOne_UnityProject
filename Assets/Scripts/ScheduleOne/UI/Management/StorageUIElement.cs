namespace ScheduleOne.UI.Management
{
	public class StorageUIElement : global::ScheduleOne.UI.Management.WorldspaceUIElement
	{
		public global::UnityEngine.UI.Image Icon;

		public global::ScheduleOne.ObjectScripts.PlaceableStorageEntity AssignedEntity { get; protected set; }

		public void Initialize(global::ScheduleOne.ObjectScripts.PlaceableStorageEntity entity)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
