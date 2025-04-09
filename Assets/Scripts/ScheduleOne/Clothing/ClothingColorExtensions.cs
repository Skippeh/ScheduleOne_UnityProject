using UnityEngine;

namespace ScheduleOne.Clothing
{
	public static class ClothingColorExtensions
	{
		public static Color GetActualColor(this EClothingColor color)
		{
			return default(Color);
		}

		public static Color GetLabelColor(this EClothingColor color)
		{
			return default(Color);
		}

		public static string GetLabel(this EClothingColor color)
		{
			return null;
		}

		public static EClothingColor GetClothingColor(Color color)
		{
			return default(EClothingColor);
		}

		public static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)
		{
			return false;
		}
	}
}
