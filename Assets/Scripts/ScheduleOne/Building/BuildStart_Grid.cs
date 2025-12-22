namespace ScheduleOne.Building
{
	public class BuildStart_Grid : global::ScheduleOne.Building.BuildStart_Base
	{
		protected global::ScheduleOne.EntityFramework.GridItem ghostModelClass;

		public override void StartBuilding(global::ScheduleOne.ItemFramework.ItemInstance itemInstance)
		{
		}

		protected virtual string GetInputPromptsModuleName()
		{
			return null;
		}

		protected virtual global::ScheduleOne.EntityFramework.GridItem CreateGhostModel(global::ScheduleOne.ItemFramework.BuildableItemDefinition itemDefinition)
		{
			return null;
		}
	}
}
