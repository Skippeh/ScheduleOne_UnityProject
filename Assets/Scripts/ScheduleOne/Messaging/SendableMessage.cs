using System;
using System.Collections.Generic;

namespace ScheduleOne.Messaging
{
	public class SendableMessage
	{
		public delegate bool BoolCheck(SendableMessage message);

		public delegate bool ValidityCheck(SendableMessage message, out string invalidReason);

		public string Text;

		public BoolCheck ShouldShowCheck;

		public ValidityCheck IsValidCheck;

		public Action onSelected;

		public Action onSent;

		private MSGConversation conversation;

		public bool disableDefaultSendBehaviour;

		private List<int> sentIDs;

		public SendableMessage(string text, MSGConversation conversation)
		{
		}

		public virtual bool ShouldShow()
		{
			return false;
		}

		public virtual bool IsValid(out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public virtual void Send(bool network, int id = -1)
		{
		}
	}
}
