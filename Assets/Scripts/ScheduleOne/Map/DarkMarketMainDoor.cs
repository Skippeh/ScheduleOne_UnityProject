using ScheduleOne.Dialogue;
using ScheduleOne.Doors;
using ScheduleOne.Interaction;
using ScheduleOne.NPCs.CharacterClasses;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class DarkMarketMainDoor : MonoBehaviour
	{
		public AudioSource KnockSound;

		public InteractableObject InteractableObject;

		public Peephole Peephole;

		public Igor Igor;

		public DialogueContainer FailDialogue;

		public DialogueContainer SuccessDialogue;

		public DialogueContainer SuccessDialogueNotOpen;

		private Coroutine knockRoutine;

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
