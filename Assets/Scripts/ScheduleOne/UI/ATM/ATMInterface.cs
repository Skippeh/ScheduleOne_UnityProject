using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.ATM
{
	public class ATMInterface : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CProcessTransaction_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ATMInterface _003C_003E4__this;

			public bool depositing;

			public float amount;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CProcessTransaction_003Ed__56(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		[SerializeField]
		protected ScheduleOne.Money.ATM atm;

		[SerializeField]
		protected AudioSourceController CompleteSound;

		[Header("Menu")]
		[SerializeField]
		protected RectTransform menuScreen;

		[SerializeField]
		protected Text menu_TitleText;

		[SerializeField]
		protected Button menu_DepositButton;

		[SerializeField]
		protected Button menu_WithdrawButton;

		[Header("Top bar")]
		[SerializeField]
		protected Text depositLimitText;

		[SerializeField]
		protected Text onlineBalanceText;

		[SerializeField]
		protected Text cleanCashText;

		[SerializeField]
		protected RectTransform depositLimitContainer;

		[Header("Amount screen")]
		[SerializeField]
		protected RectTransform amountSelectorScreen;

		[SerializeField]
		protected Text amountSelectorTitle;

		[SerializeField]
		protected List<Button> amountButtons;

		[SerializeField]
		protected Text amountLabelText;

		[SerializeField]
		protected RectTransform amountBackground;

		[SerializeField]
		protected RectTransform selectedButtonIndicator;

		[SerializeField]
		protected Button confirmAmountButton;

		[SerializeField]
		protected Text confirmButtonText;

		[Header("Processing screen")]
		[SerializeField]
		protected RectTransform processingScreen;

		[SerializeField]
		protected RectTransform processingScreenIndicator;

		[Header("Success screen")]
		[SerializeField]
		protected RectTransform successScreen;

		[SerializeField]
		protected Text successScreenSubtitle;

		[SerializeField]
		protected Button doneButton;

		private RectTransform activeScreen;

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

		public virtual void Exit(ExitAction action)
		{
		}

		public void SetActiveScreen(RectTransform screen)
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

		[IteratorStateMachine(typeof(_003CProcessTransaction_003Ed__56))]
		protected IEnumerator ProcessTransaction(float amount, bool depositing)
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
