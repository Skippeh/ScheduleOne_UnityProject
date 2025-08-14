namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ManorData : global::ScheduleOne.Persistence.Datas.PropertyData
	{
		public global::ScheduleOne.Property.Manor.EManorState ManorState;

		public int DaysSinceStateChange;

		public bool TunnelDug;

		public ManorData(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates, global::ScheduleOne.Persistence.Datas.DynamicSaveData[] employees, global::ScheduleOne.Persistence.Datas.DynamicSaveData[] objects, global::ScheduleOne.Property.Manor.EManorState state, int daysSinceStateChange, bool tunnelDug)
			: base(null, isOwned: false, null, null, null, null)
		{
		}
	}
}
