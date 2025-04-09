using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class PropertyData : SaveData
	{
		public string PropertyCode;

		public bool IsOwned;

		public bool[] SwitchStates;

		public bool[] ToggleableStates;

		public PropertyData(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates)
		{
		}
	}
}
