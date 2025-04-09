using ScheduleOne.Audio;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	public class Equippable_Cuke : Equippable_Viewmodel
	{
		[Header("Settings")]
		public float BaseEnergyGain;

		public float MinEnergyGain;

		public float ConsecutiveReduction;

		public float HealthGain;

		public float AnimationDuration;

		public bool ClearDrugEffects;

		[Header("References")]
		public Animation OpenAnim;

		public Animation DrinkAnim;

		public AudioSourceController OpenSound;

		public AudioSourceController SlurpSound;

		public TrashItem TrashPrefab;

		public bool IsDrinking { get; protected set; }

		protected override void Update()
		{
		}

		public void Drink()
		{
		}

		public void ApplyEffects()
		{
		}
	}
}
