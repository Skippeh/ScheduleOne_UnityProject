namespace ScheduleOne.Quests
{
	public class Quest_DefeatCartel : global::ScheduleOne.Quests.Quest
	{
		public const float DIG_TUNNEL_COST = 10000f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.NPCs.CharacterClasses.Sam Sam;

		public global::ScheduleOne.Property.Manor Manor;

		public global::ScheduleOne.Quests.QuestEntry DigTunnelEntry;

		public global::ScheduleOne.Quests.QuestEntry WaitForTunnelEntry;

		public global::ScheduleOne.Quests.QuestEntry EnquireAboutRDXEntry;

		public global::ScheduleOne.Quests.QuestEntry ObtainRDXEntry;

		public global::ScheduleOne.Quests.QuestEntry EnquireAboutBombEntry;

		public global::ScheduleOne.Quests.QuestEntry KillBanditEntry;

		public global::ScheduleOne.NPCs.NPC Bandit;

		public global::UnityEngine.GameObject BanditScheduleContainer;

		protected override void Start()
		{
		}

		private void OnSleepEnd()
		{
		}

		protected override void OnMinPass()
		{
		}

		public override void SetQuestEntryState(int entryIndex, global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}

		public void PlayCountdownMusic()
		{
		}

		private void Defeat()
		{
		}

		public override void SetQuestState(global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}
	}
}
