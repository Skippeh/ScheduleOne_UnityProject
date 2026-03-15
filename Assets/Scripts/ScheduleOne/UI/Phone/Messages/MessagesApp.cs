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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelaySelect_003Ed__56 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.Messages.MessagesApp _003C_003E4__this;

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
			public _003CDelaySelect_003Ed__56(int _003C_003E1__state)
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
		private sealed class _003CDelaySelectCurrentSelectedSelectable_003Ed__55 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.Messages.MessagesApp _003C_003E4__this;

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
			public _003CDelaySelectCurrentSelectedSelectable_003Ed__55(int _003C_003E1__state)
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
		private sealed class _003CDelaySelectDialogueUIPanel_003Ed__58 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.Messages.MessagesApp _003C_003E4__this;

			public global::ScheduleOne.UIPanel uIPanel;

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
			public _003CDelaySelectDialogueUIPanel_003Ed__58(int _003C_003E1__state)
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

		[global::UnityEngine.Header("Custom UI")]
		public global::ScheduleOne.UIScreen mainMessagesUIScreen;

		public global::ScheduleOne.UIPanel mainMessagesUIPanel;

		public global::ScheduleOne.UIScreen dialogueMainUIScreen;

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

		public override void SetOpen(bool open)
		{
		}

		protected override void OnPhoneOpened()
		{
		}

		private void SelectMessageSelectable()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.Messages.MessagesApp._003CDelaySelectCurrentSelectedSelectable_003Ed__55))]
		private global::System.Collections.IEnumerator DelaySelectCurrentSelectedSelectable()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.Messages.MessagesApp._003CDelaySelect_003Ed__56))]
		private global::System.Collections.IEnumerator DelaySelect()
		{
			return null;
		}

		public void SelectDialogueUIPanel(global::ScheduleOne.UIPanel uIPanel)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.Messages.MessagesApp._003CDelaySelectDialogueUIPanel_003Ed__58))]
		private global::System.Collections.IEnumerator DelaySelectDialogueUIPanel(global::ScheduleOne.UIPanel uIPanel)
		{
			return null;
		}
	}
}
