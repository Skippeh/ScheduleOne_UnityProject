using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public class LightOptimizer : MonoBehaviour
	{
		public bool LightsEnabled;

		[Header("References")]
		[SerializeField]
		protected BoxCollider[] activationZones;

		[SerializeField]
		protected Transform[] viewPoints;

		[Header("Settings")]
		public float checkRange;

		protected OptimizedLight[] lights;

		public void Awake()
		{
		}

		public void FixedUpdate()
		{
		}

		public void ApplyLights()
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

		public void LightsEnabled_True()
		{
		}

		public void LightsEnabled_False()
		{
		}
	}
}
