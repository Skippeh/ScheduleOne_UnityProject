namespace ScheduleOne.UI.Construction.Features
{
	public class FI_Base : global::UnityEngine.MonoBehaviour
	{
		protected global::ScheduleOne.Construction.Features.Feature feature;

		public global::UnityEngine.Events.UnityEvent onClose;

		public virtual void Initialize(global::ScheduleOne.Construction.Features.Feature _feature)
		{
		}

		public virtual void Close()
		{
		}
	}
}
