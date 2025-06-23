namespace ScheduleOne.EntityFramework
{
	public class SurfaceItem : global::ScheduleOne.EntityFramework.BuildableItem
	{
		[global::UnityEngine.Header("Settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Building.Surface.ESurfaceType> ValidSurfaceTypes;

		public bool AllowRotation;

		protected global::UnityEngine.Vector3 RelativePosition;

		protected global::UnityEngine.Quaternion RelativeRotation;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002ESurfaceItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002ESurfaceItemAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Building.Surface ParentSurface { get; protected set; }

		public float RotationIncrement { get; }

		public override void Awake()
		{
		}

		public override void OnStartClient()
		{
		}

		protected override void SendInitToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendSurfaceItemData(global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void InitializeSurfaceItem(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		public virtual void InitializeSurfaceItem(global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		protected virtual void SetTransformData(string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		protected override global::ScheduleOne.Property.Property GetProperty(global::UnityEngine.Transform searchTransform = null)
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
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

		private void RpcWriter___Server_SendSurfaceItemData_2652836379(global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		public void RpcLogic___SendSurfaceItemData_2652836379(global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		private void RpcReader___Server_SendSurfaceItemData_2652836379(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_InitializeSurfaceItem_2932264618(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		public virtual void RpcLogic___InitializeSurfaceItem_2932264618(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		private void RpcReader___Target_InitializeSurfaceItem_2932264618(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_InitializeSurfaceItem_2932264618(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ItemFramework.ItemInstance instance, string GUID, string parentSurfaceGUID, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation)
		{
		}

		private void RpcReader___Observers_InitializeSurfaceItem_2932264618(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEntityFramework_002ESurfaceItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
