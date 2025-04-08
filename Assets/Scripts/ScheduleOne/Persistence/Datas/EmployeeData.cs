namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class EmployeeData : global::ScheduleOne.Persistence.Datas.NPCData
	{
		public string AssignedProperty;

		public string FirstName;

		public string LastName;

		public bool IsMale;

		public int AppearanceIndex;

		public global::UnityEngine.Vector3 Position;

		public global::UnityEngine.Quaternion Rotation;

		public string GUID;

		public bool PaidForToday;

		public EmployeeData(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::System.Guid guid, bool paidForToday)
			: base(null)
		{
		}
	}
}
