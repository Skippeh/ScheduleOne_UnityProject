using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class FootprintMatchData
	{
		public string TileOwnerGUID;

		public int TileIndex;

		public Vector2 FootprintCoordinate;

		public FootprintMatchData(string tileOwnerGUID, int tileIndex, Vector2 footprintCoordinate)
		{
		}
	}
}
