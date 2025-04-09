using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	public class CharacterCustomizationCategory : MonoBehaviour
	{
		public string CategoryName;

		[Header("References")]
		public TextMeshProUGUI TitleText;

		public Button BackButton;

		public ScrollRect ScrollRect;

		private CharacterCustomizationUI ui;

		private CharacterCustomizationOption[] options;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Back()
		{
		}

		private void OptionSelected(CharacterCustomizationOption option)
		{
		}

		private void OptionDeselected(CharacterCustomizationOption option)
		{
		}

		private void OptionPurchased(CharacterCustomizationOption option)
		{
		}
	}
}
