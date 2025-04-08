namespace AdvancedPeopleSystem
{
	[global::System.Serializable]
	public class BlendshapeEmotionValue
	{
		public global::AdvancedPeopleSystem.CharacterBlendShapeType BlendType;

		[global::UnityEngine.Range(-100f, 100f)]
		public float BlendValue;

		public global::UnityEngine.AnimationCurve BlendAnimationCurve;
	}
}
