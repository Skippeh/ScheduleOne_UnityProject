namespace ScheduleOne.Dialogue
{
	public class DialogueModule : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Dialogue.EDialogueModule ModuleType;

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.Entry> Entries;

		public global::ScheduleOne.Dialogue.Entry GetEntry(string key)
		{
			return default(global::ScheduleOne.Dialogue.Entry);
		}

		public global::ScheduleOne.Dialogue.DialogueChain GetChain(string key)
		{
			return null;
		}

		public bool HasChain(string key)
		{
			return false;
		}

		public string GetLine(string key)
		{
			return null;
		}
	}
}
