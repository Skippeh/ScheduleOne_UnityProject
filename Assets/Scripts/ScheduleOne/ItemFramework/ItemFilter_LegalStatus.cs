namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_LegalStatus : global::ScheduleOne.ItemFramework.ItemFilter
	{
		public global::ScheduleOne.ItemFramework.ELegalStatus RequiredLegalStatus;

		public ItemFilter_LegalStatus(global::ScheduleOne.ItemFramework.ELegalStatus requiredLegalStatus)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
