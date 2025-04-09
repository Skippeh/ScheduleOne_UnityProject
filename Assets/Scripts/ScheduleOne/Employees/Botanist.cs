using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Dialogue;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	public class Botanist : Employee, IConfigurable
	{
		public float CRITICAL_WATERING_THRESHOLD;

		public float WATERING_THRESHOLD;

		public float TARGET_WATER_LEVEL_MIN;

		public float TARGET_WATER_LEVEL_MAX;

		public float SOIL_POUR_TIME;

		public float WATER_POUR_TIME;

		public float ADDITIVE_POUR_TIME;

		public float SEED_SOW_TIME;

		public float HARVEST_TIME;

		[Header("References")]
		public Sprite typeIcon;

		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		public PotActionBehaviour PotActionBehaviour;

		public StartDryingRackBehaviour StartDryingRackBehaviour;

		public StopDryingRackBehaviour StopDryingRackBehaviour;

		[Header("UI")]
		public BotanistUIElement WorldspaceUIPrefab;

		public Transform uiPoint;

		[Header("Settings")]
		public int MaxAssignedPots;

		public DialogueContainer NoAssignedStationsDialogue;

		public DialogueContainer UnspecifiedPotsDialogue;

		public DialogueContainer NullDestinationPotsDialogue;

		public DialogueContainer MissingMaterialsDialogue;

		public DialogueContainer NoPotsRequireWorkDialogue;

		public SyncVar<NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002EBotanistAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002EBotanistAssembly_002DCSharp_002Edll_Excuted;

		public EntityConfiguration Configuration => null;

		protected BotanistConfiguration configuration { get; set; }

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

		protected override void Start()
		{
		}

		protected override void UpdateBehaviour()
		{
		}

		private bool IsEntityAccessible(ITransitEntity entity)
		{
			return false;
		}

		private void StartAction(Pot pot, PotActionBehaviour.EActionType actionType)
		{
		}

		private void StartDryingRack(DryingRack rack)
		{
		}

		private void StopDryingRack(DryingRack rack)
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		protected override void AssignProperty(ScheduleOne.Property.Property prop)
		{
		}

		protected override void Fire()
		{
		}

		private bool CanMoveDryableToRack(out QualityItemInstance dryable, out DryingRack destinationRack, out int moveQuantity)
		{
			dryable = null;
			destinationRack = null;
			moveQuantity = default(int);
			return false;
		}

		public QualityItemInstance GetDryableInSupplies()
		{
			return null;
		}

		private DryingRack GetAssignedDryingRackFor(QualityItemInstance dryable, out int rackInputCapacity)
		{
			rackInputCapacity = default(int);
			return null;
		}

		public ItemInstance GetItemInSupplies(string id)
		{
			return null;
		}

		public ItemInstance GetSeedInSupplies()
		{
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

		private bool AreThereUnspecifiedPots()
		{
			return false;
		}

		private bool AreThereNullDestinationPots()
		{
			return false;
		}

		private bool IsMissingRequiredMaterials()
		{
			return false;
		}

		private Pot GetPotForWatering(float threshold, bool excludeFullyGrowm)
		{
			return null;
		}

		private Pot GetPotForSoilSour()
		{
			return null;
		}

		private List<Pot> GetPotsReadyForSeed()
		{
			return null;
		}

		private T GetAccessableEntity<T>(T entity) where T : ITransitEntity
		{
			return default(T);
		}

		private List<T> GetAccessableEntities<T>(List<T> list) where T : ITransitEntity
		{
			return null;
		}

		private List<Pot> FilterPotsForSpecifiedSeed(List<Pot> pots)
		{
			return null;
		}

		private Pot GetPotForAdditives(out int additiveNumber)
		{
			additiveNumber = default(int);
			return null;
		}

		private List<Pot> GetPotsForHarvest()
		{
			return null;
		}

		private List<DryingRack> GetRacksToStart()
		{
			return null;
		}

		private List<DryingRack> GetRacksToStop()
		{
			return null;
		}

		private List<DryingRack> GetRacksReadyToMove()
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

		public virtual bool ReadSyncVar___ScheduleOne_002EEmployees_002EBotanist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
