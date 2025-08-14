namespace ScheduleOne.DevUtilities
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Light))]
	[global::UnityEngine.ExecuteInEditMode]
	public class OptimizedLight : global::UnityEngine.MonoBehaviour
	{
		public bool Enabled;

		[global::UnityEngine.HideInInspector]
		public bool DisabledForOptimization;

		[global::UnityEngine.Range(10f, 500f)]
		public float MaxDistance;

		public global::UnityEngine.Light _Light;

		private bool _LightExists;

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

		public virtual void Update()
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
