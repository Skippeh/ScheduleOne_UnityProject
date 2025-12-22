namespace ScheduleOne.Economy
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "CustomerData", menuName = "ScriptableObjects/CustomerData", order = 1)]
	public class CustomerData : global::UnityEngine.ScriptableObject
	{
		public global::ScheduleOne.Economy.CustomerAffinityData DefaultAffinityData;

		[global::UnityEngine.Header("Preferred Properties - Properties the customer prefers in a product.")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> PreferredProperties;

		[global::UnityEngine.Header("Spending Behaviour")]
		public float MinWeeklySpend;

		public float MaxWeeklySpend;

		[global::UnityEngine.Range(0f, 7f)]
		public int MinOrdersPerWeek;

		[global::UnityEngine.Range(0f, 7f)]
		public int MaxOrdersPerWeek;

		[global::UnityEngine.Header("Timing Settings")]
		public int OrderTime;

		public global::ScheduleOne.GameTime.EDay PreferredOrderDay;

		[global::UnityEngine.Header("Standards")]
		public global::ScheduleOne.Economy.ECustomerStandard Standards;

		[global::UnityEngine.Header("Direct approaching")]
		public bool CanBeDirectlyApproached;

		public bool GuaranteeFirstSampleSuccess;

		[global::UnityEngine.Tooltip("The average relationship of mutual customers to provide a 50% chance of success")]
		[global::UnityEngine.Range(0f, 5f)]
		public float MinMutualRelationRequirement;

		[global::UnityEngine.Tooltip("The average relationship of mutual customers to provide a 100% chance of success")]
		[global::UnityEngine.Range(0f, 5f)]
		public float MaxMutualRelationRequirement;

		[global::UnityEngine.Tooltip("If direct approach fails, whats the chance the police will be called?")]
		[global::UnityEngine.Range(0f, 1f)]
		public float CallPoliceChance;

		[global::UnityEngine.Header("Dependence")]
		[global::UnityEngine.Tooltip("How quickly the customer builds dependence")]
		[global::UnityEngine.Range(0f, 2f)]
		public float DependenceMultiplier;

		[global::UnityEngine.Tooltip("The customer's starting (and lowest possible) dependence level")]
		[global::UnityEngine.Range(0f, 1f)]
		public float BaseAddiction;

		public global::System.Action onChanged;

		public static float GetQualityScalar(global::ScheduleOne.ItemFramework.EQuality quality)
		{
			return 0f;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.GameTime.EDay> GetOrderDays(float dependence, float normalizedRelationship)
		{
			return null;
		}

		public float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			return 0f;
		}

		[global::EasyButtons.Button]
		public void RandomizeAffinities()
		{
		}

		[global::EasyButtons.Button]
		public void RandomizeFavouriteEffects()
		{
		}

		[global::EasyButtons.Button]
		public void RandomizeTiming()
		{
		}

		[global::EasyButtons.Button]
		public void ClearInvalid()
		{
		}
	}
}
