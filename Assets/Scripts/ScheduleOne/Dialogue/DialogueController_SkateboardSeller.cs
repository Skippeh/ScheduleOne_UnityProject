namespace ScheduleOne.Dialogue
{
	public class DialogueController_SkateboardSeller : global::ScheduleOne.Dialogue.DialogueController
	{
		[global::System.Serializable]
		public class Option
		{
			public string Name;

			public float Price;

			public bool IsAvailable;

			public string NotAvailableReason;

			public global::ScheduleOne.ItemFramework.ItemDefinition Item;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueController_SkateboardSeller.Option> Options;

		private global::ScheduleOne.Dialogue.DialogueController_SkateboardSeller.Option chosenWeapon;

		public global::UnityEngine.Events.UnityEvent onPurchase;

		private void Awake()
		{
		}

		public override void ChoiceCallback(string choiceLabel)
		{
		}

		public override void ModifyChoiceList(string dialogueLabel, ref global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> existingChoices)
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> GetChoices(global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueController_SkateboardSeller.Option> options)
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
