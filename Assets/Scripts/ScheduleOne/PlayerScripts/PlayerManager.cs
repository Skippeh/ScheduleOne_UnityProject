namespace ScheduleOne.PlayerScripts
{
	public class PlayerManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.PlayerScripts.PlayerManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		private global::ScheduleOne.Persistence.Loaders.PlayersLoader loader;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.PlayerData> loadedPlayerData;

		protected global::System.Collections.Generic.List<string> loadedPlayerDataPaths;

		protected global::System.Collections.Generic.List<string> loadedPlayerFileNames;

		public global::Unity.AI.Navigation.NavMeshSurface PlayerRecoverySurface;

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

		public void SavePlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public void LoadPlayer(global::ScheduleOne.Persistence.Datas.PlayerData data, string containerPath)
		{
		}

		public void AllPlayerFilesLoaded()
		{
		}

		public bool TryGetPlayerData(string playerCode, out global::ScheduleOne.Persistence.Datas.PlayerData data, out string inventoryString, out string appearanceString, out string clothingString, out global::ScheduleOne.Persistence.Datas.VariableData[] variables)
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
