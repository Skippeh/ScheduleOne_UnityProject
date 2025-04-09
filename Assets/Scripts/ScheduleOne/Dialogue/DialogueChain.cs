using System;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public class DialogueChain
	{
		[TextArea(1, 10)]
		public string[] Lines;

		public MessageChain GetMessageChain()
		{
			return null;
		}
	}
}
