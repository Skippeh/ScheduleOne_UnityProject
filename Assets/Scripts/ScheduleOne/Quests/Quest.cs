namespace ScheduleOne.Quests
{
	[global::System.Serializable]
	public class Quest : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.ISaveable
	{
		public const int MAX_HUD_ENTRY_LABELS = 10;

		public const int CriticalExpiryThreshold = 120;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Quests.Quest> Quests;

		public static global::ScheduleOne.Quests.Quest HoveredQuest;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Quests.Quest> ActiveQuests;

		[global::UnityEngine.Header("Basic Settings")]
		[global::UnityEngine.SerializeField]
		protected string title;

		public string Subtitle;

		public global::System.Action onSubtitleChanged;

		[global::UnityEngine.TextArea(3, 10)]
		public string Description;

		public string StaticGUID;

		public bool TrackOnBegin;

		public global::ScheduleOne.Quests.EExpiryVisibility ExpiryVisibility;

		public bool AutoCompleteOnAllEntriesComplete;

		public bool PlayQuestCompleteSound;

		public int CompletionXP;

		[global::UnityEngine.Header("Entries")]
		public bool AutoStartFirstEntry;

		public global::System.Collections.Generic.List<global::ScheduleOne.Quests.QuestEntry> Entries;

		[global::UnityEngine.Header("UI")]
		public global::UnityEngine.RectTransform IconPrefab;

		[global::UnityEngine.Header("PoI Settings")]
		public global::UnityEngine.GameObject PoIPrefab;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onQuestBegin;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Quests.EQuestState> onQuestEnd;

		public global::UnityEngine.Events.UnityEvent onActiveState;

		public global::UnityEngine.Events.UnityEvent<bool> onTrackChange;

		public global::UnityEngine.Events.UnityEvent onComplete;

		public global::UnityEngine.Events.UnityEvent onInitialComplete;

		[global::UnityEngine.Header("Reminders")]
		public bool ShouldSendExpiryReminder;

		public bool ShouldSendExpiredNotification;

		protected global::UnityEngine.RectTransform journalEntry;

		protected global::UnityEngine.RectTransform entryTitleRect;

		protected global::UnityEngine.RectTransform trackedRect;

		protected global::UnityEngine.UI.Text entryTimeLabel;

		protected global::UnityEngine.UI.Image criticalTimeBackground;

		protected global::UnityEngine.RectTransform detailPanel;

		public global::System.Action onHudUICreated;

		private bool expiryReminderSent;

		private global::ScheduleOne.UI.Compass.CompassManager.Element compassElement;

		protected bool autoInitialize;

		public global::ScheduleOne.Quests.EQuestState State { get; protected set; }

		public global::System.Guid GUID { get; protected set; }

		public bool IsTracked { get; protected set; }

		public int ActiveEntryCount => 0;

		public string Title => null;

		public bool Expires { get; protected set; }

		public global::ScheduleOne.GameTime.GameDateTime Expiry { get; protected set; }

		public bool hudUIExists => false;

		public global::ScheduleOne.UI.QuestHUDUI hudUI { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public bool HasChanged { get; set; }

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void InitializeQuest(string title, string description, global::ScheduleOne.Persistence.Datas.QuestEntryData[] entries, string guid)
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public void ConfigureExpiry(bool expires, global::ScheduleOne.GameTime.GameDateTime expiry)
		{
		}

		public virtual void Begin(bool network = true)
		{
		}

		public virtual void Complete(bool network = true)
		{
		}

		public virtual void Fail(bool network = true)
		{
		}

		public virtual void Expire(bool network = true)
		{
		}

		public virtual void Cancel(bool network = true)
		{
		}

		public virtual void End()
		{
		}

		public virtual void SetQuestState(global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}

		protected virtual bool ShouldShowJournalEntry()
		{
			return false;
		}

		public virtual void SetQuestEntryState(int entryIndex, global::ScheduleOne.Quests.EQuestState state, bool network = true)
		{
		}

		protected virtual void OnMinPass()
		{
		}

		protected virtual void OnUncappedMinPass()
		{
		}

		protected virtual void CheckExpiry()
		{
		}

		private void CheckAutoComplete()
		{
		}

		protected virtual bool CanExpire()
		{
			return false;
		}

		protected virtual void SendExpiryReminder()
		{
		}

		protected virtual void SendExpiredNotification()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public void SetSubtitle(string subtitle)
		{
		}

		public virtual void SetIsTracked(bool tracked)
		{
		}

		public virtual void SetupJournalEntry()
		{
		}

		private void DestroyJournalEntry()
		{
		}

		private void JournalEntryClicked()
		{
		}

		private void JournalEntryHoverStart()
		{
		}

		public int GetMinsUntilExpiry()
		{
			return 0;
		}

		public string GetExpiryText()
		{
			return null;
		}

		public virtual global::ScheduleOne.UI.QuestHUDUI SetupHUDUI()
		{
			return null;
		}

		public void UpdateHUDUI()
		{
		}

		public void DestroyHUDUI()
		{
		}

		public void BopHUDUI()
		{
		}

		public virtual string GetQuestTitle()
		{
			return null;
		}

		public global::ScheduleOne.Quests.QuestEntry GetFirstActiveEntry()
		{
			return null;
		}

		public virtual global::UnityEngine.RectTransform CreateDetailDisplay(global::UnityEngine.RectTransform parent)
		{
			return null;
		}

		public void DestroyDetailDisplay()
		{
		}

		public virtual bool ShouldSave()
		{
			return false;
		}

		public virtual global::ScheduleOne.Persistence.Datas.SaveData GetSaveData()
		{
			return null;
		}

		public string GetSaveString()
		{
			return null;
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.QuestData data)
		{
		}

		public static global::ScheduleOne.Quests.Quest GetQuest(string questName)
		{
			return null;
		}
	}
}
