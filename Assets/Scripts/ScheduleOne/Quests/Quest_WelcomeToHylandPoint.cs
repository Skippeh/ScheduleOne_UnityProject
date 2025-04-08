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

		public global::UnityEngine.Events.UnityEvent onExplode;

		private bool exploded;

		private float cameraLookTime;

		protected override void MinPass()
		{
		}

		private void Update()
		{
		}

		[global::EasyButtons.Button]
		public void Explode()
		{
		}

		public override void SetQuestState(global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}
	}
}
