namespace ScheduleOne.Cartel
{
	public class CartelAmbushLocation : global::UnityEngine.MonoBehaviour
	{
		public const int REQUIRED_AMBUSH_POINTS = 4;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Range(2f, 20f)]
		public float DetectionRadius;

		public global::UnityEngine.Transform[] AmbushPoints;

		private void Awake()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
