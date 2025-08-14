namespace ScheduleOne.UI.Phone.Messages
{
	public class ConfirmationPopup : global::UnityEngine.MonoBehaviour
	{
		public enum EResponse
		{
			Confirm = 0,
			Cancel = 1
		}

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.UI.Text TitleLabel;

		public global::UnityEngine.UI.Text MessageLabel;

		public global::UnityEngine.UI.Button ConfirmButton;

		public global::UnityEngine.UI.Button CancelButton;

		private global::ScheduleOne.Messaging.MSGConversation conversation;

		private global::System.Action<global::ScheduleOne.UI.Phone.Messages.ConfirmationPopup.EResponse> responseCallback;

		public bool IsOpen { get; private set; }

		private void Start()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open(string title, string message, global::ScheduleOne.Messaging.MSGConversation conv, global::System.Action<global::ScheduleOne.UI.Phone.Messages.ConfirmationPopup.EResponse> callback)
		{
		}

		public void Close(global::ScheduleOne.UI.Phone.Messages.ConfirmationPopup.EResponse outcome)
		{
		}

		private void Confirm()
		{
		}

		private void Cancel()
		{
		}
	}
}
