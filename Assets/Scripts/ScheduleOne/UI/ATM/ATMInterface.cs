namespace ScheduleOne.UI.ATM
{
	public class ATMInterface : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CProcessTransaction_003Ed__56 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.ATM.ATMInterface _003C_003E4__this;

			public bool depositing;

			public float amount;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CProcessTransaction_003Ed__56(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Canvas canvas;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Money.ATM atm;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Audio.AudioSourceController CompleteSound;

		[global::UnityEngine.Header("Menu")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform menuScreen;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text menu_TitleText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button menu_DepositButton;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button menu_WithdrawButton;

		[global::UnityEngine.Header("Top bar")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text depositLimitText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text onlineBalanceText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text cleanCashText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform depositLimitContainer;

		[global::UnityEngine.Header("Amount screen")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform amountSelectorScreen;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text amountSelectorTitle;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.UI.Button> amountButtons;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text amountLabelText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform amountBackground;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform selectedButtonIndicator;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button confirmAmountButton;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text confirmButtonText;

		[global::UnityEngine.Header("Processing screen")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform processingScreen;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform processingScreenIndicator;

		[global::UnityEngine.Header("Success screen")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform successScreen;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text successScreenSubtitle;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button doneButton;

		private global::UnityEngine.RectTransform activeScreen;

		public static int[] amounts;

		private bool depositing;

		private int selectedAmountIndex;

		private float selectedAmount;

		public bool isOpen { get; protected set; }

		private float relevantBalance => 0f;

		private static float remainingAllowedDeposit => 0f;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Start()
		{
		}

		private void PlayerSpawned()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public virtual void SetIsOpen(bool o)
		{
		}

		public virtual void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void SetActiveScreen(global::UnityEngine.RectTransform screen)
		{
		}

		private void DefaultAmountSelection()
		{
		}

		public void DepositButtonPressed()
		{
		}

		public void WithdrawButtonPressed()
		{
		}

		public void CancelAmountSelection()
		{
		}

		public void AmountSelected(int amountIndex)
		{
		}

		private void SetSelectedAmount(float amount)
		{
		}

		public static float GetAmountFromIndex(int index, bool depositing)
		{
			return 0f;
		}

		private void UpdateAvailableAmounts()
		{
		}

		public void AmountConfirmed()
		{
		}

		public void ChangeAmount(float amount)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.ATM.ATMInterface._003CProcessTransaction_003Ed__56))]
		protected global::System.Collections.IEnumerator ProcessTransaction(float amount, bool depositing)
		{
			return null;
		}

		public void DoneButtonPressed()
		{
		}

		public void ReturnToMenuButtonPressed()
		{
		}
	}
}
