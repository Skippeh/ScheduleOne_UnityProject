namespace ScheduleOne.Cartel
{
	[global::System.Serializable]
	public class CartelGoonAppearance
	{
		public bool IsMale;

		public int BaseAppearanceIndex;

		public global::UnityEngine.Color SkinColor;

		public global::UnityEngine.Color HairColor;

		public int ClothingIndex;

		public int VoiceIndex;

		public CartelGoonAppearance(bool isMale, int baseAppearanceIndex, global::UnityEngine.Color skinColor, global::UnityEngine.Color hairColor, int clothingIndex, int voiceIndex)
		{
		}

		public CartelGoonAppearance()
		{
		}
	}
}
