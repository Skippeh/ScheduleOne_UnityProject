namespace ScheduleOne.ItemFramework
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Interaction.InteractableObject))]
	public class NetworkedItemPickup : global::FishNet.Object.NetworkBehaviour
	{
		public global::ScheduleOne.ItemFramework.ItemDefinition ItemToGive;

		public bool DestroyOnPickup;

		public bool ConditionallyActive;

		public global::ScheduleOne.Variables.Condition ActiveCondition;

		public bool Networked;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Events.UnityEvent onPickup;

		private bool NetworkInitialize___EarlyScheduleOne_002EItemFramework_002ENetworkedItemPickupAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EItemFramework_002ENetworkedItemPickupAssembly_002DCSharp_002Edll_Excuted;

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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
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

		private void RpcReader___Server_Destroy_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EItemFramework_002ENetworkedItemPickup_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
