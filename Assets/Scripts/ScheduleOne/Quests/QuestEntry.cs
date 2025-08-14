namespace ScheduleOne.Quests
{
	[global::System.Serializable]
	public class QuestEntry : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Naming")]
		[global::UnityEngine.SerializeField]
		protected string EntryTitle;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Quests.EQuestState state;

		[global::UnityEngine.Header("Settings")]
		public bool AutoComplete;

		public global::ScheduleOne.Variables.Conditions AutoCompleteConditions;

		public bool CompleteParentQuest;

		public string EntryAddedIn;

		[global::UnityEngine.Header("PoI Settings")]
		public bool AutoCreatePoI;

		public global::UnityEngine.Transform PoILocation;

		public bool AutoUpdatePoILocation;

		public global::ScheduleOne.Map.POI PoI;

		public global::UnityEngine.Events.UnityEvent onStart;

		public global::UnityEngine.Events.UnityEvent onEnd;

		public global::UnityEngine.Events.UnityEvent onComplete;

		public global::UnityEngine.Events.UnityEvent onInitialComplete;

		private global::ScheduleOne.UI.Compass.CompassManager.Element compassElement;

		private global::ScheduleOne.UI.QuestEntryHUDUI entryUI;

		private global::UnityEngine.RectTransform PoIIcon;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		[field: global::System.NonSerialized]
		public global::ScheduleOne.Quests.Quest ParentQuest { get; private set; }

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public string Title => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.Quests.EQuestState State => default(global::ScheduleOne.Quests.EQuestState);

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnValidate()
		{
		}

		public virtual void MinPass()
		{
		}

		public void SetData(global::ScheduleOne.Persistence.Datas.QuestEntryData data)
		{
		}

		public void Begin()
		{
		}

		public void Complete()
		{
		}

		public void SetActive(bool network = true)
		{
		}

		public virtual void SetState(global::ScheduleOne.Quests.EQuestState newState, bool network = true)
		{
		}

		protected virtual bool ShouldShowPoI()
		{
			return false;
		}

		protected virtual void UpdatePoI()
		{
		}

		public void SetPoILocation(global::UnityEngine.Vector3 location)
		{
		}

		public void CreatePoI()
		{
		}

		public void DestroyPoI()
		{
		}

		public void CreateCompassElement()
		{
		}

		public void UpdateCompassElement()
		{
		}

		public global::ScheduleOne.Persistence.Datas.QuestEntryData GetSaveData()
		{
			return null;
		}

		private void UpdateName()
		{
		}

		private void EvaluateConditions()
		{
		}

		public void SetEntryTitle(string newTitle)
		{
		}

		protected virtual void CreateEntryUI()
		{
		}

		public virtual void UpdateEntryUI()
		{
		}
	}
}
