using System.Collections.Generic;
using ScheduleOne.Product;

namespace ScheduleOne.Properties
{
	public static class PropertyMixCalculator
	{
		private class Reaction
		{
			public Property Existing;

			public Property Output;
		}

		public const int MAX_PROPERTIES = 8;

		public const float MAX_DELTA_DIFFERENCE = 0.5f;

		public static List<Property> MixProperties(List<Property> existingProperties, Property newProperty, EDrugType drugType)
		{
			return null;
		}

		public static void Shuffle<T>(List<T> list, int seed)
		{
		}
	}
}
