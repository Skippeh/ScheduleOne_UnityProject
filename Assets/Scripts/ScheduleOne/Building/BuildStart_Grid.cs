using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	public class BuildStart_Grid : BuildStart_Base
	{
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		protected virtual GridItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}
	}
}
