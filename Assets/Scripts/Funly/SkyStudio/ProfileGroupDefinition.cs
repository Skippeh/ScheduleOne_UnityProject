namespace Funly.SkyStudio
{
	public class ProfileGroupDefinition
	{
		public enum GroupType
		{
			None = 0,
			Color = 1,
			Number = 2,
			Texture = 3,
			SpherePoint = 4,
			Boolean = 5
		}

		public enum FormatStyle
		{
			None = 0,
			Integer = 1,
			Float = 2
		}

		public enum RebuildType
		{
			None = 0,
			Stars = 1
		}

		public global::Funly.SkyStudio.ProfileGroupDefinition.GroupType type;

		public global::Funly.SkyStudio.ProfileGroupDefinition.FormatStyle formatStyle;

		public global::Funly.SkyStudio.ProfileGroupDefinition.RebuildType rebuildType;

		public string propertyKey;

		public string groupName;

		public global::UnityEngine.Color color;

		public global::Funly.SkyStudio.SpherePoint spherePoint;

		public float minimumValue;

		public float maximumValue;

		public float value;

		public bool boolValue;

		public global::UnityEngine.Texture2D texture;

		public string tooltip;

		public string dependsOnFeature;

		public bool dependsOnValue;

		public static global::Funly.SkyStudio.ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, global::Funly.SkyStudio.ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, global::Funly.SkyStudio.ProfileGroupDefinition.RebuildType rebuildType, global::Funly.SkyStudio.ProfileGroupDefinition.FormatStyle formatStyle, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, global::UnityEngine.Color color, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, global::UnityEngine.Color color, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, global::UnityEngine.Color color, global::Funly.SkyStudio.ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, global::Funly.SkyStudio.ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, global::UnityEngine.Texture2D texture, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, global::UnityEngine.Texture2D texture, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, global::UnityEngine.Texture2D texture, global::Funly.SkyStudio.ProfileGroupDefinition.RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static global::Funly.SkyStudio.ProfileGroupDefinition BoolGroupDefinition(string groupName, string propKey, bool value, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}
	}
}
