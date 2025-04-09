using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Shop
{
	public class ClothingShopInterface : ShopInterface
	{
		public ShopColorPicker ColorPicker;

		private ShopListing _selectedListing;

		protected override void Start()
		{
		}

		public override void ListingClicked(ListingUI listingUI)
		{
		}

		protected override void Exit(ExitAction action)
		{
		}

		private void ColorPicked(EClothingColor color)
		{
		}

		public override bool HandoverItems()
		{
			return false;
		}
	}
}
