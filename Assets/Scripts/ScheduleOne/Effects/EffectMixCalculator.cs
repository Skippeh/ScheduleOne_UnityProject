namespace ScheduleOne.Effects
{
	public static class EffectMixCalculator
	{
		private class Reaction
		{
			public global::ScheduleOne.Effects.Effect Existing;

			public global::ScheduleOne.Effects.Effect Output;
		}

		public const int MAX_PROPERTIES = 8;

		public const float MAX_DELTA_DIFFERENCE = 0.5f;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> MixProperties(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> existingProperties, global::ScheduleOne.Effects.Effect newProperty, global::ScheduleOne.Product.EDrugType drugType)
		{
			return null;
		}

		public static void Shuffle<T>(global::System.Collections.Generic.List<T> list, int seed)
		{
		}
	}
}
