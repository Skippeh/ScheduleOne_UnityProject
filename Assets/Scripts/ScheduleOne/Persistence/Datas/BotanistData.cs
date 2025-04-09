using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class BotanistData : EmployeeData
	{
		public MoveItemData MoveItemData;

		public BotanistData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData)
			: base(null, null, null, null, isMale: false, 0, default(Vector3), default(Quaternion), default(Guid), paidForToday: false)
		{
		}
	}
}
