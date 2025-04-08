namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	public struct Entry
	{
		public string Key;

		public global::ScheduleOne.Dialogue.DialogueChain[] Chains;

		public global::ScheduleOne.Dialogue.DialogueChain GetRandomChain()
		{
			return null;
		}

		public string GetRandomLine()
		{
			return null;
		}
	}
}
