using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	public class Quest_WeNeedToCook : Quest
	{
		public Quest[] PrerequisiteQuests;

		public Supplier MethSupplier;

		protected override void MinPass()
		{
		}
	}
}
