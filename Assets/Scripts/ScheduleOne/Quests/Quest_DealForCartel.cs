namespace ScheduleOne.Quests
{
	public class Quest_DealForCartel : global::ScheduleOne.Quests.Quest
	{
		public global::ScheduleOne.Quests.QuestEntry MainEntry;

		private global::ScheduleOne.Cartel.CartelDealInfo dealInfo;

		public void Initialize(global::ScheduleOne.Cartel.CartelDealInfo dealInfo)
		{
		}

		protected override void MinPass()
		{
		}

		private void UpdateTimingLabel()
		{
		}

		public void NotifyDealCompleted()
		{
		}
	}
}
