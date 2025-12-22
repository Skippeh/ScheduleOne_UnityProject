namespace ScheduleOne.Employees
{
	public class Botanist : global::ScheduleOne.Employees.Employee, global::ScheduleOne.Management.IConfigurable
	{
		public const float CriticalWateringThreshold = 0.2f;

		public const float WateringThreshold = 0.3f;

		public const float MoistureLevelRandomMin = 0.9f;

		public const float MoistureLevelRandomMax = 1f;

		public const float SoilPourTime = 10f;

		public const float WaterPourTime = 10f;

		public const float AdditivePourTime = 10f;

		public const float SeedSowTime = 15f;

		public const float IndividualHarvestTime = 1f;

		public const float ApplySpawnTime = 15f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Sprite typeIcon;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Management.ConfigurationReplicator configReplicator;

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

		private global::ScheduleOne.NPCs.Behaviour.StartDryingRackBehaviour _startDryingRackBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.StopDryingRackBehaviour _stopDryingRackBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.UseSpawnStationBehaviour _useSpawnStationBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.AddSoilToGrowContainerBehaviour _addSoilToGrowContainerBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.ApplyAdditiveToGrowContainerBehaviour _applyAdditiveToGrowContainerBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.SowSeedInPotBehaviour _sowSeedInPotBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.WaterPotBehaviour _waterPotBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.HarvestPotBehaviour _harvestPotBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.MistMushroomBedBehaviour _mistMushroomBedBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviour _harvestMushroomBedBehaviour;

		private global::ScheduleOne.NPCs.Behaviour.ApplySpawnToMushroomBedBehaviour _applySpawnToMushroomBedBehaviour;

		private global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Behaviour.Behaviour> _workBehaviours;

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

		public override void Awake()
		{
		}

		protected override void UpdateBehaviour()
		{
		}

		private bool IsEntityAccessible(global::ScheduleOne.Management.ITransitEntity entity)
		{
			return false;
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

		protected override bool ShouldIdle()
		{
			return false;
		}

		public override global::ScheduleOne.Employees.EmployeeHome GetHome()
		{
			return null;
		}

		public global::ScheduleOne.Management.ITransitEntity GetSuppliesAsTransitEntity()
		{
			return null;
		}

		private global::ScheduleOne.ObjectScripts.Pot GetPotForWatering(float threshold)
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Growing.GrowContainer> GetGrowContainersForSoilPour()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> GetPotsReadyForSeed()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Growing.GrowContainer> GetGrowContainersForAdditives()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> GetPotsForHarvest()
		{
			return null;
		}

		private global::ScheduleOne.ObjectScripts.MushroomBed GetMushroomBedForMisting(float threshold)
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.MushroomBed> GetMushroomBedsForHarvest()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.MushroomBed> GetBedsReadyForSpawn()
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

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.MushroomSpawnStation> GetSpawnStationsReadyToUse()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.MushroomSpawnStation> GetSpawnStationsReadyToMove()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002EEmployees_002EBotanist_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
