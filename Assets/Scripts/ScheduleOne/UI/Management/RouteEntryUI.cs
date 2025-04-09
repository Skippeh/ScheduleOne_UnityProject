using System.Collections.Generic;
using ScheduleOne.Management;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class RouteEntryUI : MonoBehaviour
	{
		[Header("References")]
		public TextMeshProUGUI SourceLabel;

		public TextMeshProUGUI DestinationLabel;

		public Image FilterIcon;

		public UnityEvent onDeleteClicked;

		private bool settingSource;

		private bool settingDestination;

		public AdvancedTransitRoute AssignedRoute { get; private set; }

		public void AssignRoute(AdvancedTransitRoute route)
		{
		}

		public void ClearRoute()
		{
		}

		public void RefreshUI()
		{
		}

		public void SourceClicked()
		{
		}

		public void DestinationClicked()
		{
		}

		public void FilterClicked()
		{
		}

		public void DeleteClicked()
		{
		}

		private bool ObjectValid(ITransitEntity obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void ObjectsSelected(List<ITransitEntity> objs)
		{
		}
	}
}
