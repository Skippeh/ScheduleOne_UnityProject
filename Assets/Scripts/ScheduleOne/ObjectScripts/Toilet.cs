namespace ScheduleOne.ObjectScripts
{
	public class Toilet : global::ScheduleOne.EntityFramework.GridItem
	{
		public float InitialDelay;

		public float FlushTime;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.LayerMask ItemLayerMask;

		public global::UnityEngine.SphereCollider ItemDetectionCollider;

		public global::UnityEngine.Events.UnityEvent OnFlush;

		private global::UnityEngine.Coroutine _flushCoroutine;

		private bool isFlushing;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EToiletAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EToiletAssembly_002DCSharp_002Edll_Excuted;

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendFlush()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void Flush()
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

		private void RpcWriter___Server_SendFlush_2166136261()
		{
		}

		private void RpcLogic___SendFlush_2166136261()
		{
		}

		private void RpcReader___Server_SendFlush_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Flush_2166136261()
		{
		}

		private void RpcLogic___Flush_2166136261()
		{
		}

		private void RpcReader___Observers_Flush_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
