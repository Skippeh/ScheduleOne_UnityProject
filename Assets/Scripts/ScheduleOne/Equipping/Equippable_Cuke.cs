namespace ScheduleOne.Equipping
{
	public class Equippable_Cuke : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		[global::UnityEngine.Header("Settings")]
		public float BaseEnergyGain;

		public float MinEnergyGain;

		public float ConsecutiveReduction;

		public float HealthGain;

		public float AnimationDuration;

		public bool ClearDrugEffects;

		public global::ScheduleOne.Product.ProductDefinition PseudoProduct;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Animation OpenAnim;

		public global::UnityEngine.Animation DrinkAnim;

		public global::ScheduleOne.Audio.AudioSourceController OpenSound;

		public global::ScheduleOne.Audio.AudioSourceController SlurpSound;

		public global::ScheduleOne.Trash.TrashItem TrashPrefab;

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
