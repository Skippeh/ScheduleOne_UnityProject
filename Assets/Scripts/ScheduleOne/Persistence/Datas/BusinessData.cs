namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class BusinessData : global::ScheduleOne.Persistence.Datas.PropertyData
	{
		public global::ScheduleOne.Persistence.Datas.LaunderOperationData[] LaunderingOperations;

		public BusinessData(string propertyCode, bool isOwned, bool[] switchStates, global::ScheduleOne.Persistence.Datas.LaunderOperationData[] launderingOperations, bool[] toggleableStates)
			: base(null, isOwned: false, null, null)
		{
		}
	}
}
