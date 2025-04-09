using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Map
{
	public class DarkMarket : NetworkSingleton<DarkMarket>
	{
		public DarkMarketAccessZone AccessZone;

		public DarkMarketMainDoor MainDoor;

		public Oscar Oscar;

		public FullRank UnlockRank;

		private bool NetworkInitialize___EarlyScheduleOne_002EMap_002EDarkMarketAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMap_002EDarkMarketAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; protected set; }

		public bool Unlocked { get; protected set; }

		protected override void Start()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		private void Update()
		{
		}

		private bool ShouldBeOpen()
		{
			return false;
		}

		private void OnLoad()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendUnlocked()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetUnlocked(NetworkConnection conn)
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

		private void RpcWriter___Server_SendUnlocked_2166136261()
		{
		}

		public void RpcLogic___SendUnlocked_2166136261()
		{
		}

		private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		private void RpcLogic___SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
