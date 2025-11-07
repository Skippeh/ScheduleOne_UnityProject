namespace ScheduleOne.PlayerTasks
{
	public class PackageProductTaskMk2 : global::ScheduleOne.PlayerTasks.Task
	{
		protected global::ScheduleOne.Packaging.PackagingStationMk2 station;

		protected global::ScheduleOne.Packaging.FunctionalPackaging Packaging;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Product.FunctionalProduct> Products;

		public override string TaskName { get; protected set; }

		public PackageProductTaskMk2(global::ScheduleOne.Packaging.PackagingStationMk2 _station)
		{
		}

		public override void StopTask()
		{
		}
	}
}
