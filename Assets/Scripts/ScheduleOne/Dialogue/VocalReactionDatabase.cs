using System;
using System.Collections.Generic;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public class VocalReactionDatabase
	{
		[Serializable]
		public class Entry
		{
			public string Key;

			public string[] Reactions;

			public string name => null;

			public string GetRandomReaction()
			{
				return null;
			}
		}

		public List<Entry> Entries;

		public Entry GetEntry(string key)
		{
			return null;
		}
	}
}
