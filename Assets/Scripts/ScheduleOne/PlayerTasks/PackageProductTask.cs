using System.Collections.Generic;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Packaging;

namespace ScheduleOne.PlayerTasks
{
	public class PackageProductTask : Task
	{
		protected PackagingStation station;

		protected FunctionalPackaging Packaging;

		protected List<FunctionalProduct> Products;

		public override string TaskName { get; protected set; }

		public PackageProductTask(PackagingStation _station)
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
