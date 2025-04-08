namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "New Dialogue Database", menuName = "Dialogue/Dialogue Database")]
	public class DialogueDatabase : global::UnityEngine.ScriptableObject
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueModule> Modules;

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.Entry> GenericEntries;

		private global::ScheduleOne.Dialogue.DialogueHandler handler;

		private global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueModule> runtimeModules => null;

		public void Initialize(global::ScheduleOne.Dialogue.DialogueHandler _handler)
		{
		}

		public global::ScheduleOne.Dialogue.DialogueModule GetModule(global::ScheduleOne.Dialogue.EDialogueModule moduleType)
		{
			return null;
		}

		public global::ScheduleOne.Dialogue.DialogueChain GetChain(global::ScheduleOne.Dialogue.EDialogueModule moduleType, string key)
		{
			return null;
		}

		public bool HasChain(global::ScheduleOne.Dialogue.EDialogueModule moduleType, string key)
		{
			return false;
		}

		public string GetLine(global::ScheduleOne.Dialogue.EDialogueModule moduleType, string key)
		{
			return null;
		}
	}
}
