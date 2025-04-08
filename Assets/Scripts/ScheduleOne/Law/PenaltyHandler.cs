namespace ScheduleOne.Law
{
	public static class PenaltyHandler
	{
		public const float CONTROLLED_SUBSTANCE_FINE = 5f;

		public const float LOW_SEVERITY_DRUG_FINE = 10f;

		public const float MED_SEVERITY_DRUG_FINE = 20f;

		public const float HIGH_SEVERITY_DRUG_FINE = 30f;

		public const float FAILURE_TO_COMPLY_FINE = 50f;

		public const float EVADING_ARREST_FINE = 50f;

		public const float VIOLATING_CURFEW_TIME = 100f;

		public const float ATTEMPT_TO_SELL_FINE = 150f;

		public const float ASSAULT_FINE = 75f;

		public const float DEADLY_ASSAULT_FINE = 150f;

		public const float VANDALISM_FINE = 50f;

		public const float THEFT_FINE = 50f;

		public const float BRANDISHING_FINE = 50f;

		public const float DISCHARGE_FIREARM_FINE = 50f;

		public static global::System.Collections.Generic.List<string> ProcessCrimeList(global::System.Collections.Generic.Dictionary<global::ScheduleOne.Law.Crime, int> crimes)
		{
			return null;
		}
	}
}
