using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	public class Toilet : GridItem
	{
		public float InitialDelay;

		public float FlushTime;

		public InteractableObject IntObj;

		public LayerMask ItemLayerMask;

		public SphereCollider ItemDetectionCollider;

		public UnityEvent OnFlush;

		private Coroutine _flushCoroutine;

		private bool isFlushing;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EToiletAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EToiletAssembly_002DCSharp_002Edll_Excuted;

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendFlush()
		{
		}

		[ObserversRpc]
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

		private void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Flush_2166136261()
		{
		}

		private void RpcLogic___Flush_2166136261()
		{
		}

		private void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
