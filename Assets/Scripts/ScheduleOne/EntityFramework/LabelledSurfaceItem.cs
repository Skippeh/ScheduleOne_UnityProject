using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using TMPro;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	public class LabelledSurfaceItem : SurfaceItem
	{
		public int MaxCharacters;

		[Header("References")]
		public TextMeshPro Label;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002ELabelledSurfaceItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002ELabelledSurfaceItemAssembly_002DCSharp_002Edll_Excuted;

		public string Message { get; private set; }

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageToServer(string message)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetMessage(NetworkConnection conn, string message)
		{
		}

		public void Interacted()
		{
		}

		private void MessageSubmitted(string message)
		{
		}

		public override string GetSaveString()
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

		private void RpcWriter___Server_SendMessageToServer_3615296227(string message)
		{
		}

		public void RpcLogic___SendMessageToServer_3615296227(string message)
		{
		}

		private void RpcReader___Server_SendMessageToServer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		public void RpcLogic___SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		private void RpcReader___Observers_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetMessage_2971853958(NetworkConnection conn, string message)
		{
		}

		private void RpcReader___Target_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
