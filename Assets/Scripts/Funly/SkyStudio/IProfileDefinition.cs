namespace Funly.SkyStudio
{
	public interface IProfileDefinition
	{
		string shaderName { get; }

		global::Funly.SkyStudio.ProfileFeatureSection[] features { get; }

		global::Funly.SkyStudio.ProfileGroupSection[] groups { get; }

		global::Funly.SkyStudio.ProfileFeatureDefinition GetFeatureDefinition(string featureKey);
	}
}
