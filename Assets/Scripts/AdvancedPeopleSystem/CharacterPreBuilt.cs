namespace AdvancedPeopleSystem
{
	public class CharacterPreBuilt : global::UnityEngine.ScriptableObject
	{
		[global::UnityEngine.SerializeField]
		public global::AdvancedPeopleSystem.CharacterSettings settings;

		[global::UnityEngine.SerializeField]
		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.PreBuiltData> preBuiltDatas;

		[global::UnityEngine.SerializeField]
		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.PreBuiltBlendshape> blendshapes;
	}
}
