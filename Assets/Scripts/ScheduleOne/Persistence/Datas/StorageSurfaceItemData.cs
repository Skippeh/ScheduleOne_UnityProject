namespace ScheduleOne.Persistence.Datas
{
	public class StorageSurfaceItemData : global::ScheduleOne.Persistence.Datas.SurfaceItemData
	{
		public global::ScheduleOne.Persistence.Datas.ItemSet Contents;

		public StorageSurfaceItemData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, string parentSurfaceGUID, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot, global::ScheduleOne.Persistence.Datas.ItemSet contents)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector3), default(global::UnityEngine.Quaternion))
		{
		}
	}
}
