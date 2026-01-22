namespace ScheduleOne.ObjectScripts
{
	public class ChemistryStation : global::ScheduleOne.EntityFramework.GridItem, global::ScheduleOne.Management.IUsable, global::ScheduleOne.ItemFramework.IItemSlotOwner, global::ScheduleOne.Management.ITransitEntity, global::ScheduleOne.Management.IConfigurable
	{
		public enum EStep
		{
			CombineIngredients = 0,
			Stir = 1,
			LowerBoilingFlask = 2,
			PourIntoBoilingFlask = 3,
			RaiseBoilingFlask = 4,
			StartHeat = 5,
			Cook = 6,
			LowerBoilingFlaskAgain = 7,
			PourThroughFilter = 8
		}

		public const float FOV_OVERRIDE = 65f;

		public const int INPUT_SLOT_COUNT = 3;

		public global::ScheduleOne.ItemFramework.ItemSlot[] IngredientSlots;

		public global::ScheduleOne.ItemFramework.ItemSlot OutputSlot;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform CameraPosition_Default;

		public global::UnityEngine.Transform CameraPosition_Stirring;

		public global::UnityEngine.Transform StaticBeaker;

		public global::UnityEngine.Transform StaticFunnel;

		public global::UnityEngine.Transform StaticStirringRod;

		public global::UnityEngine.Transform ItemContainer;

		public global::ScheduleOne.ObjectScripts.LabStand LabStand;

		public global::ScheduleOne.Storage.StorageVisualizer InputVisuals;

		public global::ScheduleOne.Storage.StorageVisualizer OutputVisuals;

		public global::UnityEngine.Rigidbody AnchorRb;

		public global::ScheduleOne.ObjectScripts.BunsenBurner Burner;

		public global::ScheduleOne.StationFramework.BoilingFlask BoilingFlask;

		public global::ScheduleOne.Misc.DigitalAlarm Alarm;

		public global::UnityEngine.Transform uiPoint;

		public global::UnityEngine.Transform[] accessPoints;

		public global::ScheduleOne.Management.ConfigurationReplicator configReplicator;

		public global::UnityEngine.BoxCollider TrashSpawnVolume;

		public global::UnityEngine.Transform ExplosionPoint;

		[global::UnityEngine.Header("Slot Display Points")]
		public global::UnityEngine.Transform InputSlotsPosition;

		public global::UnityEngine.Transform OutputSlotPosition;

		[global::UnityEngine.Header("Transforms")]
		public global::UnityEngine.Transform[] IngredientTransforms;

		public global::UnityEngine.Transform BeakerAlignmentTransform;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject BeakerPrefab;

		public global::ScheduleOne.ObjectScripts.StirringRod StirringRodPrefab;

		[global::UnityEngine.Header("UI")]
		public global::ScheduleOne.UI.Management.ChemistryStationUIElement WorldspaceUIPrefab;

		public global::UnityEngine.Sprite typeIcon;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EChemistryStationAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EChemistryStationAssembly_002DCSharp_002Edll_Excuted;

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

		public global::ScheduleOne.ObjectScripts.ChemistryCookOperation CurrentCookOperation { get; set; }

		public string Name => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> InputSlots { get; set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> OutputSlots { get; set; }

		public global::UnityEngine.Transform LinkOrigin => null;

		public global::UnityEngine.Transform[] AccessPoints => null;

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

		public global::ScheduleOne.Management.EntityConfiguration Configuration => null;

		protected global::ScheduleOne.Management.ChemistryStationConfiguration stationConfiguration { get; set; }

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

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		protected override void Destroy()
		{
		}

		protected virtual void OnMinPass()
		{
		}

		private void OnTimePass(int minutes)
		{
		}

		private void UpdateClock()
		{
		}

		protected virtual void Update()
		{
		}

		public global::ScheduleOne.ObjectScripts.Beaker CreateBeaker()
		{
			return null;
		}

		public global::ScheduleOne.ObjectScripts.StirringRod CreateStirringRod()
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCookOperation(global::ScheduleOne.ObjectScripts.ChemistryCookOperation op)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetCookOperation(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.ChemistryCookOperation operation)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void FinalizeOperation()
		{
		}

		public void ResetStation()
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

		public bool HasIngredientsForRecipe(global::ScheduleOne.StationFramework.StationRecipe recipe)
		{
			return false;
		}

		public void CreateTrash(global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationItem> mixerItems)
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open()
		{
		}

		public void Close()
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

		private void RpcWriter___Server_SendCookOperation_3552222198(global::ScheduleOne.ObjectScripts.ChemistryCookOperation op)
		{
		}

		public void RpcLogic___SendCookOperation_3552222198(global::ScheduleOne.ObjectScripts.ChemistryCookOperation op)
		{
		}

		private void RpcReader___Server_SendCookOperation_3552222198(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCookOperation_1024887225(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.ChemistryCookOperation operation)
		{
		}

		public void RpcLogic___SetCookOperation_1024887225(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.ChemistryCookOperation operation)
		{
		}

		private void RpcReader___Observers_SetCookOperation_1024887225(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetCookOperation_1024887225(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.ChemistryCookOperation operation)
		{
		}

		private void RpcReader___Target_SetCookOperation_1024887225(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_FinalizeOperation_2166136261()
		{
		}

		public void RpcLogic___FinalizeOperation_2166136261()
		{
		}

		private void RpcReader___Observers_FinalizeOperation_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
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

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002EChemistryStation(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EChemistryStation_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
