using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class GenericSelectionModule : Singleton<GenericSelectionModule>
	{
		[Header("References")]
		public Canvas canvas;

		public TextMeshProUGUI TitleText;

		public RectTransform OptionContainer;

		public Button CloseButton;

		[Header("Prefabs")]
		public GameObject ListOptionPrefab;

		[HideInInspector]
		public bool OptionChosen;

		public bool isOpen { get; protected set; }

		[HideInInspector]
		public int ChosenOptionIndex { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		public void Open(string title, List<string> options)
		{
		}

		public void Close()
		{
		}

		public void Cancel()
		{
		}

		private void ClearOptions()
		{
		}

		private void ListOptionClicked(int index)
		{
		}
	}
}
