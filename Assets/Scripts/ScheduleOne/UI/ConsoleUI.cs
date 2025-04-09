using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class ConsoleUI : MonoBehaviour
	{
		[Header("References")]
		public Canvas canvas;

		public TMP_InputField InputField;

		public GameObject Container;

		public bool IS_CONSOLE_ENABLED => false;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Exit(ExitAction exitAction)
		{
		}

		public void SetIsOpen(bool open)
		{
		}

		public void Submit(string val)
		{
		}
	}
}
