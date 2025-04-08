namespace ScheduleOne.UI
{
	public class LaunderingInterface : global::UnityEngine.MonoBehaviour
	{
		protected const float fovOverride = 65f;

		protected const float lerpTime = 0.15f;

		protected const int minLaunderAmount = 10;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform cameraPosition;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject intObj;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button launderButton;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject amountSelectorScreen;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Slider amountSlider;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TMP_InputField amountInputField;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform notchContainer;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI currentTotalAmountLabel;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI launderCapacityLabel;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI insufficientCashLabel;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform entryContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform noEntries;

		public global::ScheduleOne.ObjectScripts.Cash.CashStackVisuals[] CashStacks;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject timelineNotchPrefab;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject entryPrefab;

		[global::UnityEngine.Header("UI references")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Canvas canvas;

		private int selectedAmountToLaunder;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Property.LaunderingOperation, global::UnityEngine.RectTransform> operationToNotch;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> notches;

		private bool ignoreSliderChange;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Property.LaunderingOperation, global::UnityEngine.RectTransform> operationToEntry;

		protected int maxLaunderAmount => 0;

		public global::ScheduleOne.Property.Business business { get; private set; }

		public bool isOpen => false;

		public void Initialize(global::ScheduleOne.Property.Business bus)
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void MinPass()
		{
		}

		protected void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		protected void UpdateTimeline()
		{
		}

		protected void UpdateCurrentTotal()
		{
		}

		private void CreateEntry(global::ScheduleOne.Property.LaunderingOperation op)
		{
		}

		private void RemoveEntry(global::ScheduleOne.Property.LaunderingOperation op)
		{
		}

		private void UpdateEntryTimes()
		{
		}

		private void UpdateCashStacks(global::ScheduleOne.Property.LaunderingOperation op)
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
