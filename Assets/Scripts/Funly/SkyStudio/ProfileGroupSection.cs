namespace Funly.SkyStudio
{
	public class ProfileGroupSection
	{
		public string sectionTitle;

		public string sectionIcon;

		public string sectionKey;

		public string dependsOnFeature;

		public bool dependsOnValue;

		public ProfileGroupDefinition[] groups;

		public ProfileGroupSection(string sectionTitle, string sectionKey, string sectionIcon, string dependsOnFeature, bool dependsOnValue, ProfileGroupDefinition[] groups)
		{
		}
	}
}
