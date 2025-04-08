namespace AdvancedPeopleSystem
{
	[global::UnityEngine.CreateAssetMenu(fileName = "NewCharacterSettings", menuName = "Advanced People Pack/Settings", order = 1)]
	public class CharacterSettings : global::UnityEngine.ScriptableObject
	{
		public global::UnityEngine.GameObject OriginalMesh;

		public global::UnityEngine.Material bodyMaterial;

		[global::UnityEngine.Space(20f)]
		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterAnimationPreset> characterAnimationPresets;

		[global::UnityEngine.Space(20f)]
		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterBlendshapeData> characterBlendshapeDatas;

		[global::UnityEngine.Space(20f)]
		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> hairPresets;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> beardPresets;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> hatsPresets;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> accessoryPresets;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> shirtsPresets;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> pantsPresets;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> shoesPresets;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterElementsPreset> item1Presets;

		[global::UnityEngine.Space(20f)]
		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterSettingsSelector> settingsSelectors;

		[global::UnityEngine.Space(20f)]
		public global::UnityEngine.RuntimeAnimatorController Animator;

		public global::UnityEngine.Avatar Avatar;

		[global::UnityEngine.Space(20f)]
		public global::AdvancedPeopleSystem.CharacterGeneratorSettings generator;

		[global::UnityEngine.Space(20f)]
		public global::AdvancedPeopleSystem.CharacterSelectedElements DefaultSelectedElements;

		[global::UnityEngine.Space(20f)]
		public bool DisableBlendshapeModifier;
	}
}
