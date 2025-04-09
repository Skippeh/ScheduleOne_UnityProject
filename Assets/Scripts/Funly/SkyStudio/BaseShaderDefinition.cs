using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public abstract class BaseShaderDefinition : IProfileDefinition
	{
		private ProfileGroupSection[] m_ProfileDefinitions;

		[SerializeField]
		private ProfileFeatureSection[] m_ProfileFeatures;

		private Dictionary<string, ProfileFeatureDefinition> m_KeyToFeature;

		public string shaderName { get; protected set; }

		public ProfileGroupSection[] groups => null;

		public ProfileFeatureSection[] features => null;

		public ProfileFeatureDefinition GetFeatureDefinition(string featureKey)
		{
			return null;
		}

		protected abstract ProfileFeatureSection[] ProfileFeatureSection();

		protected abstract ProfileGroupSection[] ProfileDefinitionTable();
	}
}
