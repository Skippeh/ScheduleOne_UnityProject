namespace ScheduleOne.Persistence.Datas
{
	public class LabelledSurfaceItemData : global::ScheduleOne.Persistence.Datas.SurfaceItemData
	{
		public string Message;

		public LabelledSurfaceItemData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, string parentSurfaceGUID, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot, string message)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector3), default(global::UnityEngine.Quaternion))
		{
		}
	}
}
