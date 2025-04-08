namespace ScheduleOne.StationFramework
{
	public abstract class ItemModule : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.StationFramework.StationItem Item { get; protected set; }

		public bool IsModuleActive { get; protected set; }

		public virtual void ActivateModule(global::ScheduleOne.StationFramework.StationItem item)
		{
		}
	}
}
