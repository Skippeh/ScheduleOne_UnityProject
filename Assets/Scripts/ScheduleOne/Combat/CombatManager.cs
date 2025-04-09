using System.Collections.Generic;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Combat
{
	public class CombatManager : NetworkSingleton<CombatManager>
	{
		public LayerMask MeleeLayerMask;

		public LayerMask ExplosionLayerMask;

		public LayerMask RangedWeaponLayerMask;

		public Explosion ExplosionPrefab;

		private List<int> explosionIDs;

		private bool NetworkInitialize___EarlyScheduleOne_002ECombat_002ECombatManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECombat_002ECombatManagerAssembly_002DCSharp_002Edll_Excuted;

		[Button]
		public void CreateTestExplosion()
		{
		}

		public void CreateExplosion(Vector3 origin, ExplosionData data)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void CreateExplosion(Vector3 origin, ExplosionData data, int id)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void Explosion(Vector3 origin, ExplosionData data, int id)
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

		private void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		private void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		private void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		private void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		private void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
