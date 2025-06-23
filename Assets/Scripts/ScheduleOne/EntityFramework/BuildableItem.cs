namespace ScheduleOne.EntityFramework
{
	[global::UnityEngine.RequireComponent(typeof(global::FishNet.Component.Ownership.PredictedSpawn))]
	public class BuildableItem : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.ISaveable
	{
		public enum EOutlineColor
		{
			White = 0,
			Blue = 1,
			LightBlue = 2
		}

		[global::UnityEngine.HideInInspector]
		public bool isGhost;

		[global::UnityEngine.Header("Build Settings")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject buildHandler;

		public float HoldDistance;

		public global::UnityEngine.Transform BuildPoint;

		public global::UnityEngine.Transform MidAirCenterPoint;

		public global::UnityEngine.BoxCollider BoundingCollider;

		[global::UnityEngine.Header("Outline settings")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.GameObject> OutlineRenderers;

		[global::UnityEngine.SerializeField]
		protected bool IncludeOutlineRendererChildren;

		protected global::EPOOutline.Outlinable OutlineEffect;

		[global::UnityEngine.Header("Culling Settings")]
		public global::UnityEngine.GameObject[] GameObjectsToCull;

		public global::System.Collections.Generic.List<global::UnityEngine.MeshRenderer> MeshesToCull;

		[global::UnityEngine.Header("Buildable Events")]
		public global::UnityEngine.Events.UnityEvent onGhostModel;

		public global::UnityEngine.Events.UnityEvent onInitialized;

		public global::UnityEngine.Events.UnityEvent onDestroyed;

		public global::System.Action<global::ScheduleOne.EntityFramework.BuildableItem> onDestroyedWithParameter;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002EBuildableItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002EBuildableItemAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ItemFramework.ItemInstance ItemInstance { get; protected set; }

		public global::ScheduleOne.Property.Property ParentProperty { get; protected set; }

		public bool IsDestroyed { get; protected set; }

		public bool Initialized { get; protected set; }

		public global::System.Guid GUID { get; protected set; }

		public bool IsCulled { get; protected set; }

		public global::UnityEngine.GameObject BuildHandler => null;

		public bool LocallyBuilt { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		[global::EasyButtons.Button]
		public void AddChildMeshes()
		{
		}

		public void SetLocallyBuilt()
		{
		}

		public virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual global::ScheduleOne.Property.Property GetProperty(global::UnityEngine.Transform searchTransform = null)
		{
			return null;
		}

		public virtual void InitializeSaveable()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		protected virtual void SendInitToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendBuildableItemData(global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		public void ReceiveBuildableItemData(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		public virtual void InitializeBuildableItem(global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		public bool CanBePickedUp(out string reason)
		{
			reason = null;
			return false;
		}

		public virtual bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public virtual void PickupItem()
		{
		}

		public virtual void DestroyItem(bool callOnServer = true)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void Destroy_Networked()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void DestroyItemWrapper()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public static global::UnityEngine.Color32 GetColorFromOutlineColorEnum(global::ScheduleOne.EntityFramework.BuildableItem.EOutlineColor col)
		{
			return default(global::UnityEngine.Color32);
		}

		public virtual void ShowOutline(global::UnityEngine.Color color)
		{
		}

		public void ShowOutline(global::ScheduleOne.EntityFramework.BuildableItem.EOutlineColor color)
		{
		}

		public virtual void HideOutline()
		{
		}

		public global::UnityEngine.Vector3 GetFurthestPointFromBoundingCollider(global::UnityEngine.Vector3 pos)
		{
			return default(global::UnityEngine.Vector3);
		}

		public bool GetPenetration(out float x, out float z, out float y)
		{
			x = default(float);
			z = default(float);
			y = default(float);
			return false;
		}

		private bool HasLoS_IgnoreBuildables(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		public virtual void SetCulled(bool culled)
		{
		}

		public virtual global::ScheduleOne.Persistence.Datas.DynamicSaveData GetSaveData()
		{
			return null;
		}

		public virtual global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
		{
			return null;
		}

		public string GetSaveString()
		{
			return null;
		}

		public virtual global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SendBuildableItemData_3537728543(global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		public void RpcLogic___SendBuildableItemData_3537728543(global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		private void RpcReader___Server_SendBuildableItemData_3537728543(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveBuildableItemData_3859851844(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		public void RpcLogic___ReceiveBuildableItemData_3859851844(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		private void RpcReader___Observers_ReceiveBuildableItemData_3859851844(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveBuildableItemData_3859851844(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		private void RpcReader___Target_ReceiveBuildableItemData_3859851844(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_Destroy_Networked_2166136261()
		{
		}

		private void RpcLogic___Destroy_Networked_2166136261()
		{
		}

		private void RpcReader___Server_Destroy_Networked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_DestroyItemWrapper_2166136261()
		{
		}

		private void RpcLogic___DestroyItemWrapper_2166136261()
		{
		}

		private void RpcReader___Observers_DestroyItemWrapper_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002EBuildableItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
