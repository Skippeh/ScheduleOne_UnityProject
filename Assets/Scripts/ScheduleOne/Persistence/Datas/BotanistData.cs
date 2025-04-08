namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class BotanistData : global::ScheduleOne.Persistence.Datas.EmployeeData
	{
		public global::ScheduleOne.Persistence.Datas.MoveItemData MoveItemData;

		public BotanistData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::System.Guid guid, bool paidForToday, global::ScheduleOne.Persistence.Datas.MoveItemData moveItemData)
			: base(null, null, null, null, isMale: false, 0, default(global::UnityEngine.Vector3), default(global::UnityEngine.Quaternion), default(global::System.Guid), paidForToday: false)
		{
		}
	}
}
