using System;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class MinMaxBlendshapes
	{
		[Range(-100f, 100f)]
		public float Min;

		[Range(-100f, 100f)]
		public float Max;

		public float GetRandom()
		{
			return 0f;
		}
	}
}
