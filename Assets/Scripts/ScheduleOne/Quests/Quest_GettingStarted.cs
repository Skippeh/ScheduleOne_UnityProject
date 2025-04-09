using ScheduleOne.Economy;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Quests
{
	public class Quest_GettingStarted : Quest
	{
		public float CashAmount;

		public DeadDrop CashDrop;

		public UncleNelson Nelson;

		protected override void MinPass()
		{
		}

		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}
	}
}
