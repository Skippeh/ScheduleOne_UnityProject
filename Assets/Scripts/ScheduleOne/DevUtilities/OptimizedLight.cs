namespace ScheduleOne.DevUtilities
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Light))]
	[global::UnityEngine.ExecuteInEditMode]
	public class OptimizedLight : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Enabled")]
		private bool _Enabled;

		[global::UnityEngine.HideInInspector]
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("DisabledForOptimization")]
		private bool _DisabledForOptimization;

		[global::UnityEngine.Range(10f, 500f)]
		public float MaxDistance;

		public global::UnityEngine.Light _Light;

		private bool culled;

		private float maxDistanceSquared;

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DisabledForOptimization
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateCull()
		{
		}

		public void SetEnabled(bool enabled)
		{
		}

		private void UpdateLightState()
		{
		}
	}
}
