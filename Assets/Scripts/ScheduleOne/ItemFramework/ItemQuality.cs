namespace ScheduleOne.ItemFramework
{
	public static class ItemQuality
	{
		public const float Heavenly_Threshold = 0.9f;

		public const float Premium_Threshold = 0.75f;

		public const float Standard_Threshold = 0.4f;

		public const float Poor_Threshold = 0.25f;

		public static global::UnityEngine.Color Heavenly_Color;

		public static global::UnityEngine.Color Premium_Color;

		public static global::UnityEngine.Color Standard_Color;

		public static global::UnityEngine.Color Poor_Color;

		public static global::UnityEngine.Color Trash_Color;

		public static global::ScheduleOne.ItemFramework.EQuality GetQuality(float qualityScalar)
		{
			return default(global::ScheduleOne.ItemFramework.EQuality);
		}

		public static global::ScheduleOne.ItemFramework.EQuality ShiftQuality(global::ScheduleOne.ItemFramework.EQuality baseQuality, int shiftAmount)
		{
			return default(global::ScheduleOne.ItemFramework.EQuality);
		}

		public static global::UnityEngine.Color GetColor(global::ScheduleOne.ItemFramework.EQuality quality)
		{
			return default(global::UnityEngine.Color);
		}
	}
}
