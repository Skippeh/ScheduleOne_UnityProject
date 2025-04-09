using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class OrganisationData : SaveData
	{
		public string Name;

		public float NetWorth;

		public OrganisationData(string name, float netWorth)
		{
		}
	}
}
