namespace ScheduleOne.ObjectScripts
{
	public class Pot : global::ScheduleOne.EntityFramework.GridItem, global::ScheduleOne.Management.IUsable, global::ScheduleOne.Management.IConfigurable, global::ScheduleOne.Management.ITransitEntity
	{
		public enum ECameraPosition
		{
			Closeup = 0,
			Midshot = 1,
			Fullshot = 2,
			BirdsEye = 3
		}

		public enum ESoilState
		{
			Flat = 0,
			Parted = 1,
			Packed = 2
		}

		public const float DryThreshold = 0f;

		public const float WaterloggedThreshold = 1f;

		public const float ROTATION_SPEED = 10f;

		public const float MAX_CAMERA_DISTANCE = 2.75f;

		public const float MIN_CAMERA_DISTANCE = 0.5f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform ModelTransform;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform PourableStartPoint;

		public global::UnityEngine.Transform SeedStartPoint;

		public global::UnityEngine.Transform SeedRestingPoint;

		public global::UnityEngine.GameObject WaterLoggedVisuals;

		public global::UnityEngine.Transform LookAtPoint;

		public global::UnityEngine.Transform AdditivesContainer;

		public global::UnityEngine.Transform PlantContainer;

		public global::UnityEngine.Transform IntObjLabel_Low;

		public global::UnityEngine.Transform IntObjLabel_High;

		public global::UnityEngine.Transform uiPoint;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Management.ConfigurationReplicator configReplicator;

		public global::UnityEngine.Transform[] accessPoints;

		public global::UnityEngine.Transform TaskBounds;

		public global::ScheduleOne.ObjectScripts.PotSoilCover SoilCover;

		public global::UnityEngine.Transform LeafDropPoint;

		public global::UnityEngine.ParticleSystem PoofParticles;

		public global::ScheduleOne.Audio.AudioSourceController PoofSound;

		[global::UnityEngine.Header("UI")]
		public global::UnityEngine.Transform WaterCanvasContainer;

		public global::UnityEngine.Canvas WaterLevelCanvas;

		public global::UnityEngine.CanvasGroup WaterLevelCanvasGroup;

		public global::UnityEngine.UI.Slider WaterLevelSlider;

		public global::UnityEngine.GameObject NoWaterIcon;

		public global::ScheduleOne.UI.Management.PotUIElement WorldspaceUIPrefab;

		public global::UnityEngine.Sprite typeIcon;

		[global::UnityEngine.Header("Camera References")]
		public global::UnityEngine.Transform CameraContainer;

		public global::UnityEngine.Transform MidshotPosition;

		public global::UnityEngine.Transform CloseupPosition;

		public global::UnityEngine.Transform FullshotPosition;

		public global::UnityEngine.Transform BirdsEyePosition;

		public bool AutoRotateCameraContainer;

		[global::UnityEngine.Header("Dirt references")]
		public global::UnityEngine.Transform Dirt_Flat;

		public global::UnityEngine.Transform Dirt_Parted;

		public global::ScheduleOne.Growing.SoilChunk[] SoilChunks;

		public global::System.Collections.Generic.List<global::UnityEngine.MeshRenderer> DirtRenderers;

		[global::UnityEngine.Header("Pot Settings")]
		public float PotRadius;

		[global::UnityEngine.Range(0.2f, 2f)]
		public float YieldMultiplier;

		[global::UnityEngine.Range(0.2f, 2f)]
		public float GrowSpeedMultiplier;

		[global::UnityEngine.Range(0.2f, 2f)]
		public float MoistureDrainMultiplier;

		public bool AlignLeafDropToPlayer;

		[global::UnityEngine.Header("Capacity Settings")]
		public float SoilCapacity;

		public float WaterCapacity;

		public float WaterDrainPerHour;

