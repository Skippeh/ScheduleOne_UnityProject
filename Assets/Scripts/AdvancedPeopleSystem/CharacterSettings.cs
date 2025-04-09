using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[CreateAssetMenu(fileName = "NewCharacterSettings", menuName = "Advanced People Pack/Settings", order = 1)]
	public class CharacterSettings : ScriptableObject
	{
		public GameObject OriginalMesh;

		public Material bodyMaterial;

		[Space(20f)]
		public List<CharacterAnimationPreset> characterAnimationPresets;

		[Space(20f)]
		public List<CharacterBlendshapeData> characterBlendshapeDatas;

		[Space(20f)]
		public List<CharacterElementsPreset> hairPresets;

		public List<CharacterElementsPreset> beardPresets;

		public List<CharacterElementsPreset> hatsPresets;

		public List<CharacterElementsPreset> accessoryPresets;

		public List<CharacterElementsPreset> shirtsPresets;

		public List<CharacterElementsPreset> pantsPresets;

		public List<CharacterElementsPreset> shoesPresets;

		public List<CharacterElementsPreset> item1Presets;

		[Space(20f)]
		public List<CharacterSettingsSelector> settingsSelectors;

		[Space(20f)]
		public RuntimeAnimatorController Animator;

		public Avatar Avatar;

		[Space(20f)]
		public CharacterGeneratorSettings generator;

		[Space(20f)]
		public CharacterSelectedElements DefaultSelectedElements;

		[Space(20f)]
		public bool DisableBlendshapeModifier;
	}
}
