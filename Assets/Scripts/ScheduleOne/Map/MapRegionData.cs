namespace ScheduleOne.Map
{
	[global::System.Serializable]
	public class MapRegionData
	{
		[global::System.Serializable]
		public class RegionContainer
		{
			public global::ScheduleOne.Map.EMapRegion Region;
		}

		public global::ScheduleOne.Map.EMapRegion Region;

		public string Name;

		public bool UnlockedByDefault;

		public global::ScheduleOne.Levelling.FullRank RankRequirement;

		public global::ScheduleOne.NPCs.NPC[] StartingNPCs;

		public global::UnityEngine.Sprite RegionSprite;

		public global::ScheduleOne.Economy.DeliveryLocation[] RegionDeliveryLocations;

		public global::ScheduleOne.Map.MapRegionData.RegionContainer[] AdjacentRegions;

		public global::ScheduleOne.Audio.Zone RegionBounds;

		public bool IsUnlocked { get; private set; }

		public global::ScheduleOne.Economy.DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			return null;
		}

		public void SetUnlocked()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> GetAdjacentRegions()
		{
			return null;
		}
	}
}
