namespace ScheduleOne.Tools
{
	[global::System.Serializable]
	public class FloatSmoother
	{
		public class Override
		{
			public float Value;

			public int Priority;

			public string Label;
		}

		[global::UnityEngine.SerializeField]
		private float DefaultValue;

		[global::UnityEngine.SerializeField]
		private float SmoothingSpeed;

		private global::System.Collections.Generic.List<global::ScheduleOne.Tools.FloatSmoother.Override> overrides;

		private global::ScheduleOne.Tools.FloatSmoother.Override activeOverride;

		public float CurrentValue { get; private set; }

		public float Multiplier { get; private set; }

		public void Initialize()
		{
		}

		public void SetDefault(float value, bool apply = true)
		{
		}

		public void SetMultiplier(float value)
		{
		}

		public void SetSmoothingSpeed(float value)
		{
		}

		public void AddOverride(float value, int priority, string label)
		{
		}

		public void RemoveOverride(string label)
		{
		}

		public void Update()
		{
		}
	}
}
