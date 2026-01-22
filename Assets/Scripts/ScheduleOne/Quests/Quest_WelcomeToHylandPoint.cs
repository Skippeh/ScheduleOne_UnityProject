namespace ScheduleOne.Quests
{
	public class Quest_WelcomeToHylandPoint : global::ScheduleOne.Quests.Quest
	{
		public global::ScheduleOne.Quests.QuestEntry ReturnToRVQuest;

		public global::ScheduleOne.Quests.QuestEntry ReadMessagesQuest;

		public global::ScheduleOne.Property.RV RV;

		public global::ScheduleOne.NPCs.CharacterClasses.UncleNelson Nelson;

		[global::UnityEngine.Header("Settings")]
		public float ExplosionMaxDist;

		public float ExplosionMinDist;

		private float cameraLookTime;

		protected override void OnMinPass()
		{
		}

		private void Update()
		{
		}

		public override void SetQuestState(global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}

		public void BlowupRV()
		{
		}

		public void SetRVDestroyed()
		{
		}
	}
}
