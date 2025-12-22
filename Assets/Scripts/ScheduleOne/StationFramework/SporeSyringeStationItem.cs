namespace ScheduleOne.StationFramework
{
	public class SporeSyringeStationItem : global::ScheduleOne.StationFramework.StationItem
	{
		public const float MaxAngleDifferenceForInjection = 35f;

		public const float PlungerPushSpeed = 0.8f;

		public const float PlungerDragDistanceMultiplier = 2f;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _capHighlight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _capContainer;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.PlayerTasks.Clickable _capClickable;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.PlayerTasks.Draggable _syringeDraggable;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _plungerHighlight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _plungerTransform;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _plungerExtendedPosition;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _plungerCompressedPosition;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _liquidTransform;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.PlayerTasks.Clickable _plungerClickable;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _plungerSound;

		private global::UnityEngine.Collider _injectionPortCollider;

		public global::UnityEngine.Events.UnityEvent onCapRemoved;

		public global::UnityEngine.Events.UnityEvent onInserted;

		public global::UnityEngine.Events.UnityEvent<float> onPlungerMoved;

		private bool _capRemoved;

		private global::UnityEngine.Vector3 _initialPlungerHitPoint;

		private float timeOnPlungerClickStart;

		public float PlungerPosition { get; private set; }

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void SetCapInteractable(bool interactable)
		{
		}

		public void SetInjectionPortCollider(global::UnityEngine.Collider collider)
		{
		}

		private void RemoveCap()
		{
		}

		public void SetSyringeDraggable(bool draggable)
		{
		}

		public void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void InsertSyringe()
		{
		}

		public void SetPlungerInteractable(bool interactable)
		{
		}

		private void SetPlungerPosition(float position)
		{
		}

		private void OnPlungerClickStart(global::UnityEngine.RaycastHit hit)
		{
		}

		private void OnPlungerClickEnd()
		{
		}

		private global::UnityEngine.Vector3 GetPlungerPlaneHit()
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
