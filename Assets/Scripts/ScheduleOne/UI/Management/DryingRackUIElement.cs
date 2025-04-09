using ScheduleOne.ObjectScripts;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	public class DryingRackUIElement : WorldspaceUIElement
	{
		public Image TargetQualityIcon;

		public DryingRack AssignedRack { get; protected set; }

		public void Initialize(DryingRack rack)
		{
		}

		protected virtual void RefreshUI()
		{
		}
	}
}
