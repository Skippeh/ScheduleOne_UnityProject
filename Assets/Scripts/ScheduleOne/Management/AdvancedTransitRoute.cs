using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Management
{
	public class AdvancedTransitRoute : TransitRoute
	{
		public ManagementItemFilter Filter { get; private set; }

		public AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination)
			: base(null, null)
		{
		}

		public AdvancedTransitRoute(AdvancedTransitRouteData data)
			: base(null, null)
		{
		}

		public ItemInstance GetItemReadyToMove()
		{
			return null;
		}

		public AdvancedTransitRouteData GetData()
		{
			return null;
		}
	}
}
