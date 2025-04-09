using ScheduleOne.EntityFramework;

namespace ScheduleOne.Persistence.Loaders
{
	public class ProceduralGridItemLoader : BuildableItemLoader
	{
		public override string ItemType => null;

		public override void Load(string mainPath)
		{
		}

		protected ProceduralGridItem LoadAndCreate(string mainPath)
		{
			return null;
		}
	}
}
