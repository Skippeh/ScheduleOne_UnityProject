using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Interaction;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ItemFramework
{
	[RequireComponent(typeof(InteractableObject))]
	public class ItemPickup : NetworkBehaviour
	{
		public ItemDefinition ItemToGive;

		public bool DestroyOnPickup;

		public bool ConditionallyActive;

		public Condition ActiveCondition;

		public bool Networked;

		[Header("References")]
		public InteractableObject IntObj;

		public UnityEvent onPickup;

		private bool NetworkInitialize___EarlyScheduleOne_002EItemFramework_002EItemPickupAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EItemFramework_002EItemPickupAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		private void Init()
		{
		}

		protected virtual void Hovered()
		{
		}

		private void Interacted()
		{
		}

		protected virtual bool CanPickup()
		{
			return false;
		}

		protected virtual void Pickup()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void Destroy()
		{
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

		private void RpcWriter___Server_Destroy_2166136261()
		{
		}

		public void RpcLogic___Destroy_2166136261()
		{
		}

		private void RpcReader___Server_Destroy_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EItemFramework_002EItemPickup_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
