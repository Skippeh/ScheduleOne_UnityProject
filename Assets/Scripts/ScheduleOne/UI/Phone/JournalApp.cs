namespace ScheduleOne.UI.Phone
{
	public class JournalApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.JournalApp>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform EntryContainer;

		public global::UnityEngine.UI.Text NoTasksLabel;

		public global::UnityEngine.UI.Text NoDetailsLabel;

		public global::UnityEngine.RectTransform DetailsPanelContainer;

		[global::UnityEngine.Header("Entry prefabs")]
		public global::UnityEngine.GameObject GenericEntry;

		[global::UnityEngine.Header("Details panel prefabs")]
		public global::UnityEngine.GameObject GenericDetailsPanel;

		[global::UnityEngine.Header("Quest Entry prefab")]
		public global::UnityEngine.GameObject GenericQuestEntry;

		[global::UnityEngine.Header("HUD entry prefabs")]
		public global::ScheduleOne.UI.QuestHUDUI QuestHUDUIPrefab;

		public global::ScheduleOne.UI.QuestEntryHUDUI QuestEntryHUDUIPrefab;

		protected global::ScheduleOne.Quests.Quest currentDetailsPanelQuest;

		protected global::UnityEngine.RectTransform currentDetailsPanel;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void SetOpen(bool open)
		{
		}

		protected override void Update()
		{
		}

		private void RefreshDetailsPanel()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected virtual void MinPass()
		{
		}
	}
}
