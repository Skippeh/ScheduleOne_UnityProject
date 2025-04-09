namespace ScheduleOne.Building
{
	public class BuildStart_Surface : global::ScheduleOne.Building.BuildStart_Base
	{
		public override void StartBuilding(global::ScheduleOne.ItemFramework.ItemInstance itemInstance)
		{
		}

		protected virtual global::ScheduleOne.EntityFramework.SurfaceItem CreateGhostModel(global::ScheduleOne.ItemFramework.BuildableItemDefinition itemDefinition)
		{
			return null;
		}
	}
}
