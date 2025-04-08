namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class OrganisationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string Name;

		public float NetWorth;

		public OrganisationData(string name, float netWorth)
		{
		}
	}
}
