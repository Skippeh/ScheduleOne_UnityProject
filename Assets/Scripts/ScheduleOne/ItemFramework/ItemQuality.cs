using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	public static class ItemQuality
	{
		public const float Heavenly_Threshold = 0.9f;

		public const float Premium_Threshold = 0.75f;

		public const float Standard_Threshold = 0.4f;

		public const float Poor_Threshold = 0.25f;

		public static Color Heavenly_Color;

		public static Color Premium_Color;

		public static Color Standard_Color;

		public static Color Poor_Color;

		public static Color Trash_Color;

		public static EQuality GetQuality(float qualityScalar)
		{
			return default(EQuality);
		}

		public static Color GetColor(EQuality quality)
		{
			return default(Color);
		}
	}
}
