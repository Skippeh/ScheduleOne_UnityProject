using ScheduleOne.ItemFramework;

namespace ScheduleOne.Growing
{
	public class WeedPlant : Plant
	{
		public PlantHarvestable BranchPrefab;

		public override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}
	}
}
