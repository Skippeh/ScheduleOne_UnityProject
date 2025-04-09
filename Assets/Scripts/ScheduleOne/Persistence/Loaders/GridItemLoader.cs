using ScheduleOne.EntityFramework;

namespace ScheduleOne.Persistence.Loaders
{
	public class GridItemLoader : BuildableItemLoader
	{
		public override string ItemType => null;

		public override void Load(string mainPath)
		{
		}

		protected GridItem LoadAndCreate(string mainPath)
		{
			return null;
		}
	}
}
