namespace ScheduleOne.DevUtilities
{
	public class PackingAlgorithm : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.DevUtilities.PackingAlgorithm>
	{
		[global::System.Serializable]
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

		public class StoredItemData : global::ScheduleOne.DevUtilities.PackingAlgorithm.Rectangle
		{
			public global::ScheduleOne.ItemFramework.ItemInstance item;

			public int xPos;

			public int yPos;

			public float rotation => 0f;

			public StoredItemData(string _name, int x, int y, global::ScheduleOne.ItemFramework.ItemInstance _item)
				: base(null, 0, 0)
			{
			}
		}

		public class Coordinate
		{
			public int x;

			public int y;

			public global::ScheduleOne.DevUtilities.PackingAlgorithm.Rectangle occupant;

			public Coordinate(int _x, int _y)
			{
			}
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.PackingAlgorithm.Rectangle> rectsToPack;

		public global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.PackingAlgorithm.StoredItemData> PackItems(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> datas, int gridX, int gridY)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.PackingAlgorithm.StoredItemData> AttemptPack(global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.PackingAlgorithm.StoredItemData> rects, int gridX, int gridY)
		{
			return null;
		}

		private bool DoesCoordinateHaveOccupiedAdjacent(global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate[,] grid, global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			return false;
		}

		private bool IsCoordinateInBounds(global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			return false;
		}

		private void PrintGrid(global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate[,] grid, int gridX, int gridY)
		{
		}

		private int GetRegionSize(global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate[,] grid, int gridX, int gridY)
		{
			return 0;
		}

		private global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate TransformCoordinatePoint(global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate[,] grid, global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate baseCoordinate, global::ScheduleOne.DevUtilities.PackingAlgorithm.Coordinate offset, int gridX, int gridY)
		{
			return null;
		}
	}
}
