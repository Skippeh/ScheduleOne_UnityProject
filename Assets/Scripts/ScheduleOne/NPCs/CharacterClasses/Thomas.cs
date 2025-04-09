using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Handover;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Thomas : NPC
	{
		public const int CARTEL_CONTRACT_QUANTITY = 15;

		public const float CARTEL_CONTRACT_PAYMENT = 100f;

		public NPCEvent_LocationDialogue FirstMeetingEvent;

		public NPCEvent_LocationDialogue HandoverEvent;

		public UnityEvent onCartelContractReceived;

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

		private void ProcessItemHandover(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public override void Load(NPCData data, string containerPath)
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
