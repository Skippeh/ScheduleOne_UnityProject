namespace ScheduleOne.Employees
{
	public class Botanist : global::ScheduleOne.Employees.Employee, global::ScheduleOne.Management.IConfigurable
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

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Sprite typeIcon;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Management.ConfigurationReplicator configReplicator;

		public global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour PotActionBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.StartDryingRackBehaviour StartDryingRackBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.StopDryingRackBehaviour StopDryingRackBehaviour;

		[global::UnityEngine.Header("UI")]
		public global::ScheduleOne.UI.Management.BotanistUIElement WorldspaceUIPrefab;

		public global::UnityEngine.Transform uiPoint;

		[global::UnityEngine.Header("Settings")]
		public int MaxAssignedPots;

		public global::ScheduleOne.Dialogue.DialogueContainer NoAssignedStationsDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer UnspecifiedPotsDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer NullDestinationPotsDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer MissingMaterialsDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer NoPotsRequireWorkDialogue;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002EBotanistAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002EBotanistAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Management.EntityConfiguration Configuration => null;

		protected global::ScheduleOne.Management.BotanistConfiguration configuration { get; set; }

		public global::ScheduleOne.Management.ConfigurationReplicator ConfigReplicator => null;

		public global::ScheduleOne.Management.EConfigurableType ConfigurableType => default(global::ScheduleOne.Management.EConfigurableType);

		public global::ScheduleOne.UI.Management.WorldspaceUIElement WorldspaceUI { get; set; }

		public global::FishNet.Object.NetworkObject CurrentPlayerConfigurer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		public global::UnityEngine.Sprite TypeIcon => null;

		public global::UnityEngine.Transform Transform => null;

		public global::UnityEngine.Transform UIPoint => null;

		public bool CanBeSelected => false;

		public global::ScheduleOne.Property.Property ParentProperty => null;

		public global::FishNet.Object.NetworkObject SyncAccessor__003CCurrentPlayerConfigurer_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(global::FishNet.Object.NetworkObject player)
		{
		}

		protected override void Start()
		{
		}

		protected override void UpdateBehaviour()
		{
		}

		private bool IsEntityAccessible(global::ScheduleOne.Management.ITransitEntity entity)
		{
			return false;
		}

		private void StartAction(global::ScheduleOne.ObjectScripts.Pot pot, global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType actionType)
		{
		}

		private void StartDryingRack(global::ScheduleOne.ObjectScripts.DryingRack rack)
		{
		}

		private void StopDryingRack(global::ScheduleOne.ObjectScripts.DryingRack rack)
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected override void AssignProperty(global::ScheduleOne.Property.Property prop, bool warp)
		{
		}

		protected override void UnassignProperty()
		{
		}

		protected override void ResetConfiguration()
		{
		}

		protected override void Fire()
		{
		}

		private bool CanMoveDryableToRack(out global::ScheduleOne.ItemFramework.QualityItemInstance dryable, out global::ScheduleOne.ObjectScripts.DryingRack destinationRack, out int moveQuantity)
		{
			dryable = null;
			destinationRack = null;
			moveQuantity = default(int);
			return false;
		}

		public global::ScheduleOne.ItemFramework.QualityItemInstance GetDryableInSupplies()
		{
			return null;
		}

		private global::ScheduleOne.ObjectScripts.DryingRack GetAssignedDryingRackFor(global::ScheduleOne.ItemFramework.QualityItemInstance dryable, out int rackInputCapacity)
		{
			rackInputCapacity = default(int);
			return null;
		}

		public global::ScheduleOne.ItemFramework.ItemInstance GetItemInSupplies(string id)
		{
			return null;
		}

		public global::ScheduleOne.ItemFramework.ItemInstance GetSeedInSupplies()
		{
			return null;
		}

		protected override bool ShouldIdle()
		{
			return false;
		}

		public override global::ScheduleOne.Employees.EmployeeHome GetHome()
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

		private global::ScheduleOne.ObjectScripts.Pot GetPotForWatering(float threshold, bool excludeFullyGrowm)
		{
			return null;
		}

		private global::ScheduleOne.ObjectScripts.Pot GetPotForSoilSour()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> GetPotsReadyForSeed()
		{
			return null;
		}

		private T GetAccessableEntity<T>(T entity) where T : global::ScheduleOne.Management.ITransitEntity
		{
			return default(T);
		}

		private global::System.Collections.Generic.List<T> GetAccessableEntities<T>(global::System.Collections.Generic.List<T> list) where T : global::ScheduleOne.Management.ITransitEntity
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> FilterPotsForSpecifiedSeed(global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> pots)
		{
			return null;
		}

		private global::ScheduleOne.ObjectScripts.Pot GetPotForAdditives(out int additiveNumber)
		{
			additiveNumber = default(int);
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> GetPotsForHarvest()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.DryingRack> GetRacksToStart()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.DryingRack> GetRacksToStop()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.DryingRack> GetRacksReadyToMove()
		{
			return null;
		}

		public global::ScheduleOne.UI.Management.WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		public void DestroyWorldspaceUI()
		{
		}

		public override global::ScheduleOne.Persistence.Datas.NPCData GetNPCData()
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.DynamicSaveData GetSaveData()
		{
			return null;
		}

		public override global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
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

		private void RpcWriter___Server_SetConfigurer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		public void RpcLogic___SetConfigurer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Server_SetConfigurer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEmployees_002EBotanist(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
