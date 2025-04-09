using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Dialogue
{
	public class DialogueHandler_VehicleSalesman : ControlledDialogueHandler
	{
		public Jeremy Salesman;

		public Jeremy.DealershipListing selectedVehicle;

		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}

		protected override void DialogueCallback(string choiceLabel)
		{
		}

		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}
	}
}
