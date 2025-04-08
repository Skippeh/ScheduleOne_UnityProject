namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	public class DialogueNodeData
	{
		public string Guid;

		public string DialogueText;

		public string DialogueNodeLabel;

		public global::UnityEngine.Vector2 Position;

		public global::ScheduleOne.Dialogue.DialogueChoiceData[] choices;

		public global::ScheduleOne.VoiceOver.EVOLineType VoiceLine;

		public global::ScheduleOne.Dialogue.DialogueNodeData GetCopy()
		{
			return null;
		}
	}
}
