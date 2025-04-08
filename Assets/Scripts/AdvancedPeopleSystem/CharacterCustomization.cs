namespace AdvancedPeopleSystem
{
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.AddComponentMenu("Advanced People Pack/Character Customizable", -1)]
	public class CharacterCustomization : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		public bool isSettingsExpanded;

		public global::AdvancedPeopleSystem.CharacterSettings selectedsettings;

		[global::UnityEngine.SerializeField]
		private global::AdvancedPeopleSystem.CharacterSettings _settings;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterPart> characterParts;

		public string prefabPath;

		[global::UnityEngine.SerializeField]
		public global::AdvancedPeopleSystem.CharacterInstanceStatus instanceStatus;

		public global::UnityEngine.Transform originHip;

		public global::UnityEngine.Transform headHip;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.ClothesAnchor> clothesAnchors;

		public global::UnityEngine.Animator animator;

		public global::AdvancedPeopleSystem.CharacterSelectedElements characterSelectedElements;

		public float heightValue;

		public float headSizeValue;

		public float feetOffset;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterBlendshapeData> characterBlendshapeDatas;

		public global::UnityEngine.Color Skin;

		public global::UnityEngine.Color Eye;

		public global::UnityEngine.Color Hair;

		public global::UnityEngine.Color Underpants;

		public global::UnityEngine.Color OralCavity;

		public global::UnityEngine.Color Teeth;

		public global::UnityEngine.MaterialPropertyBlock bodyPropertyBlock;

		public global::AdvancedPeopleSystem.CurrentBlendshapeAnimation currentBlendshapeAnimation;

		public global::AdvancedPeopleSystem.CombinerState CurrentCombinerState;

		public global::AdvancedPeopleSystem.CharacterPreBuilt combinedCharacter;

		public global::UnityEngine.Transform ProbesAnchorOverride;

		public global::AdvancedPeopleSystem.CharacterGeneratorSettings CharacterGenerator_settings;

		public bool UpdateWhenOffscreenMeshes;

		[global::UnityEngine.SerializeField]
		public int MinLODLevels;

		[global::UnityEngine.SerializeField]
		public int MaxLODLevels;

		private global::UnityEngine.LODGroup _lodGroup;

		public global::UnityEngine.Transform _transform;

		public bool applyFeetOffset;

		public bool notAPP2Shader;

		private global::UnityEngine.GameObject prebuiltPrefab;

		public global::AdvancedPeopleSystem.CharacterSettings Settings => null;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void AnimationTick()
		{
		}

		public void SwitchCharacterSettings(int settingsIndex)
		{
		}

		public void SwitchCharacterSettings(string selectorName)
		{
		}

		public void InitializeMeshes(global::AdvancedPeopleSystem.CharacterSettings newSettings = null, bool resetAll = true)
		{
		}

		public void UpdateSkinnedMeshesOffscreenBounds()
		{
		}

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterSettingsSelector> GetCharacterSettingsSelectors()
		{
			return null;
		}

		public void ResetBodyMaterial()
		{
		}

		public void InitColors()
		{
		}

		public void ResetBodyColors()
		{
		}

		public void SetBlendshapeValue(global::AdvancedPeopleSystem.CharacterBlendShapeType type, float weight, string[] forPart = null, global::AdvancedPeopleSystem.CharacterElementType[] forClothPart = null)
		{
		}

		public void ForceLOD(int lodLevel)
		{
		}

		public void SetElementByIndex(global::AdvancedPeopleSystem.CharacterElementType type, int index)
		{
		}

		public void ClearElement(global::AdvancedPeopleSystem.CharacterElementType type)
		{
		}

		public void SetHeight(float height)
		{
		}

		public void SetHeadSize(float size)
		{
		}

		public void SetFeetOffset(global::UnityEngine.Vector3 offset)
		{
		}

		private void SetHairByIndex(int index)
		{
		}

		private void SetBeardByIndex(int index)
		{
		}

		public global::AdvancedPeopleSystem.ClothesAnchor GetClothesAnchor(global::AdvancedPeopleSystem.CharacterElementType type)
		{
			return null;
		}

		public global::AdvancedPeopleSystem.CharacterPart GetCharacterPart(string name)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::UnityEngine.SkinnedMeshRenderer> GetAllMeshesByLod(int lod)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::UnityEngine.SkinnedMeshRenderer> GetAllMeshes()
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::UnityEngine.SkinnedMeshRenderer> GetAllMeshes(bool onlyBodyMeshes = false, string[] excludeNames = null)
		{
			return null;
		}

		public void HideParts(string[] parts)
		{
		}

		public void UnHideParts(string[] parts, global::AdvancedPeopleSystem.CharacterElementType hidePartsForElement)
		{
		}

		public void SetBodyColor(global::AdvancedPeopleSystem.BodyColorPart bodyColorPart, global::UnityEngine.Color color)
		{
		}

		public global::UnityEngine.Color GetBodyColor(global::AdvancedPeopleSystem.BodyColorPart bodyColorPart)
		{
			return default(global::UnityEngine.Color);
		}

		public void SetCharacterSetup(global::AdvancedPeopleSystem.CharacterCustomizationSetup characterCustomizationSetup)
		{
		}

		public global::AdvancedPeopleSystem.CharacterCustomizationSetup GetSetup()
		{
			return null;
		}

		public void ApplySavedCharacterData(global::AdvancedPeopleSystem.SavedCharacterData data)
		{
		}

		public void LoadCharacterFromFile(string path)
		{
		}

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.SavedCharacterData> GetSavedCharacterDatas(string path = "")
		{
			return null;
		}

		public void ClearSavedData(global::AdvancedPeopleSystem.SavedCharacterData data)
		{
		}

		public void ClearSavedData()
		{
		}

		public void SaveCharacterToFile(global::AdvancedPeopleSystem.CharacterCustomizationSetup.CharacterFileSaveFormat format, string path = "", string name = "")
		{
		}

		public void RecalculateShapes()
		{
		}

		public void EditorSavePreBuiltPrefab()
		{
		}

		public void BakeCharacter(bool usePreBuiltMeshes = false)
		{
		}

		public void ClearBake()
		{
		}

		public void RecalculateLOD()
		{
		}

		public void SetLODRange(int minLod, int maxLod)
		{
		}

		public bool IsBaked()
		{
			return false;
		}

		public global::AdvancedPeopleSystem.CharacterElementsPreset GetElementsPreset(global::AdvancedPeopleSystem.CharacterElementType type, int index)
		{
			return null;
		}

		public global::AdvancedPeopleSystem.CharacterElementsPreset GetElementsPreset(global::AdvancedPeopleSystem.CharacterElementType type, string name)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> GetElementsPresets(global::AdvancedPeopleSystem.CharacterElementType type)
		{
			return null;
		}

		public void PlayBlendshapeAnimation(string animationName, float duration = 1f, float weightPower = 1f)
		{
		}

		public void StopBlendshapeAnimations()
		{
		}

		public void ResetAll(bool ignore_settingsDefaultElements = true)
		{
		}

		public void Randomize()
		{
		}

		public global::UnityEngine.Animator GetAnimator()
		{
			return null;
		}

		public void UnlockPrefab()
		{
		}

		public void LockPrefab(string custompath = "")
		{
		}

		public void ApplyPrefab()
		{
		}

		public void RevertBonesChanges()
		{
		}

		public void ApplyPrefabInPlaymode()
		{
		}

		public void UpdateActualCharacterInstanceStatus(bool igroneUserNonPrefab = false)
		{
		}

		public global::AdvancedPeopleSystem.CharacterInstanceStatus GetCharacterInstanceStatus()
		{
			return default(global::AdvancedPeopleSystem.CharacterInstanceStatus);
		}

		public void SetNewCharacterInstanceStatus(global::AdvancedPeopleSystem.CharacterInstanceStatus characterInstanceStatus)
		{
		}

		public global::AdvancedPeopleSystem.CharacterBlendshapeData GetBlendshapeData(global::AdvancedPeopleSystem.CharacterBlendShapeType type)
		{
			return null;
		}

		public global::AdvancedPeopleSystem.CharacterBlendshapeData GetBlendshapeData(string name)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterBlendshapeData> GetBlendshapeDatasByGroup(global::AdvancedPeopleSystem.CharacterBlendShapeGroup group)
		{
			return null;
		}

		private void DestroyObjects(global::UnityEngine.Object[] objects)
		{
		}
	}
}
