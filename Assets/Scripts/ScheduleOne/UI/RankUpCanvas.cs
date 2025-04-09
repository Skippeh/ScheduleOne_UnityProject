using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.Levelling;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class RankUpCanvas : MonoBehaviour, IPostSleepEvent
	{
		public Animation OpenCloseAnim;

		public Animation RankUpAnim;

		public TextMeshProUGUI OldRankLabel;

		public TextMeshProUGUI NewRankLabel;

		public Canvas Canvas;

		public GameObject UnlockedItemsContainer;

		public RectTransform[] UnlockedItems;

		public TextMeshProUGUI ExtraUnlocksLabel;

		public AudioSourceController SoundEffect;

		public Slider ProgressSlider;

		public TextMeshProUGUI ProgressLabel;

		public AudioSourceController BlipSound;

		public AudioSourceController ClickSound;

		private Coroutine coroutine;

		private List<Tuple<FullRank, FullRank>> queuedRankUps;

		public bool IsRunning { get; private set; }

		public int Order { get; private set; }

		public void Start()
		{
		}

		private void QueuePostSleepEvent()
		{
		}

		public void StartEvent()
		{
		}

		public void EndEvent()
		{
		}

		public void RankUp(FullRank oldRank, FullRank newRank)
		{
		}

		private void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound)
		{
		}
	}
}
