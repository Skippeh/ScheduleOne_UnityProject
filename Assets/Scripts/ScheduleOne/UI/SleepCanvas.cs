using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class SleepCanvas : Singleton<SleepCanvas>
	{
		public const int MaxSleepTime = 12;

		public const int MinSleepTime = 4;

		private float QueuedMessageDisplayTime;

		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public RectTransform MenuContainer;

		public TextMeshProUGUI CurrentTimeLabel;

		public Button IncreaseButton;

		public Button DecreaseButton;

		public TextMeshProUGUI EndTimeLabel;

		public Button SleepButton;

		public TextMeshProUGUI SleepButtonLabel;

		public Image BlackOverlay;

		public TextMeshProUGUI SleepMessageLabel;

		public CanvasGroup SleepMessageGroup;

		public TextMeshProUGUI TimeLabel;

		public TextMeshProUGUI WakeLabel;

		public TextMeshProUGUI WaitingForHostLabel;

		public UnityEvent onSleepFullyFaded;

		public UnityEvent onSleepEndFade;

		private List<IPostSleepEvent> queuedPostSleepEvents;

		public bool IsMenuOpen { get; protected set; }

		public string QueuedSleepMessage { get; protected set; }

		protected override void Awake()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		public void SetIsOpen(bool open)
		{
		}

		public void Update()
		{
		}

		public void AddPostSleepEvent(IPostSleepEvent postSleepEvent)
		{
		}

		private void UpdateHourSetting()
		{
		}

		private void UpdateTimeLabels()
		{
		}

		private void UpdateSleepButton()
		{
		}

		private void ChangeSleepAmount(int change)
		{
		}

		private int ClampWakeTime(int time)
		{
			return 0;
		}

		private int ClampTime(int time, int startTime, int endTime)
		{
			return 0;
		}

		private void SleepButtonPressed()
		{
		}

		private void SleepStart()
		{
		}

		private void LerpBlackOverlay(float transparency, float lerpTime)
		{
		}

		public void QueueSleepMessage(string message, float displayTime = 3f)
		{
		}
	}
}
