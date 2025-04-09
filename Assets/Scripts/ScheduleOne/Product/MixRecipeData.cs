using System;

namespace ScheduleOne.Product
{
	[Serializable]
	public class MixRecipeData
	{
		public string Product;

		public string Mixer;

		public string Output;

		public MixRecipeData(string product, string mixer, string output)
		{
		}
	}
}
