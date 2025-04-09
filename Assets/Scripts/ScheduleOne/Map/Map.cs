using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class Map : Singleton<Map>
	{
		public MapRegionData[] Regions;

		[Header("References")]
		public PoliceStation PoliceStation;

		public MedicalCentre MedicalCentre;

		public Transform TreeBounds;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public MapRegionData GetRegionData(EMapRegion region)
		{
			return null;
		}

		private void GameLoaded()
		{
		}

		private void OnRankUp(FullRank oldRank, FullRank newRank)
		{
		}
	}
}
