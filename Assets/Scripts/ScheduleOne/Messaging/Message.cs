namespace ScheduleOne.Messaging
{
	[global::System.Serializable]
	public class Message
	{
		public enum ESenderType
		{
			Player = 0,
			Other = 1
		}

		public int messageId;

		public string text;

		public global::ScheduleOne.Messaging.Message.ESenderType sender;

		public bool endOfGroup;

		public Message()
		{
		}

		public Message(string _text, global::ScheduleOne.Messaging.Message.ESenderType _type, bool _endOfGroup = false, int _messageId = -1)
		{
		}

		public Message(global::ScheduleOne.Persistence.Datas.TextMessageData data)
		{
		}

		public global::ScheduleOne.Persistence.Datas.TextMessageData GetSaveData()
		{
			return null;
		}
	}
}
