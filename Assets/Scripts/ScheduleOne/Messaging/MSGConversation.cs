namespace ScheduleOne.Messaging
{
	[global::System.Serializable]
	public class MSGConversation : global::ScheduleOne.Persistence.ISaveable
	{
		public const int MAX_MESSAGE_HISTORY = 10;

		public string contactName;

		public global::ScheduleOne.NPCs.NPC sender;

		public global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Message> messageHistory;

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Messages.MessageChain> messageChainHistory;

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Messages.MessageBubble> bubbles;

		public global::System.Collections.Generic.List<global::ScheduleOne.Messaging.SendableMessage> Sendables;

		public global::System.Collections.Generic.List<global::ScheduleOne.Messaging.EConversationCategory> Categories;

		public global::UnityEngine.RectTransform entry;

		protected global::UnityEngine.RectTransform container;

		protected global::UnityEngine.RectTransform bubbleContainer;

		protected global::UnityEngine.RectTransform scrollRectContainer;

		protected global::UnityEngine.UI.ScrollRect scrollRect;

		protected global::UnityEngine.UI.Text entryPreviewText;

		protected global::UnityEngine.RectTransform unreadDot;

		protected global::UnityEngine.UI.Slider slider;

		protected global::UnityEngine.UI.Image sliderFill;

		protected global::UnityEngine.RectTransform responseContainer;

		protected global::ScheduleOne.UI.Phone.Messages.MessageSenderInterface senderInterface;

		private bool uiCreated;

		public global::System.Action onMessageRendered;

		public global::System.Action onLoaded;

		public global::System.Action onResponsesShown;

		public global::System.Action onConversationOpened;

		public global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Response> currentResponses;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> responseRects;

		public bool IsSenderKnown { get; protected set; }

		public bool Read { get; private set; }

		public int index { get; protected set; }

		public bool isOpen { get; protected set; }

		public bool rollingOut { get; protected set; }

		public bool EntryVisible { get; protected set; }

		public bool AreResponsesActive => false;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public MSGConversation(global::ScheduleOne.NPCs.NPC _npc, string _contactName)
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public void SetCategories(global::System.Collections.Generic.List<global::ScheduleOne.Messaging.EConversationCategory> cat)
		{
		}

		public void MoveToTop()
		{
		}

		public bool ShouldReplicate()
		{
			return false;
		}

		public int GetReplicationByteSize()
		{
			return 0;
		}

		protected void CreateUI()
		{
		}

		public void EnsureUIExists()
		{
		}

		protected void RefreshPreviewText()
		{
		}

		public void RepositionEntry()
		{
		}

		public void SetIsKnown(bool known)
		{
		}

		public void EntryClicked()
		{
		}

		public void SetOpen(bool open)
		{
		}

		public void DisplayRelationshipInfo()
		{
		}

		protected virtual void RenderMessage(global::ScheduleOne.Messaging.Message m)
		{
		}

		public void SetEntryVisibility(bool v)
		{
		}

		public void SetRead(bool r)
		{
		}

		public void SendMessage(global::ScheduleOne.Messaging.Message message, bool notify = true, bool network = true)
		{
		}

		public void SendMessageChain(global::ScheduleOne.UI.Phone.Messages.MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)
		{
		}

		public global::ScheduleOne.Persistence.Datas.MSGConversationData GetSaveData()
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.MSGConversationData data)
		{
		}

		public void ResetConversation()
		{
		}

		public void SetSliderValue(float value, global::UnityEngine.Color color)
		{
		}

		public global::ScheduleOne.Messaging.Response GetResponse(string label)
		{
			return null;
		}

		public void ShowResponses(global::System.Collections.Generic.List<global::ScheduleOne.Messaging.Response> _responses, float showResponseDelay = 0f, bool network = true)
		{
		}

		protected void CreateResponseUI(global::ScheduleOne.Messaging.Response r)
		{
		}

		private void RefreshResponseContainer()
		{
		}

		protected void ClearResponseUI()
		{
		}

		public void SetResponseContainerVisible(bool v)
		{
		}

		public void ResponseChosen(global::ScheduleOne.Messaging.Response r, bool network)
		{
		}

		public void ClearResponses(bool network = false)
		{
		}

		public global::ScheduleOne.Messaging.SendableMessage CreateSendableMessage(string text)
		{
			return null;
		}

		public void SendPlayerMessage(int sendableIndex, int sentIndex, bool network)
		{
		}

		public void RenderPlayerMessage(global::ScheduleOne.Messaging.SendableMessage sendable)
		{
		}

		private void CheckSendLoop()
		{
		}

		private bool CanSendNewMessage()
		{
			return false;
		}
	}
}
