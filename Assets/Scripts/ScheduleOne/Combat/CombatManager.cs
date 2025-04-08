namespace ScheduleOne.Combat
{
	public class CombatManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Combat.CombatManager>
	{
		public global::UnityEngine.LayerMask MeleeLayerMask;

		public global::UnityEngine.LayerMask ExplosionLayerMask;

		public global::UnityEngine.LayerMask RangedWeaponLayerMask;

		public global::ScheduleOne.Combat.Explosion ExplosionPrefab;

		private global::System.Collections.Generic.List<int> explosionIDs;

		private bool NetworkInitialize___EarlyScheduleOne_002ECombat_002ECombatManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECombat_002ECombatManagerAssembly_002DCSharp_002Edll_Excuted;

		[global::EasyButtons.Button]
		public void CreateTestExplosion()
		{
		}

		public void CreateExplosion(global::UnityEngine.Vector3 origin, global::ScheduleOne.Combat.ExplosionData data)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void CreateExplosion(global::UnityEngine.Vector3 origin, global::ScheduleOne.Combat.ExplosionData data, int id)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void Explosion(global::UnityEngine.Vector3 origin, global::ScheduleOne.Combat.ExplosionData data, int id)
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

		private void RpcWriter___Server_CreateExplosion_2907189355(global::UnityEngine.Vector3 origin, global::ScheduleOne.Combat.ExplosionData data, int id)
		{
		}

		private void RpcLogic___CreateExplosion_2907189355(global::UnityEngine.Vector3 origin, global::ScheduleOne.Combat.ExplosionData data, int id)
		{
		}

		private void RpcReader___Server_CreateExplosion_2907189355(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Explosion_2907189355(global::UnityEngine.Vector3 origin, global::ScheduleOne.Combat.ExplosionData data, int id)
		{
		}

		private void RpcLogic___Explosion_2907189355(global::UnityEngine.Vector3 origin, global::ScheduleOne.Combat.ExplosionData data, int id)
		{
		}

		private void RpcReader___Observers_Explosion_2907189355(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
