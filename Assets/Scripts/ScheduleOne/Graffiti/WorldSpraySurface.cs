namespace ScheduleOne.Graffiti
{
	public class WorldSpraySurface : global::ScheduleOne.Graffiti.SpraySurface, global::ScheduleOne.IGUIDRegisterable
	{
		public const int RemoveCartelGraffitiXP = 25;

		private const float RemoveCartelGraffitiInfluenceChange = -0.05f;

		private const float CartelInfluenceChange = -0.05f;

		[global::UnityEngine.Header("Settings")]
		public string BakedGUID;

		[global::UnityEngine.SerializeField]
		private float StandPointWallOffset;

		private bool NetworkInitialize___EarlyScheduleOne_002EGraffiti_002EWorldSpraySurfaceAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGraffiti_002EWorldSpraySurfaceAssembly_002DCSharp_002Edll_Excuted;

		public global::System.Guid GUID { get; protected set; }

		public global::ScheduleOne.Map.EMapRegion Region { get; private set; }

		public bool HasEverBeenMarkedByPlayer { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Transform NPCStandPoint { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public bool CanBeSprayedByNPCs { get; private set; }

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public override void OnEditingFinished()
		{
		}

		public override void CleanGraffiti()
		{
		}

		private void Reward()
		{
		}

		public override void ReplicateTo(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void Set(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkDrawingFinalized()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetFinalized()
		{
		}

		public override bool ShouldSave()
		{
			return false;
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		[global::EasyButtons.Button]
		private void GroundNPCStandPoint()
		{
		}

		public new global::ScheduleOne.Persistence.Datas.WorldSpraySurfaceData GetSaveData()
		{
			return null;
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

		private void RpcWriter___Observers_Set_3759704962(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
		}

		public void RpcLogic___Set_3759704962(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
		}

		private void RpcReader___Observers_Set_3759704962(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Set_3759704962(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
		}

		private void RpcReader___Target_Set_3759704962(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_MarkDrawingFinalized_2166136261()
		{
		}

		public void RpcLogic___MarkDrawingFinalized_2166136261()
		{
		}

		private void RpcReader___Server_MarkDrawingFinalized_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetFinalized_2166136261()
		{
		}

		private void RpcLogic___SetFinalized_2166136261()
		{
		}

		private void RpcReader___Observers_SetFinalized_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EGraffiti_002EWorldSpraySurface_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
