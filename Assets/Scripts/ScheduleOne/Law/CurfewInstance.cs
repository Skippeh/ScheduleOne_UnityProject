namespace ScheduleOne.Law
{
	[global::System.Serializable]
	public class CurfewInstance
	{
		public static global::ScheduleOne.Law.CurfewInstance ActiveInstance;

		[global::UnityEngine.Range(1f, 10f)]
		public int IntensityRequirement;

		[global::UnityEngine.HideInInspector]
		public bool shouldDisable;

		public bool Enabled { get; protected set; }

		public void Evaluate(bool ignoreSleepReq = false)
		{
		}

		private void MinPass()
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}
	}
}
