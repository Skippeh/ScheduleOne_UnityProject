namespace ScheduleOne.Vision
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Light))]
	public class LightVisibilityAffector : global::UnityEngine.MonoBehaviour
	{
		public const float PointLightEffect = 15f;

		public const float SpotLightEffect = 10f;

		[global::UnityEngine.Header("Settings")]
		public float EffectMultiplier;

		public string uniquenessCode;

		[global::UnityEngine.Tooltip("How far does the player have to move for visibility to be recalculated?")]
		public int updateDistanceThreshold;

		protected global::UnityEngine.Light light;

		protected global::ScheduleOne.Vision.VisibilityAttribute attribute;

		protected virtual void Awake()
		{
		}

		private void PlayerSpawned()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void UpdateVisibility()
		{
		}

		private void UpdateAttribute(float visibity)
		{
		}

		private void ClearAttribute()
		{
		}
	}
}
