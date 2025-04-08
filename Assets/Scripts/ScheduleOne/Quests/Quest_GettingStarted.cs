namespace ScheduleOne.Quests
{
	public class Quest_GettingStarted : global::ScheduleOne.Quests.Quest
	{
		public float CashAmount;

		public global::ScheduleOne.Economy.DeadDrop CashDrop;

		public global::ScheduleOne.NPCs.CharacterClasses.UncleNelson Nelson;

		protected override void MinPass()
		{
		}

		public override void SetQuestState(global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}
	}
}
