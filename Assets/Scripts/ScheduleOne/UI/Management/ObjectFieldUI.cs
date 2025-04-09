using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class ObjectFieldUI : MonoBehaviour
	{
		[Header("References")]
		public string InstructionText;

		public string ExtendedInstructionText;

		public TextMeshProUGUI FieldLabel;

		public Image IconImg;

		public TextMeshProUGUI SelectionLabel;

		public GameObject NoneSelected;

		public GameObject MultipleSelected;

		public RectTransform ClearButton;

		public List<ObjectField> Fields { get; protected set; }

		public void Bind(List<ObjectField> field)
		{
		}

		private void Refresh(BuildableItem newVal)
		{
		}

		private bool AreFieldsUniform()
		{
			return false;
		}

		public void Clicked()
		{
		}

		private bool ObjectValid(BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void ObjectsSelected(List<BuildableItem> objs)
		{
		}

		private void ObjectSelected(BuildableItem obj)
		{
		}

		public void ClearClicked()
		{
		}
	}
}
