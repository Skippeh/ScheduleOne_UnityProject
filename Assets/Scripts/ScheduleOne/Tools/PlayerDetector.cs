namespace ScheduleOne.Tools
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class PlayerDetector : global::UnityEngine.MonoBehaviour
	{
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		public bool DetectPlayerInVehicle;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onPlayerEnter;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onPlayerExit;

		public global::UnityEngine.Events.UnityEvent onLocalPlayerEnter;

		public global::UnityEngine.Events.UnityEvent onLocalPlayerExit;

		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> DetectedPlayers;

		private bool ignoreExit;

		private bool collidersEnabled;

		private global::UnityEngine.Collider[] detectionColliders;

		public bool IgnoreNewDetections { get; protected set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTick()
		{
		}

		private void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}

		public void SetIgnoreNewCollisions(bool ignore)
		{
		}
	}
}
