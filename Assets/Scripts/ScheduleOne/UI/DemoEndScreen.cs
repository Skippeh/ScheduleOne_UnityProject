using EasyButtons;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class DemoEndScreen : MonoBehaviour
	{
		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public bool IsOpen { get; private set; }

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[Button]
		public void Open()
		{
		}

		private void Update()
		{
		}

		public void Close()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		public void LinkClicked()
		{
		}
	}
}
