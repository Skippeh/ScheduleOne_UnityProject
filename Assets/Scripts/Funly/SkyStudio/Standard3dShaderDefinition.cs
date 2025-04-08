namespace Funly.SkyStudio
{
	public class Standard3dShaderDefinition : global::Funly.SkyStudio.BaseShaderDefinition
	{
		public const float MaxStarSize = 0.2f;

		public const float MaxStarDensity = 1f;

		public const float MinEdgeFeathering = 0.0001f;

		public const float MinStarFadeBegin = -0.999f;

		public const float MaxSpriteItems = 100000f;

		public const float MinRotationSpeed = -10f;

		public const float MaxRotationSpeed = 10f;

		public const float MaxCloudRotationSpeed = 0.5f;

		public const float MaxHDRValue = 25f;

		protected override global::Funly.SkyStudio.ProfileFeatureSection[] ProfileFeatureSection()
		{
			return null;
		}

		protected override global::Funly.SkyStudio.ProfileGroupSection[] ProfileDefinitionTable()
		{
			return null;
		}
	}
}
