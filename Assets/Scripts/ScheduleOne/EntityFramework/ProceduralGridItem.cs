namespace ScheduleOne.EntityFramework
{
	public class ProceduralGridItem : global::ScheduleOne.EntityFramework.BuildableItem
	{
		public class FootprintTileMatch
		{
			public global::ScheduleOne.Tiles.FootprintTile footprint;

			public global::ScheduleOne.Tiles.ProceduralTile matchedTile;
		}

		[global::UnityEngine.Header("Grid item data")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		public global::ScheduleOne.Tiles.ProceduralTile.EProceduralTileType ProceduralTileType;

		[global::FishNet.Object.Synchronizing.SyncVar]
		[global::UnityEngine.HideInInspector]
		public int Rotation;

		[global::FishNet.Object.Synchronizing.SyncVar]
		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> footprintTileMatches;

		public global::FishNet.Object.Synchronizing.SyncVar<int> syncVar___Rotation;

		public global::FishNet.Object.Synchronizing.SyncVar<global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair>> syncVar___footprintTileMatches;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002EProceduralGridItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002EProceduralGridItemAssembly_002DCSharp_002Edll_Excuted;

		public int FootprintXSize => 0;

		public int FootprintYSize => 0;

		public int SyncAccessor_Rotation
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		protected override void SendInitializationToServer()
		{
		}

		protected override void SendInitializationToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void InitializeProceduralGridItem_Server(global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void InitializeProceduralGridItem_Client(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		public virtual void InitializeProceduralGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		protected virtual void SetProceduralGridData(int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches)
		{
		}

		private void RefreshTransform()
		{
		}

		private void ClearPositionData()
		{
		}

		protected override void Destroy()
		{
		}

		protected override global::ScheduleOne.Property.Property GetProperty(global::UnityEngine.Transform searchTransform = null)
		{
			return null;
		}

		public virtual void CalculateFootprintTileIntersections()
		{
		}

		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		public global::ScheduleOne.Tiles.FootprintTile GetFootprintTile(global::ScheduleOne.Tiles.Coordinate coord)
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
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

		private void RpcWriter___Server_InitializeProceduralGridItem_Server_638911643(global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		public void RpcLogic___InitializeProceduralGridItem_Server_638911643(global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		private void RpcReader___Server_InitializeProceduralGridItem_Server_638911643(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_InitializeProceduralGridItem_Client_3164718044(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		public virtual void RpcLogic___InitializeProceduralGridItem_Client_3164718044(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		private void RpcReader___Target_InitializeProceduralGridItem_Client_3164718044(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_InitializeProceduralGridItem_Client_3164718044(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		private void RpcReader___Observers_InitializeProceduralGridItem_Client_3164718044(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEntityFramework_002EProceduralGridItem(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002EProceduralGridItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
