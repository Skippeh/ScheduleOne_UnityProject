using System;
using System.Collections.Generic;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Economy
{
	[Serializable]
	public class CustomerAffinityData
	{
		[Header("Product Affinities - How much the customer likes each product type. -1 = hates, 0 = neutral, 1 = loves.")]
		public List<ProductTypeAffinity> ProductAffinities;

		public void CopyTo(CustomerAffinityData data)
		{
		}

		public float GetAffinity(EDrugType type)
		{
			return 0f;
		}
	}
}
