using System;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public class NodeLinkData
	{
		public string BaseDialogueOrBranchNodeGuid;

		public string BaseChoiceOrOptionGUID;

		public string TargetNodeGuid;
	}
}
