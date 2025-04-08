namespace ScheduleOne.StationFramework
{
	public class Fillable : global::UnityEngine.MonoBehaviour
	{
		public class Content
		{
			public string Label;

			public float Volume_L;

			public global::UnityEngine.Color Color;
		}

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.StationFramework.LiquidContainer LiquidContainer;

		[global::UnityEngine.Header("Settings")]
		public bool FillableEnabled;

		public float LiquidCapacity_L;

		public global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.Fillable.Content> contents { get; protected set; }

		private void Awake()
		{
		}

		public void AddLiquid(string label, float volume, global::UnityEngine.Color color)
		{
		}

		public void ResetContents()
		{
		}

		private void UpdateLiquid()
		{
		}

		public float GetLiquidVolume(string label)
		{
			return 0f;
		}

		public float GetTotalLiquidVolume()
		{
			return 0f;
		}
	}
}
