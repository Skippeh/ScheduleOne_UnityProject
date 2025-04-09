using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[CreateAssetMenu(fileName = "NewCharacterGenerator", menuName = "Advanced People Pack/CharacterGenerator", order = 1)]
	public class CharacterGeneratorSettings : ScriptableObject
	{
		public MinMaxIndex hair;

		public MinMaxIndex beard;

		public MinMaxIndex hat;

		public MinMaxIndex accessory;

		public MinMaxIndex shirt;

		public MinMaxIndex pants;

		public MinMaxIndex shoes;

		[Space(10f)]
		public MinMaxColor skinColors;

		public MinMaxColor eyeColors;

		public MinMaxColor hairColors;

		[Space(10f)]
		public MinMaxBlendshapes headSize;

		public MinMaxBlendshapes headOffset;

		public MinMaxBlendshapes height;

		public MinMaxBlendshapes fat;

		public MinMaxBlendshapes muscles;

		public MinMaxBlendshapes thin;

		[Space(15f)]
		public List<MinMaxFacialBlendshapes> facialBlendshapes;

		[Space(15f)]
		public List<GeneratorExclude> excludes;
	}
}
