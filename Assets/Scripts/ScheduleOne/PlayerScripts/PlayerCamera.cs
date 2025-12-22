namespace ScheduleOne.PlayerScripts
{
	public class PlayerCamera : global::ScheduleOne.DevUtilities.PlayerSingleton<global::ScheduleOne.PlayerScripts.PlayerCamera>
	{
		public enum ECameraMode
		{
			Default = 0,
			Vehicle = 1,
			Skateboard = 2
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CILerpCamera_003Ed__116 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.PlayerScripts.PlayerCamera _003C_003E4__this;

			public bool worldSpace;

			public bool returnToRestingPosition;

			public float lerpTime;

			public global::UnityEngine.Vector3 endPos;

			public global::UnityEngine.Quaternion endRot;

			public bool reenableLook;

			private global::UnityEngine.Vector3 _003CstartPos_003E5__2;

			private global::UnityEngine.Quaternion _003CstartRot_003E5__3;

			private float _003Celapsed_003E5__4;

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
			public _003CILerpCamera_003Ed__116(int _003C_003E1__state)
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
		private sealed class _003CILerpFOV_003Ed__127 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.PlayerScripts.PlayerCamera _003C_003E4__this;

			public float endFov;

			public float lerpTime;

			private float _003CstartFov_003E5__2;

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
			public _003CILerpFOV_003Ed__127(int _003C_003E1__state)
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
		private sealed class _003CLerpDoF_003Ed__124 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool active;

			public global::ScheduleOne.PlayerScripts.PlayerCamera _003C_003E4__this;

			public float lerpTime;

			private float _003CstartFocusDist_003E5__2;

			private float _003CendFocusDist_003E5__3;

			private float _003Ci_003E5__4;

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
			public _003CLerpDoF_003Ed__124(int _003C_003E1__state)
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

		public const float CAMERA_SHAKE_MULTIPLIER = 0.1f;

		[global::UnityEngine.Header("Settings")]
		public float cameraOffsetFromTop;

		public float SprintFoVBoost;

		public float FoVChangeRate;

		public float HorizontalCameraBob;

		public float VerticalCameraBob;

		public float BobRate;

		public global::UnityEngine.AnimationCurve HorizontalBobCurve;

		public global::UnityEngine.AnimationCurve VerticalBobCurve;

		public float FreeCamSpeed;

		public float FreeCamAcceleration;

		public bool SmoothLook;

		public float SmoothLookSpeed;

		public global::ScheduleOne.Tools.FloatSmoother FoVChangeSmoother;

		public global::ScheduleOne.Tools.FloatSmoother SmoothLookSmoother;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform CameraContainer;

		public global::UnityEngine.Camera Camera;

		public global::UnityEngine.Camera OverlayCamera;

		public global::UnityEngine.Animator Animator;

		public global::UnityEngine.AnimationClip[] JoltClips;

		public global::UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset[] URPAssets;

		public global::UnityEngine.Transform ViewAvatarCameraPosition;

		public global::ScheduleOne.Audio.HeartbeatSoundController HeartbeatSoundController;

		public global::UnityEngine.ParticleSystem Flies;

		public global::ScheduleOne.Audio.AudioSourceController MethRumble;

		public global::ScheduleOne.Audio.RandomizedAudioSourceController SchizoVoices;

		[global::UnityEngine.HideInInspector]
		public bool blockNextStopTransformOverride;

		private global::UnityEngine.Rendering.Volume globalVolume;

		private global::UnityEngine.Rendering.Universal.DepthOfField DoF;

		private global::UnityEngine.Coroutine cameraShakeCoroutine;

		private global::UnityEngine.Vector3 cameraLocalPos;

		private global::UnityEngine.Vector3 freeCamMovement;

		private global::UnityEngine.Coroutine focusRoutine;

		private float focusMouseX;

		private float focusMouseY;

		private global::System.Collections.Generic.Dictionary<int, global::ScheduleOne.Tools.MotionEvent> movementEvents;

		private float freeCamSpeed;

		private float mouseX;

		private float mouseY;

		private global::UnityEngine.Vector2 seizureJitter;

		private float schizoFoV;

		private float timeUntilNextSchizoVoice;

		private global::System.Collections.Generic.List<global::UnityEngine.Vector3> gizmos;

		private global::UnityEngine.Vector3 cameralocalPos_PriorOverride;

		private global::UnityEngine.Quaternion cameraLocalRot_PriorOverride;

		public global::UnityEngine.Coroutine ILerpCamera_Coroutine;

		private global::UnityEngine.Coroutine lookRoutine;

		private global::UnityEngine.Coroutine DoFCoroutine;

		private global::UnityEngine.Coroutine ILerpCameraFOV_Coroutine;

		public static global::ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode { get; private set; }

		public bool canLook { get; protected set; }

		public int activeUIElementCount => 0;

		public bool transformOverriden { get; protected set; }

		public bool fovOverriden { get; protected set; }

		public bool FreeCamEnabled { get; private set; }

		public bool ViewingAvatar { get; private set; }

		public global::ScheduleOne.PlayerScripts.PlayerCamera.ECameraMode CameraMode { get; protected set; }

		public bool MethVisuals { get; set; }

		public bool CocaineVisuals { get; set; }

		public float FovJitter { get; private set; }

		public global::System.Collections.Generic.List<string> activeUIElements { get; protected set; }

		protected override void Awake()
		{
		}

		public override void OnStartClient(bool IsOwner)
		{
		}

		protected override void Start()
		{
		}

		private void PlayerSpawned()
		{
		}

		public static void SetAntialiasingMode(global::ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
		{
		}

		public void ApplyAASettings()
		{
		}

		protected virtual void Update()
		{
		}

		private void Screenshot()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public float GetTargetLocalY()
		{
			return 0f;
		}

		public void SetCameraMode(global::ScheduleOne.PlayerScripts.PlayerCamera.ECameraMode mode)
		{
		}

		private void RotateCamera()
		{
		}

		public void LockMouse()
		{
		}

		public void FreeMouse()
		{
		}

		public bool LookRaycast(float range, out global::UnityEngine.RaycastHit hit, global::UnityEngine.LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			hit = default(global::UnityEngine.RaycastHit);
			return false;
		}

		public bool LookRaycast_ExcludeBuildables(float range, out global::UnityEngine.RaycastHit hit, global::UnityEngine.LayerMask layerMask, bool includeTriggers = true)
		{
			hit = default(global::UnityEngine.RaycastHit);
			return false;
		}

		private void OnDrawGizmosSelected()
		{
		}

		public bool Raycast_ExcludeBuildables(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 direction, float range, out global::UnityEngine.RaycastHit hit, global::UnityEngine.LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			hit = default(global::UnityEngine.RaycastHit);
			return false;
		}

		public global::UnityEngine.Ray GetMouseRay()
		{
			return default(global::UnityEngine.Ray);
		}

		public bool MouseRaycast(float range, out global::UnityEngine.RaycastHit hit, global::UnityEngine.LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			hit = default(global::UnityEngine.RaycastHit);
			return false;
		}

		public bool LookSpherecast(float range, float radius, out global::UnityEngine.RaycastHit hit, global::UnityEngine.LayerMask layerMask)
		{
			hit = default(global::UnityEngine.RaycastHit);
			return false;
		}

		public void OverrideTransform(global::UnityEngine.Vector3 worldPos, global::UnityEngine.Quaternion rot, float lerpTime, bool keepParented = false)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerScripts.PlayerCamera._003CILerpCamera_003Ed__116))]
		protected global::System.Collections.IEnumerator ILerpCamera(global::UnityEngine.Vector3 endPos, global::UnityEngine.Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition = false, bool reenableLook = false)
		{
			return null;
		}

		public void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
		}

		public void LookAt(global::UnityEngine.Vector3 point, float duration = 0.25f)
		{
		}

		private void SetCanLook_True()
		{
		}

		public void SetCanLook(bool c)
		{
		}

		public void SetDoFActive(bool active, float lerpTime)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerScripts.PlayerCamera._003CLerpDoF_003Ed__124))]
		private global::System.Collections.IEnumerator LerpDoF(bool active, float lerpTime)
		{
			return null;
		}

		public void OverrideFOV(float fov, float lerpTime)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.PlayerScripts.PlayerCamera._003CILerpFOV_003Ed__127))]
		protected global::System.Collections.IEnumerator ILerpFOV(float endFov, float lerpTime)
		{
			return null;
		}

		public void StopFOVOverride(float lerpTime)
		{
		}

		public void AddActiveUIElement(string name)
		{
		}

		public void RemoveActiveUIElement(string name)
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

		private void ViewAvatar()
		{
		}

		private void StopViewingAvatar()
		{
		}

		public void JoltCamera()
		{
		}

		public bool PointInCameraView(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		public bool Is01(float a)
		{
			return false;
		}

		public void ResetRotation()
		{
		}

		public void FocusCameraOnTarget(global::UnityEngine.Transform target)
		{
		}

		public void StopFocus()
		{
		}

		public void OpenInterface(bool keepInventoryVisible = false, bool keepCompassVisible = false)
		{
		}

		public void CloseInterface(float cameraLerpTime = 0.2f, bool reenableCameraInput = true)
		{
		}

		public void StartCameraShake(float intensity, float duration = -1f, bool decreaseOverTime = true)
		{
		}

		public void StopCameraShake()
		{
		}

		public void UpdateCameraBob()
		{
		}

		public void SetFreeCam(bool enable, bool reenableLook = true)
		{
		}

		private void RotateFreeCam()
		{
		}

		private void UpdateFreeCamInput()
		{
		}

		private void MoveFreeCam()
		{
		}
	}
}
