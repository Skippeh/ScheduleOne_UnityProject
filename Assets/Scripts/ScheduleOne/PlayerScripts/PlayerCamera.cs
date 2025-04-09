using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.PlayerScripts
{
	public class PlayerCamera : PlayerSingleton<PlayerCamera>
	{
		public enum ECameraMode
		{
			Default = 0,
			Vehicle = 1,
			Skateboard = 2
		}

		[CompilerGenerated]
		private sealed class _003CILerpCamera_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerCamera _003C_003E4__this;

			public bool worldSpace;

			public bool returnToRestingPosition;

			public float lerpTime;

			public Vector3 endPos;

			public Quaternion endRot;

			public bool reenableLook;

			private Vector3 _003CstartPos_003E5__2;

			private Quaternion _003CstartRot_003E5__3;

			private float _003Celapsed_003E5__4;

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
			public _003CILerpCamera_003Ed__115(int _003C_003E1__state)
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
		private sealed class _003CILerpFOV_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerCamera _003C_003E4__this;

			public float endFov;

			public float lerpTime;

			private float _003CstartFov_003E5__2;

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
			public _003CILerpFOV_003Ed__126(int _003C_003E1__state)
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
		private sealed class _003CLerpDoF_003Ed__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool active;

			public PlayerCamera _003C_003E4__this;

			public float lerpTime;

			private float _003CstartFocusDist_003E5__2;

			private float _003CendFocusDist_003E5__3;

			private float _003Ci_003E5__4;

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
			public _003CLerpDoF_003Ed__123(int _003C_003E1__state)
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

		public const float CAMERA_SHAKE_MULTIPLIER = 0.1f;

		[Header("Settings")]
		public float cameraOffsetFromTop;

		public float SprintFoVBoost;

		public float FoVChangeRate;

		public float HorizontalCameraBob;

		public float VerticalCameraBob;

		public float BobRate;

		public AnimationCurve HorizontalBobCurve;

		public AnimationCurve VerticalBobCurve;

		public float FreeCamSpeed;

		public float FreeCamAcceleration;

		public bool SmoothLook;

		public float SmoothLookSpeed;

		public FloatSmoother FoVChangeSmoother;

		public FloatSmoother SmoothLookSmoother;

		[Header("References")]
		public Transform CameraContainer;

		public Camera Camera;

		public Camera OverlayCamera;

		public Animator Animator;

		public AnimationClip[] JoltClips;

		public UniversalRenderPipelineAsset[] URPAssets;

		public Transform ViewAvatarCameraPosition;

		public HeartbeatSoundController HeartbeatSoundController;

		public ParticleSystem Flies;

		public AudioSourceController MethRumble;

		public RandomizedAudioSourceController SchizoVoices;

		[HideInInspector]
		public bool blockNextStopTransformOverride;

		private Volume globalVolume;

		private DepthOfField DoF;

		private Coroutine cameraShakeCoroutine;

		private Vector3 cameraLocalPos;

		private Vector3 freeCamMovement;

		private Coroutine focusRoutine;

		private float focusMouseX;

		private float focusMouseY;

		private Dictionary<int, PlayerMovement.MovementEvent> movementEvents;

		private float freeCamSpeed;

		private float mouseX;

		private float mouseY;

		private Vector2 seizureJitter;

		private float schizoFoV;

		private float timeUntilNextSchizoVoice;

		private List<Vector3> gizmos;

		private Vector3 cameralocalPos_PriorOverride;

		private Quaternion cameraLocalRot_PriorOverride;

		public Coroutine ILerpCamera_Coroutine;

		private Coroutine lookRoutine;

		private Coroutine DoFCoroutine;

		private Coroutine ILerpCameraFOV_Coroutine;

		public static ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode { get; private set; }

		public bool canLook { get; protected set; }

		public int activeUIElementCount => 0;

		public bool transformOverriden { get; protected set; }

		public bool fovOverriden { get; protected set; }

		public bool FreeCamEnabled { get; private set; }

		public bool ViewingAvatar { get; private set; }

		public ECameraMode CameraMode { get; protected set; }

		public bool MethVisuals { get; set; }

		public bool CocaineVisuals { get; set; }

		public float FovJitter { get; private set; }

		public List<string> activeUIElements { get; protected set; }

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

		public static void SetAntialiasingMode(ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
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

		private void Exit(ExitAction action)
		{
		}

		public float GetTargetLocalY()
		{
			return 0f;
		}

		public void SetCameraMode(ECameraMode mode)
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

		public bool LookRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			hit = default(RaycastHit);
			return false;
		}

		public bool LookRaycast_ExcludeBuildables(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true)
		{
			hit = default(RaycastHit);
			return false;
		}

		private void OnDrawGizmosSelected()
		{
		}

		public bool Raycast_ExcludeBuildables(Vector3 origin, Vector3 direction, float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			hit = default(RaycastHit);
			return false;
		}

		public bool MouseRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			hit = default(RaycastHit);
			return false;
		}

		public bool LookSpherecast(float range, float radius, out RaycastHit hit, LayerMask layerMask)
		{
			hit = default(RaycastHit);
			return false;
		}

		public void OverrideTransform(Vector3 worldPos, Quaternion rot, float lerpTime, bool keepParented = false)
		{
		}

		[IteratorStateMachine(typeof(_003CILerpCamera_003Ed__115))]
		protected IEnumerator ILerpCamera(Vector3 endPos, Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition = false, bool reenableLook = false)
		{
			return null;
		}

		public void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
		}

		public void LookAt(Vector3 point, float duration = 0.25f)
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

		[IteratorStateMachine(typeof(_003CLerpDoF_003Ed__123))]
		private IEnumerator LerpDoF(bool active, float lerpTime)
		{
			return null;
		}

		public void OverrideFOV(float fov, float lerpTime)
		{
		}

		[IteratorStateMachine(typeof(_003CILerpFOV_003Ed__126))]
		protected IEnumerator ILerpFOV(float endFov, float lerpTime)
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

		public void RegisterMovementEvent(int threshold, Action action)
		{
		}

		public void DeregisterMovementEvent(Action action)
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

		public bool PointInCameraView(Vector3 point)
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

		public void FocusCameraOnTarget(Transform target)
		{
		}

		public void StopFocus()
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
