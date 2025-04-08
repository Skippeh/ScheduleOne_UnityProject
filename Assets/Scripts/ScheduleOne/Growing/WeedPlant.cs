namespace ScheduleOne.Growing
{
	public class WeedPlant : global::ScheduleOne.Growing.Plant
	{
		public global::ScheduleOne.Growing.PlantHarvestable BranchPrefab;

		public override global::ScheduleOne.ItemFramework.ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			return null;
		}
	}
}
