namespace ScheduleOne.UI.Phone.Messages
{
	public class MessagesApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.Messages.MessagesApp>
	{
		[global::System.Serializable]
		public class CategoryInfo
		{
			public global::ScheduleOne.Messaging.EConversationCategory Category;

			public string Name;

			public global::UnityEngine.Color Color;
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.Messaging.MSGConversation> Conversations;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Messaging.MSGConversation> ActiveConversations;

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Messages.MessagesApp.CategoryInfo> categoryInfos;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform conversationEntryContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform conversationContainer;

		public global::UnityEngine.GameObject homePage;

		public global::UnityEngine.GameObject dialoguePage;

		public global::UnityEngine.UI.Text dialoguePageNameText;

		public global::UnityEngine.RectTransform relationshipContainer;

		public global::UnityEngine.UI.Scrollbar relationshipScrollbar;

		public global::ScheduleOne.UI.Tooltips.Tooltip relationshipTooltip;

		public global::UnityEngine.RectTransform debtContainer;

		public global::UnityEngine.UI.Text debtLabel;

		public global::UnityEngine.RectTransform standardsContainer;

		public global::UnityEngine.UI.Image standardsStar;

		public global::ScheduleOne.UI.Tooltips.Tooltip standardsTooltip;

		public global::UnityEngine.RectTransform iconContainerRect;

		public global::UnityEngine.UI.Image iconImage;

		public global::UnityEngine.Sprite BlankAvatarSprite;

		public global::ScheduleOne.UI.Phone.Messages.DealWindowSelector DealWindowSelector;

		public global::ScheduleOne.UI.Phone.PhoneShopInterface PhoneShopInterface;

		public global::ScheduleOne.UI.Phone.CounterofferInterface CounterofferInterface;

		public global::UnityEngine.RectTransform ClearFilterButton;

		public global::UnityEngine.UI.Button[] CategoryButtons;

		public global::ScheduleOne.Audio.AudioSourceController MessageReceivedSound;

		public global::ScheduleOne.Audio.AudioSourceController MessageSentSound;

		public global::ScheduleOne.UI.Phone.Messages.ConfirmationPopup ConfirmationPopup;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject conversationEntryPrefab;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject conversationContainerPrefab;

		public global::UnityEngine.GameObject messageBubblePrefab;

		public global::System.Collections.Generic.List<global::ScheduleOne.Messaging.MSGConversation> unreadConversations;

		public global::ScheduleOne.Messaging.MSGConversation currentConversation { get; private set; }

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		private void Loaded()
		{
		}

		private void Clean()
		{
		}

		public void CreateConversationUI(global::ScheduleOne.Messaging.MSGConversation c, out global::UnityEngine.RectTransform entry, out global::UnityEngine.RectTransform container)
		{
			entry = null;
			container = null;
		}

		public void RepositionEntries()
		{
		}

		public void ReturnButtonClicked()
		{
		}

		public void RefreshNotifications()
		{
		}

		public override void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		public void SetCurrentConversation(global::ScheduleOne.Messaging.MSGConversation conversation)
		{
		}

		public global::ScheduleOne.UI.Phone.Messages.MessagesApp.CategoryInfo GetCategoryInfo(global::ScheduleOne.Messaging.EConversationCategory category)
		{
			return null;
		}

		public void FilterByCategory(int category)
		{
		}

		public void ClearFilter()
		{
		}
	}
}