		[global::UnityEngine.Header("Dirt Settings")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Vector3 DirtMinScale;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Vector3 DirtMaxScale;

		[global::UnityEngine.Header("Pour Target")]
		public global::UnityEngine.Transform Target;

		[global::UnityEngine.Header("Lighting")]
		public global::ScheduleOne.Lighting.UsableLightSource LightSourceOverride;

		public global::System.Collections.Generic.List<global::ScheduleOne.Growing.Additive> AppliedAdditives;

		private bool intObjSetThisFrame;

		private global::ScheduleOne.ItemFramework.ItemSlot outputSlot;

		private float rotation;

		private bool rotationOverridden;

		private global::ScheduleOne.ItemFramework.SoilDefinition appliedSoilDefinition;

		private global::UnityEngine.Material appliedSoilMaterial;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar____003CSoilLevel_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<string> syncVar____003CSoilID_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<int> syncVar____003CRemainingSoilUses_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar____003CWaterLevel_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EPotAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EPotAssembly_002DCSharp_002Edll_Excuted;

		public float SoilLevel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public string SoilID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public int RemainingSoilUses
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public float WaterLevel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public float NormalizedWaterLevel => 0f;

		public bool IsFilledWithSoil => false;

		public global::ScheduleOne.Growing.Plant Plant { get; protected set; }

		public global::FishNet.Object.NetworkObject NPCUserObject
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

		public global::FishNet.Object.NetworkObject PlayerUserObject
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

		public string Name => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> InputSlots { get; set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> OutputSlots { get; set; }

		public global::UnityEngine.Transform LinkOrigin => null;

		public global::UnityEngine.Transform[] AccessPoints => null;

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

		public float SyncAccessor__003CSoilLevel_003Ek__BackingField
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string SyncAccessor__003CSoilID_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int SyncAccessor__003CRemainingSoilUses_003Ek__BackingField
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float SyncAccessor__003CWaterLevel_003Ek__BackingField
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::FishNet.Object.NetworkObject SyncAccessor__003CNPCUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::FishNet.Object.NetworkObject SyncAccessor__003CPlayerUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public override void DestroyItem(bool callOnServer = true)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected void UpdateCanvas()
		{
		}

		private void OnMinPass()
		{
		}

		private void TimeSkipped(int minsSkippped)
		{
		}

		public void ConfigureInteraction(string message, global::ScheduleOne.Interaction.InteractableObject.EInteractableState state, bool useHighLabelPos = false)
		{
		}

		public void PositionCameraContainer()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void ResetPot()
		{
		}

		public float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			growSpeedMultiplier = default(float);
			return 0f;
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

		public global::UnityEngine.Transform GetCameraPosition(global::ScheduleOne.ObjectScripts.Pot.ECameraPosition pos)
		{
			return null;
		}

		public virtual void AddSoil(float amount)
		{
		}

		private void SoilLevelChanged(float _prev, float _new, bool asServer)
		{
		}

		protected virtual void UpdateSoilScale()
		{
		}

		public virtual void SetSoilID(string id)
		{
		}

		public virtual void SetSoilUses(int uses)
		{
		}

		public void PushSoilDataToServer()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendSoilData(string soilID, float soilLevel, int soilUses)
		{
		}

		public void SetSoilState(global::ScheduleOne.ObjectScripts.Pot.ESoilState state)
		{
		}

		protected virtual void UpdateSoilMaterial()
		{
		}

		public void ChangeWaterAmount(float change)
		{
		}

		public void PushWaterDataToServer()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendWaterData(float waterLevel)
		{
		}

		private void WaterLevelChanged(float _prev, float _new, bool asServer)
		{
		}

		public void SetTargetActive(bool active)
		{
		}

		public void RandomizeTarget()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendAdditive(string additiveAssetPath, bool initial)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void ApplyAdditive(global::FishNet.Connection.NetworkConnection conn, string additiveAssetPath, bool initial)
		{
		}

		public float GetAdditiveGrowthMultiplier()
		{
			return 0f;
		}

		public float GetNetYieldChange()
		{
			return 0f;
		}

		public float GetNetQualityChange()
		{
			return 0f;
		}

		public global::ScheduleOne.Growing.Additive GetAdditive(string additiveName)
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void FullyGrowPlant()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void PlantSeed(global::FishNet.Connection.NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SetGrowProgress(float progress)
		{
		}

		private void PlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetHarvestableActive(global::FishNet.Connection.NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		public void SetHarvestableActive_Local(int harvestableIndex, bool active)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendHarvestableActive(int harvestableIndex, bool active)
		{
		}

		public void SendHarvestableActive_Local(int harvestableIndex, bool active)
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

		public virtual void LoadPlant(global::ScheduleOne.Persistence.Datas.PlantData data)
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

		private void RpcWriter___Server_SetPlayerUser_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		public void RpcLogic___SetPlayerUser_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_SetPlayerUser_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetNPCUser_3323014238(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		public void RpcLogic___SetNPCUser_3323014238(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		private void RpcReader___Server_SetNPCUser_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ResetPot_2166136261()
		{
		}

		public virtual void RpcLogic___ResetPot_2166136261()
		{
		}

		private void RpcReader___Observers_ResetPot_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
		}

		public void RpcLogic___SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
		}

		private void RpcReader___Server_SendSoilData_3104499779(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendWaterData_431000436(float waterLevel)
		{
		}

		public void RpcLogic___SendWaterData_431000436(float waterLevel)
		{
		}

		private void RpcReader___Server_SendWaterData_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
		}

		public void RpcLogic___SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
		}

		private void RpcReader___Server_SendAdditive_310431262(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ApplyAdditive_619441887(global::FishNet.Connection.NetworkConnection conn, string additiveAssetPath, bool initial)
		{
		}

		public void RpcLogic___ApplyAdditive_619441887(global::FishNet.Connection.NetworkConnection conn, string additiveAssetPath, bool initial)
		{
		}

		private void RpcReader___Observers_ApplyAdditive_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ApplyAdditive_619441887(global::FishNet.Connection.NetworkConnection conn, string additiveAssetPath, bool initial)
		{
		}

		private void RpcReader___Target_ApplyAdditive_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_FullyGrowPlant_2166136261()
		{
		}

		public void RpcLogic___FullyGrowPlant_2166136261()
		{
		}

		private void RpcReader___Observers_FullyGrowPlant_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		public void RpcLogic___SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		private void RpcReader___Server_SendPlantSeed_2530605204(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PlantSeed_709433087(global::FishNet.Connection.NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		public void RpcLogic___PlantSeed_709433087(global::FishNet.Connection.NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		private void RpcReader___Observers_PlantSeed_709433087(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_PlantSeed_709433087(global::FishNet.Connection.NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
		}

		private void RpcReader___Target_PlantSeed_709433087(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetGrowProgress_431000436(float progress)
		{
		}

		private void RpcLogic___SetGrowProgress_431000436(float progress)
		{
		}

		private void RpcReader___Observers_SetGrowProgress_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetHarvestableActive_338960014(global::FishNet.Connection.NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		public void RpcLogic___SetHarvestableActive_338960014(global::FishNet.Connection.NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		private void RpcReader___Observers_SetHarvestableActive_338960014(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetHarvestableActive_338960014(global::FishNet.Connection.NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		private void RpcReader___Target_SetHarvestableActive_338960014(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
		}

		public void RpcLogic___SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
		}

		private void RpcReader___Server_SendHarvestableActive_3658436649(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
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
