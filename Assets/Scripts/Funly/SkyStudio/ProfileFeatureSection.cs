using System;

namespace Funly.SkyStudio
{
	[Serializable]
	public class ProfileFeatureSection
	{
		public string sectionTitle;

		public string sectionKey;

		public string sectionIcon;

		public ProfileFeatureDefinition[] featureDefinitions;

		public ProfileFeatureSection(string sectionTitle, string sectionKey, ProfileFeatureDefinition[] featureDefinitions)
		{
		}
	}
}
