using System;
using System.Collections.Generic;
using EPOOutline;
using EasyButtons;
using FishNet.Component.Ownership;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.EntityFramework
{
	[RequireComponent(typeof(PredictedSpawn))]
	public class BuildableItem : NetworkBehaviour, IGUIDRegisterable, ISaveable
	{
		public enum EOutlineColor
		{
			White = 0,
			Blue = 1,
			LightBlue = 2
		}

		[HideInInspector]
		public bool isGhost;

		[Header("Build Settings")]
		[SerializeField]
		protected GameObject buildHandler;

		public float HoldDistance;

		public Transform BuildPoint;

		public Transform MidAirCenterPoint;

		public BoxCollider BoundingCollider;

		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> OutlineRenderers;

		[SerializeField]
		protected bool IncludeOutlineRendererChildren;

		protected Outlinable OutlineEffect;

		[Header("Culling Settings")]
		public GameObject[] GameObjectsToCull;

		public List<MeshRenderer> MeshesToCull;

		[Header("Buildable Events")]
		public UnityEvent onInitialized;

		public UnityEvent onDestroyed;

		public Action<BuildableItem> onDestroyedWithParameter;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002EBuildableItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002EBuildableItemAssembly_002DCSharp_002Edll_Excuted;

		public ItemInstance ItemInstance { get; protected set; }

		public ScheduleOne.Property.Property ParentProperty { get; protected set; }

		public bool IsDestroyed { get; protected set; }

		public bool Initialized { get; protected set; }

		public Guid GUID { get; protected set; }

		public bool IsCulled { get; protected set; }

		public GameObject BuildHandler => null;

		public bool LocallyBuilt { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		[Button]
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

		protected virtual ScheduleOne.Property.Property GetProperty(Transform searchTransform = null)
		{
			return null;
		}

		public virtual void InitializeSaveable()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		protected virtual void SendInitToClient(NetworkConnection conn)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendBuildableItemData(ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		[ObserversRpc]
		[TargetRpc]
		public void ReceiveBuildableItemData(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		public virtual void InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode)
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

		[ServerRpc(RequireOwnership = false)]
		private void Destroy_Networked()
		{
		}

		[ObserversRpc]
		private void DestroyItemWrapper()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		public static Color32 GetColorFromOutlineColorEnum(EOutlineColor col)
		{
			return default(Color32);
		}

		public virtual void ShowOutline(Color color)
		{
		}

		public void ShowOutline(EOutlineColor color)
		{
		}

		public virtual void HideOutline()
		{
		}

		public Vector3 GetFurthestPointFromBoundingCollider(Vector3 pos)
		{
			return default(Vector3);
		}

		public bool GetPenetration(out float x, out float z, out float y)
		{
			x = default(float);
			z = default(float);
			y = default(float);
			return false;
		}

		private bool HasLoS_IgnoreBuildables(Vector3 point)
		{
			return false;
		}

		public virtual void SetCulled(bool culled)
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
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

		private void RpcWriter___Server_SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		public void RpcLogic___SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		private void RpcReader___Server_SendBuildableItemData_3537728543(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		public void RpcLogic___ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		private void RpcReader___Observers_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		private void RpcReader___Target_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_Destroy_Networked_2166136261()
		{
		}

		private void RpcLogic___Destroy_Networked_2166136261()
		{
		}

		private void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_DestroyItemWrapper_2166136261()
		{
		}

		private void RpcLogic___DestroyItemWrapper_2166136261()
		{
		}

		private void RpcReader___Observers_DestroyItemWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002EBuildableItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
