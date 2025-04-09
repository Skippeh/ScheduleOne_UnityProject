using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	public class DialogueHandler_Police : ControlledDialogueHandler
	{
		[Header("References")]
		public DialogueContainer CheckpointRequestDialogue;

		private PoliceOfficer officer;

		protected override void Awake()
		{
		}

		public override void Hovered()
		{
		}

		public override void Interacted()
		{
		}

		private bool CanTalk_Checkpoint()
		{
			return false;
		}

		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}
	}
}
