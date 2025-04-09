using ScheduleOne.Police;

namespace ScheduleOne.Dialogue
{
	public class DialogueController_Police : DialogueController
	{
		private PoliceOfficer officer;

		protected override void Start()
		{
		}

		public override bool CanStartDialogue()
		{
			return false;
		}
	}
}
