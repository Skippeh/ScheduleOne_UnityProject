namespace ScheduleOne.Dialogue
{
	public class DialogueManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Dialogue.DialogueManager>
	{
		public global::ScheduleOne.Dialogue.DialogueDatabase DefaultDatabase;

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueModule> DefaultModules;

		public global::ScheduleOne.Dialogue.DialogueModule Get(global::ScheduleOne.Dialogue.EDialogueModule moduleType)
		{
			return null;
		}
	}
}
