using System;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public class DialogueEvent
	{
		public DialogueContainer Dialogue;

		public UnityEvent onDialogueEnded;

		public DialogueNodeEvent[] NodeEvents;
	}
}
