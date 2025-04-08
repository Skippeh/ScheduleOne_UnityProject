namespace ScheduleOne.Dialogue
{
	public class DialogueHandler_EstateAgent : global::ScheduleOne.Dialogue.ControlledDialogueHandler
	{
		private global::ScheduleOne.Property.Property selectedProperty;

		private global::ScheduleOne.Property.Business selectedBusiness;

		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public override bool ShouldChoiceBeShown(string choiceLabel)
		{
			return false;
		}

		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		protected override void DialogueCallback(string choiceLabel)
		{
		}

		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}
	}
}
