namespace ScheduleOne.Management
{
	public class RouteListField : global::ScheduleOne.Management.ConfigField
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Management.AdvancedTransitRoute> Routes;

		public int MaxRoutes;

		public global::UnityEngine.Events.UnityEvent<global::System.Collections.Generic.List<global::ScheduleOne.Management.AdvancedTransitRoute>> onListChanged;

		public RouteListField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetList(global::System.Collections.Generic.List<global::ScheduleOne.Management.AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
		}

		public void Replicate()
		{
		}

		public void AddItem(global::ScheduleOne.Management.AdvancedTransitRoute item)
		{
		}

		public void RemoveItem(global::ScheduleOne.Management.AdvancedTransitRoute item)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.RouteListData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.RouteListData data)
		{
		}
	}
}
