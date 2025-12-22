namespace ScheduleOne.ObjectScripts
{
	public class Pot : global::ScheduleOne.Growing.GrowContainer, global::ScheduleOne.Management.IConfigurable
	{
		public enum ESoilState
		{
			Flat = 0,
			Parted = 1,
			Packed = 2
		}

		public const float MaxWarmthGrowthMultiplier = 1.5f;

		public const float WarmthMinThreshold = 20f;

		public const float WarmthMaxThreshold = 40f;

		public const float RotationSpeed = 10f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform ModelTransform;

		public global::UnityEngine.Transform SeedStartPoint;

		public global::UnityEngine.Transform SeedRestingPoint;

		public global::UnityEngine.Transform LookAtPoint;

		public global::UnityEngine.Transform PlantContainer;

		public global::UnityEngine.Transform TaskBounds;

		public global::UnityEngine.Transform LeafDropPoint;

		public global::UnityEngine.ParticleSystem PoofParticles;

		public global::ScheduleOne.Audio.AudioSourceController PoofSound;

		public global::ScheduleOne.Management.ConfigurationReplicator ConfigurationReplicator;

		public global::UnityEngine.Transform Dirt_Flat;

		public global::UnityEngine.Transform Dirt_Parted;

		public global::ScheduleOne.Growing.SoilChunk[] SoilChunks;

		[global::UnityEngine.Header("UI")]
		public global::ScheduleOne.UI.Management.PotUIElement WorldspaceUIPrefab;

		public global::UnityEngine.Sprite typeIcon;

		[global::UnityEngine.Header("Pot Settings")]
		public float PotRadius;

		[global::UnityEngine.Range(0.2f, 2f)]
		public float YieldMultiplier;

		[global::UnityEngine.Range(0.2f, 2f)]
		public float GrowSpeedMultiplier;

		private float rotation;

		private bool rotationOverridden;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EPotAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EPotAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Growing.Plant Plant { get; protected set; }

		public global::ScheduleOne.Management.EntityConfiguration Configuration => null;

		protected global::ScheduleOne.Management.PotConfiguration potConfiguration { get; set; }

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

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public override void InitializeGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		public override string GetManagementName()
		{
			return null;
		}

		public override string GetDefaultManagementName()
		{
			return null;
		}

		protected override void Destroy()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void UpdateRotation()
		{
		}

		protected override void OnMinPass()
		{
		}

		protected override void OnTimeSkipped(int minsSkipped)
		{
		}

		public bool CanAcceptSeed(out string reason)
		{
			reason = null;
			return false;
		}

		public bool IsReadyForHarvest(out string reason)
		{
			reason = null;
			return false;
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public void OverrideRotation(float angle)
		{
		}

		protected override global::ScheduleOne.ItemFramework.AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication)
		{
			return null;
		}

		public override bool CanApplyAdditive(global::ScheduleOne.ItemFramework.AdditiveDefinition additiveDef, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public override bool IsPointAboveGrowSurface(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		public override void SetGrowableVisible(bool visible)
		{
		}

		protected override global::UnityEngine.Vector3 GetRandomPourTargetPosition()
		{
			return default(global::UnityEngine.Vector3);
		}

		public override float GetGrowSurfaceSideLength()
		{
			return 0f;
		}

		public override float GetTemperatureGrowthMultiplier()
		{
			return 0f;
		}

		public override bool ContainsGrowable()
		{
			return false;
		}

		public void SetSoilState(global::ScheduleOne.ObjectScripts.Pot.ESoilState state)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void PlantSeed_Server(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void PlantSeed_Client(global::FishNet.Connection.NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		private void PlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SetGrowthProgress_Server(float progress)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SetGrowthProgress_Client(float progress)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetHarvestableActive_Server(int harvestableIndex, bool active)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetHarvestableActive_Client(global::FishNet.Connection.NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		private void OnPlantFullyHarvested()
		{
		}

		public global::ScheduleOne.UI.Management.WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		public void DestroyWorldspaceUI()
		{
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.DynamicSaveData GetSaveData()
		{
			return null;
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.PotData potData)
		{
		}

		private void LoadPlant(global::ScheduleOne.Persistence.Datas.PlantData data)
		{
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

		private void RpcWriter___Server_PlantSeed_Server_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		public void RpcLogic___PlantSeed_Server_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		private void RpcReader___Server_PlantSeed_Server_2530605204(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PlantSeed_Client_709433087(global::FishNet.Connection.NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		private void RpcLogic___PlantSeed_Client_709433087(global::FishNet.Connection.NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		private void RpcReader___Observers_PlantSeed_Client_709433087(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_PlantSeed_Client_709433087(global::FishNet.Connection.NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		private void RpcReader___Target_PlantSeed_Client_709433087(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetGrowthProgress_Server_431000436(float progress)
		{
		}

		public void RpcLogic___SetGrowthProgress_Server_431000436(float progress)
		{
		}

		private void RpcReader___Server_SetGrowthProgress_Server_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetGrowthProgress_Client_431000436(float progress)
		{
		}

		private void RpcLogic___SetGrowthProgress_Client_431000436(float progress)
		{
		}

		private void RpcReader___Observers_SetGrowthProgress_Client_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetHarvestableActive_Server_3658436649(int harvestableIndex, bool active)
		{
		}

		public void RpcLogic___SetHarvestableActive_Server_3658436649(int harvestableIndex, bool active)
		{
		}

		private void RpcReader___Server_SetHarvestableActive_Server_3658436649(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetHarvestableActive_Client_338960014(global::FishNet.Connection.NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		private void RpcLogic___SetHarvestableActive_Client_338960014(global::FishNet.Connection.NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		private void RpcReader___Observers_SetHarvestableActive_Client_338960014(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetHarvestableActive_Client_338960014(global::FishNet.Connection.NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		private void RpcReader___Target_SetHarvestableActive_Client_338960014(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002EPot(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EPot_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
