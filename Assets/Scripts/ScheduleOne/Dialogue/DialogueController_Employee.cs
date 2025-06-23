namespace ScheduleOne.Dialogue
{
	public class DialogueController_Employee : global::ScheduleOne.Dialogue.DialogueController
	{
		private global::ScheduleOne.Property.Property selectedProperty;

		private void Awake()
		{
		}

		public override void ChoiceCallback(string choiceLabel)
		{
		}

		public override void ModifyChoiceList(string dialogueLabel, ref global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> existingChoices)
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> GetChoices()
		{
			return null;
		}

		private global::ScheduleOne.Property.Property GetPropertyByCode(string code)
		{
			return null;
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
	}
}
