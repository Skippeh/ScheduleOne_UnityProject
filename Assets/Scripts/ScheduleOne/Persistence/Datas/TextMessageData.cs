using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class TextMessageData
	{
		public int Sender;

		public int MessageID;

		public string Text;

		public bool EndOfChain;

		public TextMessageData(int sender, int messageID, string text, bool endOfChain)
		{
		}

		public TextMessageData()
		{
		}
	}
}
