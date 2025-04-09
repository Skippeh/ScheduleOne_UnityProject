using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class MSGConversationData : SaveData
	{
		public int ConversationIndex;

		public bool Read;

		public TextMessageData[] MessageHistory;

		public TextResponseData[] ActiveResponses;

		public bool IsHidden;

		public MSGConversationData(int conversationIndex, bool read, TextMessageData[] messageHistory, TextResponseData[] activeResponses, bool isHidden)
		{
		}

		public MSGConversationData()
		{
		}
	}
}
