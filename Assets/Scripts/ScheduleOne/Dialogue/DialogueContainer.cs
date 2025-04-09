using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public class DialogueContainer : ScriptableObject
	{
		public List<NodeLinkData> NodeLinks;

		public List<DialogueNodeData> DialogueNodeData;

		public List<BranchNodeData> BranchNodeData;

		public bool allowExit { get; private set; }

		public bool AllowExit => false;

		public DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			return null;
		}

		public BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			return null;
		}

		public DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			return null;
		}

		public BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			return null;
		}

		public NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			return null;
		}

		public void SetAllowExit(bool allowed)
		{
		}
	}
}
