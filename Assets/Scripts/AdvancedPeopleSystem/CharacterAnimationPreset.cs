namespace AdvancedPeopleSystem
{
	[global::System.Serializable]
	public class CharacterAnimationPreset
	{
		public string name;

		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.BlendshapeEmotionValue> blendshapes;

		public bool UseGlobalBlendCurve;

		public global::UnityEngine.AnimationCurve GlobalBlendAnimationCurve;

		[global::UnityEngine.HideInInspector]
		public float AnimationPlayDuration;

		[global::UnityEngine.HideInInspector]
		public float weightPower;

		[global::UnityEngine.Header("May decrease performance")]
		public bool applyToAllCharacterMeshes;
	}
}
