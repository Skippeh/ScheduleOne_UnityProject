using System;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Economy
{
	[Serializable]
	public class ProductTypeAffinity
	{
		public EDrugType DrugType;

		[Range(-1f, 1f)]
		public float Affinity;
	}
}
