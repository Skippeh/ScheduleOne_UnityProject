namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	public class DialogueChoiceData
	{
		public string Guid;

		public string ChoiceText;

		public string ChoiceLabel;

		public bool ShowWorldspaceDialogue;

		public global::ScheduleOne.Dialogue.DialogueChoiceData GetCopy()
		{
			return null;
		}
	}
}
