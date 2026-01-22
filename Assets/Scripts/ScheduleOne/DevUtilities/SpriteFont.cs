namespace ScheduleOne.DevUtilities
{
	[global::UnityEngine.CreateAssetMenu(fileName = "SpriteFont", menuName = "ScriptableObjects/Fonts/SpriteFont")]
	public class SpriteFont : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public class SpriteFontItem
		{
			public string Name;

			public global::UnityEngine.Sprite Sprite;
		}

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.SpriteFont.SpriteFontItem> SpriteFontItems;

		public global::UnityEngine.Sprite GetSprite(string name)
		{
			return null;
		}
	}
}
