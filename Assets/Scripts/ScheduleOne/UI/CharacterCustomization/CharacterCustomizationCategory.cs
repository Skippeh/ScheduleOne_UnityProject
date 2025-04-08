namespace ScheduleOne.UI.CharacterCustomization
{
	public class CharacterCustomizationCategory : global::UnityEngine.MonoBehaviour
	{
		public string CategoryName;

		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI TitleText;

		public global::UnityEngine.UI.Button BackButton;

		public global::UnityEngine.UI.ScrollRect ScrollRect;

		private global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationUI ui;

		private global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption[] options;

		public global::UnityEngine.Events.UnityEvent onOpen;

		public global::UnityEngine.Events.UnityEvent onClose;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Back()
		{
		}

		private void OptionSelected(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}

		private void OptionDeselected(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}

		private void OptionPurchased(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}
	}
}
