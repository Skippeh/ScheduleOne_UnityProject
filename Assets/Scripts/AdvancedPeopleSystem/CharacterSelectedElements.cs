namespace AdvancedPeopleSystem
{
	[global::System.Serializable]
	public class CharacterSelectedElements : global::System.ICloneable
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

		public int GetSelectedIndex(global::AdvancedPeopleSystem.CharacterElementType type)
		{
			return 0;
		}

		public void SetSelectedIndex(global::AdvancedPeopleSystem.CharacterElementType type, int newIndex)
		{
		}
	}
}
