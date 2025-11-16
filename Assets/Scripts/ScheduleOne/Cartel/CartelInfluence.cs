namespace ScheduleOne.Cartel
{
	public class CartelInfluence : global::FishNet.Object.NetworkBehaviour
	{
		[global::System.Serializable]
		public class RegionInfluenceData
		{
			private string name;

			public global::ScheduleOne.Map.EMapRegion Region;

			[global::UnityEngine.Range(0f, 1f)]
			public float Influence;

			public RegionInfluenceData(global::ScheduleOne.Map.EMapRegion region, float influence = 0f)
			{
			}
		}

		public const float INFLUENCE_TO_UNLOCK_NEXT_REGION = 0.3f;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData[] DefaultRegionInfluence;

		private global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData> regionInfluence;

		public global::System.Action<global::ScheduleOne.Map.EMapRegion, float, float> OnInfluenceChanged;

		private bool NetworkInitialize___EarlyScheduleOne_002ECartel_002ECartelInfluenceAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECartel_002ECartelInfluenceAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData[] GetAllRegionInfluence()
		{
			return null;
		}

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		protected override void OnValidate()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void ChangeInfluence(global::ScheduleOne.Map.EMapRegion region, float amount)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetInfluence(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Map.EMapRegion region, float influence)
		{
		}

		public float GetInfluence(global::ScheduleOne.Map.EMapRegion region)
		{
			return 0f;
		}

		private void OnSleepEnd()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ChangeInfluence(global::ScheduleOne.Map.EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		private global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData GetRegionData(global::ScheduleOne.Map.EMapRegion region)
		{
			return null;
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_ChangeInfluence_2792544924(global::ScheduleOne.Map.EMapRegion region, float amount)
		{
		}

		public void RpcLogic___ChangeInfluence_2792544924(global::ScheduleOne.Map.EMapRegion region, float amount)
		{
		}

		private void RpcReader___Server_ChangeInfluence_2792544924(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetInfluence_2071772313(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Map.EMapRegion region, float influence)
		{
		}

		public void RpcLogic___SetInfluence_2071772313(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Map.EMapRegion region, float influence)
		{
		}

		private void RpcReader___Observers_SetInfluence_2071772313(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetInfluence_2071772313(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Map.EMapRegion region, float influence)
		{
		}

		private void RpcReader___Target_SetInfluence_2071772313(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ChangeInfluence_1267088319(global::ScheduleOne.Map.EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		private void RpcLogic___ChangeInfluence_1267088319(global::ScheduleOne.Map.EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		private void RpcReader___Observers_ChangeInfluence_1267088319(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ECartel_002ECartelInfluence_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
