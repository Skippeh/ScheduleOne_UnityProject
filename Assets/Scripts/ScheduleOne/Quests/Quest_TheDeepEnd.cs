using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.ScriptableObjects;
using UnityEngine;

namespace ScheduleOne.Quests
{
	public class Quest_TheDeepEnd : Quest
	{
		public const float MEETING_REMINDER_TIME = 36f;

		public const float KIDNAP_TIME = 82f;

		private bool kidnapQueued;

		private bool meetingSetup;

		public Thomas Thomas;

		public ManorGate Gate;

		public ModularSwitch Switch;

		public Transform MeetingTeleportPoint;

		public PhoneCallData PostMeetingCall;

		public SystemTriggerObject PostMeetingTrigger;

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

		public override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
		}
	}
}
