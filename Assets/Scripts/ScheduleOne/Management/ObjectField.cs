using System;
using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class ObjectField : ConfigField
	{
		public BuildableItem SelectedObject;

		public UnityEvent<BuildableItem> onObjectChanged;

		public ObjectSelector.ObjectFilter objectFilter;

		public List<Type> TypeRequirements;

		public bool DrawTransitLine;

		public ObjectField(EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetObject(BuildableItem obj, bool network)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		private void SelectedObjectDestroyed()
		{
		}

		public void Load(ObjectFieldData data)
		{
		}

		public ObjectFieldData GetData()
		{
			return null;
		}
	}
}
