namespace ScheduleOne.Property
{
	public class Property : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.Persistence.ISaveable
	{
		public delegate void PropertyChange(global::ScheduleOne.Property.Property property);

		public static global::System.Collections.Generic.List<global::ScheduleOne.Property.Property> Properties;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Property.Property> UnownedProperties;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Property.Property> OwnedProperties;

		public static global::ScheduleOne.Property.Property.PropertyChange onPropertyAcquired;

		public global::UnityEngine.Events.UnityEvent onThisPropertyAcquired;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected string propertyName;

		public bool AvailableInDemo;

		[global::UnityEngine.SerializeField]
		protected string propertyCode;

		public float Price;

		public float DefaultRotation;

		public int EmployeeCapacity;

		public bool OwnedByDefault;

		public string IsOwnedVariable;

		[global::UnityEngine.Header("Culling Settings")]
		public bool ContentCullingEnabled;

		public float MinimumCullingDistance;

		public global::UnityEngine.GameObject[] ObjectsToCull;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Property.PropertyContentsContainer Container;

		public global::UnityEngine.Transform EmployeeContainer;

		public global::UnityEngine.Transform SpawnPoint;

		public global::UnityEngine.Transform InteriorSpawnPoint;

		public global::UnityEngine.GameObject ForSaleSign;

		public global::UnityEngine.GameObject BoundingBox;

		public global::ScheduleOne.Map.POI PoI;

		public global::UnityEngine.Transform ListingPoster;

		public global::UnityEngine.Transform NPCSpawnPoint;

		public global::UnityEngine.Transform[] EmployeeIdlePoints;

		public global::System.Collections.Generic.List<global::ScheduleOne.Misc.ModularSwitch> Switches;

		public global::System.Collections.Generic.List<global::ScheduleOne.Interaction.InteractableToggleable> Toggleables;

		public global::ScheduleOne.Property.PropertyDisposalArea DisposalArea;

		public global::ScheduleOne.Delivery.LoadingDock[] LoadingDocks;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> BuildableItems;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> Configurables;

		public readonly global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Grid> Grids;

		private global::UnityEngine.BoxCollider[] propertyBoundsColliders;

		private global::ScheduleOne.Persistence.Loaders.PropertyLoader loader;

		private global::System.Collections.Generic.List<string> savedObjectPaths;

		private global::System.Collections.Generic.List<string> savedEmployeePaths;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002EPropertyAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002EPropertyAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOwned { get; protected set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.Employees.Employee> Employees { get; protected set; }

		public global::UnityEngine.RectTransform WorldspaceUIContainer { get; protected set; }

		public bool IsContentCulled { get; set; }

		public string PropertyName => null;

		public string PropertyCode => null;

		[field: global::UnityEngine.SerializeField]
		public float AmbientTemperature { get; private set; }

		public int LoadingDockCount => 0;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

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

		public void AddConfigurable(global::ScheduleOne.Management.IConfigurable configurable)
		{
		}

		public void RemoveConfigurable(global::ScheduleOne.Management.IConfigurable configurable)
		{
		}

		private void UpdateCulling()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void GetNetworth(global::ScheduleOne.Money.MoneyManager.FloatContainer container)
		{
		}

		public override void OnStartServer()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected void SetOwned_Server()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true, BufferLast = true)]
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

		public virtual bool CanBePurchased()
		{
			return false;
		}

		public virtual void SetContentCulled(bool culled)
		{
		}

		public int RegisterEmployee(global::ScheduleOne.Employees.Employee emp)
		{
			return 0;
		}

		public void DeregisterEmployee(global::ScheduleOne.Employees.Employee emp)
		{
		}

		private void ToggleableActioned(global::ScheduleOne.Interaction.InteractableToggleable toggleable)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendToggleableState(int index, bool state)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		public void SetToggleableState(global::FishNet.Connection.NetworkConnection conn, int index, bool state)
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		protected global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.DynamicSaveData> GetEmployeeSaveDatas()
		{
			return null;
		}

		protected global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.DynamicSaveData> GetObjectSaveDatas()
		{
			return null;
		}

		public virtual global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.PropertyData propertyData, string dataString)
		{
		}

		public bool DoBoundsContainPoint(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		private bool IsPointInsideBox(global::UnityEngine.Vector3 worldPoint, global::UnityEngine.BoxCollider box)
		{
			return false;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Bed> GetUnassignedBeds()
		{
			return null;
		}

		public global::System.Collections.Generic.List<T> GetBuildablesOfType<T>() where T : global::ScheduleOne.EntityFramework.BuildableItem
		{
			return null;
		}

		public virtual bool CanDeliverToProperty()
		{
			return false;
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

		private void RpcReader___Server_SetOwned_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveOwned_Networked_2166136261()
		{
		}

		private void RpcLogic___ReceiveOwned_Networked_2166136261()
		{
		}

		private void RpcReader___Observers_ReceiveOwned_Networked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state)
		{
		}

		public void RpcLogic___SendToggleableState_3658436649(int index, bool state)
		{
		}

		private void RpcReader___Server_SendToggleableState_3658436649(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetToggleableState_338960014(global::FishNet.Connection.NetworkConnection conn, int index, bool state)
		{
		}

		public void RpcLogic___SetToggleableState_338960014(global::FishNet.Connection.NetworkConnection conn, int index, bool state)
		{
		}

		private void RpcReader___Observers_SetToggleableState_338960014(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetToggleableState_338960014(global::FishNet.Connection.NetworkConnection conn, int index, bool state)
		{
		}

		private void RpcReader___Target_SetToggleableState_338960014(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EProperty_002EProperty_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
