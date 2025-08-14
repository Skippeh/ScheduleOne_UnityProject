namespace ScheduleOne.Storage
{
	public class WorldStorageEntity : global::ScheduleOne.Storage.StorageEntity, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.ISaveable
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.Storage.WorldStorageEntity> All;

		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		public global::ScheduleOne.GameTime.GameDateTime LastContentChangeTime;

		private bool NetworkInitialize___EarlyScheduleOne_002EStorage_002EWorldStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EStorage_002EWorldStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		public global::System.Guid GUID { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		public override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public virtual bool ShouldSave()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.WorldStorageEntityData GetSaveData()
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.WorldStorageEntityData data)
		{
		}

		protected override void ContentsChanged()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EStorage_002EWorldStorageEntity_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
