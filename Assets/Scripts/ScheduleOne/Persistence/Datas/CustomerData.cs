namespace ScheduleOne.Persistence.Datas
{
	public class CustomerData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public float Dependence;

		public float[] ProductAffinities;

		public int TimeSinceLastDealCompleted;

		public int TimeSinceLastDealOffered;

		public int OfferedDeals;

		public int CompletedDeals;

		public bool IsContractOffered;

		public global::ScheduleOne.Quests.ContractInfo OfferedContract;

		public global::ScheduleOne.GameTime.GameDateTime OfferedContractTime;

		public int TimeSincePlayerApproached;

		public int TimeSinceInstantDealOffered;

		public bool HasBeenRecommended;

		public CustomerData(float dependence, float[] productAffinities, int timeSinceLastDealCompleted, int timeSinceLastDealOffered, int offeredDeals, int completedDeals, bool isContractOffered, global::ScheduleOne.Quests.ContractInfo offeredContract, global::ScheduleOne.GameTime.GameDateTime offeredTime, int timeSincePlayerApproached, int timeSinceInstantDealOffered, bool hasBeenRecommended)
		{
		}

		public CustomerData()
		{
		}
	}
}
