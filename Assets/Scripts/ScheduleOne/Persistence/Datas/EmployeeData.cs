using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class EmployeeData : NPCData
	{
		public string AssignedProperty;

		public string FirstName;

		public string LastName;

		public bool IsMale;

		public int AppearanceIndex;

		public Vector3 Position;

		public Quaternion Rotation;

		public string GUID;

		public bool PaidForToday;

		public EmployeeData(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday)
			: base(null)
		{
		}
	}
}
