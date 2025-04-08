namespace AdvancedPeopleSystem
{
	[global::System.Serializable]
	public class CharacterCustomizationSetup
	{
		public enum CharacterFileSaveFormat
		{
			Json = 0,
			Xml = 1,
			Binary = 2
		}

		public string settingsName;

		public global::AdvancedPeopleSystem.CharacterSelectedElements selectedElements;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterBlendshapeData> blendshapes;

		public int MinLod;

		public int MaxLod;

		public float[] SkinColor;

		public float[] EyeColor;

		public float[] HairColor;

		public float[] UnderpantsColor;

		public float[] TeethColor;

		public float[] OralCavityColor;

		public float Height;

		public float HeadSize;

		public void ApplyToCharacter(global::AdvancedPeopleSystem.CharacterCustomization cc)
		{
		}

		public string Serialize(global::AdvancedPeopleSystem.CharacterCustomizationSetup.CharacterFileSaveFormat format)
		{
			return null;
		}

		public static global::AdvancedPeopleSystem.CharacterCustomizationSetup Deserialize(string data, global::AdvancedPeopleSystem.CharacterCustomizationSetup.CharacterFileSaveFormat format)
		{
			return null;
		}
	}
}
