namespace ScheduleOne.EntityFramework
{
	public class GridItem : global::ScheduleOne.EntityFramework.BuildableItem
	{
		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		protected global::System.Guid _ownerGridGUID;

		protected global::UnityEngine.Vector2 _originCoordinate;

		protected int _rotation;

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

		protected override void SendInitializationToServer()
		{
		}

		protected override void SendInitializationToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void InitializeGridItem_Server(global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void InitializeGridItem_Client(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
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

		protected override void Destroy()
		{
		}

		protected virtual void OnTileTemperatureChanged(global::ScheduleOne.Tiles.Tile tile, float newTemp)
		{
		}

		public float GetAverageTileTemperature()
		{
			return 0f;
		}

		public float GetAverageCosmeticTileTemperature()
		{
			return 0f;
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

		private void RpcWriter___Server_InitializeGridItem_Server_2821640832(global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		public void RpcLogic___InitializeGridItem_Server_2821640832(global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void RpcReader___Server_InitializeGridItem_Server_2821640832(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_InitializeGridItem_Client_1883577149(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void RpcLogic___InitializeGridItem_Client_1883577149(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void RpcReader___Target_InitializeGridItem_Client_1883577149(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_InitializeGridItem_Client_1883577149(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string gridGUID, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void RpcReader___Observers_InitializeGridItem_Client_1883577149(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002EGridItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
