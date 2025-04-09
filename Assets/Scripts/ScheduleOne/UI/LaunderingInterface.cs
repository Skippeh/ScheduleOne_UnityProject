using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ObjectScripts.Cash;
using ScheduleOne.Property;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class LaunderingInterface : MonoBehaviour
	{
		protected const float fovOverride = 65f;

		protected const float lerpTime = 0.15f;

		protected const int minLaunderAmount = 10;

		[Header("References")]
		[SerializeField]
		protected Transform cameraPosition;

		[SerializeField]
		protected InteractableObject intObj;

		[SerializeField]
		protected Button launderButton;

		[SerializeField]
		protected GameObject amountSelectorScreen;

		[SerializeField]
		protected Slider amountSlider;

		[SerializeField]
		protected TMP_InputField amountInputField;

		[SerializeField]
		protected RectTransform notchContainer;

		[SerializeField]
		protected TextMeshProUGUI currentTotalAmountLabel;

		[SerializeField]
		protected TextMeshProUGUI launderCapacityLabel;

		[SerializeField]
		protected TextMeshProUGUI insufficientCashLabel;

		[SerializeField]
		protected RectTransform entryContainer;

		[SerializeField]
		protected RectTransform noEntries;

		public CashStackVisuals[] CashStacks;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject timelineNotchPrefab;

		[SerializeField]
		protected GameObject entryPrefab;

		[Header("UI references")]
		[SerializeField]
		protected Canvas canvas;

		private int selectedAmountToLaunder;

		private Dictionary<LaunderingOperation, RectTransform> operationToNotch;

		private List<RectTransform> notches;

		private bool ignoreSliderChange;

		private Dictionary<LaunderingOperation, RectTransform> operationToEntry;

		protected int maxLaunderAmount => 0;

		public Business business { get; private set; }

		public bool isOpen => false;

		public void Initialize(Business bus)
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void MinPass()
		{
		}

		protected void Exit(ExitAction exit)
		{
		}

		protected void UpdateTimeline()
		{
		}

		protected void UpdateCurrentTotal()
		{
		}

		private void CreateEntry(LaunderingOperation op)
		{
		}

		private void RemoveEntry(LaunderingOperation op)
		{
		}

		private void UpdateEntryTimes()
		{
		}

		private void UpdateCashStacks(LaunderingOperation op)
		{
		}

		private void RefreshLaunderButton()
		{
		}

		public void OpenAmountSelector()
		{
		}

		public void CloseAmountSelector()
		{
		}

		public void ConfirmAmount()
		{
		}

		public void SliderValueChanged()
		{
		}

		public void InputValueChanged()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}
	}
}
