namespace ScheduleOne.Growing
{
	public abstract class Plant : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform VisualsContainer;

		public global::ScheduleOne.Growing.PlantGrowthStage[] GrowthStages;

		public global::UnityEngine.Collider Collider;

		public global::ScheduleOne.Audio.AudioSourceController SnipSound;

		public global::ScheduleOne.Audio.AudioSourceController DestroySound;

		public global::UnityEngine.ParticleSystem FullyGrownParticles;

		public global::UnityEngine.Transform HarvestLabelPositionTransform;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Growing.SeedDefinition SeedDefinition;

		public int GrowthTime;

		public float BaseYieldLevel;

		public float BaseQualityLevel;

		public string HarvestTarget;

		[global::UnityEngine.Header("Trash")]
		public global::ScheduleOne.Trash.TrashItem PlantScrapPrefab;

		[global::UnityEngine.Header("Plant data")]
		public float YieldLevel;

		public float QualityLevel;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<int> ActiveHarvestables;

		public global::System.Action onFullyHarvested;

		public global::ScheduleOne.ObjectScripts.Pot Pot { get; protected set; }

		public float NormalizedGrowthProgress { get; protected set; }

		public bool IsFullyGrown => false;

		public global::ScheduleOne.Growing.PlantGrowthStage FinalGrowthStage => null;

		private void Awake()
		{
		}

		public virtual void Initialize(global::FishNet.Object.NetworkObject pot, float growthProgress = 0f, float yieldLevel = 0f, float qualityLevel = 0f)
		{
		}

		public virtual void MinPass()
		{
		}

		public virtual void SetNormalizedGrowthProgress(float progress)
		{
		}

		protected virtual void UpdateVisuals()
		{
		}

		public virtual void SetHarvestableActive(int index, bool active)
		{
		}

		private void OnFullyHarvested()
		{
		}

		public bool IsHarvestableActive(int index)
		{
			return false;
		}

		private void GrowthDone()
		{
		}

		private global::System.Collections.Generic.List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			return null;
		}

		public void SetVisible(bool vis)
		{
		}

		public virtual global::ScheduleOne.ItemFramework.ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}

		public global::ScheduleOne.Persistence.Datas.PlantData GetPlantData()
		{
			return null;
		}
	}
}
