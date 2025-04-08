namespace ScheduleOne.UI.Shop
{
	public class ClothingShopInterface : global::ScheduleOne.UI.Shop.ShopInterface
	{
		public global::ScheduleOne.UI.Shop.ShopColorPicker ColorPicker;

		private global::ScheduleOne.UI.Shop.ShopListing _selectedListing;

		protected override void Start()
		{
		}

		public override void ListingClicked(global::ScheduleOne.UI.Shop.ListingUI listingUI)
		{
		}

		protected override void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void ColorPicked(global::ScheduleOne.Clothing.EClothingColor color)
		{
		}

		public override bool HandoverItems()
		{
			return false;
		}
	}
}
