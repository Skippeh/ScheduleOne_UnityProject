namespace ScheduleOne.Management
{
	public class ObjectField : global::ScheduleOne.Management.ConfigField
	{
		public global::ScheduleOne.EntityFramework.BuildableItem SelectedObject;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.EntityFramework.BuildableItem> onObjectChanged;

		public global::ScheduleOne.UI.Management.ObjectSelector.ObjectFilter objectFilter;

		public global::System.Collections.Generic.List<global::System.Type> TypeRequirements;

		public bool DrawTransitLine;

		public ObjectField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetObject(global::ScheduleOne.EntityFramework.BuildableItem obj, bool network)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		private void SelectedObjectDestroyed()
		{
		}

		public void Load(global::ScheduleOne.Persistence.Datas.ObjectFieldData data)
		{
		}

		public global::ScheduleOne.Persistence.Datas.ObjectFieldData GetData()
		{
			return null;
		}
	}
}
