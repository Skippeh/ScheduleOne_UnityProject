namespace ScheduleOne.Dialogue
{
	public class DialogueHandler_Police : global::ScheduleOne.Dialogue.ControlledDialogueHandler
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Dialogue.DialogueContainer CheckpointRequestDialogue;

		private global::ScheduleOne.Police.PoliceOfficer officer;

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
