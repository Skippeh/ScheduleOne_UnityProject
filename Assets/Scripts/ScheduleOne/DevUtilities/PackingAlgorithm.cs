using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.DevUtilities
{
	public class PackingAlgorithm : Singleton<PackingAlgorithm>
	{
		[Serializable]
		public class Rectangle
		{
			public string name;

			public int sizeX;

			public int sizeY;

			public bool flipped;

			public int actualSizeX => 0;

			public int actualSizeY => 0;

			public Rectangle(string _name, int x, int y)
			{
			}
		}

		public class StoredItemData : Rectangle
		{
			public ItemInstance item;

			public int xPos;

			public int yPos;

			public float rotation => 0f;

			public StoredItemData(string _name, int x, int y, ItemInstance _item)
				: base(null, 0, 0)
			{
			}
		}

		public class Coordinate
		{
			public int x;

			public int y;

			public Rectangle occupant;

			public Coordinate(int _x, int _y)
			{
			}
		}

		public List<Rectangle> rectsToPack;

		public List<StoredItemData> PackItems(List<ItemInstance> datas, int gridX, int gridY)
		{
			return null;
		}

		public List<StoredItemData> AttemptPack(List<StoredItemData> rects, int gridX, int gridY)
		{
			return null;
		}

		private bool DoesCoordinateHaveOccupiedAdjacent(Coordinate[,] grid, Coordinate coord, int gridX, int gridY)
		{
			return false;
		}

		private bool IsCoordinateInBounds(Coordinate coord, int gridX, int gridY)
		{
			return false;
		}

		private void PrintGrid(Coordinate[,] grid, int gridX, int gridY)
		{
		}

		private int GetRegionSize(Coordinate[,] grid, int gridX, int gridY)
		{
			return 0;
		}

		private Coordinate TransformCoordinatePoint(Coordinate[,] grid, Coordinate baseCoordinate, Coordinate offset, int gridX, int gridY)
		{
			return null;
		}
	}
}
