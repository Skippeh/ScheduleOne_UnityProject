using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	public class BuildStart_ProceduralGrid : BuildStart_Base
	{
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		protected virtual ProceduralGridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}
	}
}
