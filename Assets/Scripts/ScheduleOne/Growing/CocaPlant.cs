namespace ScheduleOne.Growing
{
	public class CocaPlant : global::ScheduleOne.Growing.Plant
	{
		public global::ScheduleOne.Growing.PlantHarvestable Harvestable;

		public override global::ScheduleOne.ItemFramework.ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}
	}
}
