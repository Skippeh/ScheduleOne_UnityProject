namespace ScheduleOne.Quests
{
	public class Quest_TheDeepEnd : global::ScheduleOne.Quests.Quest
	{
		public const float MEETING_REMINDER_TIME = 36f;

		public const float KIDNAP_TIME = 82f;

		private bool kidnapQueued;

		private bool meetingSetup;

		public global::ScheduleOne.NPCs.CharacterClasses.Thomas Thomas;

		public global::ScheduleOne.Map.ManorGate Gate;

		public global::ScheduleOne.Misc.ModularSwitch Switch;

		public global::UnityEngine.Transform MeetingTeleportPoint;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData PostMeetingCall;

		public global::ScheduleOne.Quests.SystemTriggerObject PostMeetingTrigger;

		protected override void Start()
		{
		}

		public override void Begin(bool network = true)
		{
		}

		public void SetupFirstMeeting()
		{
		}

		private void ThomasDialogueNodeDisplayed(string nodeLabel)
		{
		}

		private void HourPass()
		{
		}

		private void BeforeSleep()
		{
		}

		private void SleepFadeOut()
		{
		}

		public override void SetQuestEntryState(int entryIndex, global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}
	}
}
