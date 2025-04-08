namespace ScheduleOne.Economy
{
	[global::System.Serializable]
	public class ProductTypeAffinity
	{
		public global::ScheduleOne.Product.EDrugType DrugType;

		[global::UnityEngine.Range(-1f, 1f)]
		public float Affinity;
	}
}
