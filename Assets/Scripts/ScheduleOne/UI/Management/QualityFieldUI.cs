using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class QualityFieldUI : MonoBehaviour
	{
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		public Button[] QualityButtons;

		public List<QualityField> Fields { get; protected set; }

		public void Bind(List<QualityField> field)
		{
		}

		private void Refresh(EQuality value)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void ValueChanged(EQuality value)
		{
		}
	}
}
