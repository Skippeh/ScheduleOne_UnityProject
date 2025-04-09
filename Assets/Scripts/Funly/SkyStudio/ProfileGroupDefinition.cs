using UnityEngine;

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

		public GroupType type;

		public FormatStyle formatStyle;

		public RebuildType rebuildType;

		public string propertyKey;

		public string groupName;

		public Color color;

		public SpherePoint spherePoint;

		public float minimumValue;

		public float maximumValue;

		public float value;

		public bool boolValue;

		public Texture2D texture;

		public string tooltip;

		public string dependsOnFeature;

		public bool dependsOnValue;

		public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition NumberGroupDefinition(string groupName, string propKey, float minimumValue, float maximumValue, float value, RebuildType rebuildType, FormatStyle formatStyle, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition ColorGroupDefinition(string groupName, string propKey, Color color, RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition SpherePointGroupDefinition(string groupName, string propKey, float horizontalRotation, float verticalRotation, RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition TextureGroupDefinition(string groupName, string propKey, Texture2D texture, RebuildType rebuildType, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		public static ProfileGroupDefinition BoolGroupDefinition(string groupName, string propKey, bool value, string dependsOnKeyword, bool dependsOnValue, string tooltip)
		{
			return null;
		}
	}
}
