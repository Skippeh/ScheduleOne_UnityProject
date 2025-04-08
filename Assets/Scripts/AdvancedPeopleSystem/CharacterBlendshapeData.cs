namespace AdvancedPeopleSystem
{
	[global::System.Serializable]
	public class CharacterBlendshapeData
	{
		public string blendshapeName;

		public global::AdvancedPeopleSystem.CharacterBlendShapeType type;

		public global::AdvancedPeopleSystem.CharacterBlendShapeGroup group;

		[global::UnityEngine.HideInInspector]
		public float value;

		public CharacterBlendshapeData(string name, global::AdvancedPeopleSystem.CharacterBlendShapeType t, global::AdvancedPeopleSystem.CharacterBlendShapeGroup g, float value = 0f)
		{
		}

		public CharacterBlendshapeData()
		{
		}
	}
}
