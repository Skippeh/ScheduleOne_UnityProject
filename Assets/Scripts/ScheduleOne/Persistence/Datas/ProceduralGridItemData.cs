using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class ProceduralGridItemData : BuildableItemData
	{
		public int Rotation;

		public FootprintMatchData[] FootprintMatches;

		public ProceduralGridItemData(Guid guid, ItemInstance item, int loadOrder, int rotation, FootprintMatchData[] footprintMatches)
			: base(default(Guid), null, 0)
		{
		}
	}
}
