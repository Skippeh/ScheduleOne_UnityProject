using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Advanced People Pack/Character Customizable", -1)]
	public class CharacterCustomization : MonoBehaviour
	{
		[SerializeField]
		public bool isSettingsExpanded;

		public CharacterSettings selectedsettings;

		[SerializeField]
		private CharacterSettings _settings;

		public List<CharacterPart> characterParts;

		public string prefabPath;

		[SerializeField]
		public CharacterInstanceStatus instanceStatus;

		public Transform originHip;

		public Transform headHip;

		public List<ClothesAnchor> clothesAnchors;

		public Animator animator;

		public CharacterSelectedElements characterSelectedElements;

		public float heightValue;

		public float headSizeValue;

		public float feetOffset;

		public List<CharacterBlendshapeData> characterBlendshapeDatas;

		public Color Skin;

		public Color Eye;

		public Color Hair;

		public Color Underpants;

		public Color OralCavity;

		public Color Teeth;

		public MaterialPropertyBlock bodyPropertyBlock;

		public CurrentBlendshapeAnimation currentBlendshapeAnimation;

		public CombinerState CurrentCombinerState;

		public CharacterPreBuilt combinedCharacter;

		public Transform ProbesAnchorOverride;

		public CharacterGeneratorSettings CharacterGenerator_settings;

		public bool UpdateWhenOffscreenMeshes;

		[SerializeField]
		public int MinLODLevels;

		[SerializeField]
		public int MaxLODLevels;

		private LODGroup _lodGroup;

		public Transform _transform;

		public bool applyFeetOffset;

		public bool notAPP2Shader;

		private GameObject prebuiltPrefab;

		public CharacterSettings Settings => null;

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

		public void InitializeMeshes(CharacterSettings newSettings = null, bool resetAll = true)
		{
		}

		public void UpdateSkinnedMeshesOffscreenBounds()
		{
		}

		public List<CharacterSettingsSelector> GetCharacterSettingsSelectors()
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

		public void SetBlendshapeValue(CharacterBlendShapeType type, float weight, string[] forPart = null, CharacterElementType[] forClothPart = null)
		{
		}

		public void ForceLOD(int lodLevel)
		{
		}

		public void SetElementByIndex(CharacterElementType type, int index)
		{
		}

		public void ClearElement(CharacterElementType type)
		{
		}

		public void SetHeight(float height)
		{
		}

		public void SetHeadSize(float size)
		{
		}

		public void SetFeetOffset(Vector3 offset)
		{
		}

		private void SetHairByIndex(int index)
		{
		}

		private void SetBeardByIndex(int index)
		{
		}

		public ClothesAnchor GetClothesAnchor(CharacterElementType type)
		{
			return null;
		}

		public CharacterPart GetCharacterPart(string name)
		{
			return null;
		}

		public List<SkinnedMeshRenderer> GetAllMeshesByLod(int lod)
		{
			return null;
		}

		public List<SkinnedMeshRenderer> GetAllMeshes()
		{
			return null;
		}

		public List<SkinnedMeshRenderer> GetAllMeshes(bool onlyBodyMeshes = false, string[] excludeNames = null)
		{
			return null;
		}

		public void HideParts(string[] parts)
		{
		}

		public void UnHideParts(string[] parts, CharacterElementType hidePartsForElement)
		{
		}

		public void SetBodyColor(BodyColorPart bodyColorPart, Color color)
		{
		}

		public Color GetBodyColor(BodyColorPart bodyColorPart)
		{
			return default(Color);
		}

		public void SetCharacterSetup(CharacterCustomizationSetup characterCustomizationSetup)
		{
		}

		public CharacterCustomizationSetup GetSetup()
		{
			return null;
		}

		public void ApplySavedCharacterData(SavedCharacterData data)
		{
		}

		public void LoadCharacterFromFile(string path)
		{
		}

		public List<SavedCharacterData> GetSavedCharacterDatas(string path = "")
		{
			return null;
		}

		public void ClearSavedData(SavedCharacterData data)
		{
		}

		public void ClearSavedData()
		{
		}

		public void SaveCharacterToFile(CharacterCustomizationSetup.CharacterFileSaveFormat format, string path = "", string name = "")
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

		public CharacterElementsPreset GetElementsPreset(CharacterElementType type, int index)
		{
			return null;
		}

		public CharacterElementsPreset GetElementsPreset(CharacterElementType type, string name)
		{
			return null;
		}

		public List<CharacterElementsPreset> GetElementsPresets(CharacterElementType type)
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

		public Animator GetAnimator()
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

		public CharacterInstanceStatus GetCharacterInstanceStatus()
		{
			return default(CharacterInstanceStatus);
		}

		public void SetNewCharacterInstanceStatus(CharacterInstanceStatus characterInstanceStatus)
		{
		}

		public CharacterBlendshapeData GetBlendshapeData(CharacterBlendShapeType type)
		{
			return null;
		}

		public CharacterBlendshapeData GetBlendshapeData(string name)
		{
			return null;
		}

		public List<CharacterBlendshapeData> GetBlendshapeDatasByGroup(CharacterBlendShapeGroup group)
		{
			return null;
		}

		private void DestroyObjects(Object[] objects)
		{
		}
	}
}
