using System.Collections.Generic;
using ScheduleOne.Economy;

namespace ScheduleOne.Quests
{
	public class DeaddropQuest : Quest
	{
		public static List<DeaddropQuest> DeaddropQuests;

		public DeadDrop Drop { get; private set; }

		public override void Begin(bool network = true)
		{
		}

		public void SetDrop(DeadDrop drop)
		{
		}

		protected override void MinPass()
		{
		}

		private void OnDestroy()
		{
		}

		public override void End()
		{
		}

		public override string GetSaveString()
		{
			return null;
		}
	}
}
