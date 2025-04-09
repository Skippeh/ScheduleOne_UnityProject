using System.Collections.Generic;
using FishNet.Object;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Growing
{
	public class Plant : MonoBehaviour
	{
		[Header("References")]
		public Transform VisualsContainer;

		public PlantGrowthStage[] GrowthStages;

		public Collider Collider;

		public AudioSourceController SnipSound;

		public AudioSourceController DestroySound;

		public ParticleSystem FullyGrownParticles;

		[Header("Settings")]
		public SeedDefinition SeedDefinition;

		public int GrowthTime;

		public float BaseYieldLevel;

		public float BaseQualityLevel;

		public string HarvestTarget;

		[Header("Trash")]
		public TrashItem PlantScrapPrefab;

		public UnityEvent onGrowthDone;

		[Header("Plant data")]
		public float YieldLevel;

		public float QualityLevel;

		[HideInInspector]
		public List<int> ActiveHarvestables;

		public Pot Pot { get; protected set; }

		public float NormalizedGrowthProgress { get; protected set; }

		public bool IsFullyGrown => false;

		public PlantGrowthStage FinalGrowthStage => null;

		public virtual void Initialize(NetworkObject pot, float growthProgress = 0f, float yieldLevel = 0f, float qualityLevel = 0f)
		{
		}

		public virtual void Destroy(bool dropScraps = false)
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

		public bool IsHarvestableActive(int index)
		{
			return false;
		}

		private void GrowthDone()
		{
		}

		private List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			return null;
		}

		public void SetVisible(bool vis)
		{
		}

		public virtual ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}

		public PlantData GetPlantData()
		{
			return null;
		}
	}
}
