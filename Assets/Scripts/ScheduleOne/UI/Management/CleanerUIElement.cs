using ScheduleOne.Employees;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class CleanerUIElement : WorldspaceUIElement
	{
		[Header("References")]
		public Image[] StationsIcons;

		public Cleaner AssignedCleaner { get; protected set; }

		public void Initialize(Cleaner cleaner)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
