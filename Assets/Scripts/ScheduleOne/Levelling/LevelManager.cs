using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Levelling
{
	public class LevelManager : NetworkSingleton<LevelManager>, IBaseSaveable, ISaveable
	{
		public const int TIERS_PER_RANK = 5;

		public const int XP_PER_TIER_MIN = 200;

		public const int XP_PER_TIER_MAX = 2500;

		private int rankCount;

		public Action<FullRank, FullRank> onRankUp;

		public Dictionary<FullRank, List<Unlockable>> Unlockables;

		private RankLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002ELevelling_002ELevelManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ELevelling_002ELevelManagerAssembly_002DCSharp_002Edll_Excuted;

		public ERank Rank { get; private set; }

		public int Tier { get; private set; }

		public int XP { get; private set; }

		public int TotalXP { get; private set; }

		public float XPToNextTier => 0f;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void AddXP(int xp)
		{
		}

		[ObserversRpc]
		private void AddXPLocal(int xp)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		[ObserversRpc]
		private void IncreaseTierNetworked(FullRank before, FullRank after)
		{
		}

		private void IncreaseTier()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public FullRank GetFullRank()
		{
			return default(FullRank);
		}

		public void AddUnlockable(Unlockable unlockable)
		{
		}

		public int GetTotalXPForRank(FullRank fullrank)
		{
			return 0;
		}

		public FullRank GetFullRank(int totalXp)
		{
			return default(FullRank);
		}

		public int GetXPForTier(ERank rank)
		{
			return 0;
		}

		public static float GetOrderLimitMultiplier(FullRank rank)
		{
			return 0f;
		}

		private static float GetRankOrderLimitMultiplier(ERank rank)
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

		private void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
		{
		}

		private void RpcLogic___AddXPLocal_3316948804(int xp)
		{
		}

		private void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		public void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		private void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		private void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
		}

		private void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
		}

		private void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ELevelling_002ELevelManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
