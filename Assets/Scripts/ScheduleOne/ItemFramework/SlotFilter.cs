namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	public class SlotFilter
	{
		public enum EType
		{
			None = 0,
			Whitelist = 1,
			Blacklist = 2
		}

		public global::ScheduleOne.ItemFramework.SlotFilter.EType Type;

		public global::System.Collections.Generic.List<string> ItemIDs;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.EQuality> AllowedQualities;

		public bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}

		public bool IsDefault()
		{
			return false;
		}

		public global::ScheduleOne.ItemFramework.SlotFilter Clone()
		{
			return null;
		}
	}
}
