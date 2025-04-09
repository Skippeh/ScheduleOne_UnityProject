using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Skating
{
	public class Skateboard : NetworkBehaviour
	{
		public const float GroundedRaycastDistance = 0.1f;

		public const float JumpCooldown = 0.3f;

		public const float JumpForceMin = 0.5f;

		public const float JumpForceBuildTime = 0.5f;

		public const float PushCooldown = 1f;

		public const float PushStaminaConsumption = 12.5f;

		public const float PitchLimit = 60f;

		public const float RollLimit = 20f;

		[Header("Info - Readonly")]
		public float CurrentSpeed_Kmh;

		[Header("References")]
		public Rigidbody Rb;

		public Transform CoM;

		public Transform[] HoverPoints;

		public Transform FrontAxlePosition;

		public Transform RearAxlePosition;

		public Transform PlayerContainer;

		public SkateboardAnimation Animation;

		public SmoothedVelocityCalculator VelocityCalculator;

		public AverageAcceleration Accelerometer;

		public Skateboard_Equippable Equippable;

		public Transform IKAlignmentsContainer;

		[Header("Turn Settings")]
		public float TurnForce;

		public float TurnChangeRate;

		public float TurnReturnToRestRate;

		public float TurnSpeedBoost;

		public AnimationCurve TurnForceMap;

		[Header("Settings")]
		public float Gravity;

		public float BrakeForce;

		public float ReverseTopSpeed_Kmh;

		public LayerMask GroundDetectionMask;

		public Collider[] MainColliders;

		public float RotationClampForce;

		[Header("Friction Settings")]
		public bool FrictionEnabled;

		public AnimationCurve LongitudinalFrictionCurve;

		public float LongitudinalFrictionMultiplier;

		public float LateralFrictionForceMultiplier;

		[Header("Jump Settings")]
		public float JumpForce;

		public float JumpDuration_Min;

		public float JumpDuration_Max;

		public AnimationCurve FrontAxleJumpCurve;

		public AnimationCurve RearAxleJumpCurve;

		public AnimationCurve JumpForwardForceCurve;

		public float JumpForwardBoost;

		[Header("Hover Settings")]
		public float HoverForce;

		public float HoverRayLength;

		public float HoverHeight;

		public float Hover_P;

		public float Hover_I;

		public float Hover_D;

		[Header("Pushing Setings")]
		[Tooltip("Top speed in m/s")]
		public float TopSpeed_Kmh;

		public float PushForceMultiplier;

		public AnimationCurve PushForceMultiplierMap;

		public float PushForceDuration;

		public float PushDelay;

		public AnimationCurve PushForceCurve;

		[Header("Air Movement")]
		public bool AirMovementEnabled;

		public float AirMovementForce;

		public float AirMovementJumpReductionDuration;

		public AnimationCurve AirMovementJumpReductionCurve;

		[Header("Events")]
		public UnityEvent OnPushStart;

		public UnityEvent<float> OnJump;

		public UnityEvent OnLand;

		private int horizontalInput;

		private bool jumpReleased;

		private float timeSinceLastJump;

		private float timeGrounded;

		private float timeAirborne;

		private float jumpHeldTime;

		private float frontAxleForce;

		private float rearAxleForce;

		private float jumpForwardForce;

		private List<PID> hoverPIDs;

		private bool pushQueued;

		private bool isPushing;

		private float thisFramePushForce;

		private float timeSincePushStart;

		private bool braking;

		public SyncVar<float> syncVar____003CJumpBuildAmount_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002ESkating_002ESkateboardAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ESkating_002ESkateboardAssembly_002DCSharp_002Edll_Excuted;

		public float CurrentSteerInput { get; protected set; }

		public bool IsPushing => false;

		public float TimeSincePushStart => 0f;

		public bool isGrounded => false;

		public float AirTime => 0f;

		[field: SyncVar(Channel = Channel.Unreliable)]
		public float JumpBuildAmount
		{
			get; [ServerRpc]
			set;
		}

		public Player Rider { get; private set; }

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

		[ServerRpc(RunLocally = true)]
		private void SendJump(float jumpHeldTime)
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		public bool IsGrounded(out RaycastHit hit)
		{
			hit = default(RaycastHit);
			return false;
		}

		public void SetVelocity(Vector3 velocity)
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

		[SpecialName]
		public void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
		}

		private void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
		}

		private void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
		}

		private void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
		}

		private void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
		}

		private void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002ESkating_002ESkateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		private void Awake_UserLogic_ScheduleOne_002ESkating_002ESkateboard_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
