using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	[Serializable]
	public class Coordinate
	{
		public int x;

		public int y;

		public static implicit operator Vector2(Coordinate c)
		{
			return default(Vector2);
		}

		public Coordinate()
		{
		}

		public Coordinate(int _x, int _y)
		{
		}

		public Coordinate(Vector2 vector)
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

		public static Coordinate operator +(Coordinate a, Coordinate b)
		{
			return null;
		}

		public static Coordinate operator -(Coordinate a, Coordinate b)
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

		public static List<CoordinatePair> BuildCoordinateMatches(Coordinate originCoord, int sizeX, int sizeY, float rot)
		{
			return null;
		}

		public static Coordinate RotateCoordinates(Coordinate coord, float angle)
		{
			return null;
		}

		private static int MathMod(int a, int b)
		{
			return 0;
		}
	}
}
