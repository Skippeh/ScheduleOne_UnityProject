using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	public class CharacterCreatorMenu : MonoBehaviour
	{
		[Serializable]
		public class Window
		{
			public string Name;

			public RectTransform Container;

			public void Open()
			{
			}

			public void Close()
			{
			}
		}

		public Window[] Windows;

		[Header("References")]
		public TextMeshProUGUI CategoryLabel;

		public Button BackButton;

		public Button NextButton;

		private int openWindowIndex;

		private Window openWindow;

		public void Start()
		{
		}

		public void OpenWindow(int index)
		{
		}

		public void Back()
		{
		}

		public void Next()
		{
		}
	}
}
