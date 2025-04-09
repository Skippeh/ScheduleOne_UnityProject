using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	public class Packager : Employee, IConfigurable
	{
		[Header("References")]
		public Sprite typeIcon;

		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		public PackagingStationBehaviour PackagingBehaviour;

		public BrickPressBehaviour BrickPressBehaviour;

		[Header("UI")]
		public PackagerUIElement WorldspaceUIPrefab;

		public Transform uiPoint;

		[Header("Settings")]
		public int MaxAssignedStations;

		[Header("Proficiency Settings")]
		public float PackagingSpeedMultiplier;

		public SyncVar<NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002EPackagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002EPackagerAssembly_002DCSharp_002Edll_Excuted;

		public EntityConfiguration Configuration => null;

		protected PackagerConfiguration configuration { get; set; }

		public ConfigurationReplicator ConfigReplicator => null;

		public EConfigurableType ConfigurableType => default(EConfigurableType);

		public WorldspaceUIElement WorldspaceUI { get; set; }

		[field: SyncVar]
		public NetworkObject CurrentPlayerConfigurer { get; set; }

		public Sprite TypeIcon => null;

		public Transform Transform => null;

		public Transform UIPoint => null;

		public bool CanBeSelected => false;

		public ScheduleOne.Property.Property ParentProperty => null;

		public NetworkObject SyncAccessor__003CCurrentPlayerConfigurer_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		protected override void AssignProperty(ScheduleOne.Property.Property prop)
		{
		}

		protected override void Fire()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		protected override void UpdateBehaviour()
		{
		}

		private void StartPackaging(PackagingStation station)
		{
		}

		private void StartPress(BrickPress press)
		{
		}

		private void StartMoveItem(PackagingStation station)
		{
		}

		private void StartMoveItem(BrickPress press)
		{
		}

		protected PackagingStation GetStationToAttend()
		{
			return null;
		}

		protected BrickPress GetBrickPress()
		{
			return null;
		}

		protected PackagingStation GetStationMoveItems()
		{
			return null;
		}

		protected BrickPress GetBrickPressMoveItems()
		{
			return null;
		}

		protected AdvancedTransitRoute GetTransitRouteReady(out ItemInstance item)
		{
			item = null;
			return null;
		}

		protected override bool ShouldIdle()
		{
			return false;
		}

		public override BedItem GetBed()
		{
			return null;
		}

		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		public void DestroyWorldspaceUI()
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public override List<string> WriteData(string parentFolderPath)
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

		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEmployees_002EPackager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
