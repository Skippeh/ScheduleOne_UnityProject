using System.Collections.Generic;
using ScheduleOne.Packaging;

namespace ScheduleOne.PlayerTasks
{
	public class PackageProductTaskMk2 : Task
	{
		protected PackagingStationMk2 station;

		protected FunctionalPackaging Packaging;

		protected List<FunctionalProduct> Products;

		public override string TaskName { get; protected set; }

		public PackageProductTaskMk2(PackagingStationMk2 _station)
		{
		}

		public override void StopTask()
		{
		}
	}
}
