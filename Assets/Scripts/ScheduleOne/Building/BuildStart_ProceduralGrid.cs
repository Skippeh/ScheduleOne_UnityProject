namespace ScheduleOne.Building
{
	public class BuildStart_ProceduralGrid : global::ScheduleOne.Building.BuildStart_Base
	{
		public override void StartBuilding(global::ScheduleOne.ItemFramework.ItemInstance itemInstance)
		{
		}

		protected virtual global::ScheduleOne.EntityFramework.ProceduralGridItem CreateGhostModel(global::ScheduleOne.ItemFramework.BuildableItemDefinition itemDefinition)
		{
			return null;
		}
	}
}
