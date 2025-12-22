namespace ScheduleOne.Building
{
	public class BuildUpdate_GrowContainer : global::ScheduleOne.Building.BuildUpdate_Grid
	{
		private global::ScheduleOne.Growing.GrowContainer _gc;

		private static bool _showTemps;

		public override void Initialize(global::ScheduleOne.EntityFramework.GridItem buildableItemClass, global::ScheduleOne.ItemFramework.ItemInstance itemInstance, global::UnityEngine.GameObject ghostModel)
		{
		}

		private float GetTemperature()
		{
			return 0f;
		}

		private bool GetTemperatureVisibility()
		{
			return false;
		}

		protected override void SetShowTemperatures(bool show, global::ScheduleOne.Property.Property property)
		{
		}
	}
}
