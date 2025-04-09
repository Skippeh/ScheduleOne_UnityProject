using ScheduleOne.EntityFramework;

namespace ScheduleOne.Persistence.Loaders
{
	public class SurfaceItemLoader : BuildableItemLoader
	{
		public override string ItemType => null;

		public override void Load(string mainPath)
		{
		}

		protected SurfaceItem LoadAndCreate(string mainPath)
		{
			return null;
		}
	}
}
