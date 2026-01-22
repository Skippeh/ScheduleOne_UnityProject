namespace ScheduleOne.Quests
{
	public class DeaddropQuest : global::ScheduleOne.Quests.Quest
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.Quests.DeaddropQuest> DeaddropQuests;

		public global::ScheduleOne.Economy.DeadDrop Drop { get; private set; }

		public override void Begin(bool network = true)
		{
		}

		public void SetDrop(global::ScheduleOne.Economy.DeadDrop drop)
		{
		}

		protected override void OnMinPass()
		{
		}

		private void OnDestroy()
		{
		}

		public override void End()
		{
		}

		public override void SetQuestState(global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}

		public override bool ShouldSave()
		{
			return false;
		}

		public override global::ScheduleOne.Persistence.Datas.SaveData GetSaveData()
		{
			return null;
		}
	}
}
