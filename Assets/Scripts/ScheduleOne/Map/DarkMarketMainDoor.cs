namespace ScheduleOne.Map
{
	public class DarkMarketMainDoor : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.AudioSource KnockSound;

		public global::ScheduleOne.Interaction.InteractableObject InteractableObject;

		public global::ScheduleOne.Doors.Peephole Peephole;

		public global::ScheduleOne.NPCs.CharacterClasses.Igor Igor;

		public global::ScheduleOne.Dialogue.DialogueContainer FailDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer SuccessDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer SuccessDialogueNotOpen;

		private global::UnityEngine.Coroutine knockRoutine;

		public bool KnockingEnabled { get; private set; }

		private void Start()
		{
		}

		public void SetKnockingEnabled(bool enabled)
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private void Knocked()
		{
		}
	}
}
