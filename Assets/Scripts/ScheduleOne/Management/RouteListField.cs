using System.Collections.Generic;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class RouteListField : ConfigField
	{
		public List<AdvancedTransitRoute> Routes;

		public int MaxRoutes;

		public UnityEvent<List<AdvancedTransitRoute>> onListChanged;

		public RouteListField(EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
		}

		public void Replicate()
		{
		}

		public void AddItem(AdvancedTransitRoute item)
		{
		}

		public void RemoveItem(AdvancedTransitRoute item)
		{
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public RouteListData GetData()
		{
			return null;
		}

		public void Load(RouteListData data)
		{
		}
	}
}
