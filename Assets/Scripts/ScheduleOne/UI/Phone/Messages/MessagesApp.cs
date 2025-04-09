using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using ScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	public class MessagesApp : App<MessagesApp>
	{
		[Serializable]
		public class CategoryInfo
		{
			public EConversationCategory Category;

			public string Name;

			public Color Color;
		}

		public static List<MSGConversation> Conversations;

		public static List<MSGConversation> ActiveConversations;

		public List<CategoryInfo> categoryInfos;

		[Header("References")]
		[SerializeField]
		protected RectTransform conversationEntryContainer;

		[SerializeField]
		protected RectTransform conversationContainer;

		public GameObject homePage;

		public GameObject dialoguePage;

		public Text dialoguePageNameText;

		public RectTransform relationshipContainer;

		public Scrollbar relationshipScrollbar;

		public Tooltip relationshipTooltip;

		public RectTransform standardsContainer;

		public Image standardsStar;

		public Tooltip standardsTooltip;

		public RectTransform iconContainerRect;

		public Image iconImage;

		public Sprite BlankAvatarSprite;

		public DealWindowSelector DealWindowSelector;

		public PhoneShopInterface PhoneShopInterface;

		public CounterofferInterface CounterofferInterface;

		public RectTransform ClearFilterButton;

		public Button[] CategoryButtons;

		public AudioSourceController MessageReceivedSound;

		public AudioSourceController MessageSentSound;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject conversationEntryPrefab;

		[SerializeField]
		protected GameObject conversationContainerPrefab;

		public GameObject messageBubblePrefab;

		public List<MSGConversation> unreadConversations;

		public MSGConversation currentConversation { get; private set; }

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

		public void CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container)
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

		public override void Exit(ExitAction exit)
		{
		}

		public void SetCurrentConversation(MSGConversation conversation)
		{
		}

		public CategoryInfo GetCategoryInfo(EConversationCategory category)
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
