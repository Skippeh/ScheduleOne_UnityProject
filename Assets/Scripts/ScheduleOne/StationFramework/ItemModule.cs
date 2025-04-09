using UnityEngine;

namespace ScheduleOne.StationFramework
{
	public abstract class ItemModule : MonoBehaviour
	{
		public StationItem Item { get; protected set; }

		public bool IsModuleActive { get; protected set; }

		public virtual void ActivateModule(StationItem item)
		{
		}
	}
}
