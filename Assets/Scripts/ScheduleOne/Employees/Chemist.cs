using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	public class Chemist : Employee, IConfigurable
	{
		public const int MAX_ASSIGNED_STATIONS = 4;

		[Header("References")]
		public Sprite typeIcon;

		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		[Header("Behaviours")]
		public StartChemistryStationBehaviour StartChemistryStationBehaviour;

		public StartLabOvenBehaviour StartLabOvenBehaviour;

		public FinishLabOvenBehaviour FinishLabOvenBehaviour;

		public StartCauldronBehaviour StartCauldronBehaviour;

		public StartMixingStationBehaviour StartMixingStationBehaviour;

		[Header("UI")]
		public ChemistUIElement WorldspaceUIPrefab;

		public Transform uiPoint;

		public SyncVar<NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002EChemistAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002EChemistAssembly_002DCSharp_002Edll_Excuted;

		public EntityConfiguration Configuration => null;

		protected ChemistConfiguration configuration { get; set; }

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

		private void TryStartNewTask()
		{
		}

		private bool AnyWorkInProgress()
		{
			return false;
		}

		protected override bool ShouldIdle()
		{
			return false;
		}

		private void StartChemistryStation(ChemistryStation station)
		{
		}

		private void StartCauldron(Cauldron cauldron)
		{
		}

		private void StartLabOven(LabOven oven)
		{
		}

		private void FinishLabOven(LabOven oven)
		{
		}

		private void StartMixingStation(MixingStation station)
		{
		}

		public override BedItem GetBed()
		{
			return null;
		}

		public List<LabOven> GetLabOvensReadyToFinish()
		{
			return null;
		}

		public List<LabOven> GetLabOvensReadyToStart()
		{
			return null;
		}

		public List<ChemistryStation> GetChemistryStationsReadyToStart()
		{
			return null;
		}

		public List<Cauldron> GetCauldronsReadyToStart()
		{
			return null;
		}

		public List<MixingStation> GetMixingStationsReadyToStart()
		{
			return null;
		}

		protected List<LabOven> GetLabOvensReadyToMove()
		{
			return null;
		}

		protected List<ChemistryStation> GetChemStationsReadyToMove()
		{
			return null;
		}

		protected List<Cauldron> GetCauldronsReadyToMove()
		{
			return null;
		}

		protected List<MixingStation> GetMixStationsReadyToMove()
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

		public virtual bool ReadSyncVar___ScheduleOne_002EEmployees_002EChemist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
