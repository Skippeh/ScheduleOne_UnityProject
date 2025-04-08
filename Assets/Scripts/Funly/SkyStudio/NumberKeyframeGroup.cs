namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class NumberKeyframeGroup : global::Funly.SkyStudio.KeyframeGroup<global::Funly.SkyStudio.NumberKeyframe>
	{
		public float minValue;

		public float maxValue;

		public NumberKeyframeGroup(string name, float min, float max)
			: base((string)null)
		{
		}

		public NumberKeyframeGroup(string name, float min, float max, global::Funly.SkyStudio.NumberKeyframe frame)
			: base((string)null)
		{
		}

		public float GetFirstValue()
		{
			return 0f;
		}

		public float ValueToPercent(float value)
		{
			return 0f;
		}

		public float ValuePercentAtTime(float time)
		{
			return 0f;
		}

		public float PercentToValue(float percent)
		{
			return 0f;
		}

		public float NumericValueAtTime(float time)
		{
			return 0f;
		}
	}
}
