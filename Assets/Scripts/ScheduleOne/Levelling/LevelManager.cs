namespace ScheduleOne.Levelling
{
	public class LevelManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Levelling.LevelManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public const int TIERS_PER_RANK = 5;

		public const int XP_PER_TIER_MIN = 200;

		public const int XP_PER_TIER_MAX = 2500;

		private int rankCount;

		public global::System.Action<global::ScheduleOne.Levelling.FullRank, global::ScheduleOne.Levelling.FullRank> onRankUp;

		public global::System.Action<global::ScheduleOne.Levelling.FullRank, global::ScheduleOne.Levelling.FullRank> onRankChanged;

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Levelling.FullRank, global::System.Collections.Generic.List<global::ScheduleOne.Levelling.Unlockable>> Unlockables;

		private global::ScheduleOne.Persistence.Loaders.RankLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002ELevelling_002ELevelManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ELevelling_002ELevelManagerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Levelling.ERank Rank { get; private set; }

		public int Tier { get; private set; }

		public int XP { get; private set; }

		public int TotalXP { get; private set; }

		public float XPToNextTier => 0f;

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

		public virtual void InitializeSaveable()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void AddXP(int xp)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void AddXPLocal(int xp)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetData(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Levelling.ERank rank, int tier, int xp, int totalXp)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetUnlockedRegions(global::FishNet.Connection.NetworkConnection conn, global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> unlockedRegions)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void IncreaseTierNetworked(global::ScheduleOne.Levelling.FullRank before, global::ScheduleOne.Levelling.FullRank after)
		{
		}

		private void IncreaseTier()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public global::ScheduleOne.Levelling.FullRank GetFullRank()
		{
			return default(global::ScheduleOne.Levelling.FullRank);
		}

		public void AddUnlockable(global::ScheduleOne.Levelling.Unlockable unlockable)
		{
		}

		public int GetTotalXPForRank(global::ScheduleOne.Levelling.FullRank fullrank)
		{
			return 0;
		}

		public global::ScheduleOne.Levelling.FullRank GetFullRank(int totalXp)
		{
			return default(global::ScheduleOne.Levelling.FullRank);
		}

		public int GetXPForTier(global::ScheduleOne.Levelling.ERank rank)
		{
			return 0;
		}

		public static float GetOrderLimitMultiplier(global::ScheduleOne.Levelling.FullRank rank)
		{
			return 0f;
		}

		private static float GetRankOrderLimitMultiplier(global::ScheduleOne.Levelling.ERank rank)
		{
			return 0f;
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

		private void RpcWriter___Server_AddXP_3316948804(int xp)
		{
		}

		public void RpcLogic___AddXP_3316948804(int xp)
		{
		}

		private void RpcReader___Server_AddXP_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
		{
		}

		private void RpcLogic___AddXPLocal_3316948804(int xp)
		{
		}

		private void RpcReader___Observers_AddXPLocal_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetData_20965027(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Levelling.ERank rank, int tier, int xp, int totalXp)
		{
		}

		public void RpcLogic___SetData_20965027(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Levelling.ERank rank, int tier, int xp, int totalXp)
		{
		}

		private void RpcReader___Observers_SetData_20965027(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetData_20965027(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Levelling.ERank rank, int tier, int xp, int totalXp)
		{
		}

		private void RpcReader___Target_SetData_20965027(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetUnlockedRegions_563230222(global::FishNet.Connection.NetworkConnection conn, global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> unlockedRegions)
		{
		}

		public void RpcLogic___SetUnlockedRegions_563230222(global::FishNet.Connection.NetworkConnection conn, global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> unlockedRegions)
		{
		}

		private void RpcReader___Observers_SetUnlockedRegions_563230222(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetUnlockedRegions_563230222(global::FishNet.Connection.NetworkConnection conn, global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> unlockedRegions)
		{
		}

		private void RpcReader___Target_SetUnlockedRegions_563230222(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_IncreaseTierNetworked_3953286437(global::ScheduleOne.Levelling.FullRank before, global::ScheduleOne.Levelling.FullRank after)
		{
		}

		private void RpcLogic___IncreaseTierNetworked_3953286437(global::ScheduleOne.Levelling.FullRank before, global::ScheduleOne.Levelling.FullRank after)
		{
		}

		private void RpcReader___Observers_IncreaseTierNetworked_3953286437(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ELevelling_002ELevelManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
