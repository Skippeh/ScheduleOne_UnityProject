using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Property;

namespace ScheduleOne.Quests
{
	public class Quest_UnfavourableAgreements : Quest
	{
		public const float WEEKLY_DELIVERY_HOURS = 168f;

		public const float REMINDER_THRESHOLD = 144f;

		public Thomas Thomas;

		public ManorGate Gate;

		public ModularSwitch Switch;

		public RV RV;

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
