namespace ScheduleOne.UI.Phone.Messages
{
	public class MessageSenderInterface : global::UnityEngine.MonoBehaviour
	{
		public enum EVisibility
		{
			Hidden = 0,
			Docked = 1,
			Expanded = 2
		}

		public global::ScheduleOne.UI.Phone.Messages.MessageSenderInterface.EVisibility Visibility;

		[global::UnityEngine.Header("Settings")]
		public float DockedMenuYPos;

		public float ExpandedMenuYPos;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Menu;

		public global::UnityEngine.RectTransform SendablesContainer;

		public global::UnityEngine.RectTransform[] DockedUIElements;

		public global::UnityEngine.RectTransform[] ExpandedUIElements;

		public global::UnityEngine.UI.Button ComposeButton;

		public global::UnityEngine.UI.Button[] CancelButtons;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Messages.MessageBubble> sendableBubbles;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.UI.Phone.Messages.MessageBubble, global::ScheduleOne.Messaging.SendableMessage> sendableMap;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		public void SetVisibility(global::ScheduleOne.UI.Phone.Messages.MessageSenderInterface.EVisibility visibility)
		{
		}

		public void UpdateSendables()
		{
		}

		public void AddSendable(global::ScheduleOne.Messaging.SendableMessage sendable)
		{
		}

		protected virtual void SendableSelected(global::ScheduleOne.Messaging.SendableMessage sendable)
		{
		}
	}
}
