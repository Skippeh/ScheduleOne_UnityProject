using ScheduleOne.Levelling;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	public class CharacterCustomizationOption : MonoBehaviour
	{
		public string Name;

		public string Label;

		public float Price;

		public bool RequireLevel;

		public FullRank RequiredLevel;

		[Header("References")]
		public TextMeshProUGUI NameLabel;

		public TextMeshProUGUI PriceLabel;

		public TextMeshProUGUI LevelLabel;

		public RectTransform LockDisplay;

		public Button MainButton;

		public Button BuyButton;

		public RectTransform SelectionIndicator;

		[Header("Events")]
		public UnityEvent onSelect;

		public UnityEvent onDeselect;

		public UnityEvent onPurchase;

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

		public void SiblingOptionSelected(CharacterCustomizationOption option)
		{
		}

		public void SiblingOptionPurchased(CharacterCustomizationOption option)
		{
		}
	}
}
