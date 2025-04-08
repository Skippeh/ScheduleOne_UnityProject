namespace Funly.SkyStudio
{
	[global::UnityEngine.CreateAssetMenu(fileName = "skyProfile.asset", menuName = "Sky Studio/Sky Profile", order = 0)]
	public class SkyProfile : global::UnityEngine.ScriptableObject
	{
		public const string DefaultShaderName = "Funly/Sky Studio/Skybox/3D Standard";

		public const string DefaultLegacyShaderName = "Funly/Sky Studio/Skybox/3D Standard - Global Keywords";

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Material m_SkyboxMaterial;

		[global::UnityEngine.SerializeField]
		private string m_ShaderName;

		public global::Funly.SkyStudio.IProfileDefinition profileDefinition;

		public global::System.Collections.Generic.List<string> timelineManagedKeys;

		public global::Funly.SkyStudio.KeyframeGroupDictionary keyframeGroups;

		public global::Funly.SkyStudio.BoolDictionary featureStatus;

		public global::Funly.SkyStudio.LightningArtSet lightningArtSet;

		public global::Funly.SkyStudio.RainSplashArtSet rainSplashArtSet;

		public global::UnityEngine.Texture2D starLayer1DataTexture;

		public global::UnityEngine.Texture2D starLayer2DataTexture;

		public global::UnityEngine.Texture2D starLayer3DataTexture;

		[global::UnityEngine.SerializeField]
		private int m_ProfileVersion;

		private global::System.Collections.Generic.Dictionary<string, global::Funly.SkyStudio.ProfileGroupDefinition> m_KeyToGroupInfo;

		public global::UnityEngine.Material skyboxMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string shaderName => null;

		public global::Funly.SkyStudio.ProfileGroupSection[] groupDefinitions => null;

		public global::Funly.SkyStudio.ProfileFeatureSection[] featureDefinitions => null;

		public float GetNumberPropertyValue(string propertyKey)
		{
			return 0f;
		}

		public float GetNumberPropertyValue(string propertyKey, float timeOfDay)
		{
			return 0f;
		}

		public global::UnityEngine.Color GetColorPropertyValue(string propertyKey)
		{
			return default(global::UnityEngine.Color);
		}

		public global::UnityEngine.Color GetColorPropertyValue(string propertyKey, float timeOfDay)
		{
			return default(global::UnityEngine.Color);
		}

		public global::UnityEngine.Texture GetTexturePropertyValue(string propertyKey)
		{
			return null;
		}

		public global::UnityEngine.Texture GetTexturePropertyValue(string propertyKey, float timeOfDay)
		{
			return null;
		}

		public global::Funly.SkyStudio.SpherePoint GetSpherePointPropertyValue(string propertyKey)
		{
			return null;
		}

		public global::Funly.SkyStudio.SpherePoint GetSpherePointPropertyValue(string propertyKey, float timeOfDay)
		{
			return null;
		}

		public bool GetBoolPropertyValue(string propertyKey)
		{
			return false;
		}

		public bool GetBoolPropertyValue(string propertyKey, float timeOfDay)
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void ReloadFullProfile()
		{
		}

		private void ReloadDefinitions()
		{
		}

		private global::Funly.SkyStudio.IProfileDefinition GetShaderInfoForMaterial(string shaderName)
		{
			return null;
		}

		public void MergeProfileWithDefinitions()
		{
		}

		public void MergeGroupsWithDefinitions()
		{
		}

		public global::System.Collections.Generic.Dictionary<string, global::Funly.SkyStudio.ProfileGroupDefinition> GroupDefinitionDictionary()
		{
			return null;
		}

		public global::Funly.SkyStudio.ProfileGroupSection[] ProfileDefinitionTable()
		{
			return null;
		}

		private void AddNumericGroup(string propKey, string groupName, float min, float max, float value)
		{
		}

		private void AddColorGroup(string propKey, string groupName, global::UnityEngine.Color color)
		{
		}

		private void AddTextureGroup(string propKey, string groupName, global::UnityEngine.Texture2D texture)
		{
		}

		private void AddSpherePointGroup(string propKey, string groupName, global::Funly.SkyStudio.SpherePoint point)
		{
		}

		private void AddBooleanGroup(string propKey, string groupName, bool value)
		{
		}

		public T GetGroup<T>(string propertyKey) where T : class
		{
			return null;
		}

		public global::Funly.SkyStudio.IKeyframeGroup GetGroup(string propertyKey)
		{
			return null;
		}

		public global::Funly.SkyStudio.IKeyframeGroup GetGroupWithId(string groupId)
		{
			return null;
		}

		public global::Funly.SkyStudio.ProfileGroupSection[] GetProfileDefinitions()
		{
			return null;
		}

		public global::Funly.SkyStudio.ProfileGroupSection GetSectionInfo(string sectionKey)
		{
			return null;
		}

		public bool IsManagedByTimeline(string propertyKey)
		{
			return false;
		}

		public void ValidateTimelineGroupKeys()
		{
		}

		public global::System.Collections.Generic.List<global::Funly.SkyStudio.ProfileGroupDefinition> GetGroupDefinitionsManagedByTimeline()
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::Funly.SkyStudio.ProfileGroupDefinition> GetGroupDefinitionsNotManagedByTimeline()
		{
			return null;
		}

		public global::Funly.SkyStudio.ProfileGroupDefinition GetGroupDefinitionForKey(string propertyKey)
		{
			return null;
		}

		public void RebuildKeyToGroupInfoMapping()
		{
		}

		public void TrimGroupToSingleKeyframe(string propertyKey)
		{
		}

		public bool CanGroupBeOnTimeline(global::Funly.SkyStudio.ProfileGroupDefinition definition)
		{
			return false;
		}

		protected void MergeShaderKeywordsWithDefinitions()
		{
		}

		public bool IsFeatureEnabled(string featureKey, bool recursive = true)
		{
			return false;
		}

		public void SetFeatureEnabled(string featureKey, bool value)
		{
		}
	}
}
