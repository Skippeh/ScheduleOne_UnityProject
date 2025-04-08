namespace ScheduleOne.Dialogue
{
	public class DialogueController_Ming : global::ScheduleOne.Dialogue.DialogueController
	{
		public global::ScheduleOne.Property.Property Property;

		public float Price;

		public global::ScheduleOne.Dialogue.DialogueContainer BuyDialogue;

		public string BuyText;

		public string RemindText;

		public global::ScheduleOne.Dialogue.DialogueContainer RemindLocationDialogue;

		public global::ScheduleOne.Quests.QuestEntry[] PurchaseRoomQuests;

		public global::UnityEngine.Events.UnityEvent onPurchase;

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
