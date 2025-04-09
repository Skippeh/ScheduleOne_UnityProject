using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Delivery;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.Money;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Property
{
	public class Property : NetworkBehaviour, ISaveable
	{
		public delegate void PropertyChange(Property property);

		public static List<Property> Properties;

		public static List<Property> UnownedProperties;

		public static List<Property> OwnedProperties;

		public static PropertyChange onPropertyAcquired;

		public UnityEvent onThisPropertyAcquired;

		[Header("Settings")]
		[SerializeField]
		protected string propertyName;

		public bool AvailableInDemo;

		[SerializeField]
		protected string propertyCode;

		public float Price;

		public float DefaultRotation;

		public int EmployeeCapacity;

		public bool OwnedByDefault;

		public bool DEBUG_SET_OWNED;

		public string IsOwnedVariable;

		[Header("Culling Settings")]
		public bool ContentCullingEnabled;

		public float MinimumCullingDistance;

		public GameObject[] ObjectsToCull;

		[Header("References")]
		public PropertyContentsContainer Container;

		public Transform EmployeeContainer;

		public Transform SpawnPoint;

		public Transform InteriorSpawnPoint;

		public GameObject ForSaleSign;

		public GameObject BoundingBox;

		public POI PoI;

		public Transform ListingPoster;

		public Transform NPCSpawnPoint;

		public Transform[] EmployeeIdlePoints;

		public List<ModularSwitch> Switches;

		public List<InteractableToggleable> Toggleables;

		public PropertyDisposalArea DisposalArea;

		public LoadingDock[] LoadingDocks;

		[HideInInspector]
		public List<BuildableItem> BuildableItems;

		public List<IConfigurable> Configurables;

		private BoxCollider[] propertyBoundsColliders;

		private PropertyLoader loader;

		private List<string> savedObjectPaths;

		private List<string> savedEmployeePaths;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002EPropertyAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002EPropertyAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOwned { get; protected set; }

		public List<Employee> Employees { get; protected set; }

		public RectTransform WorldspaceUIContainer { get; protected set; }

		public bool IsContentCulled { get; set; }

		public string PropertyName => null;

		public string PropertyCode => null;

		public int LoadingDockCount => 0;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public virtual void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		public void AddConfigurable(IConfigurable configurable)
		{
		}

		public void RemoveConfigurable(IConfigurable configurable)
		{
		}

		private void UpdateCulling()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		public override void OnStartServer()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected void SetOwned_Server()
		{
		}

		[ObserversRpc(RunLocally = true, BufferLast = true)]
		private void ReceiveOwned_Networked()
		{
		}

		protected virtual void RecieveOwned()
		{
		}

		public virtual bool ShouldSave()
		{
			return false;
		}

		public void SetOwned()
		{
		}

		public void SetBoundsVisible(bool vis)
		{
		}

		public virtual void SetContentCulled(bool culled)
		{
		}

		public int RegisterEmployee(Employee emp)
		{
			return 0;
		}

		public void DeregisterEmployee(Employee emp)
		{
		}

		private void ToggleableActioned(InteractableToggleable toggleable)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendToggleableState(int index, bool state)
		{
		}

		[ObserversRpc]
		[TargetRpc]
		public void SetToggleableState(NetworkConnection conn, int index, bool state)
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

		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		public virtual void Load(PropertyData propertyData, string containerPath)
		{
		}

		public bool DoBoundsContainPoint(Vector3 point)
		{
			return false;
		}

		private bool IsPointInsideBox(Vector3 worldPoint, BoxCollider box)
		{
			return false;
		}

		public List<Bed> GetUnassignedBeds()
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

		private void RpcWriter___Server_SetOwned_Server_2166136261()
		{
		}

		protected void RpcLogic___SetOwned_Server_2166136261()
		{
		}

		private void RpcReader___Server_SetOwned_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveOwned_Networked_2166136261()
		{
		}

		private void RpcLogic___ReceiveOwned_Networked_2166136261()
		{
		}

		private void RpcReader___Observers_ReceiveOwned_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state)
		{
		}

		public void RpcLogic___SendToggleableState_3658436649(int index, bool state)
		{
		}

		private void RpcReader___Server_SendToggleableState_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		public void RpcLogic___SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		private void RpcReader___Observers_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		private void RpcReader___Target_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EProperty_002EProperty_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
