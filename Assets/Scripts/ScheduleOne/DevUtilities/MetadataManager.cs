using System;
using System.Collections.Generic;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.DevUtilities
{
	public class MetadataManager : Singleton<MetadataManager>, IBaseSaveable, ISaveable
	{
		private MetadataLoader loader;

		public DateTime CreationDate { get; protected set; }

		public string CreationVersion { get; protected set; }

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

		public void Load(MetaData data)
		{
		}
	}
}
