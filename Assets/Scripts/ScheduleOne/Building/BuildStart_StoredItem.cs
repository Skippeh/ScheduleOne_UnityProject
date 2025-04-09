using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Building
{
	public class BuildStart_StoredItem : BuildStart_Base
	{
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		protected virtual GameObject CreateGhostModel(StorableItemInstance item)
		{
			return null;
		}
	}
}
