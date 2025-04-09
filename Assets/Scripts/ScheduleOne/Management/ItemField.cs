using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class ItemField : ConfigField
	{
		public bool CanSelectNone;

		public List<ItemDefinition> Options;

		public UnityEvent<ItemDefinition> onItemChanged;

		public ItemDefinition SelectedItem { get; protected set; }

		public ItemField(EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetItem(ItemDefinition item, bool network)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public ItemFieldData GetData()
		{
			return null;
		}

		public void Load(ItemFieldData data)
		{
		}
	}
}
