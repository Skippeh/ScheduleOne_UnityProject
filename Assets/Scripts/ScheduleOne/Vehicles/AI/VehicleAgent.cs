using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Pathfinding;
using ScheduleOne.DevUtilities;
using ScheduleOne.Math;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	[RequireComponent(typeof(LandVehicle))]
	public class VehicleAgent : MonoBehaviour
	{
		public enum ENavigationResult
		{
			Failed = 0,
			Complete = 1,
			Stopped = 2
		}

		public enum EAgentStatus
		{
			Inactive = 0,
			MovingToRoad = 1,
			OnRoad = 2
		}

		public enum EPathGroupStatus
		{
			Inactive = 0,
			Calculating = 1
		}

		public enum ESweepType
		{
			FL = 0,
			FR = 1,
			RL = 2,
			RR = 3
		}

		public delegate void NavigationCallback(ENavigationResult status);

		[CompilerGenerated]
		private sealed class _003CReverse_003Ed__139 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VehicleAgent _003C_003E4__this;

			private Vector3 _003CfutureTarget_003E5__2;

			private float _003CsteerAngleNormal_003E5__3;

			private ESweepType _003CfrontWheel_003E5__4;

			private float _003CsweepAngle_003E5__5;

			private float _003CreverseSweepDistanceMin_003E5__6;

			private bool _003CcanBeginSwing_003E5__7;

			private Vector3 _003CfaceTarget_003E5__8;

			private bool _003CcontinueReversing_003E5__9;

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
			public _003CReverse_003Ed__139(int _003C_003E1__state)
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

		public const string VehicleGraphName = "General Vehicle Graph";

		public const string RoadGraphName = "Road Nodes";

		public const float MaxDistanceFromPath = 6f;

		public const float MaxDistanceFromPathWhenReversing = 8f;

		public static Vector3 MainGraphSamplePoint;

		public static float MinRenavigationRate;

		public const float Steer_P = 40f;

		public const float Steer_I = 5f;

		public const float Steer_D = 10f;

		public const float Throttle_P = 0.08f;

		public const float Throttle_I = 0f;

		public const float Throttle_D = 0f;

		public const float Steer_Rate = 135f;

		public const float MaxAxlePositionShift = 3f;

		public const float OBSTACLE_MIN_RANGE = 1.5f;

		public const float OBSTACLE_MAX_RANGE = 15f;

		public const float MAX_STEER_ANGLE_OVERRIDE = 35f;

		public const float KINEMATIC_MODE_MIN_DISTANCE = 40f;

		public const float INFREQUENT_UPDATE_RATE = 0.033f;

		public bool DEBUG_MODE;

		public DriveFlags Flags;

		[Header("Seekers")]
		[SerializeField]
		protected Seeker roadSeeker;

		[SerializeField]
		protected Seeker generalSeeker;

		[Header("References")]
		[SerializeField]
		protected Transform CTE_Origin;

		[SerializeField]
		protected Transform FrontAxlePosition;

		[SerializeField]
		protected Transform RearAxlePosition;

		[Header("Sensors")]
		[SerializeField]
		protected Sensor sensor_FL;

		[SerializeField]
		protected Sensor sensor_FM;

		[SerializeField]
		protected Sensor sensor_FR;

		[SerializeField]
		protected Sensor sensor_RR;

		[SerializeField]
		protected Sensor sensor_RL;

		[Header("Sweeping")]
		[SerializeField]
		protected LayerMask sweepMask;

		[SerializeField]
		protected Transform sweepOrigin_FL;

		[SerializeField]
		protected Transform sweepOrigin_FR;

		[SerializeField]
		protected Transform sweepOrigin_RL;

		[SerializeField]
		protected Transform sweepOrigin_RR;

		[SerializeField]
		protected Wheel leftWheel;

		[SerializeField]
		protected Wheel rightWheel;

		protected const float sweepSegment = 15f;

		[Header("Path following")]
		[SerializeField]
		[Range(0.1f, 5f)]
		protected float sampleStepSizeMin;

		[SerializeField]
		[Range(0.1f, 5f)]
		protected float sampleStepSizeMax;

		protected int aheadPointSamples;

		protected const float DestinationDistanceSlowThreshold = 8f;

		protected const float DestinationArrivalThreshold = 3f;

		[Header("Steer settings")]
		[SerializeField]
		protected float steerTargetFollowRate;

		private SteerPID steerPID;

		[Header("Turning speed reduction")]
		protected float turnSpeedReductionMinRange;

		protected float turnSpeedReductionMaxRange;

		protected float turnSpeedReductionDivisor;

		private float minTurnSpeedReductionAngleThreshold;

		private float minTurningSpeed;

		[Header("Throttle")]
		[SerializeField]
		protected float throttleMin;

		[SerializeField]
		protected float throttleMax;

		private PID throttlePID;

		public static float UnmarkedSpeed;

		public static float ReverseSpeed;

		private ValueTracker speedReductionTracker;

		[Header("Pursuit Mode")]
		public bool PursuitModeEnabled;

		public Transform PursuitTarget;

		public float PursuitDistanceUpdateThreshold;

		private Vector3 PursuitTargetLastPosition;

		[Header("Stuck Detection")]
		public VehicleTeleporter Teleporter;

		public PositionHistoryTracker PositionHistoryTracker;

		public float StuckTimeThreshold;

		public int StuckSamples;

		public float StuckDistanceThreshold;

		protected NavigationCallback storedNavigationCallback;

		protected SpeedZone currentSpeedZone;

		protected LandVehicle vehicle;

		protected float wheelbase;

		protected float wheeltrack;

		protected float vehicleLength;

		protected float vehicleWidth;

		protected float turnRadius;

		protected float sweepTrack;

		private float wheelBottomOffset;

		[Header("Control info - READONLY")]
		[SerializeField]
		protected float targetSpeed;

		[SerializeField]
		protected float targetSteerAngle_Normalized;

		protected float lateralOffset;

		protected PathSmoothingUtility.SmoothedPath path;

		private float timeSinceLastNavigationCall;

		private float sweepTestFailedTime;

		private NavigationSettings currentNavigationSettings;

		private Coroutine navigationCalculationRoutine;

		private Coroutine reverseCoroutine;

		public bool KinematicMode { get; protected set; }

		public bool AutoDriving { get; protected set; }

		public bool IsReversing => false;

		public Vector3 TargetLocation { get; protected set; }

		protected float sampleStepSize => 0f;

		protected float turnSpeedReductionRange => 0f;

		protected float maxSteerAngle => 0f;

		private Vector3 FrontOfVehiclePosition => default(Vector3);

		public bool NavigationCalculationInProgress => false;

		private void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void InitializeVehicleData()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected void InfrequentUpdate()
		{
		}

		protected void LateUpdate()
		{
		}

		protected void UpdateKinematic(float deltaTime)
		{
		}

		private Vector3 GetAxleGroundHit(bool front)
		{
			return default(Vector3);
		}

		private void UpdateSweep()
		{
		}

		private void UpdateSpeedReduction()
		{
		}

		private void UpdatePursuitMode()
		{
		}

		private void UpdateStuckDetection()
		{
		}

		private void CheckDistanceFromPath()
		{
		}

		private void UpdateOvertaking()
		{
		}

		protected virtual void RefreshSpeedZone()
		{
		}

		protected virtual void UpdateSpeed()
		{
		}

		protected void UpdateSteering()
		{
		}

		public void Navigate(Vector3 location, NavigationSettings settings = null, NavigationCallback callback = null)
		{
		}

		private void NavigationCalculationCallback(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath _path)
		{
		}

		private void EndDriving()
		{
		}

		public void StopNavigating()
		{
		}

		public void RecalculateNavigation()
		{
		}

		public bool SweepTurn(ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out Vector3 hitPoint, float steerAngle = 0f)
		{
			hitDistance = default(float);
			hitPoint = default(Vector3);
			return false;
		}

		public void BetterSweepTurn(ESweepType sweep, float steerAngle, bool reverse, LayerMask mask, out float hitDistance, out Vector3 hitPoint)
		{
			hitDistance = default(float);
			hitPoint = default(Vector3);
		}

		public void StartReverse()
		{
		}

		[IteratorStateMachine(typeof(_003CReverse_003Ed__139))]
		public IEnumerator Reverse()
		{
			return null;
		}

		private void StopReversing()
		{
		}

		private Collider GetClosestForwardObstruction(out float obstructionDist)
		{
			obstructionDist = default(float);
			return null;
		}

		public bool IsOnVehicleGraph()
		{
			return false;
		}

		private float GetDistanceFromVehicleGraph()
		{
			return 0f;
		}

		private Vector3 GetPathLateralDirection()
		{
			return default(Vector3);
		}

		public bool GetIsStuck()
		{
			return false;
		}
	}
}
