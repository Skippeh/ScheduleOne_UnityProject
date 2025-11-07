namespace ScheduleOne.Product
{
	[global::System.Serializable]
	public class WeedAppearanceSettings
	{
		public enum EWeedAppearanceType
		{
			Main = 0,
			Secondary = 1,
			Leaf = 2,
			Stem = 3
		}

		public global::UnityEngine.Color32 MainColor;

		public global::UnityEngine.Color32 SecondaryColor;

		public global::UnityEngine.Color32 LeafColor;

		public global::UnityEngine.Color32 StemColor;

		public WeedAppearanceSettings(global::UnityEngine.Color32 mainColor, global::UnityEngine.Color32 secondaryColor, global::UnityEngine.Color32 leafColor, global::UnityEngine.Color32 stemColor)
		{
		}

		public WeedAppearanceSettings()
		{
		}

		public bool IsUnintialized()
		{
			return false;
		}
	}
}
