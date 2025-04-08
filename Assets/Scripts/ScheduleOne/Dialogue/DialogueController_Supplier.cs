namespace ScheduleOne.Dialogue
{
	public class DialogueController_Supplier : global::ScheduleOne.Dialogue.DialogueController
	{
		public global::ScheduleOne.Economy.Dealer dealer;

		protected override void Start()
		{
		}

		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		public override string ModifyChoiceText(string choiceLabel, string choiceText)
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
