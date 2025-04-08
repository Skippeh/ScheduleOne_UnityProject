namespace ScheduleOne.DevUtilities
{
	public class ValueTracker
	{
		public class Value
		{
			public float val;

			public float time;

			public Value(float val, float time)
			{
			}
		}

		private float historyDuration;

		private global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.ValueTracker.Value> valueHistory;

		public ValueTracker(float HistoryDuration)
		{
		}

		public void Destroy()
		{
		}

		public void Update()
		{
		}

		public void SubmitValue(float value)
		{
		}

		public float RecordedHistoryLength()
		{
			return 0f;
		}

		public float GetLowestValue()
		{
			return 0f;
		}

		public float GetAverageValue()
		{
			return 0f;
		}
	}
}
