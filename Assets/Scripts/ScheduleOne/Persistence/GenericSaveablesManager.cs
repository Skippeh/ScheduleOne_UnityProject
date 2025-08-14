namespace ScheduleOne.Persistence
{
	public class GenericSaveablesManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Persistence.GenericSaveablesManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		protected global::System.Collections.Generic.List<global::ScheduleOne.Persistence.IGenericSaveable> Saveables;

		private global::ScheduleOne.Persistence.Loaders.GenericSaveablesLoader loader;

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

		public void RegisterSaveable(global::ScheduleOne.Persistence.IGenericSaveable saveable)
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void LoadSaveable(global::ScheduleOne.Persistence.Datas.GenericSaveData data)
		{
		}
	}
}
