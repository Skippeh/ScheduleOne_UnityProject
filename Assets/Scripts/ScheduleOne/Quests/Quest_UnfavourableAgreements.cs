namespace ScheduleOne.Quests
{
	public class Quest_UnfavourableAgreements : global::ScheduleOne.Quests.Quest
	{
		public const float WEEKLY_DELIVERY_HOURS = 168f;

		public const float REMINDER_THRESHOLD = 144f;

		public global::ScheduleOne.NPCs.CharacterClasses.Thomas Thomas;

		public global::ScheduleOne.Map.ManorGate Gate;

		public global::ScheduleOne.Misc.ModularSwitch Switch;

		public global::ScheduleOne.Property.RV RV;

		public string QuestEntryTitle;

		private bool handoverSetup;

		protected override void Start()
		{
		}

		public override void Begin(bool network = true)
		{
		}

		private void HourPass()
		{
		}

		private void SetupHandover()
		{
		}

		private void CheckHandoverExpiry()
		{
		}

		private void UpdateName()
		{
		}

		private void HandoverCompleted()
		{
		}

		public void ResetTimer(bool allowBuildup)
		{
		}
	}
}
