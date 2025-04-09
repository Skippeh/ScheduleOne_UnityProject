using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public abstract class App<T> : PlayerSingleton<T> where T : PlayerSingleton<T>
	{
		public enum EOrientation
		{
			Horizontal = 0,
			Vertical = 1
		}

		public static List<App<T>> Apps;

		[Header("Settings")]
		public string AppName;

		public string IconLabel;

		public Sprite AppIcon;

		public EOrientation Orientation;

		public bool AvailableInTutorial;

		[Header("References")]
		[SerializeField]
		protected RectTransform appContainer;

		protected RectTransform notificationContainer;

		protected Text notificationText;

		protected Button appIconButton;

		public bool isOpen { get; protected set; }

		public static App<T> GetApp(int index)
		{
			return null;
		}

		public override void OnStartClient(bool IsOwner)
		{
		}

		protected override void Start()
		{
		}

		private void Close()
		{
		}

		protected virtual void Update()
		{
		}

		private bool IsHoveringButton()
		{
			return false;
		}

		private void GenerateHomeScreenIcon()
		{
		}

		public void SetNotificationCount(int amount)
		{
		}

		protected virtual void OnPhoneOpened()
		{
		}

		private void ShortcutClicked()
		{
		}

		public virtual void Exit(ExitAction exit)
		{
		}

		public virtual void SetOpen(bool open)
		{
		}
	}
}
