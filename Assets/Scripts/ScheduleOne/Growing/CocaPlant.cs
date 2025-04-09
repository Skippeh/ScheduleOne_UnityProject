using ScheduleOne.ItemFramework;

namespace ScheduleOne.Growing
{
	public class CocaPlant : Plant
	{
		public PlantHarvestable Harvestable;

		public override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}
	}
}
