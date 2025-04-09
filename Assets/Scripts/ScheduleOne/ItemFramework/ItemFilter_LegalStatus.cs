namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_LegalStatus : ItemFilter
	{
		public ELegalStatus RequiredLegalStatus;

		public ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus)
		{
		}

		public override bool DoesItemMatchFilter(ItemInstance instance)
		{
			return false;
		}
	}
}
