using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Dragging
{
	public class DragManager : NetworkSingleton<DragManager>
	{
		public const float DRAGGABLE_OFFSET = 1.25f;

		public AudioSourceController ThrowSound;

		[Header("Settings")]
		public float DragForce;

		public float DampingFactor;

		public float TorqueForce;

		public float TorqueDampingFactor;

		public float ThrowForce;

		public float MassInfluence;

		private List<Draggable> AllDraggables;

		private Draggable lastThrownDraggable;

		private Draggable lastHeldDraggable;

		private bool NetworkInitialize___EarlyScheduleOne_002EDragging_002EDragManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EDragging_002EDragManagerAssembly_002DCSharp_002Edll_Excuted;

		public Draggable CurrentDraggable { get; protected set; }

		public bool IsDragging => false;

		public override void OnSpawnServer(NetworkConnection connection)
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

		public void RegisterDraggable(Draggable draggable)
		{
		}

		public void Deregister(Draggable draggable)
		{
		}

		public void StartDragging(Draggable draggable)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		[ObserversRpc]
		private void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		public void StopDragging(Vector3 velocity)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		private Vector3 GetTargetPosition()
		{
			return default(Vector3);
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

		private void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		private void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		private void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		private void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		private void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		private void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		private void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		private void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		private void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		private void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
