namespace ScheduleOne.Messaging
{
	public class SendableMessage
	{
		public delegate bool BoolCheck(global::ScheduleOne.Messaging.SendableMessage message);

		public delegate bool ValidityCheck(global::ScheduleOne.Messaging.SendableMessage message, out string invalidReason);

		public string Text;

		public global::ScheduleOne.Messaging.SendableMessage.BoolCheck ShouldShowCheck;

		public global::ScheduleOne.Messaging.SendableMessage.ValidityCheck IsValidCheck;

		public global::System.Action onSelected;

		public global::System.Action onSent;

		private global::ScheduleOne.Messaging.MSGConversation conversation;

		public bool disableDefaultSendBehaviour;

		private global::System.Collections.Generic.List<int> sentIDs;

		public SendableMessage(string text, global::ScheduleOne.Messaging.MSGConversation conversation)
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
