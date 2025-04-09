using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	public class BuildableItemLoader : Loader
	{
		public virtual string ItemType => null;

		public override void Load(string mainPath)
		{
		}

		public BuildableItemData GetBuildableItemData(string mainPath)
		{
			return null;
		}

		protected T GetData<T>(string mainPath) where T : BuildableItemData
		{
			return null;
		}
	}
}
