namespace ScheduleOne.Persistence.Loaders
{
	public class BuildableItemLoader : global::ScheduleOne.Persistence.Loaders.Loader
	{
		public virtual string ItemType => null;

		public override void Load(string mainPath)
		{
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.DynamicSaveData data)
		{
		}

		public global::ScheduleOne.Persistence.Datas.BuildableItemData GetBuildableItemData(string mainPath)
		{
			return null;
		}

		protected T GetData<T>(string mainPath) where T : global::ScheduleOne.Persistence.Datas.BuildableItemData
		{
			return null;
		}
	}
}
