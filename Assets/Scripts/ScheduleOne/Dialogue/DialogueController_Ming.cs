using ScheduleOne.Quests;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	public class DialogueController_Ming : DialogueController
	{
		public ScheduleOne.Property.Property Property;

		public float Price;

		public DialogueContainer BuyDialogue;

		public string BuyText;

		public string RemindText;

		public DialogueContainer RemindLocationDialogue;

		public QuestEntry[] PurchaseRoomQuests;

		public UnityEvent onPurchase;

		protected override void Start()
		{
		}

		private bool CanBuyRoom(bool enabled)
		{
			return false;
		}

		public override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public override void ChoiceCallback(string choiceLabel)
		{
		}
	}
}
