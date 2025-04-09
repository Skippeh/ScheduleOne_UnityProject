using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	public class SettingsDropdown : MonoBehaviour
	{
		public string[] DefaultOptions;

		protected TMP_Dropdown dropdown;

		protected virtual void Awake()
		{
		}

		protected virtual void OnValueChanged(int value)
		{
		}

		protected void AddOption(string option)
		{
		}
	}
}
