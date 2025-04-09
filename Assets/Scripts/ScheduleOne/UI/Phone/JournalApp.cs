using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	public class JournalApp : App<JournalApp>
	{
		[Header("References")]
		public RectTransform EntryContainer;

		public Text NoTasksLabel;

		public Text NoDetailsLabel;

		public RectTransform DetailsPanelContainer;

		[Header("Entry prefabs")]
		public GameObject GenericEntry;

		[Header("Details panel prefabs")]
		public GameObject GenericDetailsPanel;

		[Header("Quest Entry prefab")]
		public GameObject GenericQuestEntry;

		[Header("HUD entry prefabs")]
		public QuestHUDUI QuestHUDUIPrefab;

		public QuestEntryHUDUI QuestEntryHUDUIPrefab;

		protected Quest currentDetailsPanelQuest;

		protected RectTransform currentDetailsPanel;

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
