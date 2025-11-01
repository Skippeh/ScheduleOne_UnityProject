namespace ScheduleOne.ObjectScripts
{
	public class BrickPress : global::ScheduleOne.EntityFramework.GridItem, global::ScheduleOne.Management.IUsable, global::ScheduleOne.ItemFramework.IItemSlotOwner, global::ScheduleOne.Management.ITransitEntity, global::ScheduleOne.Management.IConfigurable
	{
		public const int INPUT_SLOT_COUNT = 2;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform CameraPosition;

		public global::UnityEngine.Transform CameraPosition_Pouring;

		public global::UnityEngine.Transform CameraPosition_Raising;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform uiPoint;

		public global::UnityEngine.Transform StandPoint;

		public global::UnityEngine.Transform[] accessPoints;

		public global::ScheduleOne.Storage.StorageVisualizer OutputVisuals;

		public global::ScheduleOne.ObjectScripts.BrickPressContainer Container1;

		public global::ScheduleOne.ObjectScripts.BrickPressContainer Container2;

		public global::UnityEngine.Transform ContainerSpawnPoint;

		public global::ScheduleOne.Product.Packaging.PackagingDefinition BrickPackaging;

		public global::UnityEngine.BoxCollider MouldDetection;

		public global::ScheduleOne.ObjectScripts.BrickPressHandle Handle;

		public global::UnityEngine.Transform PressTransform;

		public global::UnityEngine.Transform PressTransform_Raised;

		public global::UnityEngine.Transform PressTransform_Lowered;

		public global::UnityEngine.Transform PressTransform_Compressed;

		public global::ScheduleOne.Audio.AudioSourceController SlamSound;

		public global::ScheduleOne.Management.ConfigurationReplicator configReplicator;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.PlayerTasks.Draggable FunctionalContainerPrefab;

		[global::UnityEngine.Header("UI")]
		public global::ScheduleOne.UI.Management.BrickPressUIElement WorldspaceUIPrefab;

		public global::UnityEngine.Sprite typeIcon;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EBrickPressAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EBrickPressAssembly_002DCSharp_002Edll_Excuted;

		public bool isOpen => false;

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

		public global::ScheduleOne.ItemFramework.ItemSlot[] ProductSlots { get; private set; }

		public global::ScheduleOne.ItemFramework.ItemSlot OutputSlot { get; private set; }

		public string Name => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> InputSlots { get; set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> OutputSlots { get; set; }

		public global::UnityEngine.Transform LinkOrigin => null;

		public global::UnityEngine.Transform[] AccessPoints => null;

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

		public global::ScheduleOne.Management.EntityConfiguration Configuration => null;

		protected global::ScheduleOne.Management.BrickPressConfiguration stationConfiguration { get; set; }

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

		protected virtual void LateUpdate()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(global::FishNet.Connection.NetworkConnection conn)
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

		public override void DestroyItem(bool callOnServer = true)
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

		public global::ScheduleOne.ObjectScripts.PackagingStation.EState GetState()
		{
			return default(global::ScheduleOne.ObjectScripts.PackagingStation.EState);
		}

		private void UpdateInputVisuals()
		{
		}

		public bool HasSufficientProduct(out global::ScheduleOne.Product.ProductItemInstance product)
		{
			product = null;
			return false;
		}

		public void GetMainInputs(out global::ScheduleOne.ItemFramework.ItemInstance primaryItem, out int primaryItemQuantity, out global::ScheduleOne.ItemFramework.ItemInstance secondaryItem, out int secondaryItemQuantity)
		{
			primaryItem = null;
			primaryItemQuantity = default(int);
			secondaryItem = null;
			secondaryItemQuantity = default(int);
		}

		public global::ScheduleOne.PlayerTasks.Draggable CreateFunctionalContainer(global::ScheduleOne.Product.ProductItemInstance instance, float productScale, out global::System.Collections.Generic.List<global::ScheduleOne.Packaging.FunctionalProduct> products)
		{
			products = null;
			return null;
		}

		public void PlayPressAnim()
		{
		}

		public void CompletePress(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Packaging.FunctionalProduct> GetProductInMould()
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

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002EBrickPress(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EBrickPress_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
