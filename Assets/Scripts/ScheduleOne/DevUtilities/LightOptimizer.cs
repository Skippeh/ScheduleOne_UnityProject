namespace ScheduleOne.DevUtilities
{
	public class LightOptimizer : global::UnityEngine.MonoBehaviour
	{
		public bool LightsEnabled;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.BoxCollider[] activationZones;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform[] viewPoints;

		[global::UnityEngine.Header("Settings")]
		public float checkRange;

		protected global::ScheduleOne.DevUtilities.OptimizedLight[] lights;

		public void Awake()
		{
		}

		public void FixedUpdate()
		{
		}

		public void ApplyLights()
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

		public void LightsEnabled_True()
		{
		}

		public void LightsEnabled_False()
		{
		}
	}
}
