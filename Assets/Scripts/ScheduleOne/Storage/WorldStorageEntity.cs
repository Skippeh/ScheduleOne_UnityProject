using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Storage
{
	public class WorldStorageEntity : StorageEntity, IGUIDRegisterable, ISaveable
	{
		public static List<WorldStorageEntity> All;

		[SerializeField]
		protected string BakedGUID;

		private bool NetworkInitialize___EarlyScheduleOne_002EStorage_002EWorldStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EStorage_002EWorldStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		public Guid GUID { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		[Button]
		public void RegenerateGUID()
		{
		}

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		public virtual bool ShouldSave()
		{
			return false;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual void Load(WorldStorageEntityData data)
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
