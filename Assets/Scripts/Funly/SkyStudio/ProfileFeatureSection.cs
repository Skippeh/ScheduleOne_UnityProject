namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class ProfileFeatureSection
	{
		public string sectionTitle;

		public string sectionKey;

		public string sectionIcon;

		public global::Funly.SkyStudio.ProfileFeatureDefinition[] featureDefinitions;

		public ProfileFeatureSection(string sectionTitle, string sectionKey, global::Funly.SkyStudio.ProfileFeatureDefinition[] featureDefinitions)
		{
		}
	}
}
