namespace ScheduleOne.Vehicles
{
	public class Forklift : global::ScheduleOne.Vehicles.LandVehicle
	{
		[global::UnityEngine.Header("Forklift References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform steeringWheel;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Rigidbody forkRb;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.ConfigurableJoint joint;

		[global::UnityEngine.Header("Forklift settings")]
		[global::UnityEngine.SerializeField]
		protected float steeringWheelAngleMultiplier;

		[global::UnityEngine.SerializeField]
		protected float lift_MinY;

		[global::UnityEngine.SerializeField]
		protected float lift_MaxY;

		[global::UnityEngine.SerializeField]
		protected float liftMoveRate;

		private float lastFrameTargetForkHeight;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar____003CtargetForkHeight_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar____003CactualForkHeight_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EForkliftAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EForkliftAssembly_002DCSharp_002Edll_Excuted;

		public float targetForkHeight
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc(RunLocally = true)]
			protected set
			{
			}
		}

		public float actualForkHeight
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc(RunLocally = true)]
			protected set
			{
			}
		}

		public float SyncAccessor__003CtargetForkHeight_003Ek__BackingField
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SyncAccessor__003CactualForkHeight_003Ek__BackingField
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		protected override void Update()
		{
		}

		protected override void FixedUpdate()
		{
		}

		protected virtual void LateUpdate()
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

		private void RpcWriter___Server_set_targetForkHeight_431000436(float value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		protected void RpcLogic___set_targetForkHeight_431000436(float value)
		{
		}

		private void RpcReader___Server_set_targetForkHeight_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_actualForkHeight_431000436(float value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		protected void RpcLogic___set_actualForkHeight_431000436(float value)
		{
		}

		private void RpcReader___Server_set_actualForkHeight_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EVehicles_002EForklift(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVehicles_002EForklift_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
