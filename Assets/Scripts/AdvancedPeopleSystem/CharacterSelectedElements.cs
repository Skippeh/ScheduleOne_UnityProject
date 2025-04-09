using System;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class CharacterSelectedElements : ICloneable
	{
		public int Hair;

		public int Beard;

		public int Hat;

		public int Shirt;

		public int Pants;

		public int Shoes;

		public int Accessory;

		public int Item1;

		public object Clone()
		{
			return null;
		}

		public int GetSelectedIndex(CharacterElementType type)
		{
			return 0;
		}

		public void SetSelectedIndex(CharacterElementType type, int newIndex)
		{
		}
	}
}
