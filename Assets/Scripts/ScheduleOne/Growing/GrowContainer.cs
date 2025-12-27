namespace ScheduleOne.Growing
{
	public abstract class GrowContainer : global::ScheduleOne.EntityFramework.GridItem, global::ScheduleOne.Management.IUsable, global::ScheduleOne.Management.ITransitEntity
	{
		public const float DryThreshold = 0f;

		[global::UnityEngine.SerializeField]
		private float _moistureDrainPerHour;

		[global::UnityEngine.SerializeField]
		public global::ScheduleOne.ItemFramework.SoilDefinition[] AllowedSoils;

		[global::UnityEngine.SerializeField]
		public global::ScheduleOne.ItemFramework.AdditiveDefinition[] AllowedAdditives;

		[global::UnityEngine.Header("Grow Container References")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Growing.GrowContainerInteraction _interactionHandler;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer[] _soilMeshRenderers;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform _soilMinTransform;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform _soilMaxTransform;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.MeshRenderer _additiveDisplayTemplate;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform _pourTarget;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform _uiPoint;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform[] _accessPoints;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ParticleSystem[] _soilClearedParticles;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _soilClearedSound;

		[global::UnityEngine.Header("Optional References")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Lighting.UsableLightSource _lightSourceOverride;

		public global::System.Action onMinPass;

		public global::System.Action<int> onTimeSkip;

		protected float _currentSoilAmount;

		protected float _currentMoistureAmount;

		protected int _remainingSoilUses;

		private global::System.Collections.Generic.List<global::UnityEngine.MeshRenderer> _activeAdditiveDisplays;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EGrowing_002EGrowContainerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGrowing_002EGrowContainerAssembly_002DCSharp_002Edll_Excuted;

		[field: global::UnityEngine.Header("Grow Container Settings")]
		[field: global::UnityEngine.SerializeField]
		public float SoilCapacity { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public float MoistureCapacity { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public bool HidePlantDuringPourTasks { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Transform SoilContainer { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Transform PourableStartPoint { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.Growing.GrowContainerSurfaceCover SurfaceCover { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.Growing.GrowContainerCameraHandler CameraHandler { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.UI.TemperatureDisplay TemperatureDisplay { get; private set; }

		public float NormalizedSoilAmount => 0f;

		public bool IsFullyFilledWithSoil => false;

		public float NormalizedMoistureAmount => 0f;

		public global::ScheduleOne.ItemFramework.SoilDefinition CurrentSoil { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.AdditiveDefinition> AppliedAdditives { get; private set; }

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

		public string Name => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> InputSlots { get; set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> OutputSlots { get; set; }

		public global::UnityEngine.Transform LinkOrigin => null;

		public global::UnityEngine.Transform[] AccessPoints => null;

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

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

		public void ConfigureInteraction(string labelText, global::ScheduleOne.Interaction.InteractableObject.EInteractableState interactionState)
		{
		}

		public void ConfigureInteraction(string labelText, global::ScheduleOne.Interaction.InteractableObject.EInteractableState interactionState, global::UnityEngine.Vector3 labelPosition)
		{
		}

		public override void Awake()
		{
		}

		public override void InitializeGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void HeatmapVisibilityChanged(global::ScheduleOne.Property.Property property, bool visible)
		{
		}

		protected override void Destroy()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		protected virtual void OnMinPass()
		{
		}

		protected virtual void OnTimeSkipped(int minsSkipped)
		{
		}

		private void DrainMoisture(int minutes)
		{
		}

		public float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			growSpeedMultiplier = default(float);
			return 0f;
		}

		public abstract bool IsPointAboveGrowSurface(global::UnityEngine.Vector3 point);

		public abstract void SetGrowableVisible(bool visible);

		public abstract float GetGrowSurfaceSideLength();

		public abstract bool ContainsGrowable();

		public abstract float GetGrowthProgressNormalized();

		public virtual void SetSoil(global::ScheduleOne.ItemFramework.SoilDefinition soil)
		{
		}

		public void ChangeSoilAmount(float amount)
		{
		}

		public void SetSoilAmount(float amount)
		{
		}

		public void SetRemainingSoilUses(int uses)
		{
		}

		public void SyncSoilData()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SetSoilData_Server(string soilID, float amount, int uses)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void SetSoilData_Client(global::FishNet.Connection.NetworkConnection conn, string soilID, float amount, int uses)
		{
		}

		protected virtual void RefreshSoilVisuals()
		{
		}

		protected virtual void ClearSoil()
		{
		}

		public bool IsSoilAllowed(global::ScheduleOne.ItemFramework.SoilDefinition soil)
		{
			return false;
		}

		protected virtual global::UnityEngine.Material GetSoilMaterial()
		{
			return null;
		}

		public void ChangeMoistureAmount(float amount)
		{
		}

		public virtual void SetMoistureAmount(float amount)
		{
		}

		public void SyncMoistureData()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SetMoistureData_Server(float amount)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void SetMoistureData_Client(global::FishNet.Connection.NetworkConnection conn, float amount)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ApplyAdditive_Server(string additiveID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ApplyAdditive_Client(global::FishNet.Connection.NetworkConnection conn, string additiveID, bool initialApplication)
		{
		}

		protected virtual global::ScheduleOne.ItemFramework.AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication)
		{
			return null;
		}

		public virtual float GetTemperatureGrowthMultiplier()
		{
			return 0f;
		}

		public bool IsAdditiveApplied(string additiveID)
		{
			return false;
		}

		protected void ClearAdditives()
		{
		}

		public virtual bool CanApplyAdditive(global::ScheduleOne.ItemFramework.AdditiveDefinition additiveDef, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public void SetPourTargetActive(bool active)
		{
		}

		public void RandomizePourTargetPosition()
		{
		}

		public global::UnityEngine.Vector3 GetCurrentTargetPosition()
		{
			return default(global::UnityEngine.Vector3);
		}

		protected abstract global::UnityEngine.Vector3 GetRandomPourTargetPosition();

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		protected void Load(global::ScheduleOne.Persistence.Datas.GrowContainerData data)
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

		private void RpcWriter___Server_SetSoilData_Server_3104499779(string soilID, float amount, int uses)
		{
		}

		private void RpcLogic___SetSoilData_Server_3104499779(string soilID, float amount, int uses)
		{
		}

		private void RpcReader___Server_SetSoilData_Server_3104499779(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSoilData_Client_433593356(global::FishNet.Connection.NetworkConnection conn, string soilID, float amount, int uses)
		{
		}

		private void RpcLogic___SetSoilData_Client_433593356(global::FishNet.Connection.NetworkConnection conn, string soilID, float amount, int uses)
		{
		}

		private void RpcReader___Observers_SetSoilData_Client_433593356(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetSoilData_Client_433593356(global::FishNet.Connection.NetworkConnection conn, string soilID, float amount, int uses)
		{
		}

		private void RpcReader___Target_SetSoilData_Client_433593356(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetMoistureData_Server_431000436(float amount)
		{
		}

		private void RpcLogic___SetMoistureData_Server_431000436(float amount)
		{
		}

		private void RpcReader___Server_SetMoistureData_Server_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMoistureData_Client_530160725(global::FishNet.Connection.NetworkConnection conn, float amount)
		{
		}

		private void RpcLogic___SetMoistureData_Client_530160725(global::FishNet.Connection.NetworkConnection conn, float amount)
		{
		}

		private void RpcReader___Observers_SetMoistureData_Client_530160725(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetMoistureData_Client_530160725(global::FishNet.Connection.NetworkConnection conn, float amount)
		{
		}

		private void RpcReader___Target_SetMoistureData_Client_530160725(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ApplyAdditive_Server_3615296227(string additiveID)
		{
		}

		public void RpcLogic___ApplyAdditive_Server_3615296227(string additiveID)
		{
		}

		private void RpcReader___Server_ApplyAdditive_Server_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ApplyAdditive_Client_619441887(global::FishNet.Connection.NetworkConnection conn, string additiveID, bool initialApplication)
		{
		}

		private void RpcLogic___ApplyAdditive_Client_619441887(global::FishNet.Connection.NetworkConnection conn, string additiveID, bool initialApplication)
		{
		}

		private void RpcReader___Observers_ApplyAdditive_Client_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ApplyAdditive_Client_619441887(global::FishNet.Connection.NetworkConnection conn, string additiveID, bool initialApplication)
		{
		}

		private void RpcReader___Target_ApplyAdditive_Client_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
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

		public virtual bool ReadSyncVar___ScheduleOne_002EGrowing_002EGrowContainer(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EGrowing_002EGrowContainer_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
