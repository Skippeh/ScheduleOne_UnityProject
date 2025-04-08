namespace ScheduleOne.Economy
{
	[global::System.Serializable]
	public class CustomerAffinityData
	{
		[global::UnityEngine.Header("Product Affinities - How much the customer likes each product type. -1 = hates, 0 = neutral, 1 = loves.")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Economy.ProductTypeAffinity> ProductAffinities;

		public void CopyTo(global::ScheduleOne.Economy.CustomerAffinityData data)
		{
		}

		public float GetAffinity(global::ScheduleOne.Product.EDrugType type)
		{
			return 0f;
		}
	}
}
