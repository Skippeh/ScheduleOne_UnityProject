using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	public class PlayerMovement : PlayerSingleton<PlayerMovement>
	{
		public class MovementEvent
		{
			public List<Action> actions;

			public Vector3 LastUpdatedDistance;

			public void Update(Vector3 newPosition)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CJump_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerMovement _003C_003E4__this;

			private float _003CsavedSlopeLimit_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CJump_003Ed__114(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLerpPlayerRotation_Process_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerMovement _003C_003E4__this;

			public Quaternion endRotation;

			public float lerpTime;

			private Quaternion _003CstartRot_003E5__2;

			private float _003Ci_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLerpPlayerRotation_Process_003Ed__122(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public const float DEV_SPRINT_MULTIPLIER = 1f;

		public const float GROUNDED_THRESHOLD = 0.05f;

		public const float SLOPE_THRESHOLD = 5f;

		public static float WalkSpeed;

		public static float SprintMultiplier;

		public static float StaticMoveSpeedMultiplier;

		public const float StaminaRestoreDelay = 1f;

		public static float JumpMultiplier;

		public static float ControllerRadius;

		public static float StandingControllerHeight;

		public static float CrouchHeightMultiplier;

		public static float CrouchTime;

		public const float StaminaDrainRate = 12.5f;

		public const float StaminaRestoreRate = 25f;

		public static float StaminaReserveMax;

		public const float SprintChangeRate = 4f;

		[Header("References")]
		public Player Player;

		public CharacterController Controller;

		[Header("Move settings")]
		[SerializeField]
		protected float sensitivity;

		[SerializeField]
		protected float dead;

		public bool canMove;

		public bool canJump;

		public bool SprintingRequiresStamina;

		public float MoveSpeedMultiplier;

		public float SlipperyMovementMultiplier;

		[Header("Jump/fall settings")]
		[SerializeField]
		protected float jumpForce;

		[SerializeField]
		protected float gravityMultiplier;

		[SerializeField]
		protected LayerMask groundDetectionMask;

		[Header("Slope Settings")]
		[SerializeField]
		protected float slopeForce;

		[SerializeField]
		protected float slopeForceRayLength;

		[Header("Crouch Settings")]
		[SerializeField]
		protected float crouchSpeedMultipler;

		[SerializeField]
		protected float Crouched_VigIntensity;

		[SerializeField]
		protected float Crouched_VigSmoothness;

		[Header("Visibility Points")]
		[SerializeField]
		protected List<Transform> visibilityPointsToScale;

		private Dictionary<Transform, float> originalVisibilityPointOffsets;

		protected Vector3 movement;

		protected float movementY;

		public List<LandVehicle> recentlyDrivenVehicles;

		private bool isJumping;

		public float CurrentStaminaReserve;

		public Action<float> onStaminaReserveChanged;

		public Action onJump;

		public Action onLand;

		public UnityEvent onCrouch;

		public UnityEvent onUncrouch;

		protected float horizontalAxis;

		protected float verticalAxis;

		protected float timeGrounded;

		private Dictionary<int, MovementEvent> movementEvents;

		private float timeSinceStaminaDrain;

		private bool sprintActive;

		private bool sprintReleased;

		private Vector3 residualVelocityDirection;

		private float residualVelocityForce;

		private float residualVelocityDuration;

		private float residualVelocityTimeRemaining;

		private bool teleport;

		private Vector3 teleportPosition;

		private List<string> sprintBlockers;

		private Vector3 lastFrameMovement;

		private Coroutine playerRotCoroutine;

		public static float GravityMultiplier { get; set; }

		public float playerHeight { get; protected set; }

		public Vector3 Movement => default(Vector3);

		public LandVehicle currentVehicle { get; protected set; }

		public float airTime { get; protected set; }

		public bool isCrouched { get; protected set; }

		public float standingScale { get; protected set; }

		public bool isRagdolled { get; protected set; }

		public bool isSprinting { get; protected set; }

		public float CurrentSprintMultiplier { get; protected set; }

		public bool IsGrounded { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		protected virtual void Move()
		{
		}

		private void ClampMovement()
		{
		}

		protected float GetSurfaceAngle()
		{
			return 0f;
		}

		private bool isGrounded()
		{
			return false;
		}

		protected void UpdateHorizontalAxis()
		{
		}

		protected void UpdateVerticalAxis()
		{
		}

		[IteratorStateMachine(typeof(_003CJump_003Ed__114))]
		private IEnumerator Jump()
		{
			return null;
		}

		private void TryToggleCrouch()
		{
		}

		public bool CanStand()
		{
			return false;
		}

		public void SetCrouched(bool c)
		{
		}

		private void UpdateCrouchVignetteEffect()
		{
		}

		private void UpdatePlayerHeight()
		{
		}

		public void LerpPlayerRotation(Quaternion rotation, float lerpTime)
		{
		}

		[IteratorStateMachine(typeof(_003CLerpPlayerRotation_Process_003Ed__122))]
		private IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime)
		{
			return null;
		}

		private void EnterVehicle(LandVehicle vehicle)
		{
		}

		private void ExitVehicle(LandVehicle veh, Transform exitPoint)
		{
		}

		public void Teleport(Vector3 position)
		{
		}

		public void SetResidualVelocity(Vector3 dir, float force, float time)
		{
		}

		public void WarpToNavMesh()
		{
		}

		public void RegisterMovementEvent(int threshold, Action action)
		{
		}

		public void DeregisterMovementEvent(Action action)
		{
		}

		private void UpdateMovementEvents()
		{
		}

		public void ChangeStamina(float change, bool notify = true)
		{
		}

		public void SetStamina(float value, bool notify = true)
		{
		}

		public void AddSprintBlocker(string tag)
		{
		}

		public void RemoveSprintBlocker(string tag)
		{
		}
	}
}
