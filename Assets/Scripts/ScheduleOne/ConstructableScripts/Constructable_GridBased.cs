using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Property.Utilities.Power;
using ScheduleOne.Tiles;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.ConstructableScripts
{
	public class Constructable_GridBased : Constructable
	{
		[Header("Grid Based Constructable References")]
		public Transform buildPoint;

		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		public Transform ContentContainer;

		public Grid[] Grids;

		public List<GameObject> roofObjectsForVisibility;

		[Header("Power")]
		[SerializeField]
		protected bool AlwaysPowered;

		[SerializeField]
		protected PowerNode powerNode;

		[HideInInspector]
		public bool isGhost;

		protected bool dataChangedThisFrame;

		[SyncVar]
		public Guid OwnerGridGUID;

		[SyncVar]
		public Vector2 OriginCoordinate;

		[SyncVar]
		public float Rotation;

		public List<CoordinatePair> coordinatePairs;

		private Dictionary<GameObject, LayerMask> originalRoofLayers;

		protected bool roofVisible;

		public SyncVar<Guid> syncVar___OwnerGridGUID;

		public SyncVar<Vector2> syncVar___OriginCoordinate;

		public SyncVar<float> syncVar___Rotation;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstructableScripts_002EConstructable_GridBasedAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstructableScripts_002EConstructable_GridBasedAssembly_002DCSharp_002Edll_Excuted;

		public FootprintTile OriginFootprint => null;

		public int FootprintX => 0;

		public int FootprintY => 0;

		public bool hasWaterSupply => false;

		public PowerNode PowerNode => null;

		public bool isPowered => false;

		public Grid OwnerGrid { get; protected set; }

		public Guid SyncAccessor_OwnerGridGUID
		{
			get
			{
				return default(Guid);
			}
			set
			{
			}
		}

		public Vector2 SyncAccessor_OriginCoordinate
		{
			get
			{
				return default(Vector2);
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

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public override void OnStartNetwork()
		{
		}

		public virtual void InitializeConstructable_GridBased(Grid grid, Vector2 originCoordinate, float rotation)
		{
		}

		private void ReceiveData()
		{
		}

		private void SetParent(Transform parent)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
		}

		public virtual void RepositionConstructable(Guid gridGUID, Vector2 originCoordinate, float rotation)
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

		[ObserversRpc]
		[TargetRpc]
		protected void SetGridGUIDs(NetworkConnection target, string[] guids)
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

		public FootprintTile GetFootprintTile(Coordinate coord)
		{
			return null;
		}

		public List<FootprintTile> GetFootprintTiles()
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

		private void RpcWriter___Server_SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
		}

		protected virtual void RpcLogic___SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
		}

		private void RpcReader___Server_SetData_810381718(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
		{
		}

		protected void RpcLogic___SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
		{
		}

		private void RpcReader___Observers_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
		{
		}

		private void RpcReader___Target_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EConstructableScripts_002EConstructable_GridBased(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EConstructableScripts_002EConstructable_GridBased_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
