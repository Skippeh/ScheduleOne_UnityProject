using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Property
{
	public class PropertyManager : Singleton<PropertyManager>, IBaseSaveable, ISaveable
	{
		private PropertiesLoader loader;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

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

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public void LoadProperty(PropertyData propertyData, string containerPath)
		{
		}

		public Property GetProperty(string code)
		{
			return null;
		}
	}
}
