namespace ScheduleOne.Dialogue
{
	public class DialogueController_Police : global::ScheduleOne.Dialogue.DialogueController
	{
		private global::ScheduleOne.Police.PoliceOfficer officer;

		protected override void Start()
		{
		}

		public override bool CanStartDialogue()
		{
			return false;
		}
	}
}
