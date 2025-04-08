namespace ScheduleOne.ConstructableScripts
{
	public class Constructable_GridBased : global::ScheduleOne.ConstructableScripts.Constructable
	{
		[global::UnityEngine.Header("Grid Based Constructable References")]
		public global::UnityEngine.Transform buildPoint;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		public global::UnityEngine.Transform ContentContainer;

		public global::ScheduleOne.Tiles.Grid[] Grids;

		public global::System.Collections.Generic.List<global::UnityEngine.GameObject> roofObjectsForVisibility;

		[global::UnityEngine.Header("Power")]
		[global::UnityEngine.SerializeField]
		protected bool AlwaysPowered;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Property.Utilities.Power.PowerNode powerNode;

		[global::UnityEngine.HideInInspector]
		public bool isGhost;

		protected bool dataChangedThisFrame;

		[global::FishNet.Object.Synchronizing.SyncVar]
		public global::System.Guid OwnerGridGUID;

		[global::FishNet.Object.Synchronizing.SyncVar]
		public global::UnityEngine.Vector2 OriginCoordinate;

		[global::FishNet.Object.Synchronizing.SyncVar]
		public float Rotation;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinatePair> coordinatePairs;

		private global::System.Collections.Generic.Dictionary<global::UnityEngine.GameObject, global::UnityEngine.LayerMask> originalRoofLayers;

		protected bool roofVisible;

		public global::FishNet.Object.Synchronizing.SyncVar<global::System.Guid> syncVar___OwnerGridGUID;

		public global::FishNet.Object.Synchronizing.SyncVar<global::UnityEngine.Vector2> syncVar___OriginCoordinate;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar___Rotation;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstructableScripts_002EConstructable_GridBasedAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstructableScripts_002EConstructable_GridBasedAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Tiles.FootprintTile OriginFootprint => null;

		public int FootprintX => 0;

		public int FootprintY => 0;

		public bool hasWaterSupply => false;

		public global::ScheduleOne.Property.Utilities.Power.PowerNode PowerNode => null;

		public bool isPowered => false;

		public global::ScheduleOne.Tiles.Grid OwnerGrid { get; protected set; }

		public global::System.Guid SyncAccessor_OwnerGridGUID
		{
			get
			{
				return default(global::System.Guid);
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector2 SyncAccessor_OriginCoordinate
		{
			get
			{
				return default(global::UnityEngine.Vector2);
			}
			set
			{
			}
		}

		public float SyncAccessor_Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public override void OnStartServer()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public override void OnStartNetwork()
		{
		}

		public virtual void InitializeConstructable_GridBased(global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, float rotation)
		{
		}

		private void ReceiveData()
		{
		}

		private void SetParent(global::UnityEngine.Transform parent)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(global::System.Guid gridGUID, global::UnityEngine.Vector2 originCoordinate, float rotation)
		{
		}

		public virtual void RepositionConstructable(global::System.Guid gridGUID, global::UnityEngine.Vector2 originCoordinate, float rotation)
		{
		}

		private void RefreshTransform()
		{
		}

		private void ClearPositionData()
		{
		}

		public override void DestroyConstructable(bool callOnServer = true)
		{
		}

		private void GenerateGridGUIDs()
		{
		}

		private string[] GetGridGUIDs()
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		protected void SetGridGUIDs(global::FishNet.Connection.NetworkConnection target, string[] guids)
		{
		}

		public override void SetInvisible()
		{
		}

		public override void RestoreVisibility()
		{
		}

		public virtual void SetRoofVisible(bool vis)
		{
		}

		public void CalculateFootprintTileIntersections()
		{
		}

		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		public global::ScheduleOne.Tiles.FootprintTile GetFootprintTile(global::ScheduleOne.Tiles.Coordinate coord)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.FootprintTile> GetFootprintTiles()
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

		private void RpcWriter___Server_SetData_810381718(global::System.Guid gridGUID, global::UnityEngine.Vector2 originCoordinate, float rotation)
		{
		}

		protected virtual void RpcLogic___SetData_810381718(global::System.Guid gridGUID, global::UnityEngine.Vector2 originCoordinate, float rotation)
		{
		}

		private void RpcReader___Server_SetData_810381718(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetGridGUIDs_2890081366(global::FishNet.Connection.NetworkConnection target, string[] guids)
		{
		}

		protected void RpcLogic___SetGridGUIDs_2890081366(global::FishNet.Connection.NetworkConnection target, string[] guids)
		{
		}

		private void RpcReader___Observers_SetGridGUIDs_2890081366(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetGridGUIDs_2890081366(global::FishNet.Connection.NetworkConnection target, string[] guids)
		{
		}

		private void RpcReader___Target_SetGridGUIDs_2890081366(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EConstructableScripts_002EConstructable_GridBased(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EConstructableScripts_002EConstructable_GridBased_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
