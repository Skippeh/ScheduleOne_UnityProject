namespace ScheduleOne.Growing
{
	public abstract class Plant : global::UnityEngine.MonoBehaviour
	{
		public const float BaseQualityLevel = 0.5f;

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

		public int BaseYieldQuantity;

		public string HarvestTarget;

		[global::UnityEngine.Header("Trash")]
		public global::ScheduleOne.Trash.TrashItem PlantScrapPrefab;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<int> ActiveHarvestables;

		public global::System.Action onFullyHarvested;

		public global::ScheduleOne.ObjectScripts.Pot Pot { get; protected set; }

		public float NormalizedGrowthProgress { get; protected set; }

		public bool IsFullyGrown => false;

		public float YieldMultiplier { get; private set; }

		public float QualityLevel { get; private set; }

		public global::ScheduleOne.Growing.PlantGrowthStage FinalGrowthStage => null;

		private void Awake()
		{
		}

		public virtual void Initialize(global::FishNet.Object.NetworkObject pot, float growthProgress)
		{
		}

		public virtual void MinPass(int mins)
		{
		}

		public void AdditiveApplied(global::ScheduleOne.ItemFramework.AdditiveDefinition additive, bool isInitialApplication)
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
