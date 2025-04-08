namespace ScheduleOne.Management
{
	public class ManagementItemFilter
	{
		public enum EMode
		{
			Whitelist = 0,
			Blacklist = 1
		}

		public global::ScheduleOne.Management.ManagementItemFilter.EMode Mode { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemDefinition> Items { get; private set; }

		public ManagementItemFilter(global::ScheduleOne.Management.ManagementItemFilter.EMode mode)
		{
		}

		public void SetMode(global::ScheduleOne.Management.ManagementItemFilter.EMode mode)
		{
		}

		public void AddItem(global::ScheduleOne.ItemFramework.ItemDefinition item)
		{
		}

		public void RemoveItem(global::ScheduleOne.ItemFramework.ItemDefinition item)
		{
		}

		public bool Contains(global::ScheduleOne.ItemFramework.ItemDefinition item)
		{
			return false;
		}

		public bool DoesItemMeetFilter(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return false;
		}

		public string GetDescription()
		{
			return null;
		}
	}
}
