using System;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public class DialogueNodeEvent
	{
		public string NodeLabel;

		public UnityEvent onNodeDisplayed;
	}
}
