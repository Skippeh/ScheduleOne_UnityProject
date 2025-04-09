using System;
using ScheduleOne.Economy;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	[Serializable]
	public class MapRegionData
	{
		public EMapRegion Region;

		public string Name;

		public FullRank RankRequirement;

		public NPC[] StartingNPCs;

		public Sprite RegionSprite;

		public DeliveryLocation[] RegionDeliveryLocations;

		public bool IsUnlocked => false;

		public DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			return null;
		}

		public void SetUnlocked()
		{
		}
	}
}
