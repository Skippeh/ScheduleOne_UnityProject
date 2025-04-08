namespace ScheduleOne.Growing
{
	public class PlantHarvestable : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.ItemFramework.StorableItemDefinition Product;

		public int ProductQuantity;

		public virtual void Harvest(bool giveProduct = true)
		{
		}
	}
}
