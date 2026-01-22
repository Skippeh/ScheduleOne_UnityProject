namespace ScheduleOne.DevUtilities
{
	[global::UnityEngine.CreateAssetMenu(fileName = "ColorFont", menuName = "ScriptableObjects/Fonts/ColorFont", order = 1)]
	public class ColorFont : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public class ColorFontItem
		{
			public string Name;

			public global::UnityEngine.Color Colour;
		}

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.ColorFont.ColorFontItem> ColorFontItems;

		public global::UnityEngine.Color GetColour(string name)
		{
			return default(global::UnityEngine.Color);
		}
	}
}
