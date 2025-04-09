namespace Funly.SkyStudio
{
	public interface IProfileDefinition
	{
		string shaderName { get; }

		ProfileFeatureSection[] features { get; }

		ProfileGroupSection[] groups { get; }

		ProfileFeatureDefinition GetFeatureDefinition(string featureKey);
	}
}
