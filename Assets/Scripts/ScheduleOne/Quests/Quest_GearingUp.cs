using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	public class Quest_GearingUp : Quest
	{
		public QuestEntry WaitForDropEntry;

		public QuestEntry CollectDropEntry;

		public Supplier Supplier;

		private bool setCollectionPosition;

		protected override void Start()
		{
		}

		protected override void MinPass()
		{
		}

		private void DropReady()
		{
		}
	}
}
