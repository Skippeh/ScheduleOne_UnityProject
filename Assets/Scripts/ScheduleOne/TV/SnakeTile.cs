using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.TV
{
	public class SnakeTile : MonoBehaviour
	{
		public enum TileType
		{
			Empty = 0,
			Snake = 1,
			Food = 2
		}

		public Vector2 Position;

		public Color SnakeColor;

		public Color FoodColor;

		public RectTransform RectTransform;

		public Image Image;

		public TileType Type { get; private set; }

		public void SetType(TileType type, int index = 0)
		{
		}

		public void SetPosition(Vector2 position, float tileSize)
		{
		}
	}
}
