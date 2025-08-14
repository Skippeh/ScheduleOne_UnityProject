namespace ScheduleOne.Cartel
{
	public class CartelInfluence : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class RegionInfluenceData
		{
			private string name;

			public global::ScheduleOne.Map.EMapRegion Region;

			[global::UnityEngine.Range(0f, 1f)]
			public float Influence;

			public RegionInfluenceData(global::ScheduleOne.Map.EMapRegion region, float influence = 0f)
			{
			}
		}

		public const float INFLUENCE_TO_UNLOCK_NEXT_REGION = 0.3f;

		public const float PASSIVE_INFLUENCE_GAIN_PER_DAY = 0.02f;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData[] DefaultRegionInfluence;

		private global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData> regionInfluence;

		public global::System.Action<global::ScheduleOne.Map.EMapRegion, float, float> OnInfluenceChanged;

		public global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData[] GetAllRegionInfluence()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		private void OnSleepEnd()
		{
		}

		public void ChangeInfluence(global::ScheduleOne.Map.EMapRegion region, float amount)
		{
		}

		public void SetInfluence(global::ScheduleOne.Map.EMapRegion region, float influence)
		{
		}

		public float GetInfluence(global::ScheduleOne.Map.EMapRegion region)
		{
			return 0f;
		}

		[global::EasyButtons.Button]
		public void Test()
		{
		}

		private global::ScheduleOne.Cartel.CartelInfluence.RegionInfluenceData GetRegionData(global::ScheduleOne.Map.EMapRegion region)
		{
			return null;
		}
	}
}
