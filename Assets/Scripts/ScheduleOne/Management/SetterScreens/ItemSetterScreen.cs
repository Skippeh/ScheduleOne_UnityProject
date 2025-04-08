namespace ScheduleOne.Management.SetterScreens
{
	public class ItemSetterScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Management.SetterScreens.ItemSetterScreen>
	{
		private class Pair
		{
			public string prefabID;

			public global::UnityEngine.RectTransform entry;
		}

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject ListEntryPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform EntryContainer;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		private global::UnityEngine.RectTransform allEntry;

		private global::UnityEngine.RectTransform noneEntry;

		private global::System.Collections.Generic.List<global::ScheduleOne.Management.SetterScreens.ItemSetterScreen.Pair> pairs;

		public global::ScheduleOne.Management.Presets.Options.ItemList Option { get; private set; }

		public bool IsOpen => false;

		protected override void Awake()
		{
		}

		public virtual void Open(global::ScheduleOne.Management.Presets.Options.ItemList option)
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public virtual void Close()
		{
		}

		private global::UnityEngine.RectTransform CreateEntry(global::UnityEngine.Sprite icon, string label, global::System.Action onClick, string prefabID = "", bool createPair = false)
		{
			return null;
		}

		private void AllClicked()
		{
		}

		private void NoneClicked()
		{
		}

		private void EntryClicked(string prefabID)
		{
		}

		private void RefreshTicks()
		{
		}

		private void SetEntryTicked(global::UnityEngine.RectTransform entry, bool ticked)
		{
		}

		private void CreateEntries()
		{
		}

		private void DestroyEntries()
		{
		}
	}
}
