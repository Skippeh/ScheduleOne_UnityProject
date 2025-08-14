namespace ScheduleOne.GamePhysics
{
	public class PhysicsManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.GamePhysics.PhysicsManager>
	{
		public const bool AUTO_SYNC_TRANSFORMS = true;

		private bool NetworkInitialize___EarlyScheduleOne_002EGamePhysics_002EPhysicsManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGamePhysics_002EPhysicsManagerAssembly_002DCSharp_002Edll_Excuted;

		public float GravityMultiplier { get; private set; }

		public override void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetGravityMultiplier(global::FishNet.Connection.NetworkConnection conn, float gravity)
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

		private void RpcWriter___Observers_SetGravityMultiplier_530160725(global::FishNet.Connection.NetworkConnection conn, float gravity)
		{
		}

		public void RpcLogic___SetGravityMultiplier_530160725(global::FishNet.Connection.NetworkConnection conn, float gravity)
		{
		}

		private void RpcReader___Observers_SetGravityMultiplier_530160725(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetGravityMultiplier_530160725(global::FishNet.Connection.NetworkConnection conn, float gravity)
		{
		}

		private void RpcReader___Target_SetGravityMultiplier_530160725(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EGamePhysics_002EPhysicsManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
