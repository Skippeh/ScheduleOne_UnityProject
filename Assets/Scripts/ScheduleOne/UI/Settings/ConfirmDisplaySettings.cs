using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	public class ConfirmDisplaySettings : MonoBehaviour
	{
		public const float RevertTime = 15f;

		public TextMeshProUGUI SubtitleLabel;

		private float timeUntilRevert;

		private DisplaySettings oldSettings;

		private DisplaySettings newSettings;

		public bool IsOpen => false;

		public void Awake()
		{
		}

		public void Open(DisplaySettings _oldSettings, DisplaySettings _newSettings)
		{
		}

		public void Exit(ExitAction action)
		{
		}

		public void Update()
		{
		}

		public void Close(bool revert)
		{
		}
	}
}
