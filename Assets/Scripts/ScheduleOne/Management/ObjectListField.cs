using System;
using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class ObjectListField : ConfigField
	{
		public List<BuildableItem> SelectedObjects;

		public int MaxItems;

		public ObjectSelector.ObjectFilter objectFilter;

		public List<Type> TypeRequirements;

		public UnityEvent<List<BuildableItem>> onListChanged;

		public ObjectListField(EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetList(List<BuildableItem> list, bool network)
		{
		}

		public void AddItem(BuildableItem item)
		{
		}

		public void RemoveItem(BuildableItem item)
		{
		}

		private void SelectedObjectDestroyed(BuildableItem item)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public ObjectListFieldData GetData()
		{
			return null;
		}

		public void Load(ObjectListFieldData data)
		{
		}
	}
}
