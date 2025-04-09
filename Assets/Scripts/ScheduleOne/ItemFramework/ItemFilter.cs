namespace ScheduleOne.ItemFramework
{
	public class ItemFilter
	{
		public virtual bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}
	}
}
