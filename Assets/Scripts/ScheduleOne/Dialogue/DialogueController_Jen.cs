namespace ScheduleOne.Dialogue
{
	public class DialogueController_Jen : global::ScheduleOne.Dialogue.DialogueController
	{
		public string BuyKeyText;

		public global::ScheduleOne.ItemFramework.StorableItemDefinition KeyItem;

		public global::ScheduleOne.Dialogue.DialogueContainer BuyKeyDialogue;

		public float MinRelationToBuyKey;

		protected override void Start()
		{
		}

		private bool CanBuyKey(out string invalidReason)
		{
			invalidReason = null;
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
