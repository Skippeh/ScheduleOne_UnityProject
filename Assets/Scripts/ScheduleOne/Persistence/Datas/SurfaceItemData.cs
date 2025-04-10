namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class SurfaceItemData : global::ScheduleOne.Persistence.Datas.BuildableItemData
	{
		public string ParentSurfaceGUID;

		public global::UnityEngine.Vector3 RelativePosition;

		public global::UnityEngine.Quaternion RelativeRotation;

		public SurfaceItemData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, string parentSurfaceGUID, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot)
			: base(default(global::System.Guid), null, 0)
		{
		}
	}
}
