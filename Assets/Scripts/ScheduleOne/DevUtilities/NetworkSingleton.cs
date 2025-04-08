namespace ScheduleOne.DevUtilities
{
	public abstract class NetworkSingleton<T> : global::FishNet.Object.NetworkBehaviour where T : global::ScheduleOne.DevUtilities.NetworkSingleton<T>
	{
		private static T instance;

		protected bool Destroyed;

		private bool NetworkInitialize___EarlyScheduleOne_002EDevUtilities_002ENetworkSingleton_00601Assembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EDevUtilities_002ENetworkSingleton_00601Assembly_002DCSharp_002Edll_Excuted;

		public static bool InstanceExists => false;

		public static T Instance
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected virtual void Start()
		{
		}

		public virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002EDevUtilities_002ENetworkSingleton_00601_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
