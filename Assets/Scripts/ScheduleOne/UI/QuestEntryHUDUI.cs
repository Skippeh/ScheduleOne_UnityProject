using ScheduleOne.Quests;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class QuestEntryHUDUI : MonoBehaviour
	{
		[Header("References")]
		public TextMeshProUGUI MainLabel;

		public Animation Animation;

		public QuestEntry QuestEntry { get; private set; }

		public void Initialize(QuestEntry entry)
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
