using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	public class ProceduralGridItem : BuildableItem
	{
		public class FootprintTileMatch
		{
			public FootprintTile footprint;

			public ProceduralTile matchedTile;
		}

		[Header("Grid item data")]
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		public ProceduralTile.EProceduralTileType ProceduralTileType;

		[SyncVar]
		[HideInInspector]
		public int Rotation;

		[SyncVar]
		[HideInInspector]
		public List<CoordinateProceduralTilePair> footprintTileMatches;

		public SyncVar<int> syncVar___Rotation;

		public SyncVar<List<CoordinateProceduralTilePair>> syncVar___footprintTileMatches;

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

		public List<CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches
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

		public override void OnStartClient()
		{
		}

		protected override void SendInitToClient(NetworkConnection conn)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendProceduralGridItemData(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void InitializeProceduralGridItem(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		public virtual void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		protected virtual void SetProceduralGridData(int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches)
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

		protected override ScheduleOne.Property.Property GetProperty(Transform searchTransform = null)
		{
			return null;
		}

		public virtual void CalculateFootprintTileIntersections()
		{
		}

		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		public FootprintTile GetFootprintTile(Coordinate coord)
		{
			return null;
		}

		public override string GetSaveString()
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

		private void RpcWriter___Server_SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		public void RpcLogic___SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		private void RpcReader___Server_SendProceduralGridItemData_638911643(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		public virtual void RpcLogic___InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		private void RpcReader___Target_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		private void RpcReader___Observers_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEntityFramework_002EProceduralGridItem(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002EProceduralGridItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
