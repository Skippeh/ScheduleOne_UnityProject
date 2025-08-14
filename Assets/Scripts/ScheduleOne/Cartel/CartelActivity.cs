namespace ScheduleOne.Cartel
{
	public class CartelActivity : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Range(0f, 1f)]
		public float InfluenceRequirement;

		public global::System.Action onActivated;

		public global::System.Action onDeactivated;

		public bool IsActive { get; protected set; }

		public int MinsSinceActivation { get; protected set; }

		public global::ScheduleOne.Map.EMapRegion Region { get; protected set; }

		private void Start()
		{
		}

		public virtual void Activate(global::ScheduleOne.Map.EMapRegion region)
		{
		}

		protected virtual void MinPassed()
		{
		}

		protected virtual void HourPassed()
		{
		}

		protected virtual void Deactivate()
		{
		}

		public virtual bool IsRegionValidForActivity(global::ScheduleOne.Map.EMapRegion region)
		{
			return false;
		}
	}
}
