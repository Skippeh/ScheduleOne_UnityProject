namespace ScheduleOne.UI
{
	public class GenericSelectionModule : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.GenericSelectionModule>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas canvas;

		public global::TMPro.TextMeshProUGUI TitleText;

		public global::UnityEngine.RectTransform OptionContainer;

		public global::UnityEngine.UI.Button CloseButton;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject ListOptionPrefab;

		[global::UnityEngine.HideInInspector]
		public bool OptionChosen;

		public bool isOpen { get; protected set; }

		[global::UnityEngine.HideInInspector]
		public int ChosenOptionIndex { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open(string title, global::System.Collections.Generic.List<string> options)
		{
		}

		public void Close()
		{
		}

		public void Cancel()
		{
		}

		private void ClearOptions()
		{
		}

		private void ListOptionClicked(int index)
		{
		}
	}
}
