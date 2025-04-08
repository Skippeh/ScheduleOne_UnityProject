namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public abstract class BaseShaderDefinition : global::Funly.SkyStudio.IProfileDefinition
	{
		private global::Funly.SkyStudio.ProfileGroupSection[] m_ProfileDefinitions;

		[global::UnityEngine.SerializeField]
		private global::Funly.SkyStudio.ProfileFeatureSection[] m_ProfileFeatures;

		private global::System.Collections.Generic.Dictionary<string, global::Funly.SkyStudio.ProfileFeatureDefinition> m_KeyToFeature;

		public string shaderName { get; protected set; }

		public global::Funly.SkyStudio.ProfileGroupSection[] groups => null;

		public global::Funly.SkyStudio.ProfileFeatureSection[] features => null;

		public global::Funly.SkyStudio.ProfileFeatureDefinition GetFeatureDefinition(string featureKey)
		{
			return null;
		}

		protected abstract global::Funly.SkyStudio.ProfileFeatureSection[] ProfileFeatureSection();

		protected abstract global::Funly.SkyStudio.ProfileGroupSection[] ProfileDefinitionTable();
	}
}
