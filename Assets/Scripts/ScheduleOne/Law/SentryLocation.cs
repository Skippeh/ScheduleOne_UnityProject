namespace ScheduleOne.Law
{
	public class SentryLocation : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class SentryRoute
		{
			public global::UnityEngine.Transform[] RoutePoints;

			public int MinutesPerPoint;
		}

		[global::UnityEngine.Header("References")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Law.SentryLocation.SentryRoute> Routes;

		public global::System.Collections.Generic.List<global::ScheduleOne.Police.PoliceOfficer> AssignedOfficers { get; private set; }
	}
}
