using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	[Serializable]
	public class DialogueChoiceEntry
	{
		public GameObject gameObject;

		public TextMeshProUGUI text;

		public Button button;

		public GameObject notPossibleGameObject;

		public TextMeshProUGUI notPossibleText;

		public CanvasGroup canvasGroup;
	}
}
