namespace ScheduleOne.Product
{
	public class ProductEntry : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Color SelectedColor;

		public global::UnityEngine.Color DeselectedColor;

		public global::UnityEngine.Color FavouritedColor;

		public global::UnityEngine.Color UnfavouritedColor;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Button Button;

		public global::UnityEngine.UI.Image Frame;

		public global::UnityEngine.UI.Image Icon;

		public global::UnityEngine.RectTransform Tick;

		public global::UnityEngine.RectTransform Cross;

		public global::UnityEngine.EventSystems.EventTrigger Trigger;

		public global::UnityEngine.UI.Button FavouriteButton;

		public global::UnityEngine.UI.Image FavouriteIcon;

		public global::UnityEngine.Events.UnityEvent onHovered;

		private bool destroyed;

		public global::ScheduleOne.Product.ProductDefinition Definition { get; private set; }

		public void Initialize(global::ScheduleOne.Product.ProductDefinition definition)
		{
		}

		public void Destroy()
		{
		}

		private void OnDestroy()
		{
		}

		private void Clicked()
		{
		}

		private void FavouriteClicked()
		{
		}

		private void ProductListedOrDelisted(global::ScheduleOne.Product.ProductDefinition def)
		{
		}

		public void UpdateListed()
		{
		}

		private void ProductFavouritedOrUnFavourited(global::ScheduleOne.Product.ProductDefinition def)
		{
		}

		public void UpdateFavourited()
		{
		}

		public void UpdateDiscovered(global::ScheduleOne.Product.ProductDefinition def)
		{
		}
	}
}
