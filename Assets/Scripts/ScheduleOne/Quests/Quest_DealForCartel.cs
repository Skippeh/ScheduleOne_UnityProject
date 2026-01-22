namespace ScheduleOne.Quests
{
	public class Quest_DealForCartel : global::ScheduleOne.Quests.Quest
	{
		public global::ScheduleOne.Quests.QuestEntry MainEntry;

		public global::ScheduleOne.Quests.QuestEntry EndTruceEntry;

		private global::ScheduleOne.Cartel.CartelDealInfo dealInfo;

		public void Initialize(global::ScheduleOne.Cartel.CartelDealInfo dealInfo)
		{
		}

		public override void Begin(bool network = true)
		{
		}

		protected override void OnMinPass()
		{
		}

		private void UpdateTimingLabel()
		{
		}

		public void NotifyDealCompleted()
		{
		}

		public void NotifyTruceEnded()
		{
		}
	}
}
