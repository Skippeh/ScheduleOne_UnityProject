namespace ScheduleOne.ItemFramework
{
	public class ItemFilter_LegalStatus : global::ScheduleOne.ItemFramework.ItemFilter
	{
		public global::ScheduleOne.Core.Items.Framework.ELegalStatus RequiredLegalStatus;

		public ItemFilter_LegalStatus(global::ScheduleOne.Core.Items.Framework.ELegalStatus requiredLegalStatus)
		{
		}

		public override bool DoesItemMatchFilter(global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
			return false;
		}
	}
}
