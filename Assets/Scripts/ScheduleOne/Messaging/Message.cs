using System;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Messaging
{
	[Serializable]
	public class Message
	{
		public enum ESenderType
		{
			Player = 0,
			Other = 1
		}

		public int messageId;

		public string text;

		public ESenderType sender;

		public bool endOfGroup;

		public Message()
		{
		}

		public Message(string _text, ESenderType _type, bool _endOfGroup = false, int _messageId = -1)
		{
		}

		public Message(TextMessageData data)
		{
		}

		public TextMessageData GetSaveData()
		{
			return null;
		}
	}
}
