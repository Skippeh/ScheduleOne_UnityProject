namespace ScheduleOne.DevUtilities
{
	public class GameManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.DevUtilities.GameManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public const bool IS_DEMO = false;

		public static bool IS_BETA;

		[global::UnityEngine.SerializeField]
		private int seed;

		public string OrganisationName;

		public global::ScheduleOne.DevUtilities.GameSettings Settings;

		public global::UnityEngine.Transform SpawnPoint;

		public global::UnityEngine.Transform NoHomeRespawnPoint;

		public global::UnityEngine.Transform Temp;

		public global::UnityEngine.Events.UnityEvent onSettingsLoaded;

		private global::ScheduleOne.Persistence.Loaders.GameDataLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EDevUtilities_002EGameManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EDevUtilities_002EGameManagerAssembly_002DCSharp_002Edll_Excuted;

		public static bool IS_TUTORIAL => false;

		public static int Seed => 0;

		public global::UnityEngine.Sprite OrganisationLogo { get; protected set; }

		public bool IsTutorial => false;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.TargetRpc]
		public void SetGameData(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.GameData data)
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.GameData data, string path)
		{
		}

		[global::EasyButtons.Button]
		public void EndTutorial(bool natural)
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

		private void RpcWriter___Target_SetGameData_3076874643(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.GameData data)
		{
		}

		public void RpcLogic___SetGameData_3076874643(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.GameData data)
		{
		}

		private void RpcReader___Target_SetGameData_3076874643(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EDevUtilities_002EGameManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
