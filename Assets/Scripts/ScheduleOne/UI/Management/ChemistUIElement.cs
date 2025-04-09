using ScheduleOne.Employees;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class ChemistUIElement : WorldspaceUIElement
	{
		[Header("References")]
		public Image[] StationsIcons;

		public Chemist AssignedChemist { get; protected set; }

		public void Initialize(Chemist chemist)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
