namespace ScheduleOne.Skating
{
	public class Skateboard : global::FishNet.Object.NetworkBehaviour
	{
		public const float JumpCooldown = 0.3f;

		public const float JumpForceMin = 0.5f;

		public const float JumpForceBuildTime = 0.5f;

		public const float PushCooldown = 1f;

		public const float PushStaminaConsumption = 12.5f;

		public const float PitchLimit = 60f;

		public const float RollLimit = 20f;

		[global::UnityEngine.Header("Info - Readonly")]
		public float CurrentSpeed_Kmh;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Rigidbody Rb;

		public global::UnityEngine.Transform CoM;

		public global::UnityEngine.Transform[] HoverPoints;

		public global::UnityEngine.Transform FrontAxlePosition;

		public global::UnityEngine.Transform RearAxlePosition;

		public global::UnityEngine.Transform PlayerContainer;

		public global::ScheduleOne.Skating.SkateboardAnimation Animation;

		public global::ScheduleOne.Tools.SmoothedVelocityCalculator VelocityCalculator;

		public global::ScheduleOne.DevUtilities.AverageAcceleration Accelerometer;

		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.Skating.Skateboard_Equippable Equippable;

		public global::UnityEngine.Transform IKAlignmentsContainer;

		[global::UnityEngine.Header("Turn Settings")]
		public float TurnForce;

		public float TurnChangeRate;

		public float TurnReturnToRestRate;

		public float TurnSpeedBoost;

		public global::UnityEngine.AnimationCurve TurnForceMap;

		[global::UnityEngine.Header("Settings")]
		public float Gravity;

		public float BrakeForce;

		public float ReverseTopSpeed_Kmh;

		public global::UnityEngine.LayerMask GroundDetectionMask;

		public global::UnityEngine.Collider[] MainColliders;

		public float RotationClampForce;

		public bool SlowOnTerrain;

		[global::UnityEngine.Header("Friction Settings")]
		public bool FrictionEnabled;

		public global::UnityEngine.AnimationCurve LongitudinalFrictionCurve;

		public float LongitudinalFrictionMultiplier;

		public float LateralFrictionForceMultiplier;

		[global::UnityEngine.Header("Jump Settings")]
		public float JumpForce;

		public float JumpDuration_Min;

		public float JumpDuration_Max;

		public global::UnityEngine.AnimationCurve FrontAxleJumpCurve;

		public global::UnityEngine.AnimationCurve RearAxleJumpCurve;

		public global::UnityEngine.AnimationCurve JumpForwardForceCurve;

		public float JumpForwardBoost;

		[global::UnityEngine.Header("Hover Settings")]
		public float HoverForce;

		public float HoverRayLength;

		public float HoverHeight;

		public float Hover_P;

		public float Hover_I;

		public float Hover_D;

		[global::UnityEngine.Header("Pushing Setings")]
		[global::UnityEngine.Tooltip("Top speed in m/s")]
		public float TopSpeed_Kmh;

		public float PushForceMultiplier;

		public global::UnityEngine.AnimationCurve PushForceMultiplierMap;

		public float PushForceDuration;

		public float PushDelay;

		public global::UnityEngine.AnimationCurve PushForceCurve;

		[global::UnityEngine.Header("Air Movement")]
		public bool AirMovementEnabled;

		public float AirMovementForce;

		public float AirMovementJumpReductionDuration;

		public global::UnityEngine.AnimationCurve AirMovementJumpReductionCurve;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent OnPushStart;

		public global::UnityEngine.Events.UnityEvent<float> OnJump;

		public global::UnityEngine.Events.UnityEvent OnLand;

		private float horizontalInput;

		private bool jumpReleased;

		private float timeSinceLastJump;

		private float timeGrounded;

		private float timeAirborne;

		private float jumpHeldTime;

		private float frontAxleForce;

		private float rearAxleForce;

		private float jumpForwardForce;

		private global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.PID> hoverPIDs;

		private bool pushQueued;

		private bool isPushing;

		private float thisFramePushForce;

		private float timeSincePushStart;

		private bool braking;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar____003CJumpBuildAmount_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002ESkating_002ESkateboardAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ESkating_002ESkateboardAssembly_002DCSharp_002Edll_Excuted;

		public float CurrentSteerInput { get; protected set; }

		public bool IsPushing => false;

		public float TimeSincePushStart => 0f;

		public bool isGrounded => false;

		public float AirTime => 0f;

		public float JumpBuildAmount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc]
			set
			{
			}
		}

		public global::ScheduleOne.PlayerScripts.Player Rider { get; private set; }

		public float TopSpeed_Ms => 0f;

		public float SyncAccessor__003CJumpBuildAmount_003Ek__BackingField
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		public override void OnStartClient()
		{
		}

		public void Update()
		{
		}

		private void GetInput()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void ApplyInput()
		{
		}

		private void ApplyLateralFriction()
		{
		}

		private void UpdateHover()
		{
		}

		private void ApplyGravity()
		{
		}

		private void CheckGrounded()
		{
		}

		private void CheckJump()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		private void SendJump(float jumpHeldTime)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveJump(float _jumpHeldTime)
		{
		}

		private void Jump()
		{
		}

		private void Push()
		{
		}

		public bool IsGrounded()
		{
			return false;
		}

		public bool IsGrounded(out global::UnityEngine.RaycastHit hit)
		{
			hit = default(global::UnityEngine.RaycastHit);
			return false;
		}

		public void SetVelocity(global::UnityEngine.Vector3 velocity)
		{
		}

		private void ClampRotation()
		{
		}

		public void ApplyPlayerScale()
		{
		}

		public float GetSurfaceSmoothness()
		{
			return 0f;
		}

		public bool IsOnTerrain()
		{
			return false;
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

		private void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		public void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
		}

		private void RpcReader___Server_set_JumpBuildAmount_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
		}

		private void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
		}

		private void RpcReader___Server_SendJump_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
		}

		private void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
		}

		private void RpcReader___Observers_ReceiveJump_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002ESkating_002ESkateboard(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		private void Awake_UserLogic_ScheduleOne_002ESkating_002ESkateboard_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
