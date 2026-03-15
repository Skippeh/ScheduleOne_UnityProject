namespace ScheduleOne.Effects
{
	[global::System.Serializable]
	public class EffectSettingsWrapper
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.NumericParameter> NumericParameters;

		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.GradientParameter> GradientParameters;

		public float GetNumericParameter(string variable)
		{
			return 0f;
		}

		public void SetNumericParameter(string variable, float value)
		{
		}

		public global::UnityEngine.Gradient GetGradientParameter(string variable)
		{
			return null;
		}

		public void SetGradientParameter(string variable, global::UnityEngine.Gradient value)
		{
		}
	}
}
