namespace ScheduleOne.Building
{
	public class BuildUpdate_AirConditioner : global::ScheduleOne.Building.BuildUpdate_Grid
	{
		private global::ScheduleOne.Temperature.AirConditioner _ac;

		private global::ScheduleOne.Temperature.AirConditioner.EMode _currentMode;

		private global::ScheduleOne.Property.Property _currentProperty;

		public override void Initialize(global::ScheduleOne.EntityFramework.GridItem buildableItemClass, global::ScheduleOne.ItemFramework.ItemInstance itemInstance, global::UnityEngine.GameObject ghostModel)
		{
		}

		protected override void Update()
		{
		}

		private void CycleACMode()
		{
		}

		private void SetACMode(global::ScheduleOne.Temperature.AirConditioner.EMode mode)
		{
		}

		protected override void OnPlacedObjectPreSpawn(global::ScheduleOne.EntityFramework.GridItem item)
		{
		}

		protected override void OnClosestIntersectionChanged(global::ScheduleOne.Building.TileIntersection previous, global::ScheduleOne.Building.TileIntersection current)
		{
		}

		private void AddToProperty(global::ScheduleOne.Property.Property property)
		{
		}

		public void RemoveFromPropery()
		{
		}
	}
}
