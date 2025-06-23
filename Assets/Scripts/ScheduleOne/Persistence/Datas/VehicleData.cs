namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class VehicleData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string GUID;

		public string VehicleCode;

		public global::UnityEngine.Vector3 Position;

		public global::UnityEngine.Quaternion Rotation;

		public string Color;

		public global::ScheduleOne.Persistence.Datas.ItemSet VehicleContents;

		public VehicleData(global::System.Guid guid, string code, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot, global::ScheduleOne.Vehicles.Modification.EVehicleColor col, global::ScheduleOne.Persistence.Datas.ItemSet vehicleContents)
		{
		}
	}
}
