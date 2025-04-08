namespace ScheduleOne.UI
{
	public class QuestEntryHUDUI : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI MainLabel;

		public global::UnityEngine.Animation Animation;

		public global::ScheduleOne.Quests.QuestEntry QuestEntry { get; private set; }

		public void Initialize(global::ScheduleOne.Quests.QuestEntry entry)
		{
		}

		public void Destroy()
		{
		}

		public virtual void UpdateUI()
		{
		}

		private void FadeIn()
		{
		}

		private void EntryEnded()
		{
		}

		private void FadeOut()
		{
		}

		private void Complete()
		{
		}
	}
}
