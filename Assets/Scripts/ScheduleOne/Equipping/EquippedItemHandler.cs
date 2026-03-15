namespace ScheduleOne.Equipping
{
	[global::UnityEngine.RequireComponent(typeof(global::FishNet.Component.Ownership.PredictedSpawn))]
	public class EquippedItemHandler : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler
	{
		[global::FishNet.Object.Synchronizing.SyncVar]
		public global::ScheduleOne.Equipping.Framework.INetworkedEquippableUser _user;

		[global::FishNet.Object.Synchronizing.SyncVar]
		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.Core.Equipping.Framework.EquippableData _equippableData;

		public global::FishNet.Object.Synchronizing.SyncVar<global::ScheduleOne.Equipping.Framework.INetworkedEquippableUser> syncVar____user;

		public global::FishNet.Object.Synchronizing.SyncVar<global::ScheduleOne.Core.Equipping.Framework.EquippableData> syncVar____equippableData;

		private bool NetworkInitialize___EarlyScheduleOne_002EEquipping_002EEquippedItemHandlerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEquipping_002EEquippedItemHandlerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Core.Equipping.Framework.IEquippableUser User => null;

		public global::ScheduleOne.Core.Equipping.Framework.EquippableData EquippableData => null;

		public bool IsEquipped { get; private set; }

		public global::ScheduleOne.Equipping.Framework.INetworkedEquippableUser SyncAccessor__user
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::ScheduleOne.Core.Equipping.Framework.EquippableData SyncAccessor__equippableData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		global::UnityEngine.GameObject global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler.gameObject => null;

		public event global::System.Action OnUnequipped
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		public virtual void Equipped(global::ScheduleOne.Core.Equipping.Framework.IEquippableUser user, global::ScheduleOne.Core.Equipping.Framework.EquippableData data)
		{
		}

		public virtual void EquippedWithItem(global::ScheduleOne.Core.Equipping.Framework.IEquippableUser user, global::ScheduleOne.Core.Equipping.Framework.EquippableData data, global::ScheduleOne.Core.Items.Framework.BaseItemInstance itemInstance)
		{
		}

		public virtual void Unequipped()
		{
		}

		public override void OnStartClient()
		{
		}

		private void SetupParent()
		{
		}

		protected virtual void SetupThirdPerson()
		{
		}

		protected virtual void SetupFirstPerson()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void UserUpdate()
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

		public virtual bool ReadSyncVar___ScheduleOne_002EEquipping_002EEquippedItemHandler(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public virtual void Awake()
		{
		}
	}
}
