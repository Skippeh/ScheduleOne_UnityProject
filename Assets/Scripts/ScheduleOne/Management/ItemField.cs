namespace ScheduleOne.Management
{
	public class ItemField : global::ScheduleOne.Management.ConfigField
	{
		public bool CanSelectNone;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemDefinition> Options;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.ItemFramework.ItemDefinition> onItemChanged;

		public global::ScheduleOne.ItemFramework.ItemDefinition SelectedItem { get; protected set; }

		public ItemField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetItem(global::ScheduleOne.ItemFramework.ItemDefinition item, bool network)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.ItemFieldData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.ItemFieldData data)
		{
		}
	}
}
