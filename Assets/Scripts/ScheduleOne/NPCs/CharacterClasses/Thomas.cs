namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Thomas : global::ScheduleOne.NPCs.NPC
	{
		public const int CARTEL_CONTRACT_QUANTITY = 15;

		public const float CARTEL_CONTRACT_PAYMENT = 100f;

		public global::ScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogue FirstMeetingEvent;

		public global::ScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogue HandoverEvent;

		public global::UnityEngine.Events.UnityEvent onCartelContractReceived;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002EThomasAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002EThomasAssembly_002DCSharp_002Edll_Excuted;

		public bool MeetingReminderSent { get; protected set; }

		public bool HandoverReminderSent { get; protected set; }

		protected override void Start()
		{
		}

		public void SetFirstMeetingEventActive(bool active)
		{
		}

		public void SetHandoverEventActive(bool active)
		{
		}

		public void SendMeetingReminder()
		{
		}

		public void SendHandoverReminder()
		{
		}

		public void InitialMeetingComplete()
		{
		}

		private void DialogueChoiceCallback(string choiceLabel)
		{
		}

		private void ProcessItemHandover(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, float price)
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public override void Load(global::ScheduleOne.Persistence.Datas.NPCData data, string containerPath)
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
