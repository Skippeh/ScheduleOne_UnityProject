namespace ScheduleOne.Management
{
	public class ObjectListField : global::ScheduleOne.Management.ConfigField
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> SelectedObjects;

		public int MaxItems;

		public global::ScheduleOne.UI.Management.ObjectSelector.ObjectFilter objectFilter;

		public global::System.Collections.Generic.List<global::System.Type> TypeRequirements;

		public global::UnityEngine.Events.UnityEvent<global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem>> onListChanged;

		public ObjectListField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetList(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> list, bool network)
		{
		}

		public void AddItem(global::ScheduleOne.EntityFramework.BuildableItem item)
		{
		}

		public void RemoveItem(global::ScheduleOne.EntityFramework.BuildableItem item)
		{
		}

		private void SelectedObjectDestroyed(global::ScheduleOne.EntityFramework.BuildableItem item)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.ObjectListFieldData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.ObjectListFieldData data)
		{
		}
	}
}
