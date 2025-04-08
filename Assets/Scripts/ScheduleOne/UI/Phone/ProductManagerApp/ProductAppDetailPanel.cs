namespace ScheduleOne.UI.Phone.ProductManagerApp
{
	public class ProductAppDetailPanel : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Color AddictionColor_Min;

		public global::UnityEngine.Color AddictionColor_Max;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject NothingSelected;

		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.UI.Text NameLabel;

		public global::UnityEngine.UI.InputField ValueLabel;

		public global::UnityEngine.UI.Text SuggestedPriceLabel;

		public global::UnityEngine.UI.Toggle ListedForSale;

		public global::UnityEngine.UI.Text DescLabel;

		public global::UnityEngine.UI.Text[] PropertyLabels;

		public global::UnityEngine.RectTransform Listed;

		public global::UnityEngine.RectTransform Delisted;

		public global::UnityEngine.RectTransform NotDiscovered;

		public global::UnityEngine.RectTransform RecipesLabel;

		public global::UnityEngine.RectTransform[] RecipeEntries;

		public global::UnityEngine.UI.VerticalLayoutGroup LayoutGroup;

		public global::UnityEngine.UI.Scrollbar AddictionSlider;

		public global::UnityEngine.UI.Text AddictionLabel;

		public global::UnityEngine.UI.ScrollRect ScrollRect;

		public global::ScheduleOne.Product.ProductDefinition ActiveProduct { get; protected set; }

		public void Awake()
		{
		}

		public void SetActiveProduct(global::ScheduleOne.Product.ProductDefinition productDefinition)
		{
		}

		private void Update()
		{
		}

		private void UpdateListed()
		{
		}

		private void UpdatePrice()
		{
		}

		private void ListingToggled()
		{
		}

		private void PriceSubmitted(string value)
		{
		}
	}
}
