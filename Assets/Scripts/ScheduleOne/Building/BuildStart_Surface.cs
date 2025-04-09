using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Building
{
	public class BuildStart_Surface : BuildStart_Base
	{
		public override void StartBuilding(ItemInstance itemInstance)
		{
		}

		protected virtual SurfaceItem CreateGhostModel(BuildableItemDefinition itemDefinition)
		{
			return null;
		}
	}
}
