namespace ScheduleOne.Property
{
	public class PropertyManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Property.PropertyManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		private global::ScheduleOne.Persistence.Loaders.PropertiesLoader loader;

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

		public virtual global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		public void LoadProperty(global::ScheduleOne.Persistence.Datas.PropertyData propertyData, string dataString)
		{
		}

		public global::ScheduleOne.Property.Property GetProperty(string code)
		{
			return null;
		}
	}
}
