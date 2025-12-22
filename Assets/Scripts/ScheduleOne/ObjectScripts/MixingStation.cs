namespace ScheduleOne.ObjectScripts
{
	public class MixingStation : global::ScheduleOne.EntityFramework.GridItem, global::ScheduleOne.Management.IUsable, global::ScheduleOne.ItemFramework.IItemSlotOwner, global::ScheduleOne.Management.ITransitEntity, global::ScheduleOne.Management.IConfigurable
	{
		public global::ScheduleOne.ItemFramework.ItemSlot ProductSlot;

		public global::ScheduleOne.ItemFramework.ItemSlot MixerSlot;

		public global::ScheduleOne.ItemFramework.ItemSlot OutputSlot;

		public bool RequiresIngredientInsertion;

		[global::UnityEngine.Header("Settings")]
		public int MixTimePerItem;

		public int MaxMixQuantity;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject JugPrefab;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform CameraPosition;

		public global::UnityEngine.Transform CameraPosition_CombineIngredients;

		public global::UnityEngine.Transform CameraPosition_StartMachine;

		public global::ScheduleOne.Storage.StorageVisualizer InputVisuals;

		public global::ScheduleOne.Storage.StorageVisualizer OutputVisuals;

		public global::ScheduleOne.Misc.DigitalAlarm Clock;

		public global::ScheduleOne.Misc.ToggleableLight Light;

		public global::ScheduleOne.Product.NewMixDiscoveryBox DiscoveryBox;

		public global::UnityEngine.Transform ItemContainer;

		public global::UnityEngine.Transform[] IngredientTransforms;

		public global::ScheduleOne.StationFramework.Fillable BowlFillable;

		public global::ScheduleOne.PlayerTasks.Clickable StartButton;

		public global::UnityEngine.Transform JugAlignment;

		public global::UnityEngine.Rigidbody Anchor;

		public global::UnityEngine.BoxCollider TrashSpawnVolume;

		public global::UnityEngine.Transform uiPoint;

		public global::UnityEngine.Transform[] accessPoints;

		public global::ScheduleOne.Management.ConfigurationReplicator configReplicator;

		[global::UnityEngine.Header("Sounds")]
		public global::ScheduleOne.Audio.StartLoopStopAudio MachineSound;

		public global::ScheduleOne.Audio.AudioSourceController StartSound;

		public global::ScheduleOne.Audio.AudioSourceController StopSound;

		[global::UnityEngine.Header("Mix Timing")]
		[global::UnityEngine.Header("UI")]
		public global::ScheduleOne.UI.Management.MixingStationUIElement WorldspaceUIPrefab;

		public global::UnityEngine.Sprite typeIcon;

		public global::UnityEngine.Events.UnityEvent onMixStart;

		public global::UnityEngine.Events.UnityEvent onMixDone;

		public global::UnityEngine.Events.UnityEvent onOutputCollected;

		public global::UnityEngine.Events.UnityEvent onStartButtonClicked;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EMixingStationAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EMixingStationAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; private set; }

		public global::ScheduleOne.ObjectScripts.MixOperation CurrentMixOperation { get; set; }

		public bool IsMixingDone => false;

		public int CurrentMixTime { get; protected set; }

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

		protected global::ScheduleOne.Management.MixingStationConfiguration stationConfiguration { get; set; }

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

		public global::UnityEngine.Vector3 DiscoveryBoxOffset { get; private set; }

		public global::UnityEngine.Quaternion DiscoveryBoxRotation { get; private set; }

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

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(global::FishNet.Connection.NetworkConnection conn)
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

		private void TimeSkipped(int minsPassed)
		{
		}

		protected virtual void MinPass()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixingOperation(global::ScheduleOne.ObjectScripts.MixOperation operation, int mixTime)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public virtual void SetMixOperation(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.MixOperation operation, int mixTIme)
		{
		}

		public virtual void MixingStart()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void MixingDone_Networked()
		{
		}

		public virtual void MixingDone()
		{
		}

		public bool DoesOutputHaveSpace(global::ScheduleOne.StationFramework.StationRecipe recipe)
		{
			return false;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> GetIngredients()
		{
			return null;
		}

		public int GetMixQuantity()
		{
			return 0;
		}

		public bool CanStartMix()
		{
			return false;
		}

		public global::ScheduleOne.Product.ProductDefinition GetProduct()
		{
			return null;
		}

		public global::ScheduleOne.Product.PropertyItemDefinition GetMixer()
		{
			return null;
		}

		public int GetMixTimeForCurrentOperation()
		{
			return 0;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void TryCreateOutputItems()
		{
		}

		public void SetStartButtonClickable(bool clickable)
		{
		}

		private void OutputChanged()
		{
		}

		private void StartButtonClicked(global::UnityEngine.RaycastHit hit)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		public global::ScheduleOne.UI.Management.WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		public void DestroyWorldspaceUI()
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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(global::FishNet.Object.NetworkObject npcObject)
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

		private void RpcWriter___Server_SendMixingOperation_2669582547(global::ScheduleOne.ObjectScripts.MixOperation operation, int mixTime)
		{
		}

		public void RpcLogic___SendMixingOperation_2669582547(global::ScheduleOne.ObjectScripts.MixOperation operation, int mixTime)
		{
		}

		private void RpcReader___Server_SendMixingOperation_2669582547(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMixOperation_1073078804(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.MixOperation operation, int mixTIme)
		{
		}

		public virtual void RpcLogic___SetMixOperation_1073078804(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.MixOperation operation, int mixTIme)
		{
		}

		private void RpcReader___Observers_SetMixOperation_1073078804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetMixOperation_1073078804(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.MixOperation operation, int mixTIme)
		{
		}

		private void RpcReader___Target_SetMixOperation_1073078804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_MixingDone_Networked_2166136261()
		{
		}

		public void RpcLogic___MixingDone_Networked_2166136261()
		{
		}

		private void RpcReader___Observers_MixingDone_Networked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_TryCreateOutputItems_2166136261()
		{
		}

		public void RpcLogic___TryCreateOutputItems_2166136261()
		{
		}

		private void RpcReader___Server_TryCreateOutputItems_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
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

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002EMixingStation(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EMixingStation_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
