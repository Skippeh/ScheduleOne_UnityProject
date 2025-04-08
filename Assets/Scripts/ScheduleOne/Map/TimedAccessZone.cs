namespace ScheduleOne.Map
{
	public class TimedAccessZone : global::ScheduleOne.Map.AccessZone
	{
		[global::UnityEngine.Header("Timing Settings")]
		public int OpenTime;

		public int CloseTime;

		protected virtual void Start()
		{
		}

		protected virtual void MinPass()
		{
		}

		protected virtual bool GetIsOpen()
		{
			return false;
		}
	}
}
