namespace ScheduleOne.Dialogue
{
	[global::System.Serializable]
	public class VocalReactionDatabase
	{
		[global::System.Serializable]
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

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.VocalReactionDatabase.Entry> Entries;

		public global::ScheduleOne.Dialogue.VocalReactionDatabase.Entry GetEntry(string key)
		{
			return null;
		}
	}
}
