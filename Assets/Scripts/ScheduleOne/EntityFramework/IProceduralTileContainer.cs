using System.Collections.Generic;
using ScheduleOne.Tiles;

namespace ScheduleOne.EntityFramework
{
	public interface IProceduralTileContainer
	{
		List<ProceduralTile> ProceduralTiles { get; }
	}
}
