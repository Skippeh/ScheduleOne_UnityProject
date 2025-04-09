using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class OptimizedLight : MonoBehaviour
	{
		public bool Enabled;

		[HideInInspector]
		public bool DisabledForOptimization;

		[Range(10f, 500f)]
		public float MaxDistance;

		public Light _Light;

		private bool culled;

		private float maxDistanceSquared;

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void FixedUpdate()
		{
		}

		private void UpdateCull()
		{
		}

		public void SetEnabled(bool enabled)
		{
		}
	}
}
