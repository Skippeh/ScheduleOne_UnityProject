using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Economy
{
	[Serializable]
	[CreateAssetMenu(fileName = "CustomerData", menuName = "ScriptableObjects/CustomerData", order = 1)]
	public class CustomerData : ScriptableObject
	{
		public CustomerAffinityData DefaultAffinityData;

		[Header("Preferred Properties - Properties the customer prefers in a product.")]
		public List<ScheduleOne.Properties.Property> PreferredProperties;

		[Header("Spending Behaviour")]
		public float MinWeeklySpend;

		public float MaxWeeklySpend;

		[Range(0f, 7f)]
		public int MinOrdersPerWeek;

		[Range(0f, 7f)]
		public int MaxOrdersPerWeek;

		[Header("Timing Settings")]
		public int OrderTime;

		public EDay PreferredOrderDay;

		[Header("Standards")]
		public ECustomerStandard Standards;

		[Header("Direct approaching")]
		public bool CanBeDirectlyApproached;

		public bool GuaranteeFirstSampleSuccess;

		[Tooltip("The average relationship of mutual customers to provide a 50% chance of success")]
		[Range(0f, 5f)]
		public float MinMutualRelationRequirement;

		[Tooltip("The average relationship of mutual customers to provide a 100% chance of success")]
		[Range(0f, 5f)]
		public float MaxMutualRelationRequirement;

		[Tooltip("If direct approach fails, whats the chance the police will be called?")]
		[Range(0f, 1f)]
		public float CallPoliceChance;

		[Header("Dependence")]
		[Tooltip("How quickly the customer builds dependence")]
		[Range(0f, 2f)]
		public float DependenceMultiplier;

		[Tooltip("The customer's starting (and lowest possible) dependence level")]
		[Range(0f, 1f)]
		public float BaseAddiction;

		public Action onChanged;

		public static float GetQualityScalar(EQuality quality)
		{
			return 0f;
		}

		public List<EDay> GetOrderDays(float dependence, float normalizedRelationship)
		{
			return null;
		}

		public float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			return 0f;
		}

		[Button]
		public void RandomizeAffinities()
		{
		}

		[Button]
		public void RandomizeProperties()
		{
		}

		[Button]
		public void RandomizeTiming()
		{
		}

		[Button]
		public void ClearInvalid()
		{
		}
	}
}
