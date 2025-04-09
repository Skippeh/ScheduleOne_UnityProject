using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	public class CharacterCustomizationUI : MonoBehaviour
	{
		[Header("Settings")]
		public string Title;

		public CharacterCustomizationCategory[] Categories;

		public bool LoadAvatarSettingsNaked;

		[Header("References")]
		public Canvas Canvas;

		public RectTransform MainContainer;

		public RectTransform MenuContainer;

		public TextMeshProUGUI TitleText;

		public RectTransform ButtonContainer;

		public Button ExitButton;

		public Slider RigRotationSlider;

		public Transform CameraPosition;

		public Transform RigContainer;

		public ScheduleOne.AvatarFramework.Avatar AvatarRig;

		public RectTransform PreviewIndicator;

		[Header("Prefab")]
		public Button CategoryButtonPrefab;

		private float rigTargetY;

		private Coroutine openCloseRoutine;

		protected BasicAvatarSettings currentSettings;

		public bool IsOpen { get; private set; }

		public CharacterCustomizationCategory ActiveCategory { get; private set; }

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		public void SetActiveCategory(CharacterCustomizationCategory category)
		{
		}

		public virtual bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			return false;
		}

		public virtual void OptionSelected(CharacterCustomizationOption option)
		{
		}

		public virtual void OptionDeselected(CharacterCustomizationOption option)
		{
		}

		public virtual void OptionPurchased(CharacterCustomizationOption option)
		{
		}

		public virtual void Open()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		protected virtual void Close()
		{
		}
	}
}
