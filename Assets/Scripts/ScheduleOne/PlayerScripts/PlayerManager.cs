using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using Unity.AI.Navigation;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	public class PlayerManager : Singleton<PlayerManager>, IBaseSaveable, ISaveable
	{
		private PlayersLoader loader;

		[SerializeField]
		protected List<PlayerData> loadedPlayerData;

		protected List<string> loadedPlayerDataPaths;

		protected List<string> loadedPlayerFileNames;

		public NavMeshSurface PlayerRecoverySurface;

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

		public void SavePlayer(Player player)
		{
		}

		public void LoadPlayer(PlayerData data, string containerPath)
		{
		}

		public void AllPlayerFilesLoaded()
		{
		}

		public bool TryGetPlayerData(string playerCode, out PlayerData data, out string inventoryString, out string appearanceString, out string clothingString, out VariableData[] variables)
		{
			data = null;
			inventoryString = null;
			appearanceString = null;
			clothingString = null;
			variables = null;
			return false;
		}
	}
}
