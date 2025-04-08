namespace ScheduleOne.Map
{
	[global::System.Serializable]
	public class MapRegionData
	{
		public global::ScheduleOne.Map.EMapRegion Region;

		public string Name;

		public global::ScheduleOne.Levelling.FullRank RankRequirement;

		public global::ScheduleOne.NPCs.NPC[] StartingNPCs;

		public global::UnityEngine.Sprite RegionSprite;

		public global::ScheduleOne.Economy.DeliveryLocation[] RegionDeliveryLocations;

		public bool IsUnlocked => false;

		public global::ScheduleOne.Economy.DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			return null;
		}

		public void SetUnlocked()
		{
		}
	}
}
