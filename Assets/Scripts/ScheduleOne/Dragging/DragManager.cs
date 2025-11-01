namespace ScheduleOne.Dragging
{
	public class DragManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Dragging.DragManager>
	{
		public const float DRAGGABLE_OFFSET = 1.25f;

		public global::ScheduleOne.Audio.AudioSourceController ThrowSound;

		[global::UnityEngine.Header("Settings")]
		public float DragForce;

		public float DampingFactor;

		public float TorqueForce;

		public float TorqueDampingFactor;

		public float ThrowForce;

		public float MassInfluence;

		private global::System.Collections.Generic.List<global::ScheduleOne.Dragging.Draggable> AllDraggables;

		private global::System.Collections.Generic.List<global::ScheduleOne.Dragging.Draggable> CurrentlyUpdating;

		private global::ScheduleOne.Dragging.Draggable lastThrownDraggable;

		private global::ScheduleOne.Dragging.Draggable lastHeldDraggable;

		private bool NetworkInitialize___EarlyScheduleOne_002EDragging_002EDragManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EDragging_002EDragManagerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Dragging.Draggable CurrentDraggable { get; protected set; }

		public bool IsDragging => false;

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void Update()
		{
		}

		public void FixedUpdate()
		{
		}

		public bool IsDraggingAllowed()
		{
			return false;
		}

		public void RegisterDraggable(global::ScheduleOne.Dragging.Draggable draggable)
		{
		}

		public void Deregister(global::ScheduleOne.Dragging.Draggable draggable)
		{
		}

		public void StartDragging(global::ScheduleOne.Dragging.Draggable draggable)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendDragger(string draggableGUID, global::FishNet.Object.NetworkObject dragger, global::UnityEngine.Vector3 position)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SetDragger(string draggableGUID, global::FishNet.Object.NetworkObject dragger, global::UnityEngine.Vector3 position)
		{
		}

		public void StopDragging(global::UnityEngine.Vector3 velocity)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDraggableTransformData(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetDraggableTransformData(global::FishNet.Connection.NetworkConnection conn, string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity)
		{
		}

		private global::UnityEngine.Vector3 GetTargetPosition()
		{
			return default(global::UnityEngine.Vector3);
		}

		[global::EasyButtons.Button]
		public void EnsureAllDraggableGUIDsAreValid()
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

		private void RpcWriter___Server_SendDragger_807933219(string draggableGUID, global::FishNet.Object.NetworkObject dragger, global::UnityEngine.Vector3 position)
		{
		}

		private void RpcLogic___SendDragger_807933219(string draggableGUID, global::FishNet.Object.NetworkObject dragger, global::UnityEngine.Vector3 position)
		{
		}

		private void RpcReader___Server_SendDragger_807933219(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, global::FishNet.Object.NetworkObject dragger, global::UnityEngine.Vector3 position)
		{
		}

		private void RpcLogic___SetDragger_807933219(string draggableGUID, global::FishNet.Object.NetworkObject dragger, global::UnityEngine.Vector3 position)
		{
		}

		private void RpcReader___Observers_SetDragger_807933219(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity)
		{
		}

		private void RpcLogic___SendDraggableTransformData_4062762274(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity)
		{
		}

		private void RpcReader___Server_SendDraggableTransformData_4062762274(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetDraggableTransformData_3831223955(global::FishNet.Connection.NetworkConnection conn, string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity)
		{
		}

		private void RpcLogic___SetDraggableTransformData_3831223955(global::FishNet.Connection.NetworkConnection conn, string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity)
		{
		}

		private void RpcReader___Observers_SetDraggableTransformData_3831223955(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetDraggableTransformData_3831223955(global::FishNet.Connection.NetworkConnection conn, string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity)
		{
		}

		private void RpcReader___Target_SetDraggableTransformData_3831223955(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
