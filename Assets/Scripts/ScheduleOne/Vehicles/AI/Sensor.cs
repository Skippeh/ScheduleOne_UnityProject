namespace ScheduleOne.Vehicles.AI
{
	public class Sensor : global::UnityEngine.MonoBehaviour
	{
		public bool Enabled;

		public global::UnityEngine.Collider obstruction;

		public float obstructionDistance;

		public const float checkRate = 0.33f;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected float minDetectionRange;

		[global::UnityEngine.SerializeField]
		protected float maxDetectionRange;

		public float checkRadius;

		public global::UnityEngine.LayerMask checkMask;

		private global::ScheduleOne.Vehicles.LandVehicle vehicle;

		[global::UnityEngine.HideInInspector]
		public float calculatedDetectionRange;

		private global::UnityEngine.RaycastHit hit;

		private global::System.Collections.Generic.List<global::UnityEngine.RaycastHit> hits;

		protected virtual void Start()
		{
		}

		public void Check()
		{
		}
	}
}
