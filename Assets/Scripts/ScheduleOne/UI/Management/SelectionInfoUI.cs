using System.Collections.Generic;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class SelectionInfoUI : MonoBehaviour
	{
		[Header("References")]
		public Image Icon;

		public TextMeshProUGUI Title;

		[Header("Settings")]
		public bool SelfUpdate;

		public Sprite NonUniformTypeSprite;

		public Sprite CrossSprite;

		private void Update()
		{
		}

		public void Set(List<IConfigurable> Configurables)
		{
		}
	}
}
