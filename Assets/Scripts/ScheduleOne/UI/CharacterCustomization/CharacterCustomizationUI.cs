namespace ScheduleOne.UI.CharacterCustomization
{
	public class CharacterCustomizationUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string Title;

		public global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationCategory[] Categories;

		public bool LoadAvatarSettingsNaked;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform MainContainer;

		public global::UnityEngine.RectTransform MenuContainer;

		public global::TMPro.TextMeshProUGUI TitleText;

		public global::UnityEngine.RectTransform ButtonContainer;

		public global::UnityEngine.UI.Button ExitButton;

		public global::UnityEngine.UI.Slider RigRotationSlider;

		public global::UnityEngine.RectTransform PreviewIndicator;

		public global::ScheduleOne.AvatarFramework.CharacterCustomizationShop CharacterCustomizationShop;

		[global::UnityEngine.Header("Prefab")]
		public global::UnityEngine.UI.Button CategoryButtonPrefab;

		private float rigTargetY;

		private global::UnityEngine.Coroutine openCloseRoutine;

		protected global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings currentSettings;

		public bool IsOpen { get; private set; }

		public global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationCategory ActiveCategory { get; private set; }

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetActiveCategory(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationCategory category)
		{
		}

		public virtual bool IsOptionCurrentlyApplied(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
			return false;
		}

		public virtual void OptionSelected(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}

		public virtual void OptionDeselected(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}

		public virtual void OptionPurchased(global::ScheduleOne.UI.CharacterCustomization.CharacterCustomizationOption option)
		{
		}

		public virtual void Open()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected virtual void Close()
		{
		}
	}
}
