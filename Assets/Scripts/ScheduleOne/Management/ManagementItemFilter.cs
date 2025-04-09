using System.Collections.Generic;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Management
{
	public class ManagementItemFilter
	{
		public enum EMode
		{
			Whitelist = 0,
			Blacklist = 1
		}

		public EMode Mode { get; private set; }

		public List<ItemDefinition> Items { get; private set; }

		public ManagementItemFilter(EMode mode)
		{
		}

		public void SetMode(EMode mode)
		{
		}

		public void AddItem(ItemDefinition item)
		{
		}

		public void RemoveItem(ItemDefinition item)
		{
		}

		public bool Contains(ItemDefinition item)
		{
			return false;
		}

		public bool DoesItemMeetFilter(ItemInstance item)
		{
			return false;
		}

		public string GetDescription()
		{
			return null;
		}
	}
}
