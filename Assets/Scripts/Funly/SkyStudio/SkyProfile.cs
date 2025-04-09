using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	[CreateAssetMenu(fileName = "skyProfile.asset", menuName = "Sky Studio/Sky Profile", order = 0)]
	public class SkyProfile : ScriptableObject
	{
		public const string DefaultShaderName = "Funly/Sky Studio/Skybox/3D Standard";

		public const string DefaultLegacyShaderName = "Funly/Sky Studio/Skybox/3D Standard - Global Keywords";

		[SerializeField]
		private Material m_SkyboxMaterial;

		[SerializeField]
		private string m_ShaderName;

		public IProfileDefinition profileDefinition;

		public List<string> timelineManagedKeys;

		public KeyframeGroupDictionary keyframeGroups;

		public BoolDictionary featureStatus;

		public LightningArtSet lightningArtSet;

		public RainSplashArtSet rainSplashArtSet;

		public Texture2D starLayer1DataTexture;

		public Texture2D starLayer2DataTexture;

		public Texture2D starLayer3DataTexture;

		[SerializeField]
		private int m_ProfileVersion;

		private Dictionary<string, ProfileGroupDefinition> m_KeyToGroupInfo;

		public Material skyboxMaterial
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

		public ProfileGroupSection[] groupDefinitions => null;

		public ProfileFeatureSection[] featureDefinitions => null;

		public float GetNumberPropertyValue(string propertyKey)
		{
			return 0f;
		}

		public float GetNumberPropertyValue(string propertyKey, float timeOfDay)
		{
			return 0f;
		}

		public Color GetColorPropertyValue(string propertyKey)
		{
			return default(Color);
		}

		public Color GetColorPropertyValue(string propertyKey, float timeOfDay)
		{
			return default(Color);
		}

		public Texture GetTexturePropertyValue(string propertyKey)
		{
			return null;
		}

		public Texture GetTexturePropertyValue(string propertyKey, float timeOfDay)
		{
			return null;
		}

		public SpherePoint GetSpherePointPropertyValue(string propertyKey)
		{
			return null;
		}

		public SpherePoint GetSpherePointPropertyValue(string propertyKey, float timeOfDay)
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

		private IProfileDefinition GetShaderInfoForMaterial(string shaderName)
		{
			return null;
		}

		public void MergeProfileWithDefinitions()
		{
		}

		public void MergeGroupsWithDefinitions()
		{
		}

		public Dictionary<string, ProfileGroupDefinition> GroupDefinitionDictionary()
		{
			return null;
		}

		public ProfileGroupSection[] ProfileDefinitionTable()
		{
			return null;
		}

		private void AddNumericGroup(string propKey, string groupName, float min, float max, float value)
		{
		}

		private void AddColorGroup(string propKey, string groupName, Color color)
		{
		}

		private void AddTextureGroup(string propKey, string groupName, Texture2D texture)
		{
		}

		private void AddSpherePointGroup(string propKey, string groupName, SpherePoint point)
		{
		}

		private void AddBooleanGroup(string propKey, string groupName, bool value)
		{
		}

		public T GetGroup<T>(string propertyKey) where T : class
		{
			return null;
		}

		public IKeyframeGroup GetGroup(string propertyKey)
		{
			return null;
		}

		public IKeyframeGroup GetGroupWithId(string groupId)
		{
			return null;
		}

		public ProfileGroupSection[] GetProfileDefinitions()
		{
			return null;
		}

		public ProfileGroupSection GetSectionInfo(string sectionKey)
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

		public List<ProfileGroupDefinition> GetGroupDefinitionsManagedByTimeline()
		{
			return null;
		}

		public List<ProfileGroupDefinition> GetGroupDefinitionsNotManagedByTimeline()
		{
			return null;
		}

		public ProfileGroupDefinition GetGroupDefinitionForKey(string propertyKey)
		{
			return null;
		}

		public void RebuildKeyToGroupInfoMapping()
		{
		}

		public void TrimGroupToSingleKeyframe(string propertyKey)
		{
		}

		public bool CanGroupBeOnTimeline(ProfileGroupDefinition definition)
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
