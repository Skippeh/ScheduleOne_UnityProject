using System;

namespace Funly.SkyStudio
{
	[Serializable]
	public class ProfileFeatureDefinition
	{
		public enum FeatureType
		{
			ShaderKeyword = 0,
			BooleanValue = 1,
			ShaderKeywordDropdown = 2
		}

		public string featureKey;

		public string[] featureKeys;

		public FeatureType featureType;

		public string shaderKeyword;

		public string[] shaderKeywords;

		public string[] dropdownLabels;

		public int dropdownSelectedIndex;

		public string name;

		public bool value;

		public string tooltip;

		public string dependsOnFeature;

		public bool dependsOnValue;

		public bool isShaderKeywordFeature;

		public static ProfileFeatureDefinition CreateShaderFeature(string featureKey, string shaderKeyword, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileFeatureDefinition CreateShaderFeatureDropdown(string[] featureKeys, string[] shaderKeywords, string[] labels, int selectedIndex, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileFeatureDefinition CreateBooleanFeature(string featureKey, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}
	}
}
