using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.UI.Phone.Messages
{
	[Serializable]
	public class MessageChain
	{
		[TextArea(2, 10)]
		public List<string> Messages;

		[HideInInspector]
		public int id;

		public static MessageChain Combine(MessageChain a, MessageChain b)
		{
			return null;
		}
	}
}
