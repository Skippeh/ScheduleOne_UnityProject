namespace ScheduleOne.Growing
{
	public class PlantHarvestable : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.ItemFramework.StorableItemDefinition Product;

		public int ProductQuantity;

		private void Awake()
		{
		}

		public virtual void Harvest(bool giveProduct = true)
		{
		}
	}
}
