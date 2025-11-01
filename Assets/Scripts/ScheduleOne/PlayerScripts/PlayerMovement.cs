namespace ScheduleOne.PlayerScripts
{
	public class PlayerMovement : global::ScheduleOne.DevUtilities.PlayerSingleton<global::ScheduleOne.PlayerScripts.PlayerMovement>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CJump_003Ed__143 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
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
			public _003CJump_003Ed__143(int _003C_003E1__state)
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
		private sealed class _003CLerpPlayerRotation_Process_003Ed__151 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
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
			public _003CLerpPlayerRotation_Process_003Ed__151(int _003C_003E1__state)
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

		public const float DevSprintMultiplier = 1f;

		public const float WalkSpeed = 3.25f;

		public static float StaticMoveSpeedMultiplier;

		public const float InputSensitivity = 7f;

		public const float InputDeadZone = 0.001f;

		public const float SlipperyMovementMultiplier = 0.98f;

		public const float GroundedThreshold = 0.05f;

		public const float SlopeThreshold = 5f;

		public const float SlopeForce = 1f;

		public const float SlopeForceRayLength = 1.5f;

		public const float ControllerRadius = 0.35f;

		public const float DefaultCharacterControllerHeight = 1.85f;

		public const float CrouchHeightMultiplier = 0.65f;

		public const float CrouchTime = 0.2f;

		public const float CrouchSpeedMultipler = 0.6f;

		public const float CrouchedVigIntensity = 0.35f;

		public const float CrouchedVigSmoothness = 0.7f;

		public const bool SprintingRequiresStamina = false;

		public const float SprintChangeRate = 4f;

		public const float SprintMultiplier = 1.9f;

		public const float StaminaDrainRate = 12.5f;

		public const float StaminaRestoreRate = 25f;

		public const float StaminaRestoreDelay = 1f;

		public static float StaminaReserveMax;

		public const float JumpForce = 5.25f;

		public static float JumpMultiplier;

		public static float GravityMultiplier;

		public const float BaseGravityMultiplier = 1.4f;

		public const float VerticalLadderSpeedMultiplier = 1.2f;

		public const float LateralLadderSpeedMultiplier = 0.5f;

		public const float LadderTopBuffer = 0.15f;

		public const float LadderPitchAdjustment = 60f;

		public const float DismountForce = 7f;

		public const float DismountForceDuration = 0.5f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.PlayerScripts.Player Player;

		public global::UnityEngine.CharacterController Controller;

		[global::UnityEngine.Header("Jump/fall settings")]
		[global::UnityEngine.Serialization.FormerlySerializedAs("groundDetectionMask")]
		public global::UnityEngine.LayerMask GroundDetectionMask;

		public global::System.Action<float> onStaminaReserveChanged;

		public global::System.Action onJump;

		public global::System.Action onLand;

		public global::System.Action onCrouch;

		public global::System.Action onUncrouch;

		private global::UnityEngine.Vector3 movement;

		private global::UnityEngine.Vector3 lastFrameMovement;

		private float movementY;

		private float timeOnLadderDismount;

		private global::UnityEngine.Vector3 ladderDismountDir;

		private float horizontalAxis;

		private float verticalAxis;

		private global::System.Collections.Generic.Dictionary<int, global::ScheduleOne.Tools.MotionEvent> movementEvents;

		private float timeSinceStaminaDrain;

		private bool sprintActive;

		private bool sprintReleased;

		private global::System.Collections.Generic.List<string> sprintBlockers;

		private global::UnityEngine.Vector3 residualVelocityDirection;

		private float residualVelocityForce;

		private float residualVelocityDuration;

		private float residualVelocityTimeRemaining;

		private bool teleport;

		private global::UnityEngine.Vector3 teleportPosition;

		private float playerLadderYPosOnLastClimbSound;

		private global::UnityEngine.Coroutine playerRotCoroutine;

		public bool CanMove { get; set; }

		public bool CanJump { get; set; }

		public float MoveSpeedMultiplier { get; set; }

		public global::UnityEngine.Vector3 Movement => default(global::UnityEngine.Vector3);

		public bool IsJumping { get; private set; }

		public float TimeAirborne { get; private set; }

		public float TimeGrounded { get; private set; }

		public bool IsGrounded { get; private set; }

		public bool IsCrouched { get; private set; }

		public float StandingScale { get; private set; }

		public bool IsRagdolled { get; private set; }

		public bool IsSprinting { get; private set; }

		public bool ForceSprint { get; set; }

		public float CurrentStaminaReserve { get; private set; }

		public float CurrentSprintMultiplier { get; private set; }

		public global::ScheduleOne.Vehicles.LandVehicle CurrentVehicle { get; protected set; }

		public global::ScheduleOne.Map.Ladder CurrentLadder { get; set; }

		public bool IsOnLadder => false;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void Move()
		{
		}

		private void ClampMovement()
		{
		}

		private float GetSurfaceAngle()
		{
			return 0f;
		}

		private bool GetIsGrounded()
		{
			return false;
		}

		public void Teleport(global::UnityEngine.Vector3 position, bool alignFeetToPosition = false)
		{
		}

		public void SetResidualVelocity(global::UnityEngine.Vector3 dir, float force, float time)
		{
		}

		public void WarpToNavMesh()
		{
		}

		private void UpdateHorizontalAxis()
		{
		}

		private void UpdateVerticalAxis()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerScripts.PlayerMovement._003CJump_003Ed__143))]
		private global::System.Collections.IEnumerator Jump()
		{
			return null;
		}

		public void SetCrouched(bool c)
		{
		}

		private void TryToggleCrouch()
		{
		}

		private bool CanStand()
		{
			return false;
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

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerScripts.PlayerMovement._003CLerpPlayerRotation_Process_003Ed__151))]
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

		public void MountLadder(global::ScheduleOne.Map.Ladder ladder)
		{
		}

		public void DismountLadder()
		{
		}

		private void LadderMove()
		{
		}

		private void PlayLadderClimbSound()
		{
		}
	}
}
