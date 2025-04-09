using System;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public struct Entry
	{
		public string Key;

		public DialogueChain[] Chains;

		public DialogueChain GetRandomChain()
		{
			return null;
		}

		public string GetRandomLine()
		{
			return null;
		}
	}
}
