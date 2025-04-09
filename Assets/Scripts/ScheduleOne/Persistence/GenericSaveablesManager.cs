using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	public class GenericSaveablesManager : Singleton<GenericSaveablesManager>, IBaseSaveable, ISaveable
	{
		protected List<IGenericSaveable> Saveables;

		private GenericSaveablesLoader loader;

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

		public void RegisterSaveable(IGenericSaveable saveable)
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

		public void LoadSaveable(GenericSaveData data)
		{
		}
	}
}
