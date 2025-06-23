namespace ScheduleOne.EntityFramework
{
	public class LabelledSurfaceItem : global::ScheduleOne.EntityFramework.SurfaceItem
	{
		public int MaxCharacters;

		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshPro Label;

		private bool NetworkInitialize___EarlyScheduleOne_002EEntityFramework_002ELabelledSurfaceItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEntityFramework_002ELabelledSurfaceItemAssembly_002DCSharp_002Edll_Excuted;

		public string Message { get; private set; }

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageToServer(string message)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetMessage(global::FishNet.Connection.NetworkConnection conn, string message)
		{
		}

		public void Interacted()
		{
		}

		private void MessageSubmitted(string message)
		{
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

		private void RpcWriter___Server_SendMessageToServer_3615296227(string message)
		{
		}

		public void RpcLogic___SendMessageToServer_3615296227(string message)
		{
		}

		private void RpcReader___Server_SendMessageToServer_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMessage_2971853958(global::FishNet.Connection.NetworkConnection conn, string message)
		{
		}

		public void RpcLogic___SetMessage_2971853958(global::FishNet.Connection.NetworkConnection conn, string message)
		{
		}

		private void RpcReader___Observers_SetMessage_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetMessage_2971853958(global::FishNet.Connection.NetworkConnection conn, string message)
		{
		}

		private void RpcReader___Target_SetMessage_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
