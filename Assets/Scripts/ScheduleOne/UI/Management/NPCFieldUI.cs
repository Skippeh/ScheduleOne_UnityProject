using System.Collections.Generic;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class NPCFieldUI : MonoBehaviour
	{
		[Header("References")]
		public TextMeshProUGUI FieldLabel;

		public Image IconImg;

		public TextMeshProUGUI SelectionLabel;

		public GameObject NoneSelected;

		public GameObject MultipleSelected;

		public RectTransform ClearButton;

		public List<NPCField> Fields { get; protected set; }

		public void Bind(List<NPCField> field)
		{
		}

		private void Refresh(NPC newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void Clicked()
		{
		}

		public void NPCSelected(NPC npc)
		{
		}

		public void ClearClicked()
		{
		}
	}
}
