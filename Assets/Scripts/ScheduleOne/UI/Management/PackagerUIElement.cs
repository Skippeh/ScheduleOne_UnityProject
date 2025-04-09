using ScheduleOne.Employees;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class PackagerUIElement : WorldspaceUIElement
	{
		[Header("References")]
		public RectTransform[] StationRects;

		public Packager AssignedPackager { get; protected set; }

		public void Initialize(Packager packager)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
