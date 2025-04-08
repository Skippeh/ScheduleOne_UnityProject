namespace ScheduleOne.Management
{
	public class AdvancedTransitRoute : global::ScheduleOne.Management.TransitRoute
	{
		public global::ScheduleOne.Management.ManagementItemFilter Filter { get; private set; }

		public AdvancedTransitRoute(global::ScheduleOne.Management.ITransitEntity source, global::ScheduleOne.Management.ITransitEntity destination)
			: base(null, null)
		{
		}

		public AdvancedTransitRoute(global::ScheduleOne.Persistence.Datas.AdvancedTransitRouteData data)
			: base(null, null)
		{
		}

		public global::ScheduleOne.ItemFramework.ItemInstance GetItemReadyToMove()
		{
			return null;
		}

		public global::ScheduleOne.Persistence.Datas.AdvancedTransitRouteData GetData()
		{
			return null;
		}
	}
}
