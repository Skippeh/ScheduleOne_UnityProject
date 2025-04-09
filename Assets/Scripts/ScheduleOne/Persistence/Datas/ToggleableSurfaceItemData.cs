namespace ScheduleOne.Persistence.Datas
{
	public class ToggleableSurfaceItemData : global::ScheduleOne.Persistence.Datas.SurfaceItemData
	{
		public bool IsOn;

		public ToggleableSurfaceItemData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, string parentSurfaceGUID, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot, bool isOn)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector3), default(global::UnityEngine.Quaternion))
		{
		}
	}
}
