using System;
using ScheduleOne.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class QuestHUDUI : MonoBehaviour
	{
		public string CriticalTimeColor;

		[Header("References")]
		public RectTransform EntryContainer;

		public TextMeshProUGUI MainLabel;

		public VerticalLayoutGroup hudUILayout;

		public Animation Animation;

		public RectTransform Shade;

		public Action onUpdateUI;

		public Quest Quest { get; private set; }

		public void Initialize(Quest quest)
		{
		}

		public void Destroy()
		{
		}

		public void UpdateUI()
		{
		}

		public void UpdateMainLabel()
		{
		}

		public void UpdateExpiry()
		{
		}

		public void UpdateShade()
		{
		}

		public void BopIcon()
		{
		}

		private void FadeIn()
		{
		}

		private void EntryEnded(EQuestState endState)
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
