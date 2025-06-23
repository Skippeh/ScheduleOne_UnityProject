namespace ScheduleOne.EntityFramework
{
	public class GridItem : global::ScheduleOne.EntityFramework.BuildableItem
	{
		public enum EGridType
		{
			All = 0,
			IndoorOnly = 1,
			OutdoorOnly = 2
		}

		[global::UnityEngine.Header("Grid item data")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		public global::ScheduleOne.EntityFramework.GridItem.EGridType GridType;

		public global::System.Guid OwnerGridGUID;

		public global::UnityEngine.Vector2 OriginCoordinate;

		public int Rotation;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinatePair> CoordinatePairs;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002EGridItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002EGridItemAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Tiles.FootprintTile OriginFootprint => null;

		public int FootprintX => 0;

		public int FootprintY => 0;

		public global::ScheduleOne.Tiles.Grid OwnerGrid { get; protected set; }

		public override void Awake()
		{
		}

		public override void OnStartClient()
		{
		}

		protected override void SendInitToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendGridItemData(global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void InitializeGridItem(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		public virtual void InitializeGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		protected void SetGridData(global::System.Guid gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation)
		{
		}

		private int ValidateRotation(int rotation)
		{
			return 0;
		}

		private void ProcessGridData()
		{
		}

		private void RefreshTransform()
		{
		}

		private void ClearPositionData()
		{
		}

		public override void DestroyItem(bool callOnServer = true)
		{
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

		public global::ScheduleOne.Tiles.Tile GetParentTileAtFootprintCoordinate(global::ScheduleOne.Tiles.Coordinate footprintCoord)
		{
			return null;
		}

		public virtual bool CanShareTileWith(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.GridItem> obstacles)
		{
			return false;
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

		private void RpcWriter___Server_SendGridItemData_2821640832(global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		public void RpcLogic___SendGridItemData_2821640832(global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void RpcReader___Server_SendGridItemData_2821640832(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_InitializeGridItem_1883577149(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		public virtual void RpcLogic___InitializeGridItem_1883577149(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void RpcReader___Target_InitializeGridItem_1883577149(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_InitializeGridItem_1883577149(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void RpcReader___Observers_InitializeGridItem_1883577149(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002EGridItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
