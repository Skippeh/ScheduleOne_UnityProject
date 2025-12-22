namespace ScheduleOne.Product
{
	[global::System.Serializable]
	public class ShroomAppearanceSettings
	{
		public static readonly global::UnityEngine.Color32 DefaultPrimaryColor;

		public static readonly global::UnityEngine.Color32 DefaultSecondaryColor;

		public static readonly global::UnityEngine.Color32 DefaultSpotsColor;

		public global::UnityEngine.Color32 PrimaryColor { get; private set; }

		public global::UnityEngine.Color32 SecondaryColor { get; private set; }

		public bool HasSpots { get; private set; }

		public global::UnityEngine.Color32 SpotsColor { get; private set; }

		public ShroomAppearanceSettings(global::UnityEngine.Color32 primary, global::UnityEngine.Color32 secondary, bool hasSpots, global::UnityEngine.Color32 spotsColor)
		{
		}

		public ShroomAppearanceSettings()
		{
		}

		public bool IsUnintialized()
		{
			return false;
		}
	}
}
