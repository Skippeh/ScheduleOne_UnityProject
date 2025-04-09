using System;
using UnityEngine;

namespace ScheduleOne.Levelling
{
	[Serializable]
	public struct FullRank
	{
		public ERank Rank;

		[Range(1f, 5f)]
		public int Tier;

		public FullRank(ERank rank, int tier)
		{
			this.Rank = rank;
			this.Tier = tier;
		}

		public override string ToString()
		{
			return null;
		}

		public FullRank NextRank()
		{
			return default(FullRank);
		}

		public static string GetString(FullRank rank)
		{
			return null;
		}

		public static bool operator >(FullRank a, FullRank b)
		{
			return false;
		}

		public static bool operator <(FullRank a, FullRank b)
		{
			return false;
		}

		public static bool operator <=(FullRank a, FullRank b)
		{
			return false;
		}

		public static bool operator >=(FullRank a, FullRank b)
		{
			return false;
		}

		public static bool operator ==(FullRank a, FullRank b)
		{
			return false;
		}

		public static bool operator !=(FullRank a, FullRank b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public int CompareTo(FullRank other)
		{
			return 0;
		}
	}
}
