namespace ScheduleOne.Building
{
	public class BuildStart_AirConditioner : global::ScheduleOne.Building.BuildStart_Grid
	{
		private global::ScheduleOne.Temperature.AirConditioner ac;

		public override void StartBuilding(global::ScheduleOne.ItemFramework.ItemInstance itemInstance)
		{
		}

		protected override string GetInputPromptsModuleName()
		{
			return null;
		}
	}
}
