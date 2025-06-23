namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class TrashItemData
	{
		public string DataType;

		public string TrashID;

		public string GUID;

		public global::UnityEngine.Vector3 Position;

		public global::UnityEngine.Quaternion Rotation;

		public global::ScheduleOne.Persistence.TrashContentData Contents;

		public TrashItemData(string trashID, string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}
	}
}
