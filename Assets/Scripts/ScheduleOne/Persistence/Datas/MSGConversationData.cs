namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class MSGConversationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public int ConversationIndex;

		public bool Read;

		public global::ScheduleOne.Persistence.Datas.TextMessageData[] MessageHistory;

		public global::ScheduleOne.Persistence.Datas.TextResponseData[] ActiveResponses;

		public bool IsHidden;

		public MSGConversationData(int conversationIndex, bool read, global::ScheduleOne.Persistence.Datas.TextMessageData[] messageHistory, global::ScheduleOne.Persistence.Datas.TextResponseData[] activeResponses, bool isHidden)
		{
		}

		public MSGConversationData()
		{
		}
	}
}
