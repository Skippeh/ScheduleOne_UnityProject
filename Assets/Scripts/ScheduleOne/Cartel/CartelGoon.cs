namespace ScheduleOne.Cartel
{
	public class CartelGoon : global::ScheduleOne.NPCs.NPC
	{
		private global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelGoon> goonMates;

		private global::ScheduleOne.Cartel.CartelGoonAppearance appearance;

		public global::System.Action onDespawn;

		private bool NetworkInitialize___EarlyScheduleOne_002ECartel_002ECartelGoonAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECartel_002ECartelGoonAssembly_002DCSharp_002Edll_Excuted;

		public bool IsGoonSpawned { get; private set; }

		public global::ScheduleOne.Cartel.GoonPool GoonPool => null;

		protected override void Start()
		{
		}

		public override void OnStartServer()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void Spawn(global::ScheduleOne.Cartel.GoonPool pool, global::UnityEngine.Vector3 spawnPoint)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Spawn_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ConfigureGoonSettings(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		public void Despawn()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Despawn_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public void AttackEntity(global::ScheduleOne.Combat.ICombatTargetable target, bool includeGoonMates = true)
		{
		}

		public void AddGoonMate(global::ScheduleOne.Cartel.CartelGoon goonMate)
		{
		}

		public void RemoveGoonMate(global::ScheduleOne.Cartel.CartelGoon goonMate)
		{
		}

		public bool IsMatesWith(global::ScheduleOne.Cartel.CartelGoon otherGoon)
		{
			return false;
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

		private void RpcWriter___Observers_Spawn_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___Spawn_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Spawn_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Spawn_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Spawn_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ConfigureGoonSettings_3427656873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		private void RpcLogic___ConfigureGoonSettings_3427656873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		private void RpcReader___Observers_ConfigureGoonSettings_3427656873(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ConfigureGoonSettings_3427656873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		private void RpcReader___Target_ConfigureGoonSettings_3427656873(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Despawn_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___Despawn_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Despawn_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Despawn_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Despawn_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
