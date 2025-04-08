namespace ScheduleOne.DevUtilities
{
	public class RebindActionUI : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class UpdateBindingUIEvent : global::UnityEngine.Events.UnityEvent<global::ScheduleOne.DevUtilities.RebindActionUI, string, string, string>
		{
		}

		[global::System.Serializable]
		public class InteractiveRebindEvent : global::UnityEngine.Events.UnityEvent<global::ScheduleOne.DevUtilities.RebindActionUI, global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation>
		{
		}

		public global::System.Action onRebind;

		[global::UnityEngine.Tooltip("Reference to action that is to be rebound from the UI.")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.InputSystem.InputActionReference m_Action;

		[global::UnityEngine.SerializeField]
		private string m_BindingId;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions m_DisplayStringOptions;

		[global::UnityEngine.Tooltip("Text label that will receive the name of the action. Optional. Set to None to have the rebind UI not show a label for the action.")]
		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI m_ActionLabel;

		[global::UnityEngine.Tooltip("Text label that will receive the current, formatted binding string.")]
		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI m_BindingText;

		[global::UnityEngine.Tooltip("Optional UI that will be shown while a rebind is in progress.")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject m_RebindOverlay;

		[global::UnityEngine.Tooltip("Optional text label that will be updated with prompt for user input.")]
		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI m_RebindText;

		[global::UnityEngine.Tooltip("Event that is triggered when the way the binding is display should be updated. This allows displaying bindings in custom ways, e.g. using images instead of text.")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent;

		[global::UnityEngine.Tooltip("Event that is triggered when an interactive rebind is being initiated. This can be used, for example, to implement custom UI behavior while a rebind is in progress. It can also be used to further customize the rebind.")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.RebindActionUI.InteractiveRebindEvent m_RebindStartEvent;

		[global::UnityEngine.Tooltip("Event that is triggered when an interactive rebind is complete or has been aborted.")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.RebindActionUI.InteractiveRebindEvent m_RebindStopEvent;

		private global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation m_RebindOperation;

		private static global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.RebindActionUI> s_RebindActionUIs;

		public global::UnityEngine.InputSystem.InputActionReference actionReference
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string bindingId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions displayStringOptions
		{
			get
			{
				return default(global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions);
			}
			set
			{
			}
		}

		public global::TMPro.TextMeshProUGUI actionLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::TMPro.TextMeshProUGUI bindingText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::TMPro.TextMeshProUGUI rebindPrompt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.GameObject rebindOverlay
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::ScheduleOne.DevUtilities.RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent => null;

		public global::ScheduleOne.DevUtilities.RebindActionUI.InteractiveRebindEvent startRebindEvent => null;

		public global::ScheduleOne.DevUtilities.RebindActionUI.InteractiveRebindEvent stopRebindEvent => null;

		public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation ongoingRebind => null;

		public bool ResolveActionAndBinding(out global::UnityEngine.InputSystem.InputAction action, out int bindingIndex)
		{
			action = null;
			bindingIndex = default(int);
			return false;
		}

		public void UpdateBindingDisplay()
		{
		}

		public void ResetToDefault()
		{
		}

		public void StartInteractiveRebind()
		{
		}

		private void PerformInteractiveRebind(global::UnityEngine.InputSystem.InputAction action, int bindingIndex, bool allCompositeParts = false)
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		private static void OnActionChange(object obj, global::UnityEngine.InputSystem.InputActionChange change)
		{
		}

		private void UpdateActionLabel()
		{
		}
	}
}
