namespace ScheduleOne.Map
{
	public class DarkMarket : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Map.DarkMarket>
	{
		public global::ScheduleOne.Map.DarkMarketAccessZone AccessZone;

		public global::ScheduleOne.Map.DarkMarketMainDoor MainDoor;

		public global::ScheduleOne.NPCs.CharacterClasses.Oscar Oscar;

		public global::ScheduleOne.Levelling.FullRank UnlockRank;

		private bool NetworkInitialize___EarlyScheduleOne_002EMap_002EDarkMarketAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMap_002EDarkMarketAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; protected set; }

		public bool Unlocked { get; protected set; }

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendUnlocked()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetUnlocked(global::FishNet.Connection.NetworkConnection conn)
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

		private void RpcReader___Server_SendUnlocked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetUnlocked_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___SetUnlocked_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_SetUnlocked_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetUnlocked_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetUnlocked_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
