namespace AdvancedPeopleSystem
{
	[global::UnityEngine.CreateAssetMenu(fileName = "NewCharacterGenerator", menuName = "Advanced People Pack/CharacterGenerator", order = 1)]
	public class CharacterGeneratorSettings : global::UnityEngine.ScriptableObject
	{
		public global::AdvancedPeopleSystem.MinMaxIndex hair;

		public global::AdvancedPeopleSystem.MinMaxIndex beard;

		public global::AdvancedPeopleSystem.MinMaxIndex hat;

		public global::AdvancedPeopleSystem.MinMaxIndex accessory;

		public global::AdvancedPeopleSystem.MinMaxIndex shirt;

		public global::AdvancedPeopleSystem.MinMaxIndex pants;

		public global::AdvancedPeopleSystem.MinMaxIndex shoes;

		[global::UnityEngine.Space(10f)]
		public global::AdvancedPeopleSystem.MinMaxColor skinColors;

		public global::AdvancedPeopleSystem.MinMaxColor eyeColors;

		public global::AdvancedPeopleSystem.MinMaxColor hairColors;

		[global::UnityEngine.Space(10f)]
		public global::AdvancedPeopleSystem.MinMaxBlendshapes headSize;

		public global::AdvancedPeopleSystem.MinMaxBlendshapes headOffset;

		public global::AdvancedPeopleSystem.MinMaxBlendshapes height;

		public global::AdvancedPeopleSystem.MinMaxBlendshapes fat;

		public global::AdvancedPeopleSystem.MinMaxBlendshapes muscles;

		public global::AdvancedPeopleSystem.MinMaxBlendshapes thin;

		[global::UnityEngine.Space(15f)]
		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.MinMaxFacialBlendshapes> facialBlendshapes;

		[global::UnityEngine.Space(15f)]
		public global::System.Collections.Generic.List<global::AdvancedPeopleSystem.GeneratorExclude> excludes;
	}
}
