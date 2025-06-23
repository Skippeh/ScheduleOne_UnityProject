namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class PropertyData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string PropertyCode;

		public bool IsOwned;

		public bool[] SwitchStates;

		public bool[] ToggleableStates;

		public global::ScheduleOne.Persistence.Datas.DynamicSaveData[] Employees;

		public global::ScheduleOne.Persistence.Datas.DynamicSaveData[] Objects;

		public PropertyData(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates, global::ScheduleOne.Persistence.Datas.DynamicSaveData[] employees, global::ScheduleOne.Persistence.Datas.DynamicSaveData[] objects)
		{
		}
	}
}
