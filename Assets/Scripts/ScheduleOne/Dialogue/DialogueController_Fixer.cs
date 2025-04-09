using System.Collections.Generic;
using ScheduleOne.Employees;

namespace ScheduleOne.Dialogue
{
	public class DialogueController_Fixer : DialogueController
	{
		private EEmployeeType selectedEmployeeType;

		private ScheduleOne.Property.Property selectedProperty;

		private bool lastConfirmationWasInitial;

		public override void ChoiceCallback(string choiceLabel)
		{
		}

		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
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
