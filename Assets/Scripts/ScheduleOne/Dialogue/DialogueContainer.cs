namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	public class DialogueContainer : global::UnityEngine.ScriptableObject
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.NodeLinkData> NodeLinks;

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueNodeData> DialogueNodeData;

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.BranchNodeData> BranchNodeData;

		public bool allowExit { get; private set; }

		public bool AllowExit => false;

		public global::ScheduleOne.Dialogue.DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			return null;
		}

		public global::ScheduleOne.Dialogue.BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			return null;
		}

		public global::ScheduleOne.Dialogue.DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			return null;
		}

		public global::ScheduleOne.Dialogue.BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			return null;
		}

		public global::ScheduleOne.Dialogue.NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			return null;
		}

		public void SetAllowExit(bool allowed)
		{
		}
	}
}
