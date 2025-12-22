namespace ScheduleOne.ObjectScripts
{
	public class LabOven : global::ScheduleOne.EntityFramework.GridItem, global::ScheduleOne.Management.IUsable, global::ScheduleOne.ItemFramework.IItemSlotOwner, global::ScheduleOne.Management.ITransitEntity, global::ScheduleOne.Management.IConfigurable
	{
		public enum ELightMode
		{
			Off = 0,
			On = 1,
			Flash = 2
		}

		public enum EState
		{
			CanBegin = 0,
			MissingItems = 1,
			InsufficentProduct = 2,
			OutputSlotFull = 3,
			Mismatch = 4
		}

		public const int SOLID_INGREDIENT_COOK_LIMIT = 10;

		public const float FOV_OVERRIDE = 70f;

		public global::ScheduleOne.ObjectScripts.LabOven.ELightMode LightMode;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform CameraPosition_Default;

		public global::UnityEngine.Transform CameraPosition_Pour;

		public global::UnityEngine.Transform CameraPosition_PlaceItems;

		public global::UnityEngine.Transform CameraPosition_Breaking;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::ScheduleOne.ObjectScripts.LabOvenDoor Door;

		public global::ScheduleOne.ObjectScripts.LabOvenWireTray WireTray;

		public global::ScheduleOne.Misc.ToggleableLight OvenLight;

		public global::ScheduleOne.ObjectScripts.LabOvenButton Button;

		public global::TMPro.TextMeshPro TimerLabel;

		public global::ScheduleOne.Misc.ToggleableLight Light;

		public global::UnityEngine.Transform PourableContainer;

		public global::UnityEngine.Transform ItemContainer;

		public global::UnityEngine.Animation PourAnimation;

		public global::UnityEngine.SkinnedMeshRenderer LiquidMesh;

		public global::ScheduleOne.Storage.StorageVisualizer InputVisuals;

		public global::ScheduleOne.Storage.StorageVisualizer OutputVisuals;

		public global::UnityEngine.MeshRenderer CookedLiquidMesh;

		public global::UnityEngine.Animation RemoveTrayAnimation;

		public global::UnityEngine.Transform SquareTray;

		public global::UnityEngine.Transform HammerSpawnPoint;

		public global::UnityEngine.Transform HammerContainer;

		public global::UnityEngine.Transform OafBastard;

		public global::UnityEngine.Transform DecalContainer;

		public global::UnityEngine.Transform DecalMaxBounds;

		public global::UnityEngine.Transform DecalMinBounds;

		public global::UnityEngine.BoxCollider CookedLiquidCollider;

		public global::UnityEngine.Transform[] ShardSpawnPoints;

		public global::UnityEngine.ParticleSystem ShatterParticles;

		public global::UnityEngine.Transform uiPoint;

		public global::UnityEngine.Transform[] accessPoints;

		public global::ScheduleOne.Management.ConfigurationReplicator configReplicator;

		public global::UnityEngine.Transform[] SolidIngredientSpawnPoints;

		public global::UnityEngine.BoxCollider TrayDetectionArea;

		[global::UnityEngine.Header("Sounds")]
		public global::ScheduleOne.Audio.AudioSourceController ButtonSound;

		public global::ScheduleOne.Audio.AudioSourceController DingSound;

		public global::ScheduleOne.Audio.AudioSourceController RunLoopSound;

		public global::ScheduleOne.Audio.AudioSourceController ImpactSound;

		public global::ScheduleOne.Audio.AudioSourceController ShatterSound;

		[global::UnityEngine.Header("UI")]
		public global::ScheduleOne.UI.Management.LabOvenUIElement WorldspaceUIPrefab;

		public global::UnityEngine.Sprite typeIcon;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.ObjectScripts.LabOvenHammer HammerPrefab;

		public global::UnityEngine.GameObject SmashDecalPrefab;

		public global::ScheduleOne.ItemFramework.ItemSlot IngredientSlot;

		public global::ScheduleOne.ItemFramework.ItemSlot OutputSlot;

		private global::UnityEngine.Vector3 pourableContainerDefaultPos;

		private global::UnityEngine.Quaternion pourableContainerDefaultRot;

		private global::UnityEngine.Vector3 squareTrayDefaultPos;

		private global::UnityEngine.Quaternion squareTrayDefaultRot;

		private global::System.Collections.Generic.List<global::UnityEngine.GameObject> decals;

		private global::System.Collections.Generic.List<global::UnityEngine.GameObject> shards;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ELabOvenAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ELabOvenAssembly_002DCSharp_002Edll_Excuted;

		public bool isOpen => false;

		public global::ScheduleOne.ObjectScripts.OvenCookOperation CurrentOperation { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> ItemSlots { get; set; }

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

		public global::ScheduleOne.Management.EntityConfiguration Configuration => null;

		protected global::ScheduleOne.Management.LabOvenConfiguration ovenConfiguration { get; set; }

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

		public override void InitializeGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		public override string GetManagementName()
		{
			return null;
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void Update()
		{
		}

		private void MinPass()
		{
		}

		private void TimeSkipped(int minsSkippped)
		{
		}

		private void UpdateOvenAppearance()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		protected override void Destroy()
		{
		}

		public void SetOvenLit(bool lit)
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

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public bool IsIngredientCookable()
		{
			return false;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCookOperation(global::ScheduleOne.ObjectScripts.OvenCookOperation operation)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetCookOperation(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.OvenCookOperation operation, bool playButtonPress)
		{
		}

		public bool IsReadyToStart()
		{
			return false;
		}

		public bool IsReadyForHarvest()
		{
			return false;
		}

		public bool CanOutputSpaceFitCurrentOperation()
		{
			return false;
		}

		public void SetLiquidColor(global::UnityEngine.Color col)
		{
		}

		private void UpdateLiquid()
		{
		}

		public global::ScheduleOne.StationFramework.StationItem[] CreateStationItems(int quantity = 1)
		{
			return null;
		}

		public void ResetPourableContainer()
		{
		}

		public void ResetSquareTray()
		{
		}

		public global::ScheduleOne.ObjectScripts.LabOvenHammer CreateHammer()
		{
			return null;
		}

		public void CreateImpactEffects(global::UnityEngine.Vector3 point, bool playSound = true)
		{
		}

		public void Shatter(int shardQuantity, global::UnityEngine.GameObject shardPrefab)
		{
		}

		public void ClearShards()
		{
		}

		public void ClearDecals()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetStoredInstance_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetSlotFilter_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
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

		private void RpcWriter___Server_SendCookOperation_3708012700(global::ScheduleOne.ObjectScripts.OvenCookOperation operation)
		{
		}

		public void RpcLogic___SendCookOperation_3708012700(global::ScheduleOne.ObjectScripts.OvenCookOperation operation)
		{
		}

		private void RpcReader___Server_SendCookOperation_3708012700(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCookOperation_2611294368(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.OvenCookOperation operation, bool playButtonPress)
		{
		}

		public void RpcLogic___SetCookOperation_2611294368(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.OvenCookOperation operation, bool playButtonPress)
		{
		}

		private void RpcReader___Observers_SetCookOperation_2611294368(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetCookOperation_2611294368(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.OvenCookOperation operation, bool playButtonPress)
		{
		}

		private void RpcReader___Target_SetCookOperation_2611294368(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetStoredInstance_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		public void RpcLogic___SetStoredInstance_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Server_SetStoredInstance_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcLogic___SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Server_SetItemSlotQuantity_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotLocked_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		public void RpcLogic___SetSlotLocked_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Server_SetSlotLocked_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcLogic___SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotFilter_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		public void RpcLogic___SetSlotFilter_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Server_SetSlotFilter_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcLogic___SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Target_SetSlotFilter_Internal_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002ELabOven(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002ELabOven_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
