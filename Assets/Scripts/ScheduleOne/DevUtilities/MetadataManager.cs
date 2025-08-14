namespace ScheduleOne.DevUtilities
{
	public class MetadataManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.DevUtilities.MetadataManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		private global::ScheduleOne.Persistence.Loaders.MetadataLoader loader;

		public global::System.DateTime CreationDate { get; protected set; }

		public string CreationVersion { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		protected override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.MetaData data)
		{
		}
	}
}
