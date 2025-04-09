using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Product
{
	public class ProductEntry : MonoBehaviour
	{
		public Color SelectedColor;

		public Color DeselectedColor;

		public Color FavouritedColor;

		public Color UnfavouritedColor;

		[Header("References")]
		public Button Button;

		public Image Frame;

		public Image Icon;

		public RectTransform Tick;

		public RectTransform Cross;

		public EventTrigger Trigger;

		public Button FavouriteButton;

		public Image FavouriteIcon;

		public UnityEvent onHovered;

		private bool destroyed;

		public ProductDefinition Definition { get; private set; }

		public void Initialize(ProductDefinition definition)
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

		private void ProductListedOrDelisted(ProductDefinition def)
		{
		}

		public void UpdateListed()
		{
		}

		private void ProductFavouritedOrUnFavourited(ProductDefinition def)
		{
		}

		public void UpdateFavourited()
		{
		}

		public void UpdateDiscovered(ProductDefinition def)
		{
		}
	}
}
