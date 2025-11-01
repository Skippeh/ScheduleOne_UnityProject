namespace ScheduleOne.Tools
{
	[global::System.Serializable]
	public class ColorSmoother
	{
		[global::System.Serializable]
		public class Override
		{
			public global::UnityEngine.Color Value;

			public int Priority;

			public string Label;
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color DefaultValue;

		[global::UnityEngine.SerializeField]
		private float SmoothingSpeed;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Tools.ColorSmoother.Override> overrides;

		private global::ScheduleOne.Tools.ColorSmoother.Override activeOverride;

		public global::UnityEngine.Color CurrentValue { get; private set; }

		public float Multiplier { get; private set; }

		public global::UnityEngine.Color Default => default(global::UnityEngine.Color);

		public void Initialize()
		{
		}

		public void SetDefault(global::UnityEngine.Color value)
		{
		}

		public void SetMultiplier(float value)
		{
		}

		public void AddOverride(global::UnityEngine.Color value, int priority, string label)
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
