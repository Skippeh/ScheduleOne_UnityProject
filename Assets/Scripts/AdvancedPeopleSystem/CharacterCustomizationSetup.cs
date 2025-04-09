using System;
using System.Collections.Generic;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class CharacterCustomizationSetup
	{
		public enum CharacterFileSaveFormat
		{
			Json = 0,
			Xml = 1,
			Binary = 2
		}

		public string settingsName;

		public CharacterSelectedElements selectedElements;

		public List<CharacterBlendshapeData> blendshapes;

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

		public void ApplyToCharacter(CharacterCustomization cc)
		{
		}

		public string Serialize(CharacterFileSaveFormat format)
		{
			return null;
		}

		public static CharacterCustomizationSetup Deserialize(string data, CharacterFileSaveFormat format)
		{
			return null;
		}
	}
}
