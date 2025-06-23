namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class BusinessData : global::ScheduleOne.Persistence.Datas.PropertyData
	{
		public global::ScheduleOne.Persistence.Datas.LaunderOperationData[] LaunderingOperations;

		public BusinessData(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates, global::ScheduleOne.Persistence.Datas.DynamicSaveData[] employees, global::ScheduleOne.Persistence.Datas.DynamicSaveData[] objects, global::ScheduleOne.Persistence.Datas.LaunderOperationData[] launderingOperations)
			: base(null, isOwned: false, null, null, null, null)
		{
		}
	}
}
