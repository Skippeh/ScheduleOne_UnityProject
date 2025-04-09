using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class Forklift : LandVehicle
	{
		[Header("Forklift References")]
		[SerializeField]
		protected Transform steeringWheel;

		[SerializeField]
		protected Rigidbody forkRb;

		[SerializeField]
		protected ConfigurableJoint joint;

		[Header("Forklift settings")]
		[SerializeField]
		protected float steeringWheelAngleMultiplier;

		[SerializeField]
		protected float lift_MinY;

		[SerializeField]
		protected float lift_MaxY;

		[SerializeField]
		protected float liftMoveRate;

		private float lastFrameTargetForkHeight;

		public SyncVar<float> syncVar____003CtargetForkHeight_003Ek__BackingField;

		public SyncVar<float> syncVar____003CactualForkHeight_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EForkliftAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EForkliftAssembly_002DCSharp_002Edll_Excuted;

		[field: SyncVar(Channel = Channel.Unreliable)]
		public float targetForkHeight
		{
			get; [ServerRpc(RunLocally = true)]
			protected set;
		}

		[field: SyncVar(SendRate = 0.04f, Channel = Channel.Unreliable)]
		public float actualForkHeight
		{
			get; [ServerRpc(RunLocally = true)]
			protected set;
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

		protected new virtual void LateUpdate()
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

		[SpecialName]
		protected void RpcLogic___set_targetForkHeight_431000436(float value)
		{
		}

		private void RpcReader___Server_set_targetForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_actualForkHeight_431000436(float value)
		{
		}

		[SpecialName]
		protected void RpcLogic___set_actualForkHeight_431000436(float value)
		{
		}

		private void RpcReader___Server_set_actualForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EVehicles_002EForklift(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVehicles_002EForklift_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
