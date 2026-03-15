namespace ScheduleOne
{
	public class UIPopupScreen_ModifyAmountMenu : global::ScheduleOne.UIPopupScreen
	{
		public enum ModifyAmountMenuMode
		{
			Store = 0
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass41_0
		{
			public global::ScheduleOne.UIPopupScreen_ModifyAmountMenu _003C_003E4__this;

			public global::System.Action<float> onConfirm;

			public global::System.Action onCancel;

			internal void _003CRegisterInput_003Eb__0()
			{
			}

			internal void _003CRegisterInput_003Eb__1()
			{
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRegisterInput_003Ed__41 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UIPopupScreen_ModifyAmountMenu _003C_003E4__this;

			public global::System.Action<float> onConfirm;

			public global::System.Action onCancel;

			private global::ScheduleOne.UIPopupScreen_ModifyAmountMenu._003C_003Ec__DisplayClass41_0 _003C_003E8__1;

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
			public _003CRegisterInput_003Ed__41(int _003C_003E1__state)
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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CSelectInputField_003Ed__39 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UIPopupScreen_ModifyAmountMenu _003C_003E4__this;

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
			public _003CSelectInputField_003Ed__39(int _003C_003E1__state)
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

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text titleText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text topMessageText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text bottomMessageText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_InputField amountInputField;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Image itemImage;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text itemNameText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text itemCostText;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UITrigger confirmButton;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UITrigger cancelButton;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Canvas canvas;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button tier1DecreaseButton;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button tier2DecreaseButton;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button tier3DecreaseButton;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button tier1IncreaseButton;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button tier2IncreaseButton;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button tier3IncreaseButton;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text tier1DecreaseText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text tier2DecreaseText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text tier3DecreaseText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text tier1IncreaseText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text tier2IncreaseText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text tier3IncreaseText;

		[global::UnityEngine.SerializeField]
		private float holdThreshold;

		[global::UnityEngine.SerializeField]
		private float repeatInterval;

		private global::ScheduleOne.UIInputDetectBehaviour tier1InputDetect;

		private global::ScheduleOne.UIInputDetectBehaviour tier2InputDetect;

		private global::ScheduleOne.UIInputDetectBehaviour tier3InputDetect;

		private global::ScheduleOne.UIPopupScreen_ModifyAmountMenu.ModifyAmountMenuMode modifyAmountMenuMode;

		private float itemPrice;

		private float minAmount;

		private float tier1Amount;

		private float tier2Amount;

		private float tier3Amount;

		protected override void OnAwake()
		{
		}

		protected override void OnStarted()
		{
		}

		protected override void Update()
		{
		}

		public override void Close()
		{
		}

		private void Open()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UIPopupScreen_ModifyAmountMenu._003CSelectInputField_003Ed__39))]
		private global::System.Collections.IEnumerator SelectInputField()
		{
			return null;
		}

		public override void Open(params object[] args)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UIPopupScreen_ModifyAmountMenu._003CRegisterInput_003Ed__41))]
		private global::System.Collections.IEnumerator RegisterInput(global::System.Action<float> onConfirm, global::System.Action onCancel)
		{
			return null;
		}

		private void UpdateStoreBottomMessage()
		{
		}

		private float GetCurrentAmount()
		{
			return 0f;
		}

		private void ChangeCurrentAmountBasedOnInputDetectTier1(float inputValue)
		{
		}

		private void ChangeCurrentAmountBasedOnInputDetectTier2(float inputValue)
		{
		}

		private void ChangeCurrentAmountBasedOnInputDetectTier3(float inputValue)
		{
		}

		private void ChangeCurrentAmountBasedOnInputDetect(float inputValue, float tierAmount)
		{
		}

		private void ChangeCurrentAmount(float increment)
		{
		}

		private void SetCurrentAmount(float amount)
		{
		}

		private void CapAmount(float amount)
		{
		}
	}
}
