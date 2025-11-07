namespace ScheduleOne.PlayerTasks
{
	public class PackageProductTask : global::ScheduleOne.PlayerTasks.Task
	{
		protected global::ScheduleOne.ObjectScripts.PackagingStation station;

		protected global::ScheduleOne.Packaging.FunctionalPackaging Packaging;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Product.FunctionalProduct> Products;

		public override string TaskName { get; protected set; }

		public PackageProductTask(global::ScheduleOne.ObjectScripts.PackagingStation _station)
		{
		}

		public override void StopTask()
		{
		}

		public override void Success()
		{
		}

		private void FullyPacked()
		{
		}

		private void Sealed()
		{
		}

		private void ReachedOutput()
		{
		}
	}
}
