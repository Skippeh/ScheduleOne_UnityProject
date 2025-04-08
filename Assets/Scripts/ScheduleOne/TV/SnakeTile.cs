namespace ScheduleOne.TV
{
	public class SnakeTile : global::UnityEngine.MonoBehaviour
	{
		public enum TileType
		{
			Empty = 0,
			Snake = 1,
			Food = 2
		}

		public global::UnityEngine.Vector2 Position;

		public global::UnityEngine.Color SnakeColor;

		public global::UnityEngine.Color FoodColor;

		public global::UnityEngine.RectTransform RectTransform;

		public global::UnityEngine.UI.Image Image;

		public global::ScheduleOne.TV.SnakeTile.TileType Type { get; private set; }

		public void SetType(global::ScheduleOne.TV.SnakeTile.TileType type, int index = 0)
		{
		}

		public void SetPosition(global::UnityEngine.Vector2 position, float tileSize)
		{
		}
	}
}
