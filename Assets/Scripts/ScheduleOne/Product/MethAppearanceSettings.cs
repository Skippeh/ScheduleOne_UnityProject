namespace ScheduleOne.Product
{
	[global::System.Serializable]
	public class MethAppearanceSettings
	{
		public global::UnityEngine.Color32 MainColor;

		public global::UnityEngine.Color32 SecondaryColor;

		public MethAppearanceSettings(global::UnityEngine.Color32 mainColor, global::UnityEngine.Color32 secondaryColor)
		{
		}

		public MethAppearanceSettings()
		{
		}

		public bool IsUnintialized()
		{
			return false;
		}
	}
}
