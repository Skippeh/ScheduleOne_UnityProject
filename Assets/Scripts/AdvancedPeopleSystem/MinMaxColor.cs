using System;
using System.Collections.Generic;
using UnityEngine;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class MinMaxColor
	{
		public List<Color> minColors;

		public List<Color> maxColors;

		public Color GetRandom()
		{
			return default(Color);
		}
	}
}
