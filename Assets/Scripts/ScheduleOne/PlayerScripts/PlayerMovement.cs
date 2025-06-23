namespace ScheduleOne.PlayerScripts
{
	public class PlayerMovement : global::ScheduleOne.DevUtilities.PlayerSingleton<global::ScheduleOne.PlayerScripts.PlayerMovement>
	{
		public class MovementEvent
		{
			public global::System.Collections.Generic.List<global::System.Action> actions;

			public global::UnityEngine.Vector3 LastUpdatedDistance;

			public void Update(global::UnityEngine.Vector3 newPosition)
			{
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CJump_003Ed__115 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.PlayerScripts.PlayerMovement _003C_003E4__this;

			private float _003CsavedSlopeLimit_003E5__2;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CJump_003Ed__115(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CLerpPlayerRotation_Process_003Ed__123 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.PlayerScripts.PlayerMovement _003C_003E4__this;

			public global::UnityEngine.Quaternion endRotation;

			public float lerpTime;

			private global::UnityEngine.Quaternion _003CstartRot_003E5__2;

			private float _003Ci_003E5__3;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CLerpPlayerRotation_Process_003Ed__123(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
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

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.PlayerScripts.Player Player;

		public global::UnityEngine.CharacterController Controller;

		[global::UnityEngine.Header("Move settings")]
		[global::UnityEngine.SerializeField]
		protected float sensitivity;

		[global::UnityEngine.SerializeField]
		protected float dead;

		public bool canMove;

		public bool canJump;

		public bool SprintingRequiresStamina;

		public float MoveSpeedMultiplier;

		public float SlipperyMovementMultiplier;

		public bool ForceSprint;

		[global::UnityEngine.Header("Jump/fall settings")]
		[global::UnityEngine.SerializeField]
		protected float jumpForce;

		[global::UnityEngine.SerializeField]
		protected float gravityMultiplier;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.LayerMask groundDetectionMask;

		[global::UnityEngine.Header("Slope Settings")]
		[global::UnityEngine.SerializeField]
		protected float slopeForce;

		[global::UnityEngine.SerializeField]
		protected float slopeForceRayLength;

		[global::UnityEngine.Header("Crouch Settings")]
		[global::UnityEngine.SerializeField]
		protected float crouchSpeedMultipler;

		[global::UnityEngine.SerializeField]
		protected float Crouched_VigIntensity;

		[global::UnityEngine.SerializeField]
		protected float Crouched_VigSmoothness;

		[global::UnityEngine.Header("Visibility Points")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.Transform> visibilityPointsToScale;

		private global::System.Collections.Generic.Dictionary<global::UnityEngine.Transform, float> originalVisibilityPointOffsets;

		protected global::UnityEngine.Vector3 movement;

		protected float movementY;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> recentlyDrivenVehicles;

		private bool isJumping;

		public float CurrentStaminaReserve;

		public global::System.Action<float> onStaminaReserveChanged;

		public global::System.Action onJump;

		public global::System.Action onLand;

		public global::UnityEngine.Events.UnityEvent onCrouch;

		public global::UnityEngine.Events.UnityEvent onUncrouch;

		protected float horizontalAxis;

		protected float verticalAxis;

		protected float timeGrounded;

		private global::System.Collections.Generic.Dictionary<int, global::ScheduleOne.PlayerScripts.PlayerMovement.MovementEvent> movementEvents;

		private float timeSinceStaminaDrain;

		private bool sprintActive;

		private bool sprintReleased;

		private global::UnityEngine.Vector3 residualVelocityDirection;

		private float residualVelocityForce;

		private float residualVelocityDuration;

		private float residualVelocityTimeRemaining;

		private bool teleport;

		private global::UnityEngine.Vector3 teleportPosition;

		private global::System.Collections.Generic.List<string> sprintBlockers;

		private global::UnityEngine.Vector3 lastFrameMovement;

		private global::UnityEngine.Coroutine playerRotCoroutine;

		public static float GravityMultiplier { get; set; }

		public float playerHeight { get; protected set; }

		public global::UnityEngine.Vector3 Movement => default(global::UnityEngine.Vector3);

		public global::ScheduleOne.Vehicles.LandVehicle currentVehicle { get; protected set; }

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

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerScripts.PlayerMovement._003CJump_003Ed__115))]
		private global::System.Collections.IEnumerator Jump()
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

		public void LerpPlayerRotation(global::UnityEngine.Quaternion rotation, float lerpTime)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerScripts.PlayerMovement._003CLerpPlayerRotation_Process_003Ed__123))]
		private global::System.Collections.IEnumerator LerpPlayerRotation_Process(global::UnityEngine.Quaternion endRotation, float lerpTime)
		{
			return null;
		}

		private void EnterVehicle(global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}

		private void ExitVehicle(global::ScheduleOne.Vehicles.LandVehicle veh, global::UnityEngine.Transform exitPoint)
		{
		}

		public void Teleport(global::UnityEngine.Vector3 position)
		{
		}

		public void SetResidualVelocity(global::UnityEngine.Vector3 dir, float force, float time)
		{
		}

		public void WarpToNavMesh()
		{
		}

		public void RegisterMovementEvent(int threshold, global::System.Action action)
		{
		}

		public void DeregisterMovementEvent(global::System.Action action)
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
