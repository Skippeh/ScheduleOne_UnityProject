namespace ScheduleOne.UI.CharacterCustomization
{
	public class CharacterCustomizationOption : global::UnityEngine.MonoBehaviour
	{
		public string Name;

		public string Label;

		public float Price;

		public bool RequireLevel;

		public global::ScheduleOne.Levelling.FullRank RequiredLevel;

		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI NameLabel;

		public global::TMPro.TextMeshProUGUI PriceLabel;

		public global::TMPro.TextMeshProUGUI LevelLabel;

		public global::UnityEngine.RectTransform LockDisplay;

		public global::UnityEngine.UI.Button MainButton;

		public global::UnityEngine.UI.Button BuyButton;

		public global::UnityEngine.RectTransform SelectionIndicator;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onSelect;

		public global::UnityEngine.Events.UnityEvent onDeselect;

		public global::UnityEngine.Events.UnityEvent onPurchase;

		private bool selected;

		public bool purchased { get; private set; }

		private bool purchaseable => false;

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Start()
		{
		}

		private void Selected()
		{
		}

		private void Purchased()
		{
		}

		private void UpdatePriceColor()
		{
		}

		public void SetSelected(bool _selected)
		{
		}

		public void SetPurchased(bool _purchased)
		{
		}

		private void UpdateUI()
		{
		}

		public void ParentCategoryClosed()
		{
		}

		public void SiblingOptionSelected(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}

		public void SiblingOptionPurchased(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}
	}
}
