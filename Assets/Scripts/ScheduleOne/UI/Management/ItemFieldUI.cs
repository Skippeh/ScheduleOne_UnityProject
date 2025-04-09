using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class ItemFieldUI : MonoBehaviour
	{
		public bool ShowNoneAsAny;

		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		public Image IconImg;

		public TextMeshProUGUI SelectionLabel;

		public GameObject NoneSelected;

		public GameObject MultipleSelected;

		public List<ItemField> Fields { get; protected set; }

		public void Bind(List<ItemField> field)
		{
		}

		private void Refresh(ItemDefinition newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void Clicked()
		{
		}

		private void OptionSelected(ItemSelector.Option option)
		{
		}
	}
}
