namespace ScheduleOne.Vehicles.AI
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Vehicles.LandVehicle))]
	public class VehicleAgent : global::UnityEngine.MonoBehaviour
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

		public delegate void NavigationCallback(global::ScheduleOne.Vehicles.AI.VehicleAgent.ENavigationResult status);

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CReverse_003Ed__139 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Vehicles.AI.VehicleAgent _003C_003E4__this;

			private global::UnityEngine.Vector3 _003CfutureTarget_003E5__2;

			private float _003CsteerAngleNormal_003E5__3;

			private global::ScheduleOne.Vehicles.AI.VehicleAgent.ESweepType _003CfrontWheel_003E5__4;

			private float _003CsweepAngle_003E5__5;

			private float _003CreverseSweepDistanceMin_003E5__6;

			private bool _003CcanBeginSwing_003E5__7;

			private global::UnityEngine.Vector3 _003CfaceTarget_003E5__8;

			private bool _003CcontinueReversing_003E5__9;

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
			public _003CReverse_003Ed__139(int _003C_003E1__state)
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

		public const string VehicleGraphName = "General Vehicle Graph";

		public const string RoadGraphName = "Road Nodes";

		public const float MaxDistanceFromPath = 6f;

		public const float MaxDistanceFromPathWhenReversing = 8f;

		public static global::UnityEngine.Vector3 MainGraphSamplePoint;

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

		public const float INFREQUENT_UPDATE_RATE = 0.033f;

		public bool DEBUG_MODE;

		public global::ScheduleOne.Vehicles.AI.DriveFlags Flags;

		[global::UnityEngine.Header("Seekers")]
		[global::UnityEngine.SerializeField]
		protected global::Pathfinding.Seeker roadSeeker;

		[global::UnityEngine.SerializeField]
		protected global::Pathfinding.Seeker generalSeeker;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform CTE_Origin;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform FrontAxlePosition;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform RearAxlePosition;

		[global::UnityEngine.Header("Sensors")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.AI.Sensor sensor_FL;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.AI.Sensor sensor_FM;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.AI.Sensor sensor_FR;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.AI.Sensor sensor_RR;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.AI.Sensor sensor_RL;

		private global::ScheduleOne.Vehicles.AI.Sensor[] sensors;

		[global::UnityEngine.Header("Sweeping")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.LayerMask sweepMask;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform sweepOrigin_FL;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform sweepOrigin_FR;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform sweepOrigin_RL;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform sweepOrigin_RR;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.Wheel leftWheel;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.Wheel rightWheel;

		protected const float sweepSegment = 15f;

		[global::UnityEngine.Header("Path following")]
		protected float sampleStepSizeMin;

		protected float sampleStepSizeMax;

		protected int aheadPointSamples;

		protected const float DestinationDistanceSlowThreshold = 8f;

		protected const float DestinationArrivalThreshold = 3f;

		[global::UnityEngine.Header("Steer settings")]
		[global::UnityEngine.SerializeField]
		protected float steerTargetFollowRate;

		private global::ScheduleOne.Vehicles.AI.SteerPID steerPID;

		[global::UnityEngine.Header("Turning speed reduction")]
		protected float turnSpeedReductionMinRange;

		protected float turnSpeedReductionMaxRange;

		protected float turnSpeedReductionDivisor;

		private float minTurnSpeedReductionAngleThreshold;

		private float minTurningSpeed;

		[global::UnityEngine.Header("Throttle")]
		[global::UnityEngine.SerializeField]
		protected float throttleMin;

		[global::UnityEngine.SerializeField]
		protected float throttleMax;

		private global::ScheduleOne.DevUtilities.PID throttlePID;

		public static float UnmarkedSpeed;

		public static float ReverseSpeed;

		private global::ScheduleOne.DevUtilities.ValueTracker speedReductionTracker;

		[global::UnityEngine.Header("Pursuit Mode")]
		public bool PursuitModeEnabled;

		public global::UnityEngine.Transform PursuitTarget;

		public float PursuitDistanceUpdateThreshold;

		private global::UnityEngine.Vector3 PursuitTargetLastPosition;

		[global::UnityEngine.Header("Stuck Detection")]
		public global::ScheduleOne.Vehicles.AI.VehicleTeleporter Teleporter;

		public global::ScheduleOne.DevUtilities.PositionHistoryTracker PositionHistoryTracker;

		public float StuckTimeThreshold;

		public int StuckSamples;

		public float StuckDistanceThreshold;

		protected global::ScheduleOne.Vehicles.AI.VehicleAgent.NavigationCallback storedNavigationCallback;

		protected global::ScheduleOne.Vehicles.SpeedZone currentSpeedZone;

		protected global::ScheduleOne.Vehicles.LandVehicle vehicle;

		protected float wheelbase;

		protected float wheeltrack;

		protected float vehicleLength;

		protected float vehicleWidth;

		protected float turnRadius;

		protected float sweepTrack;

		private float wheelBottomOffset;

		[global::UnityEngine.Header("Control info - READONLY")]
		[global::UnityEngine.SerializeField]
		protected float targetSpeed;

		[global::UnityEngine.SerializeField]
		protected float targetSteerAngle_Normalized;

		protected float lateralOffset;

		protected global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path;

		private float timeOnLastNavigationCall;

		private float sweepTestFailedTime;

		private global::ScheduleOne.Vehicles.AI.NavigationSettings currentNavigationSettings;

		private global::UnityEngine.Coroutine navigationCalculationRoutine;

		private global::UnityEngine.Coroutine reverseCoroutine;

		public bool AutoDriving { get; protected set; }

		public bool KinematicMode => false;

		public bool IsReversing => false;

		public global::UnityEngine.Vector3 TargetLocation { get; protected set; }

		protected float sampleStepSize => 0f;

		protected float turnSpeedReductionRange => 0f;

		protected float maxSteerAngle => 0f;

		private global::UnityEngine.Vector3 frontOfVehiclePosition => default(global::UnityEngine.Vector3);

		public bool NavigationCalculationInProgress => false;

		private float timeSinceLastNavigationCall => 0f;

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

		private global::UnityEngine.Vector3 GetAxleGroundHit(bool front)
		{
			return default(global::UnityEngine.Vector3);
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

		public void Navigate(global::UnityEngine.Vector3 location, global::ScheduleOne.Vehicles.AI.NavigationSettings settings = null, global::ScheduleOne.Vehicles.AI.VehicleAgent.NavigationCallback callback = null)
		{
		}

		private void NavigationCalculationCallback(global::ScheduleOne.Vehicles.AI.NavigationUtility.ENavigationCalculationResult result, global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath _path)
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

		public bool SweepTurn(global::ScheduleOne.Vehicles.AI.VehicleAgent.ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out global::UnityEngine.Vector3 hitPoint, float steerAngle = 0f)
		{
			hitDistance = default(float);
			hitPoint = default(global::UnityEngine.Vector3);
			return false;
		}

		public void BetterSweepTurn(global::ScheduleOne.Vehicles.AI.VehicleAgent.ESweepType sweep, float steerAngle, bool reverse, global::UnityEngine.LayerMask mask, out float hitDistance, out global::UnityEngine.RaycastHit hit)
		{
			hitDistance = default(float);
			hit = default(global::UnityEngine.RaycastHit);
		}

		public void StartReverse()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Vehicles.AI.VehicleAgent._003CReverse_003Ed__139))]
		public global::System.Collections.IEnumerator Reverse()
		{
			return null;
		}

		private void StopReversing()
		{
		}

		private global::UnityEngine.Collider GetClosestForwardObstruction(out float obstructionDist)
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

		private global::UnityEngine.Vector3 GetPathLateralDirection()
		{
			return default(global::UnityEngine.Vector3);
		}

		public bool GetIsStuck()
		{
			return false;
		}
	}
}
