using System;
using System.Collections.Generic;

namespace ScheduleOne.Management.Settings
{
	[Serializable]
	public class ItemSelectionSetting
	{
		public List<string> SelectedItems { get; protected set; }
	}
}
