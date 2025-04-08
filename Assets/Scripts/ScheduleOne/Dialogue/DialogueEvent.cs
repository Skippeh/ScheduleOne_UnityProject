namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	public class DialogueEvent
	{
		public global::ScheduleOne.Dialogue.DialogueContainer Dialogue;

		public global::UnityEngine.Events.UnityEvent onDialogueEnded;

		public global::ScheduleOne.Dialogue.DialogueNodeEvent[] NodeEvents;
	}
}
