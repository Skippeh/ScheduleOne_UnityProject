namespace ScheduleOne.DevUtilities
{
	public class FontSetter : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class ImageItem
		{
			public string Name;

			public global::UnityEngine.UI.Image Image;
		}

		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.FontSetter.ImageItem> _imageItems;

		[global::UnityEngine.Header("Fonts")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _colourFont;

		public void SetColour(string componentName, string ColourName)
		{
		}
	}
}
