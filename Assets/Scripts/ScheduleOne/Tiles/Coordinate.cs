namespace ScheduleOne.Tiles
{
	[global::System.Serializable]
	public class Coordinate
	{
		public int x;

		public int y;

		public static implicit operator global::UnityEngine.Vector2(global::ScheduleOne.Tiles.Coordinate c)
		{
			return default(global::UnityEngine.Vector2);
		}

		public Coordinate()
		{
		}

		public Coordinate(int _x, int _y)
		{
		}

		public Coordinate(global::UnityEngine.Vector2 vector)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static global::ScheduleOne.Tiles.Coordinate operator +(global::ScheduleOne.Tiles.Coordinate a, global::ScheduleOne.Tiles.Coordinate b)
		{
			return null;
		}

		public static global::ScheduleOne.Tiles.Coordinate operator -(global::ScheduleOne.Tiles.Coordinate a, global::ScheduleOne.Tiles.Coordinate b)
		{
			return null;
		}

		private int CantorPair(int x, int y)
		{
			return 0;
		}

		private int SignedCantorPair(int x, int y)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinatePair> BuildCoordinateMatches(global::ScheduleOne.Tiles.Coordinate originCoord, int sizeX, int sizeY, float rot)
		{
			return null;
		}

		public static global::ScheduleOne.Tiles.Coordinate RotateCoordinates(global::ScheduleOne.Tiles.Coordinate coord, float angle)
		{
			return null;
		}

		private static int MathMod(int a, int b)
		{
			return 0;
		}
	}
}
