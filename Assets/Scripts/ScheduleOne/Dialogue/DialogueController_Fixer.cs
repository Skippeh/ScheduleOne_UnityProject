namespace ScheduleOne.Dialogue
{
	public class DialogueController_Fixer : global::ScheduleOne.Dialogue.DialogueController
	{
		private global::ScheduleOne.Employees.EEmployeeType selectedEmployeeType;

		private global::ScheduleOne.Property.Property selectedProperty;

		private bool lastConfirmationWasInitial;

		public override void ChoiceCallback(string choiceLabel)
		{
		}

		public override void ModifyChoiceList(string dialogueLabel, ref global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> existingChoices)
		{
		}

		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		public override bool DecideBranch(string branchLabel, out int index)
		{
			index = default(int);
			return false;
		}

		private void Confirm()
		{
		}
	}
}
